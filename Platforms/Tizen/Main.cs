using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Cretu_Ioana_Lab7_2
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}