using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App1S7AR.Droid;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(SqlClient))]

namespace App1S7AR.Droid
{
    class SqlClient : DataBase
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documetPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documetPath, "uisrael.ed3");
            return new SQLiteAsyncConnection(path);
        }
    }
}