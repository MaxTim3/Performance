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
        public static GoalsDB goalsDB;
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

        public static CheckpointsDB checkpointsDB;
        public static CheckpointsDB CheckpointsDB
        {
            get
            {
                if (checkpointsDB == null)
                {
                    checkpointsDB = new CheckpointsDB(
                        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CheckpointsDatabase.db3"));
                }
                return checkpointsDB;
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
