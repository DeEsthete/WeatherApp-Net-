using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        private Forecastday mainData;
        public WeatherUserControl(Forecastday data)
        {
            InitializeComponent();
            mainData = data;
            dateWeather.Text = data.Date;
            ApplyImage();
            dayTemperatureWeather.Text = data.Day.Maxtemp_c;
            nightTemperatureWeather.Text = data.Day.Mintemp_c;
            specificationWeather.Text = data.Day.Condition.Text;
            humidityWeather.Text = data.Day.Avghumidity;
            windWeather.Text = data.Day.Maxwind_mph;
        }

        private async void ApplyImage()
        {
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.StreamSource = await GetImage();
            bitmap.EndInit();
            imageWeather.Source = bitmap;
        }

        private Task<MemoryStream> GetImage()
        {
            return Task.Run(() =>
            {
                using (WebClient client = new WebClient())
                {
                    mainData.Day.Condition.Icon = "https:" + mainData.Day.Condition.Icon;
                    var file = client.DownloadData(mainData.Day.Condition.Icon);
                    var memoryStream = new MemoryStream(file);
                    return memoryStream;
                }
            });
        }
    }
}
