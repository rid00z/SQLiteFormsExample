using System;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using Xamarin.Forms;
using SQLiteExample.iOS;

[assembly: Dependency(typeof(SQLiteFactory))]

namespace SQLiteExample.iOS
{
    public class SQLiteFactory : ISQLiteFactory
    {
        public SQLite.Net.SQLiteConnection GetConnection (string fileName)
        {
            var path = System.IO.Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.Personal), fileName);
            return new SQLiteConnection (new SQLitePlatformIOS(), path);
        }
    }
}

