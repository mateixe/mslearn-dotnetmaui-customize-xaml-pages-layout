using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace mslearn_dotnetmaui_customize_xaml_pages_layout
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
