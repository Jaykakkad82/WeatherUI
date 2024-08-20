using System;
using System.Net;
using Newtonsoft.Json ;

namespace WeatherUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string API_KEY = "";
        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeatherData();
        }

        private void getWeatherData()
        {
            using (WebClient myWeb = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, API_KEY);
                var json = myWeb.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                picIcon.ImageLocation = "http://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                labCondition.Text = Info.weather[0].main;
                labDetail.Text = Info.weather[0].description;
                labSunsetOut.Text = ConvertDateTime(Info.sys.sunset).ToString();
                labSunriseOut.Text = ConvertDateTime(Info.sys.sunrise).ToString();
                labWindSpeed.Text = Info.wind.speed.ToString();
                labPressureSpeed.Text = Info.main.pressure.ToString();
                labTemp.Text = Info.main.temp.ToString()+"°C";


            }


        }
        DateTime ConvertDateTime(long milliseconds)
        {
            DateTime aday = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            aday = aday.AddSeconds(milliseconds).ToLocalTime();
            return aday;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
