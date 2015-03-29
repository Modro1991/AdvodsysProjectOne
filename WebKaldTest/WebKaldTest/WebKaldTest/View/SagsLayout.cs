using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;
using WebKaldTest;
using System.Diagnostics;
using System.Net.Http;

namespace WebKaldTest
{
	public class Sagslayout : ContentPage
	{
		Sagsliste sagsliste;

		Label label;
		private void InitializeComponent()
		{
			this.LoadFromXaml(typeof(Sagslayout));
			Sagsliste sagsliste = new Sagsliste();
		}
		public Sagslayout()
		{
			Label header = new Label
			{
				Text = "Hent Sager",
				Font = Font.SystemFontOfSize(50, FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};

			Button button = new Button
			{
				Text = "Hent!",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			button.Clicked += OnButtonClicked;

			label = new Label
			{
				Text = "Text",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};
			var scrollview = new ScrollView{			
				//HorizontalOptions = LayoutOptions.End,
				//IsClippedToBounds = true,
				Orientation = ScrollOrientation.Vertical,
				VerticalOptions = LayoutOptions.Fill,
			// Build the page.
			 Content = new StackLayout
			{
				Children = 
				{
					header,
					button,
					label
				}
					},
				};
			this.Content = new StackLayout {
				Children = {
					scrollview
				}
			};
				
			}
		async void OnButtonClicked(object sender, EventArgs e)
		{
			sagsliste = new Sagsliste();
			await sagsliste.HentSager(1, "", 200);
			var txt = "Sagsliste\n";
			foreach (var s in sagsliste.sager.Sag)
			{
				txt += string.Format("{0} {1}\n", s.nr, s.navn);
			}

			label.Text = txt;
			//clickTotal += 1;
			//label.Text = String.Format("{0} button click{1}",
			//                           clickTotal, clickTotal == 1 ? "" : "s");
		}
	}
}
