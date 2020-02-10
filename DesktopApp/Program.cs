using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using SimpleInjector;


namespace DesktopApp
{
    public class Program
    {
        static readonly Container container;

        static Program()
        {
            container = new Container();
            Bootstrapper.Bootstrapping(container);
        }

        [STAThread]
        static void Main(string[] args)
        {
            var app = new App();
            
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}
