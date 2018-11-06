using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;
using WeatherApp.Core.Services;
using System.Threading.Tasks;
namespace WeatherApp.Core.ViewModels
{
    public class MainWeatherViewModel : MvxViewModel
    {

        private string _city;
        public string City
        {
            get => _city;
            set
            {
                _city = value;
                RaisePropertyChanged(() => City);
                RaisePropertyChanged(() => ButtonEnabled);
            }
        }

        private bool _buttonEnabled;
        public bool ButtonEnabled
        {
            get
            {            
                if (City.Length == 0 || City == null)
                    return false;
                else
                    return true;
            }
            set
            {
                _buttonEnabled = value;
                RaisePropertyChanged(() => ButtonEnabled);
            }
        }
    }
}
