using System;

using Xamarin.Forms;

namespace WebKaldTest
{
	public class HentTid : ContentPage
	{
		Button buttonFind;
		Entry entryDato;
		Label label;
		Tidsliste tidsliste;

		public HentTid ()
		{
			entryDato = new Entry
			{
				Placeholder = "Indtast dato",
				BackgroundColor = Color.FromRgba (255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = true
			};

			buttonFind = new Button
			{ 
				Text = "Tid",
				BackgroundColor = Color.Silver,
				TextColor = Color.Black,
				HorizontalOptions = LayoutOptions.Fill,
				VerticalOptions = LayoutOptions.Center
			};
			buttonFind.Clicked += OnButtonClicked;
			/*buttonFind.Clicked += delegate {

				//int dato = Int32.Parse(entryDato.Text);
				string dato = entryDato.Text;
				tidsliste.HentTider(dato);
				var txt = "Tid\n";
				foreach (var t in tidsliste.tider.Tid)
				{
					txt += string.Format("{0} {1}\n", t.aktivitet, t.fraklokken);
				}

				label.Text = txt;
			};*/

			label = new Label
			{
				Text = "Text",
				Font = Font.SystemFontOfSize(NamedSize.Large),
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			var scrollView = new ScrollView 
			{

				Orientation = ScrollOrientation.Vertical,
				VerticalOptions = LayoutOptions.Fill,

				Content = new StackLayout
				{
					Orientation = StackOrientation.Vertical,
					Padding = new Thickness(20),
					Spacing = 20,

					Children = {
						entryDato,
						buttonFind,
						label
					}
				},

			};

			this.Content = new StackLayout
			{ 
				Children = {
					scrollView
				}
			};
		}
		async void OnButtonClicked(object sender, EventArgs e)
		{
			tidsliste = new Tidsliste ();
			string dato = entryDato.Text;
			await tidsliste.HentTider(dato);
			var txt = "Tid\n";
			foreach (var t in tidsliste.tider.Tid)
			{
				txt += string.Format("{0} {1}\n", t.aktivitet, t.fraklokken);
			}

			label.Text = txt;
		}
	}
}


