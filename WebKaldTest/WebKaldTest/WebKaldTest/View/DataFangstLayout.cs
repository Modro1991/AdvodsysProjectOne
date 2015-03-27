using System;

using Xamarin.Forms;

namespace WebKaldTest
{
	public class DataFangstLayout : ContentPage
	{
		public DataFangstLayout ()
		{
			Label header = new Label
			{
				Text = "Hent Sager",
				Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};

			Entry entry = new Entry 
			{

			};
			
			Content = new StackLayout { 
				Children = {
					header,
					entry
				}
			};
		}
	}
}


