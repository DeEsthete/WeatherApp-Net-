using OpenWeatherMap;
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
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WeatherApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void WithdrawWeatherButtonClick(object sender, RoutedEventArgs e)
        {
            var root = await GetWeather("astana");
        }

        public Task<Root> GetWeather(string city)
        {
            return Task.Run(() =>
            {
                string value;
                using (var webClient = new WebClient())
                {
                    webClient.Encoding = Encoding.UTF8;
                    value = webClient.DownloadString("https://api.apixu.com/v1/forecast.xml?key=f5ea02745ad04b66805103401182805%20&q=" + city + "&days=7");

                    XmlSerializer formatter = new XmlSerializer(typeof(Root));
                    using (TextReader tr = new StringReader(value))
                    {
                        Root newRoot = (Root)formatter.Deserialize(tr);
                        return newRoot;
                    }
                }
            });
        }

        //private Task<MemoryStream> GetImage(string url)
        //{
        //    return Task.Run(() =>
        //    {
        //        using (var c = new WebClient())
        //        {
        //            var bytes = c.DownloadData(url);
        //            var ms = new MemoryStream(bytes);
        //            return ms;
        //        }
        //    });
        //}


    }
}
