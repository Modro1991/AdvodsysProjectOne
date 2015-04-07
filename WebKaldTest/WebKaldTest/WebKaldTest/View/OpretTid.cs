using System;

using Xamarin.Forms;

namespace WebKaldTest
{
	public class OpretTid : ContentPage
	{
		public OpretTid ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


