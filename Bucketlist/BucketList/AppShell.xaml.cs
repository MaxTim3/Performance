﻿using BucketList.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BucketList
{
	public partial class AppShell : Shell
	{
		public AppShell ()
		{
			InitializeComponent ();

			Routing.RegisterRoute(nameof(GoalAddingPage), typeof(GoalAddingPage));	
		}
	}
}