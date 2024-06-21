using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BucketList.Data;
using System.IO;
using BucketList.Views;
using System.Reflection;
using BucketList.Models;

namespace BucketList
{
    public partial class App : Application
    {
        public static BucketlistDB bucketlistDB;
        public static BucketlistDB BucketlistDB
        {
            get
            {
                if (bucketlistDB == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Bucketlist.db");
                    bucketlistDB = new BucketlistDB(dbPath);
                }
                
                return bucketlistDB;
            }
        }

        public App()
        {
            InitializeComponent();
            
            if (string.IsNullOrEmpty(UserName.Name))
            {
                MainPage = new NavigationPage(new SignInPage());
            }

            else 
            {
                MainPage = new NavigationPage(new HomePage());
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
