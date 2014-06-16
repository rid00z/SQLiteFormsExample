using System;
using SQLite.Net;
using System.IO;
using SQLite.Net.Platform.XamarinAndroid;
using Xamarin.Forms;
using SQLiteExample.Android.Dependancies;

[assembly: Dependency(typeof(SQLiteFactory))]

namespace SQLiteExample.Android.Dependancies
{
    public class SQLiteFactory : ISQLiteFactory
    {
        public SQLiteFactory ()
        {
        }

        public SQLiteConnection GetConnection (string fileName)
        {
            var path = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), fileName);
            return new SQLiteConnection (new SQLitePlatformAndroid (), path);
        }
    }
}

