﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLK_DongLuc.Models;

namespace QLK_DongLuc.Controllers
{
    public class KetNoiCSDLCtrl
    {
        private static string DeCryptPass()
        {
            var ecr = Properties.Settings.Default.SSAP;
            var key = "3/3JysB9VLsqWAE35jXoy7Hf6GtSRlFJO9tcP9pm1SPKXU0zfZKIXHLSa+8wkgBQe8bDfeBI2GoS6obZlcKrZw==";

            return Utilities.DeCryptMD5(ecr, key);
        }

        public static string EnCryptPass(string pass)
        {
            var key = "3/3JysB9VLsqWAE35jXoy7Hf6GtSRlFJO9tcP9pm1SPKXU0zfZKIXHLSa+8wkgBQe8bDfeBI2GoS6obZlcKrZw==";

            return Utilities.EnCryptMD5(pass, key);
        }

        public static string GetConnectionString()
        {
            string Pass = DeCryptPass();
            var Datasource = Properties.Settings.Default.DS;
            var Database = Properties.Settings.Default.DB;
            var UserId = Properties.Settings.Default.UID;

            return "data source=" + Datasource + ";initial catalog=" + Database + ";persist security info=True;user id=" + UserId + ";password=" + Pass + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";
        }

        public static List<string> GetDatabaseList(string Datasource, string UserId, string Pass)
        {
            string connectionString = "data source=" + Datasource +";initial catalog=master;persist security info=True;user id=" + UserId + ";password=" + Pass + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";

            Entities db = new Entities();
            db.Database.Connection.ConnectionString = connectionString;

            try
            {
                var databases = db.Database.SqlQuery<string>("select [name] from sys.databases").ToList();

                return databases;
            }
            catch
            {
                return new List<string>();
            }
        }

        public static int ConnectDatabase(string Datasource, string UserId, string Pass, string Database)
        {
            Entities db = new Entities();
            db.Database.Connection.ConnectionString = "data source=" + Datasource + ";initial catalog=" + Database + ";persist security info=True;user id=" + UserId + ";password=" + Pass + ";MultipleActiveResultSets=True;App=EntityFramework&quot;";

            try
            {
                db.Database.Connection.Open();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
