using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross;
using MvvmCross.ViewModels;
using WeatherApp.Core.ViewModels;
using WeatherApp.Core.Services;
namespace WeatherApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            #pragma warning disable CS0618 // Type or member is obsolete
            Mvx.RegisterType<IWeatherService, WeatherService>();
            #pragma warning restore CS0618 // Type or member is obsolete

            RegisterAppStart<MainWeatherViewModel>();
        }
    }
}
