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
        static GoalsDB goalsDB;

        public static GoalsDB GoalsDB
        {
            get
            {
                if (goalsDB == null)
                {
                    goalsDB = new GoalsDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "GoalsDatabase.db3"));
                }
                return goalsDB;
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
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
