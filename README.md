#GtkMessenger V.1.1

![Alt text](/Screenshots/FrontPage.png?raw=true "Login Page")
![Alt text](/Screenshots/Condensed.png?raw=true "Square Page View")

Facebook no longer permits XMPP protocol application for Messenger on Pidgin or Empathy.
The easy solution was a desktop app that displays the messenger.com interface.

Super simple dynamic WebView that wraps Facebook Messenger into a GtkWindow.


TO RUN APPLICATION:
        
	chmod +x INSTALL
	sudo /bin/sh INSTALL 
	
Desktop Launcher will be created!

   Necessary Libraries:
              mono-devel                      - Mono development tools   (http://www.mono-project.com/)                       
              gtk-sharp3                      - GTK# 3.0 suite, CLI bindings for GTK+ (http://www.mono-project.com/docs/gui/gtksharp/)
	      libwebkit2gtk-3.0
  
#ToDo: GtkMessenger V.1.2

	Display message notifications in window list
	Disable leaving messenger.com page
	Multiple Theme Options
