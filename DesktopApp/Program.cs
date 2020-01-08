using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DesktopApp
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var app = new App();
            
            var mainWindow = new MainWindow();
            app.Run(mainWindow);
        }
    }
}
