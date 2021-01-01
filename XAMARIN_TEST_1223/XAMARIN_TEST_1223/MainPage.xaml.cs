using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;


namespace XAMARIN_TEST_1223
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //timerPicker2.Time = DateTime.Now.TimeOfDay; // timerPcker2에 현재 시간 표시
        }
#if false
        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            label_switch.IsVisible = e.Value;

            if( e.Value ) // Switch On 하면 현재시간 보이게,표준 시간 한국 시간으로 보이게 변경 필요함
            {
                DateTime today = DateTime.Now;
                //일반 날짜 -> UTC 표준 날짜로 변경 -> ISO8601 Format
                DateTime utcTime = today.ToUniversalTime();
                //string str_time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"); //UTC Time
                //string str_time = DateTime.UtcNow.ToString("HH:mm:ss");
                string str_time = DateTime.Now.TimeOfDay.ToString(); // 가능한가?
                label_time_eat_water.Text = str_time;
                f_vibrate_on();
            }
            else
            {
                f_vibrate_off();
            }
        }
#endif
        private void datePicker1_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private void f_vibrate_on()
        {
            try
            {
                //Use default vibration length
                Vibration.Vibrate();

                //Or use specified time
                var duration = TimeSpan.FromSeconds(0.1);
                Vibration.Vibrate(duration);
            }
            catch(FeatureNotSupportedException)
            {
                //Feature not supported on device
            }
            catch(Exception ex)
            {
                //Other error has occured
            }
        }
        private void f_vibrate_off()
        {
            try
            {
                Vibration.Cancel();
            }
            catch(FeatureNotSupportedException ex)
            {
                // Feature not supported on device
            }
            catch(Exception ex)
            {
                // Other error has occured
            }
        }

        private void water1_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
            
        }

        private void water2_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water3_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water4_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water5_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water6_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water7_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water8_Clicked(object sender, EventArgs e)
        {
            water_eat_action();
        }

        private void water_eat_action()
        {
            DateTime today = DateTime.Now;
            //일반 날짜 -> UTC 표준 날짜로 변경 -> ISO8601 Format
            DateTime utcTime = today.ToUniversalTime();
            //string str_time = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ"); //UTC Time
            string str_time = DateTime.UtcNow.ToString("HH:mm:ss");
            //string str_time = DateTime.Now.TimeOfDay.ToString(); // 가능한가?
            label_time_eat_water.Text = str_time;
            f_vibrate_on();
        }
    }
}
