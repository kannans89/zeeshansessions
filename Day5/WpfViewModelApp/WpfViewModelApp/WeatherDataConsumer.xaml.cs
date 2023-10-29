using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfViewModelApp
{
    /// <summary>
    /// Interaction logic for WeatherDataConsumer.xaml
    /// </summary>
    public partial class WeatherDataConsumer : Window
    {
        public WeatherDataConsumer()
        {
            InitializeComponent();
        }

        private async void CallApi_Click(object sender, RoutedEventArgs e)
        {
            var httpClient = new HttpClient();
            // var stringJson =await httpClient.GetStringAsync("https://localhost:7111/WeatherForecast");
            // lblREsult.Content = stringJson;
            // MessageBox.Show(stringJson);

            var data = new WeatherForecast {
                Date = DateTime.Now,
                TemperatureC = 10,
                Summary="Good weather"
            };

           HttpResponseMessage response = await httpClient.PutAsJsonAsync("https://localhost:7111/WeatherForecast/101", data);
            if (response.IsSuccessStatusCode)
            {
                
                MessageBox.Show("updated");
            }
            else {
                MessageBox.Show("error");
            }
          
        }
    }
}
public class WeatherForecast
{
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }
}