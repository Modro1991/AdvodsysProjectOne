using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebKaldTest;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebKaldTest
{
	public class Sagslayout : ContentPage
	{

		ListView lv = new ListView ();
		Label l;
		private void InitializeComponent()
		{
			
			this.LoadFromXaml(typeof(Sagslayout));
		}
		public Sagslayout()
		{
			l = new Label { Text = "Sager", Font = Font.BoldSystemFontOfSize(NamedSize.Large) };

			var b = new Button { Text = "Hent Sager" };
			b.Clicked += async (sender, e) => {
				var sv = new Sagsliste();
				await sv.HentSager(0,"",200);
				Device.BeginInvokeOnMainThread( () => {
					Debug.WriteLine (string.Format ("Fundet {0} Sager", sv));
					l.Text = sv + " sager";
					lv.ItemsSource = sv.sager.Sag;

				});
			};

			lv = new ListView ();
			lv.ItemTemplate = new DataTemplate(typeof(TextCell));
			lv.ItemTemplate.SetBinding(TextCell.TextProperty, "Summary");
			lv.ItemSelected += (sender, e) => {
				var eq = (Sag)e.SelectedItem;
				DisplayAlert("Earthquake info", eq.ToString(), "OK", null);
			};

			Content = new StackLayout {
				Padding = new Thickness (0, 20, 0, 0),
				Children = {
					l,
					b,
					lv
				}
			};
		}
	}
}
