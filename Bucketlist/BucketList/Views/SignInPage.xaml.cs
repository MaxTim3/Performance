using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketList.Views
{
	public partial class SignInPage : ContentPage
	{
		public SignInPage ()
		{
			InitializeComponent ();
		}
        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userEntry.Text))
            {
                errorText.Text = "Это поле обязательно для заполнения";
                return;
            }
            else
            {
                errorText.Text = "";
            }
            await Navigation.PushModalAsync(new HomePage());

        }
    }
}