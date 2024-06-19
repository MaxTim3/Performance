﻿using BucketList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketList.Views
{
    public partial class RepeatActionPage : ContentPage
    {
        public RepeatActionPage()
        {
            InitializeComponent();
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void Edit_Clicked(object sender, EventArgs e)
        {
            RepeatAction repeatAction = (RepeatAction)BindingContext;
            RepeatActionAddingPage repeatActionAddingPage = new RepeatActionAddingPage();
            repeatActionAddingPage.BindingContext = repeatAction;
            await Navigation.PushModalAsync(repeatActionAddingPage);
        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            RepeatAction repeatAction = (RepeatAction)BindingContext;
            await App.BucketlistDB.DeleteRepeatActionAsync(repeatAction);
            await Navigation.PopModalAsync();
        }

        private async void Completed_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}