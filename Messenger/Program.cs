using System;
using WebKit;
using Gtk;

namespace Messenger
{
	class MainClass
	{

		public static void Main (string[] args)
		{
			Application.Init ();
			Window window = new Window ("Gtk#Messenger");
			window.Destroyed += delegate (object sender, EventArgs e) 
			{
				Application.Quit ();
			};
			window.SetDefaultSize (550,550);
			WebView webView = new WebView ();
			webView.Open ("https://messenger.com");
			webView.SetSizeRequest (500,500);
			window.Add(webView);
			window.ShowAll ();
			Application.Run ();
		}
	}
}
