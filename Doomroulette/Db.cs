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
                                            `filename` INTEGER
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
                sqlite_conn.Close();
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
            int n = 0;
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"SELECT count(id) AS count FROM CachedWadInfo";
                    SQLiteDataReader r = fmd.ExecuteReader();
                    while (r.Read())
                    {
                        n = Convert.ToInt32(r["count"]);
                    }
                   
                }
                connect.Close();
            }

            return n;
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
                connect.Close();
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

        public WadInfo[] getWadList(string[] directoriesToInclude, double minimumRating = 0, string createdDate = null)
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
                        fmd.CommandText = string.Format(@"SELECT * FROM CachedWadInfo WHERE dir IN ({0}) AND rating >= @minimumRating ", strDirectoriesToInclude);
                    }
                    else {
                        fmd.CommandText = string.Format(@"SELECT * FROM CachedWadInfo WHERE dir IN ({0}) AND rating >= @minimumRating AND date >= @createdDate", strDirectoriesToInclude);
                        fmd.Parameters.AddWithValue("@createdDate", createdDate);
                    }
                    fmd.Parameters.AddWithValue("@minimumRating", minimumRating);

                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {
                        foundWadInfos.Add(new WadInfo()
                        {
                            content = new Content()
                            {
                                id = Convert.ToInt32(content["id"]),
                                wadId = Convert.ToInt32(content["wadId"]),
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
                connect.Close();
            }
            return foundWadInfos.ToArray();
        }

        public WadInfo getWadInfo(int id)
        {
            string query = "Select * from CachedWadInfo where id = @id";

            WadInfo foundWadInfo = new WadInfo();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = query;
                    fmd.Parameters.AddWithValue("@id", id);

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
                        
                    }
                }
                connect.Close();
            }
            return foundWadInfo;
        }

        public void saveWadId(int id)
        {
            string query = "INSERT INTO DownloadedWadIds (wadId, date) VALUES (@id, @datetime);";

            SQLiteConnection sqlite_conn =
                 new SQLiteConnection(connectionString);
            sqlite_conn.Open();

            using (var cmd = new SQLiteCommand(sqlite_conn))
            using (var transaction = sqlite_conn.BeginTransaction())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            sqlite_conn.Close();
        }

        public void saveLikedWadId(int id)
        {
            string query = "INSERT INTO LikedWadIds(wadInfoID, date) VALUES(@id, @datetime);";

            SQLiteConnection sqlite_conn =
                 new SQLiteConnection(connectionString);
            sqlite_conn.Open();

            using (var cmd = new SQLiteCommand(sqlite_conn))
            using (var transaction = sqlite_conn.BeginTransaction())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                transaction.Commit();

            }
            sqlite_conn.Close();
        }

        public void saveDislikedWadId(int id)
        {
            string query = "INSERT INTO DislikedWadIds(wadInfoID, date) VALUES(@id, @datetime);";

            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();

            using (var cmd = new SQLiteCommand(sqlite_conn))
            using (var transaction = sqlite_conn.BeginTransaction())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                transaction.Commit();

            }
            sqlite_conn.Close();
        }

        public AdditionalWad[] getAdditionalWads()
        {
            List<AdditionalWad> foundWads = new List<AdditionalWad>();
            using (SQLiteConnection connect = new SQLiteConnection(connectionString))
            {
                connect.Open();
                using (SQLiteCommand fmd = connect.CreateCommand())
                {
                    fmd.CommandText = @"select id,filename from AdditionalWads";
                    SQLiteDataReader content = fmd.ExecuteReader();
                    while (content.Read())
                    {
                        var test = content.GetInt32(0);
                        foundWads.Add(new AdditionalWad()
                        {
                            ID = content.GetInt32(0),
                            filename = content.GetString(1),
                            name = Path.GetFileNameWithoutExtension(content.GetString(1))
                        });
                    }
                }
                connect.Close();
            }
            return foundWads.ToArray();
        }

        public long addAdditionalWad(AdditionalWad additionalWad)
        {
            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();

            long insertedId = -1;
            string query = "INSERT INTO `AdditionalWads` (`id`,`filename`) VALUES (NULL,@filename);";

            using (var cmd = new SQLiteCommand(sqlite_conn))
            using (var transaction = sqlite_conn.BeginTransaction())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@filename", additionalWad.filename);
                cmd.ExecuteNonQuery();
                transaction.Commit();

                cmd.CommandText = "SELECT last_insert_rowid()";
                insertedId = (long)cmd.ExecuteScalar();
            }
            sqlite_conn.Close();
            return insertedId;
        }

        public void deleteAdditionalWad(long id)
        {
            SQLiteConnection sqlite_conn =
                new SQLiteConnection(connectionString);
            sqlite_conn.Open();

            string query = "DELETE FROM `AdditionalWads` WHERE id = @id";
            using (var cmd = new SQLiteCommand(sqlite_conn))
            using (var transaction = sqlite_conn.BeginTransaction())
            {
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                transaction.Commit();
            }
            sqlite_conn.Close();
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
                connect.Close();


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
                    fmd.CommandText = @"select * from CachedWadInfo join DislikedWadIds on DislikedWadIds.wadInfoID = CachedWadInfo.id";
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
                connect.Close();
            }
            return foundWadInfos.ToArray();
        }


    }
}
