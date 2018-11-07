using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using WeatherApp.Core.Services;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Java.Sql;

namespace WeatherApp.Core.ViewModels
{
    public class WeatherDetailsViewModel : MvxViewModel
    {
        readonly IWeatherService _weatherService;
        readonly MainWeatherViewModel _mainWeatherViewModel;
        readonly Singleton _singleton;
        //private 


        public WeatherDetailsViewModel(WeatherService weatherService, MainWeatherViewModel mainWeatherViewModel, Singleton singleton)
        {
            _weatherService = weatherService;
            _mainWeatherViewModel = mainWeatherViewModel;
            _singleton = singleton;
        }

        public WeatherDetailsViewModel()
        {
        }

        private string _cityName;
        public string CityName
        {
            get => _cityName;
            set
            {
                _cityName = value;
                RaisePropertyChanged(() => CityName);
            }
        }
        private double _temperature;
        public double Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                RaisePropertyChanged(() => Temperature);
            }
        }
        public async void ShowWeatherAsync()
        {
            CityName = _mainWeatherViewModel.City;
            
            var result = await _weatherService.GetWeather(CityName);

            Temperature = Math.Round(result.Main.Temperature, 1);

           
        }

    }
}

