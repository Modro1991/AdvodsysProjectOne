using System;

using WebKaldTest;
using Xamarin.Forms;

namespace WebKaldTest
{
	public class Menu : ContentPage
	{
		Label l1;
		Button b1;
		Button b2;
		Button b3;

		public Menu ()
		{
		    l1 = new Label {
				Text = "Menu",
				Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};

			b1 = new Button {
				Text = "Sagsliste",				
				BackgroundColor = Color.Silver,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center

			};

			b2 = new Button {
				Text = "Datafangst",
				BackgroundColor = Color.Silver,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center
			};

			b3 = new Button {
				Text = "Tid",
				BackgroundColor = Color.Silver,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center
			};
			b1.Clicked += delegate
			{
//				App.Current.MainPage = new Sagslayout();
//				new NavigationPage(new Sagslayout () );
				Navigation.PushModalAsync(new Sagslayout());
			};
			b2.Clicked += delegate
			{

//				App.Current.MainPage = new DataFangstLayout();
//
     			Navigation.PushModalAsync(new DataFangstLayout());
//				var tabs = new TabbedPage();
//				tabs.Navigation.PushModalAsync(new TabbedPage());
//				tabs.Children.Add(new DataFangstLayout{Title = "Se Data"});
//				tabs.Children.Add(new RedigerDataFangstLayout{Title = "Rediger Data"});

			};
			b3.Clicked += delegate
			{
				Navigation.PushModalAsync(new TidLayout());
			};

			this.Content = new StackLayout {
				Spacing = 50,
				Children = {
					l1,
					b1,
					b2,
					b3
				}
			};




		}

	}
}


