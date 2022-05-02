using Gtk;
using GtkSource;
using System;

namespace Note_Taking_App2
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.Note_Taking_App2.Note_Taking_App2", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);
            // Register GtkSourceView so GtkBuilder can find it.
            new SourceView().GetType();
            var win = new MainWindow();
            app.AddWindow(win);

            win.Show();
            Application.Run();
        }
    }
}
