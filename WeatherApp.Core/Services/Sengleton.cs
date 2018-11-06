using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WeatherApp
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;

        public Singleton(string v, object cityname)
        {
        }

        private Singleton() {
           
        }
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        public string CityName { get; set; }
     

    }
}