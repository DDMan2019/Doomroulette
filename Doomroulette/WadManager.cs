using Doomroulette.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette
{
    class WadManager
    {
        //private string ftphost = "archives.gamers.org";
        private string ftphost = "ftp.fu-berlin.de";

        public string doompath; //@"E:\Games\Doom\gzdoom.exe";
        public string downloadedWadsFolder;

        private string sourcePort = "gzdoom.exe";
        private string folder = @"\downloadedWads\";
        private string folderPath = @"/pc/games/idgames/";

        //private string folderPath = @"/pub/games/doom2/";
        private Db db;
        public string currentFile;
        
        public double minimumRating = 4;

        public string status = "Ready...";
        public Skill skill = Skill.sk_medium;
        public enum Skill
        {
            sk_baby = 1,
            sk_easy = 2,
            sk_medium = 3,
            sk_hard = 4,
            sk_nightmare = 5
        };

        

        public SelectedGame selectedGame = SelectedGame.Doom2;
        public enum SelectedGame
        {
            FreeDoom2,
            Doom2
        }
        
        public GameSettings settings = new GameSettings();

        public WadManager()
        {
            this.db = new Db();
        }

        public bool emptyDb() {
            return db.getWadCount() == 0;
        }

        public bool missingExecutablePath()
        {
            return !(Settings.configValues.ContainsKey("doompath") && Settings.configValues.ContainsKey("folder"));
        }

        public void refreshSettings()
        {
            if (!missingExecutablePath())
            {
                doompath = Settings.configValues["doompath"];
                downloadedWadsFolder = Settings.configValues["folder"];
            }
        }

        public Action<string> callback;

        public async Task<string> downloadWad(WadInfo wad, Action<string> callback)
        {
            refreshSettings();
            //this.callback = callback;
            //string inputfilepath = doompath + folder + wad.content.filename;
            string destination = downloadedWadsFolder + "/" + wad.content.filename;
            string ftpfilepath = wad.content.dir + wad.content.filename;//"/Updater/Dir1/FileName.exe";
            string ftpfullpath = "ftp://" + ftphost + "/" + folderPath + ftpfilepath;
            bool isBusy = true;

            using (WebClient client = new WebClient())
            {
                client.Credentials = new NetworkCredential("anonymous", "");

                //client.DownloadProgressChanged += DownloadProgressCallback;object sender, DownloadProgressChangedEventArgs e)
                client.DownloadProgressChanged += delegate (object sender, DownloadProgressChangedEventArgs e)
                {
                    long totalbytes = wad.content.size;
                    long bytesReceived = e.BytesReceived;

                    double totalKilobytes = Math.Round((totalbytes / 1024f),1);
                    double currentKilobytes = Math.Round((bytesReceived / 1024f));

                    int percent = (int)Math.Round(currentKilobytes / totalKilobytes * 100,1);

                    string progress = string.Format("downloaded {0} of {1} KB.\n{2} % complete...",
                        bytesReceived,
                        totalKilobytes,
                        percent);

                    callback(progress);
                };

                client.DownloadDataCompleted +=
                   delegate (object sender, DownloadDataCompletedEventArgs fileData)
                   {
                       try
                       {
                           using (FileStream file = System.IO.File.Create(destination))
                           {
                               file.Write(fileData.Result, 0, fileData.Result.Length);
                               file.Close();
                               db.saveWadId(wad.content.id);
                               isBusy = false;

                           }
                       }
                       catch (Exception e)
                       {
                           isBusy = false;
                       }

                   };

                //client.DownloadDataAsync(new Uri(ftpfullpath));
                var result = await client.DownloadDataTaskAsync(new Uri(ftpfullpath));

                while (client.IsBusy)
                {
                }
                
                return wad.content.filename;

            }
           
        }

        public string[] unzipFile(string zipPath)
        {
            string src = downloadedWadsFolder + "/" + zipPath;
            string extractDestination = downloadedWadsFolder + "/" + Path.GetFileNameWithoutExtension(zipPath);
            
            if (!Directory.Exists(extractDestination))
            {
                Directory.CreateDirectory(extractDestination);
                ZipFile.ExtractToDirectory(src, extractDestination);
            }

            return getFiles(extractDestination);

        }

        public string[] getFiles(string path)
        {
            string[] fileEntries = Directory.GetFiles(path).Select(p => Path.GetFileName(p)).ToArray();
            return fileEntries;
        }

        private string getIwad()
        {
            switch (this.selectedGame)
            {
                case WadManager.SelectedGame.Doom2:
                    return Settings.configValues.ContainsKey("doom2Iwad") ? Settings.configValues["doom2Iwad"] : "";
                case WadManager.SelectedGame.FreeDoom2:
                    return Settings.configValues.ContainsKey("freeDoom2Iwad") ? Settings.configValues["freeDoom2Iwad"] : "";
            }
            return "";
        }

        public Process startDoom(string wadfolder ,string[] files, AdditionalWad[] additionalFiles)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = doompath;
            
            int skill = (int)this.skill;

            string args = "";

            foreach(string file in files)
            {
                
                switch (Path.GetExtension(file).ToLower())
                {
                    case ".pk4": case ".pk3": case ".wad":
                        args += @"-file """ + downloadedWadsFolder + @"/" + wadfolder + @"/" + file + @""" ";
                        break;
                    case ".deh":
                        args += "-deh " + downloadedWadsFolder + "/" + wadfolder+"/" + file + " ";
                        break;
                    default:
                        break;
                }
            }
            if (additionalFiles.Length > 0)
            {
                args += loadAdditionalFiles(additionalFiles);
            }
            startInfo.Arguments = @args + " -iwad "+getIwad()+" -warp 01 -skill "+skill;
            return Process.Start(startInfo);
        }

        private string loadAdditionalFiles(AdditionalWad[] additionalFiles)
        {
            string[] filenames = additionalFiles.Select(a => "\"" + a.filename + "\"").ToArray();
            return string.Join(@" ", filenames);
        }

        public WadInfo getLastPlayedWad()
        {
            int[] history = db.getAlreadyPlayedWadIds();
            WadInfo lastPlayedWad = db.getWadInfo(history[history.Length-1]);
            return lastPlayedWad;
        }

        public WadInfo getRandomWad()
        {
            List<string> directories = new List<string>();

            if (settings.includeVanilla)
            {
                directories.AddRange(new[] {
                    "levels/doom2/0-9/",
                    "levels/doom2/a-c/",
                    "levels/doom2/d-f/",
                    "levels/doom2/g-i/",
                    "levels/doom2/j-l/",
                    "levels/doom2/m-o/",
                    "levels/doom2/p-r/",
                    "levels/doom2/s-u/",
                    "levels/doom2/v-z/"
                });
            }
            if (settings.includeMegawads)
            {
                directories.Add("levels/doom2/megawads/");
            }

            if (settings.includePorts)
            {
                directories.AddRange(new[] {
                    "levels/doom2/Ports/0-9/",
                    "levels/doom2/Ports/a-c/",
                    "levels/doom2/Ports/d-f/",
                    "levels/doom2/Ports/g-i/",
                    "levels/doom2/Ports/j-l/",
                    "levels/doom2/Ports/m-o/",
                    "levels/doom2/Ports/p-r/",
                    "levels/doom2/Ports/s-u/",
                    "levels/doom2/Ports/v-z/",
                });
            }
            if (settings.includePorts && settings.includeMegawads)
            {
                directories.Add("levels/doom2/Ports/megawads/");
            }

            int[] alreadyPlayedIds = db.getAlreadyPlayedIds();
            
            WadInfo[] foundWads = db.getWadList(directories.ToArray(), settings.minimumRating, settings.createdDate);
            int[] foundWadIds = foundWads.Where(a => !alreadyPlayedIds.Contains(a.content.id)).Select(i => i.content.id).ToArray();
            
            int nWads = foundWads.Length;
            if (nWads == 0) 
            {
                throw new Exception("No wads found!");
            }

            int randomId = new Random().Next(0, nWads - 1);
            if (!Helpers.arrayIsSimilar(foundWadIds, alreadyPlayedIds))
            {
                while (alreadyPlayedIds.Contains(randomId)) // || excludeIds.Contains(randomId))
                {
                    randomId = new Random().Next(0, nWads - 1);
                }
            }

            WadInfo wad = db.getWadInfo(foundWadIds[randomId]);
            return wad;
        }

        public void openTextFile(WadInfo selectedWad)
        {
            string filename = Path.GetFileNameWithoutExtension(selectedWad.content.filename);
            string fullpath = string.Format("{0}/{1}/{2}.txt", downloadedWadsFolder, filename, filename);

            if (System.IO.File.Exists(fullpath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "notepad.exe";
                startInfo.Arguments = fullpath;
                Process.Start(startInfo);
            } else
            {
                //Since selectedWad.textfile is always null, which comes from the api. 
                //I have to try open the first txtfile it can find.
                string[] files = getFiles(Path.GetDirectoryName(fullpath));
                foreach(string file in files)
                {
                    if(Path.GetExtension(file) == ".txt")
                    {
                        string firsttextfile = string.Format("{0}/{1}/{2}", downloadedWadsFolder, filename, file);
                        ProcessStartInfo startInfo = new ProcessStartInfo();
                        startInfo.FileName = "notepad.exe";
                        startInfo.Arguments = firsttextfile;
                        Process.Start(startInfo);
                        return;
                    }
                }
                
                throw new Exception("Textfile not found!");
            }
        }

        public void updateWadInfoList()
        {
            List<string> directories = new List<string>()
            {
                "levels/doom2/0-9/",
                "levels/doom2/a-c/",
                "levels/doom2/d-f/",
                "levels/doom2/g-i/",
                "levels/doom2/j-l/",
                "levels/doom2/m-o/",
                "levels/doom2/p-r/",
                "levels/doom2/s-u/",
                "levels/doom2/v-z/",
                "levels/doom2/megawads/",
                "levels/doom2/Ports/0-9/",
                "levels/doom2/Ports/a-c/",
                "levels/doom2/Ports/d-f/",
                "levels/doom2/Ports/g-i/",
                "levels/doom2/Ports/j-l/",
                "levels/doom2/Ports/m-o/",
                "levels/doom2/Ports/p-r/",
                "levels/doom2/Ports/s-u/",
                "levels/doom2/Ports/v-z/",
                "levels/doom2/Ports/megawads/"
            };

            WadInfo[] wads = IdGamesApi.getWads(directories.ToArray());
            int[] cachedWadIds = db.getWadList(directories.ToArray()).Select(a => a.content.wadId).ToArray();

            var wadsToAdd = wads.Where(a => !cachedWadIds.Contains(a.content.wadId)).ToArray();

            if (wadsToAdd.Any())
                db.saveWadInfo(wadsToAdd);
        }

        public void setWadRating(int wadId,bool liked)
        {
            if (liked)
                db.saveLikedWadId(wadId);
            else
                db.saveDislikedWadId(wadId);
        }

        public WadInfo[] getLikedWads()
        {
            return db.getLikedWads();
        }

        public WadInfo[] getDislikedWads()
        {
            return db.getDisLikedWads();
        }

        public void deleteLikedWad(WadInfo wadInfo, bool deleteFile = true)
        {
            long wadIdToDelete = wadInfo.content.id;
            db.deleteLikedWad(wadIdToDelete);
            if(deleteFile)
            {
                string folderToDelete = Path.GetFileNameWithoutExtension(wadInfo.content.filename);
                if (Directory.Exists(downloadedWadsFolder + "/" + folderToDelete))
                {
                    Directory.Delete(downloadedWadsFolder + "/" + folderToDelete, true);
                }
                System.IO.File.Delete(downloadedWadsFolder + "/" + wadInfo.content.filename);
            }
        }

        public void deleteDislikedWad(WadInfo wadInfo, bool deleteFile = true)
        {
            long wadIdToDelete = wadInfo.content.id;
            db.deleteDislikedWad(wadIdToDelete);
            if(deleteFile)
            {
                string folderToDelete = Path.GetFileNameWithoutExtension(wadInfo.content.filename);
                if (Directory.Exists(downloadedWadsFolder + "/" + folderToDelete))
                {
                    Directory.Delete(downloadedWadsFolder + "/" + folderToDelete, true);
                }
                System.IO.File.Delete(downloadedWadsFolder + "/" + wadInfo.content.filename);

            }
        }

        public AdditionalWad[] getAdditionalWads()
        {
            return db.getAdditionalWads();
        }

        public long addAdditionalWad(AdditionalWad additionalWad)
        {
            return db.addAdditionalWad(additionalWad);
        }

        public void deleteAdditionalWad(long id)
        {
            db.deleteAdditionalWad(id);
        }

        public class GameSettings
        {
            public bool includeMegawads = true;
            public bool includePorts = true;
            public bool includeVanilla = true;
            public double minimumRating = 3;
            public string createdDate;
        }
    }
}
