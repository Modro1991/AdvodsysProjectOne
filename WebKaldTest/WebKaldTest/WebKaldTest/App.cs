﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace WebKaldTest
{
    public class App : Application
    {
        public App()
        {
//			MainPage = new Menu();
			var tabs = new TabbedPage ();

			tabs.Children.Add(new DataFangstLayout {Title = "Se Data" });
			tabs.Children.Add(new RedigerDataFangstLayout {Title = "Rediger Data" });

			MainPage = tabs;
        }
    }
}
