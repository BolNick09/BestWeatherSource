using Svg;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;


namespace BestWeatherSource
{
    public partial class FrmWeatherSource : Form
    {
        public FrmWeatherSource()
        {
            InitializeComponent();
        }

        private async void FrmWeatherSource_Load(object sender, EventArgs e)
        {
            await ShowWeatherFromYandex();
            //await ShowWeatherFromOpenWeather();

        }

        private async Task ShowWeatherFromYandex()
        {
            Regex hrefWeatherValue = new Regex(@"Текущая температура ([+-]?\d+°)");
            Regex hrefWeatherValueSence = new Regex(@"Ощущается как ([+-]?\d+°)");
            Regex hrefWeatherPicture = new Regex(@"<img class=""icon icon_color_light icon_size_48 icon_thumb_bkn-n fact__icon"" aria-hidden=""true"" src=""([^""]+)""");
            HttpClient client = new HttpClient();

            lblValue.Text = "Выполняяется запрос к серверу погоды";
            string html = await client.GetStringAsync(@"https://yandex.ru/pogoda/moscow");

            lblValue.Text = Regex.Match(html, hrefWeatherValue.ToString()).Groups[1].Value;
            lblValue.Text += "C";
            lblAdd.Text = Regex.Match(html, hrefWeatherValueSence.ToString()).Value + "C";

            Match imageSourceMatch = Regex.Match(html, hrefWeatherPicture.ToString());
            string imageSource = "https:" + imageSourceMatch.Groups[1].Value;
            imageSource = "https://yastatic.net/weather/i/icons/confident/light/svg/bkn_n.svg";

            var imageBytes = await client.GetByteArrayAsync(imageSource);
            using (var ms = new MemoryStream(imageBytes))
            {
                SvgDocument svgDocument = SvgDocument.Open<SvgDocument>(ms);
                Bitmap bitmap = new Bitmap(128, 128);
                svgDocument.Draw(bitmap);
                pbWeatherStatus.Image = bitmap;
            }

        }

        private async Task ShowWeatherFromOpenWeather()
        {
            Regex hrefWeatherValue = new Regex(@"<span data-v-3e6e9f12="""" class=""heading"">(-?\d+(?:\.\d+)?)");

            HttpClient client = new HttpClient();

            lblValue.Text = "Выполняяется запрос к серверу погоды";
            string html = await client.GetStringAsync("https://openweathermap.org/city/524901");

            lblValue.Text = Regex.Match(html, hrefWeatherValue.ToString()).Groups[1].Value;
            lblValue.Text += "°C";
        }
        

        
    }
}