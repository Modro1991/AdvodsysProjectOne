using System;

using Xamarin.Forms;

namespace WebKaldTest
{
	public class TidLayout : ContentPage
	{
		Label l1;
		Button b1;
		Button b2;
		public TidLayout ()
		{
			l1 = new Label {
				Text = "Tid",
				Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};

			b1 = new Button {
				Text = "Hent Tid",				
				BackgroundColor = Color.Silver,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center
			};

			b2 = new Button {
				Text = "Registrer",
				BackgroundColor = Color.Silver,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center
			};
			b1.Clicked += delegate {
				Navigation.PushModalAsync(new HentTid());
			};
			this.Content = new StackLayout {

				Children = {
					l1,
					b1,
					b2
				}
			};
		}
	}
}


