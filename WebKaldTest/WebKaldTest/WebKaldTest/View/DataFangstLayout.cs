﻿using System;

using Xamarin.Forms;

namespace WebKaldTest
{
	public class DataFangstLayout : ContentPage
	{
		public DataFangstLayout ()
		{
			//var myEntry = new Entry ();

			//myEntry.Placeholder = "text";
			Label header = new Label
			{
				Text = "Data",
				Font = Font.SystemFontOfSize(40, FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};
			//------------------navn--------------------------
			//Label navn = new Label {
				//Text = "Navn",
				//Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
				//TextColor = Color.Silver
			//};
			var entry1 = new Entry 
			{
				Placeholder = "indtast navn",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};
			//------------------adresse--------------------------
//			Label adresse = new Label {
//				Text = "Adresse",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			Entry entry2 = new Entry 
			{
				Placeholder = "indtast adresse",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};
			//------------------postnr--------------------------
//			Label postnr = new Label {
//				Text = "Postnummer",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			Entry entry3 = new Entry 
			{
				Placeholder = "indtast postnummer",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};
			//------------------vedr--------------------------
//			Label vedr = new Label {
//				Text = "Vedrørende",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			Entry entry4 = new Entry 
			{
				Placeholder = "indtast vedrørende",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};
			//------------------dato--------------------------
//			Label dato = new Label {
//				Text = "Dato",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			DatePicker date = new DatePicker {
			Date = DateTime.Today,
			BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
			IsEnabled = false
			};
			//------------------beløb--------------------------
//			Label belob = new Label {
//				Text = "Beløb",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			Entry entry5 = new Entry 
			{
				Placeholder = "indtast beløb",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};
			//------------------rente--------------------------
//			Label rente = new Label {
//				Text = "Rente",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			Entry entry6 = new Entry 
			{
				Placeholder = "indtast rente",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};
			//------------------gebyr--------------------------
//			Label gebyr = new Label {
//				Text = "Gebyr",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
			Entry entry7 = new Entry 
			{
				Placeholder = "indtast gebyr",
				BackgroundColor = Color.FromRgba(255, 255, 255, 0.3),
				TextColor = Color.Black,
				IsEnabled = false
			};

			//-----------Button-------------------
//			Button button = new Button 
//			{
//				Text = "Rediger",
//				Font = Font.SystemFontOfSize(30, FontAttributes.Bold),
//				TextColor = Color.Silver
//			};
		
			//----------egne------------------------



			var scrollview = new ScrollView{			
				//HorizontalOptions = LayoutOptions.End,
				//IsClippedToBounds = true,
				Orientation = ScrollOrientation.Vertical,
				VerticalOptions = LayoutOptions.Fill,

				Content = new StackLayout {
					Orientation = StackOrientation.Vertical,
					Padding = new Thickness (20),
					Spacing = 20,


					Children = {
						header,
						entry1,
						entry2,
						entry3,
						entry4,
						date,
						entry5,
						entry6,
						entry7
					}
				},
				};
				this.Content = new StackLayout {
				Children = {
					scrollview
				}
			};
		
		
		}
	}
}



