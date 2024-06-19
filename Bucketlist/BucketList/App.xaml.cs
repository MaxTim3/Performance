using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BucketList.Data;
using System.IO;
using BucketList.Views;

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
                    bucketlistDB = new BucketlistDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Bucketlist.db"));
                }
                return bucketlistDB;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
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
