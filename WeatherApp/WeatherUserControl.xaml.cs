using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WeatherApp
{
    /// <summary>
    /// Логика взаимодействия для WeatherUserControl.xaml
    /// </summary>
    public partial class WeatherUserControl : UserControl
    {
        public WeatherUserControl(Forecastday data)
        {
            InitializeComponent();
            dateWeather.Text = data.Date;
            //Image
            dayTemperatureWeather.Text = data.Day.Maxtemp_c;
            nightTemperatureWeather.Text = data.Day.Mintemp_c;
            specificationWeather.Text = data.Day.Condition.Text;
            //pressureWeather.Text = data.
            humidityWeather.Text = data.Day.Avghumidity;
            windWeather.Text = data.Day.Maxwind_mph;
        }
    }
}
