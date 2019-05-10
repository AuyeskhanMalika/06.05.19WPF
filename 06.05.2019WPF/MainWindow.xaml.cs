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

namespace _06._05._2019WPF
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            const int DAY = 0;
            const int FIRST_DAY = 1;
            const int SECOND_DAY = 2;
            const int THIRD_DAY = 3;
            const int FOURTH_DAY = 4;
            const int FIFTH_DAY = 5;
            const int SIXTH_DAY = 6;

            Weather weather;

            try
            {
                weather = new Service().DeserializationJson(city.Text);
            }
            catch
            {
                MessageBox.Show("This city doesn't exist!");
                return;
            }

            string uri = "http:" + weather.Forecast.ForecastDay[DAY].Day.Condition.Icon;
            image.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[FIRST_DAY].Day.Condition.Icon;
            imageFirst.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[SECOND_DAY].Day.Condition.Icon;
            imageSecond.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[THIRD_DAY].Day.Condition.Icon;
            imageThird.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[FOURTH_DAY].Day.Condition.Icon;
            imageFourth.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[FIFTH_DAY].Day.Condition.Icon;
            imageFifth.Source = new BitmapImage(new Uri(uri));

            uri = "http:" + weather.Forecast.ForecastDay[SIXTH_DAY].Day.Condition.Icon;
            imageSixth.Source = new BitmapImage(new Uri(uri));


            temperatureInCelsius.Text = Convert.ToInt32(weather.Forecast.ForecastDay[DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusFirst.Text = Convert.ToInt32(weather.Forecast.ForecastDay[FIRST_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIRST_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusSecond.Text = Convert.ToInt32(weather.Forecast.ForecastDay[SECOND_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[SECOND_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusThird.Text = Convert.ToInt32(weather.Forecast.ForecastDay[THIRD_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[THIRD_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusFourth.Text = Convert.ToInt32(weather.Forecast.ForecastDay[FOURTH_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[FOURTH_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusFifth.Text = Convert.ToInt32(weather.Forecast.ForecastDay[FIFTH_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIFTH_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            temperatureInCelsiusSixth.Text = Convert.ToInt32(weather.Forecast.ForecastDay[SIXTH_DAY].Day.MaximumTemperatureInCelsius).ToString()
                + "° - " + Convert.ToInt32(weather.Forecast.ForecastDay[SIXTH_DAY].Day.MinimumTemperatureInCelsius).ToString() + "°";

            date.Text = weather.Forecast.ForecastDay[DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[DAY].Date.Value.ToShortDateString();
            dateFirst.Text = weather.Forecast.ForecastDay[FIRST_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[FIRST_DAY].Date.Value.ToShortDateString();
            dateSecond.Text = weather.Forecast.ForecastDay[SECOND_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[SECOND_DAY].Date.Value.ToShortDateString();
            dateThird.Text = weather.Forecast.ForecastDay[THIRD_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[THIRD_DAY].Date.Value.ToShortDateString();
            dateFourth.Text = weather.Forecast.ForecastDay[FOURTH_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[FOURTH_DAY].Date.Value.ToShortDateString();
            dateFifth.Text = weather.Forecast.ForecastDay[FIFTH_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[FIFTH_DAY].Date.Value.ToShortDateString();
            dateSixth.Text = weather.Forecast.ForecastDay[SIXTH_DAY].Date.Value.DayOfWeek.ToString() + "\n" + weather.Forecast.ForecastDay[SIXTH_DAY].Date.Value.ToShortDateString();

            humidity.Text = "Humidity - " + weather.Forecast.ForecastDay[DAY].Day.AverageHumidity.ToString() + "%";
            humidityFirst.Text = "Humidity - " + weather.Forecast.ForecastDay[FIRST_DAY].Day.AverageHumidity.ToString() + "%";
            humiditySecond.Text = "Humidity - " + weather.Forecast.ForecastDay[SECOND_DAY].Day.AverageHumidity.ToString() + "%";
            humidityThird.Text = "Humidity - " + weather.Forecast.ForecastDay[THIRD_DAY].Day.AverageHumidity.ToString() + "%";
            humidityFourth.Text = "Humidity - " + weather.Forecast.ForecastDay[FOURTH_DAY].Day.AverageHumidity.ToString() + "%";
            humidityFifth.Text = "Humidity - " + weather.Forecast.ForecastDay[FIFTH_DAY].Day.AverageHumidity.ToString() + "%";
            humiditySixth.Text = "Humidity - " + weather.Forecast.ForecastDay[SIXTH_DAY].Day.AverageHumidity.ToString() + "%";

            windSpeed.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedFirst.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIRST_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedSecond.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[SECOND_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedThird.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[THIRD_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedFourth.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[FOURTH_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedFifth.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[FIFTH_DAY].Day.WindSpeed).ToString() + "км/ч";
            windSpeedSixth.Text = "Wind speed - " + Convert.ToInt32(weather.Forecast.ForecastDay[SIXTH_DAY].Day.WindSpeed).ToString() + "км/ч";
        }
    }
}
