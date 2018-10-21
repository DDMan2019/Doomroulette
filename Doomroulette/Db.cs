using Doomroulette.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette
{
    class Db
    {
        private string connectionString = "Data Source=saveddata.db;Version=3;";

        public Db()
        {
            if (!System.IO.File.Exists("saveddata.db"))
            {
                // create a new database connection:
                SQLiteConnection sqlite_conn = new SQLiteConnection(connectionString);
                sqlite_conn.Open();

                SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

                string cachedDatatable = @"CREATE TABLE `CachedWadInfo` (
	                                        `id` INTEGER PRIMARY KEY AUTOINCREMENT,
                                            `wadId`	INTEGER,
	                                        `title`	TEXT,
	                                        `dir`	TEXT,
	                                        `filename`	TEXT,
	                                        `size`	INTEGER,
	                                        `age`	TEXT,
	                                        `date`	TEXT,
	                                        `author`	TEXT,
	                                        `email`	TEXT,
	                                        `description`	TEXT,
	                                        `credits`	TEXT,
	                                        `_base`	TEXT,
	                                        `buildtime`	TEXT,
	                                        `editors`	TEXT,
	                                        `bugs`	TEXT,
	                                        `textfile`	TEXT,
	                                        `rating`	REAL,
	                                        `votes`	INTEGER,
	                                        `url`	TEXT,
	                                        `idgamesurl`	TEXT
	                                        
                                        );";

                string downloadedWadIds = @"CREATE TABLE `DownloadedWadIds` (
	                                        `id` INTEGER PRIMARY KEY AUTOINCREMENT,
                                            `wadId`	INTEGER,
                                            `date`  TEXT
                                        );";
                string likedWadIds = @"CREATE TABLE `LikedWadIds` (
	                                        `id` INTEGER PRIMARY KEY AUTOINCREMENT,
                                            `wadInfoID`	INTEGER,
                                            `date`  TEXT
                                        );";

                string dislikedWadIds = @"CREATE TABLE `DislikedWadIds` (
	                                        `id` INTEGER PRIMARY KEY AUTOINCREMENT,
                                            `wadInfoID`	INTEGER,
                                            `date`  TEXT
                                        );";

                string additionalWads = @"CREATE TABLE `AdditionalWads` (
	                                        `id` INTEGER PRIMARY KEY AUTOINCREMENT,
                                            `filename`  INTEGER
                                        );";

                sqlite_cmd.CommandText = cachedDatatable;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = downloadedWadIds;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = likedWadIds;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = dislikedWadIds;
                sqlite_cmd.ExecuteNonQuery();
                sqlite_cmd.CommandText = additionalWads;
                sqlite_cmd.ExecuteNonQuery();

            }
        }

        public void saveWadInfo(WadInfo[] wads)
        {
            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();

            string query = "INSERT INTO `CachedWadInfo`(`wadId`,`title`,`dir`,`filename`,`size`,`age`,`date`,`author`,`email`,`description`,`credits`,`_base`,`buildtime`,`editors`,`bugs`,`textfile`,`rating`,`votes`,`url`,`idgamesurl`) VALUES " +
                "(@wadId, @title, @dir, @filename, @size, @age, @date, @author, @email, @description, @credits, @_base, @buildtime, @editors, @bugs, @textfile, @rating, @votes, @url, @idgamesurl);";

            using (var cmd = new SQLiteCommand(sqlite_conn))
            using (var transaction = sqlite_conn.BeginTransaction())
            {
                foreach (WadInfo wad in wads)
                {
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@wadId", wad.content.id);
                    cmd.Parameters.AddWithValue("@title", wad.content.title);
                    cmd.Parameters.AddWithValue("@dir", wad.content.dir);
                    cmd.Parameters.AddWithValue("@filename", wad.content.filename);
                    cmd.Parameters.AddWithValue("@size", wad.content.size);
                    cmd.Parameters.AddWithValue("@age", wad.content.age);
                    cmd.Parameters.AddWithValue("@date", wad.content.date);
                    cmd.Parameters.AddWithValue("@author", wad.content.author);
                    cmd.Parameters.AddWithValue("@email", wad.content.email);
                    cmd.Parameters.AddWithValue("@description", wad.content.description);
                    cmd.Parameters.AddWithValue("@credits", wad.content.credits);
                    cmd.Parameters.AddWithValue("@_base", wad.content._base);
                    cmd.Parameters.AddWithValue("@buildtime", wad.content.buildtime);
                    cmd.Parameters.AddWithValue("@editors", wad.content.editors);
                    cmd.Parameters.AddWithValue("@bugs", wad.content.bugs);
                    cmd.Parameters.AddWithValue("@textfile", wad.content.textfile);
                    cmd.Parameters.AddWithValue("@rating", wad.content.rating);
                    cmd.Parameters.AddWithValue("@votes", wad.content.votes);
                    cmd.Parameters.AddWithValue("@url", wad.content.url);
                    cmd.Parameters.AddWithValue("@idgamesurl", wad.content.idgamesurl);
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            
        }

        public int getWadCount()
        {
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT count(id) AS count FROM CachedWadInfo";
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        return Convert.ToInt32(r["count"]);
                    }
                }
                return 0;
            }
        }

        public int[] getExcludedIds(string[] directoriesToInclude, double minimumrating)
        {
            for(int i = 0; i < directoriesToInclude.Length; i++)
            {
                directoriesToInclude[i] = string.Format("'{0}'",directoriesToInclude[i]);
            }
            string strDirectoriesToInclude = string.Join(",", directoriesToInclude);

            List<int> wadidsToExclude = new List<int>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select id from CachedWadInfo where dir NOT IN ("+ strDirectoriesToInclude + ") OR rating <= "+ minimumrating + ";";
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        wadidsToExclude.Add(Convert.ToInt32(r["id"]));
                    }
                }
            }
            return wadidsToExclude.ToArray();
        }

        public int[] getAlreadyPlayedIds()
        {
            List<int> wadids = new List<int>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select wadId from DownloadedWadIds";
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        wadids.Add(Convert.ToInt32(r["wadId"]));
                    }
                }
            }
            return wadids.ToArray();
        }
        public int[] getAlreadyPlayedWadIds()
        {
            List<int> wadids = new List<int>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select wadId from DownloadedWadIds";
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        wadids.Add(Convert.ToInt32(r["wadId"]));
                    }
                }
            }
            return wadids.ToArray();
        }

        public WadInfo[] getWadList(string[] directoriesToInclude, double minimumRating, string createdDate)
        {
            for (int i = 0; i < directoriesToInclude.Length; i++)
            {
                directoriesToInclude[i] = string.Format("'{0}'", directoriesToInclude[i]);
            }
            string strDirectoriesToInclude = string.Join(",", directoriesToInclude);

            List<WadInfo> foundWadInfos = new List<WadInfo>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    if(createdDate == null)
                    {
                        fmd.CommandText = string.Format(@"SELECT * FROM CachedWadInfo WHERE dir IN ({0}) AND rating >= {1} ", strDirectoriesToInclude, minimumRating);
                    } else {
                        fmd.CommandText = string.Format(@"SELECT * FROM CachedWadInfo WHERE dir IN ({0}) AND rating >= {1} AND date >= '{2}'", strDirectoriesToInclude, minimumRating, createdDate);
                    }
                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {
                        foundWadInfos.Add(new WadInfo()
                        {
                            content = new Content()
                            {
                                id = Convert.ToInt32(content["id"]),
                                title = Convert.ToString(content["title"]),
                                dir = Convert.ToString(content["dir"]),
                                filename = Convert.ToString(content["filename"]),
                                size = Convert.ToInt64(content["size"]),
                                age = Convert.ToDateTime(content["age"]),
                                date = Convert.ToString(content["date"]),
                                author = Convert.ToString(content["author"]),
                                email = Convert.ToString(content["email"]),
                                description = Convert.ToString(content["description"]),
                                credits = Convert.ToString(content["credits"]),
                                buildtime = Convert.ToString(content["buildtime"]),
                                editors = Convert.ToString(content["editors"]),
                                bugs = Convert.ToString(content["bugs"]),
                                textfile = Convert.ToString(content["textfile"]),
                                rating = Convert.ToSingle(content["rating"]),
                                votes = Convert.ToInt32(content["votes"]),
                                url = Convert.ToString(content["url"]),
                                idgamesurl = Convert.ToString(content["idgamesurl"]),
                                _base = Convert.ToString(content["_base"])
                            }
                        });
                    }
                }
                
            }
            return foundWadInfos.ToArray();
        }

        public WadInfo getWadInfo(int id)
        {
            WadInfo foundWadInfo;
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"Select * from CachedWadInfo where id = " + id;
                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {
                        foundWadInfo = new WadInfo()
                        {
                            content = new Content()
                            {
                                id = Convert.ToInt32(content["id"]),
                                title = Convert.ToString(content["title"]),
                                dir = Convert.ToString(content["dir"]),
                                filename = Convert.ToString(content["filename"]),
                                size = Convert.ToInt64(content["size"]),
                                age = Convert.ToDateTime(content["age"]),
                                date = Convert.ToString(content["date"]),
                                author = Convert.ToString(content["author"]),
                                email = Convert.ToString(content["email"]),
                                description = Convert.ToString(content["description"]),
                                credits = Convert.ToString(content["credits"]),
                                buildtime = Convert.ToString(content["buildtime"]),
                                editors = Convert.ToString(content["editors"]),
                                bugs = Convert.ToString(content["bugs"]),
                                textfile = Convert.ToString(content["textfile"]),
                                rating = Convert.ToSingle(content["rating"]),
                                votes = Convert.ToInt32(content["votes"]),
                                url = Convert.ToString(content["url"]),
                                idgamesurl = Convert.ToString(content["idgamesurl"]),
                                _base = Convert.ToString(content["_base"])
                            }
                        };
                        return foundWadInfo;
                    }
                }
                return null;
            }
        }

        public void saveWadId(int id)
        {
            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO DownloadedWadIds (wadId, date) VALUES (" + id + ", '" + DateTime.Now.ToString() + "');";

            sqlite_cmd.ExecuteNonQuery();
        }

        public void saveLikedWadId(int id)
        {
            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO LikedWadIds (wadInfoID, date) VALUES (" + id + ", '" + DateTime.Now.ToString() + "');";

            sqlite_cmd.ExecuteNonQuery();
        }

        public void saveDislikedWadId(int id)
        {
            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = "INSERT INTO DislikedWadIds (wadInfoID, date) VALUES (" + id + ", '" + DateTime.Now.ToString() + "');";

            sqlite_cmd.ExecuteNonQuery();
        }

        public AdditionalWad[] getAdditionalWads()
        {
            List<AdditionalWad> foundWads = new List<AdditionalWad>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select id,filename  from AdditionalWads";
                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {
                        var test = content.GetString(1);
                        foundWads.Add(new AdditionalWad()
                        {
                            ID = content.GetInt32(0),
                            filename = content.GetString(1),
                            name = Path.GetFileNameWithoutExtension(content.GetString(1))
                        });
                    }
                }
                
            }
            return foundWads.ToArray();
        }

        public void addAdditionalWad(AdditionalWad additionalWad)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection(connectionString);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = string.Format("INSERT INTO `AdditionalWads`(`id`,`filename`) VALUES (NULL,'{0}');",additionalWad.filename);

            sqlite_cmd.ExecuteNonQuery();
        }

        public void deleteAdditionalWad(int id)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection(connectionString);
            sqlite_conn.Open();
            SQLiteCommand sqlite_cmd = sqlite_conn.CreateCommand();

            sqlite_cmd.CommandText = string.Format("DELETE FROM `AdditionalWads` WHERE id = {0};",id);

            sqlite_cmd.ExecuteNonQuery();
        }

        public WadInfo[] getLikedWads()
        {
            List<WadInfo> foundWadInfos = new List<WadInfo>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select * from CachedWadInfo join LikedWadIds on LikedWadIds.wadInfoID = CachedWadInfo.id";
                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {
                        
                        foundWadInfos.Add(new WadInfo()
                        {
                            content = new Content()
                            {
                                id = Convert.ToInt32(content["id"]),
                                title = Convert.ToString(content["title"]),
                                dir = Convert.ToString(content["dir"]),
                                filename = Convert.ToString(content["filename"]),
                                size = Convert.ToInt64(content["size"]),
                                age = Convert.ToDateTime(content["age"]),
                                date = Convert.ToString(content["date"]),
                                author = Convert.ToString(content["author"]),
                                email = Convert.ToString(content["email"]),
                                description = Convert.ToString(content["description"]),
                                credits = Convert.ToString(content["credits"]),
                                buildtime = Convert.ToString(content["buildtime"]),
                                editors = Convert.ToString(content["editors"]),
                                bugs = Convert.ToString(content["bugs"]),
                                textfile = Convert.ToString(content["textfile"]),
                                rating = Convert.ToSingle(content["rating"]),
                                votes = Convert.ToInt32(content["votes"]),
                                url = Convert.ToString(content["url"]),
                                idgamesurl = Convert.ToString(content["idgamesurl"]),
                                _base = Convert.ToString(content["_base"])
                            }
                        });
                    }
                }
                
            }
            return foundWadInfos.ToArray();
        }

        public WadInfo[] getDisLikedWads()
        {
            List<WadInfo> foundWadInfos = new List<WadInfo>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select * from CachedWadInfo join DislikedWadIds on DislikedWadIds.wadInfoID = CachedWadInfo.id"; // + id;
                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {

                        foundWadInfos.Add(new WadInfo()
                        {
                            content = new Content()
                            {
                                id = Convert.ToInt32(content["id"]),
                                title = Convert.ToString(content["title"]),
                                dir = Convert.ToString(content["dir"]),
                                filename = Convert.ToString(content["filename"]),
                                size = Convert.ToInt64(content["size"]),
                                age = Convert.ToDateTime(content["age"]),
                                date = Convert.ToString(content["date"]),
                                author = Convert.ToString(content["author"]),
                                email = Convert.ToString(content["email"]),
                                description = Convert.ToString(content["description"]),
                                credits = Convert.ToString(content["credits"]),
                                buildtime = Convert.ToString(content["buildtime"]),
                                editors = Convert.ToString(content["editors"]),
                                bugs = Convert.ToString(content["bugs"]),
                                textfile = Convert.ToString(content["textfile"]),
                                rating = Convert.ToSingle(content["rating"]),
                                votes = Convert.ToInt32(content["votes"]),
                                url = Convert.ToString(content["url"]),
                                idgamesurl = Convert.ToString(content["idgamesurl"]),
                                _base = Convert.ToString(content["_base"])
                            }
                        });
                    }
                }
                return foundWadInfos.ToArray();
            }
        }


    }
}
