using System;
using Xamarin.Forms;
using System.Data;
//using System.Data.DataSetExtensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;
using System.Text;
using Lab9Gestures;
//using Lab9Gestures.Services;
using System.Diagnostics;


namespace Lab9Gestures
{
    
    public partial class App : Application
    {
        public static float ScreenHeight { get; set; }
        public static float ScreenWidth { get; set; }
        public App()
        {
            InitializeComponent();

            DependencyService.Register<ITableModel>();
            //MainPage =new MainPage();
            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
