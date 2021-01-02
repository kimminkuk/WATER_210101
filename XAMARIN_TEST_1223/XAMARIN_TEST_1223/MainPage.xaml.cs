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
        string flg_1 = "";
        bool flg8 = false;
        //bool rememberMe = false;

        public MainPage()
        {
            InitializeComponent();
            //timerPicker2.Time = DateTime.Now.TimeOfDay; // timerPcker2에 현재 시간 표시
            //flg_1 = GetValue_bool("mykey");
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
            if (flg_1 != "true")
            {
                water1.IsVisible = false;
                water_eat_action();
                string str_time = DateTime.Now.ToString("HH:mm");
                water1_eat_time.Text = str_time;
                lasttime_eat_water.Text = str_time;
            }
            flg_1 = "true";
        }

        private void water2_Clicked(object sender, EventArgs e)
        {
            water2.IsVisible = false;
            water_eat_action();
            string str_time = DateTime.Now.ToString("HH:mm");
            water2_eat_time.Text = str_time;
            lasttime_eat_water.Text = str_time;
        }

        private void water3_Clicked(object sender, EventArgs e)
        {
            water3.IsVisible = false;
            water_eat_action();
            string str_time = DateTime.Now.ToString("HH:mm");
            water3_eat_time.Text = str_time;
            lasttime_eat_water.Text = str_time;
        }

        private void water4_Clicked(object sender, EventArgs e)
        {
            water4.IsVisible = false;
            water_eat_action();
            string str_time = DateTime.Now.ToString("HH:mm");
            water4_eat_time.Text = str_time;
            lasttime_eat_water.Text = str_time;
        }

        private void water5_Clicked(object sender, EventArgs e)
        {
            water5.IsVisible = false;
            water_eat_action();
            string str_time = DateTime.Now.ToString("HH:mm");
            water5_eat_time.Text = str_time;
            lasttime_eat_water.Text = str_time;
        }

        private void water6_Clicked(object sender, EventArgs e)
        {
            water6.IsVisible = false;
            water_eat_action();
            string str_time = DateTime.Now.ToString("HH:mm");
            water6_eat_time.Text = str_time;
            lasttime_eat_water.Text = str_time;
        }

        private void water7_Clicked(object sender, EventArgs e)
        {
            water7.IsVisible = false;
            water_eat_action();
            string str_time = DateTime.Now.ToString("HH:mm");
            water7_eat_time.Text = str_time;
            lasttime_eat_water.Text = str_time;
        }

        private void water8_Clicked(object sender, EventArgs e)
        {
            if (flg8 == true)
            {
                water8.IsVisible = true;
                water8_eat_time.Text = "";
                flg8 = false;
            } else
            {
                water8.IsVisible = false;
                flg8 = true;

                water_eat_action();
                string str_time = DateTime.Now.ToString("HH:mm");
                water8_eat_time.Text = str_time;
                lasttime_eat_water.Text = str_time;
            }
        }

        private void water_eat_action()
        {
            f_vibrate_on();
         
        }
        

        public void AddValue(string key, string value)
        {
            Preferences.Set(key, value);
        }
        public string GetValue_bool(string key)
        {
            return Preferences.Get(key, "");
        }

        public bool RememberMe
        { 
            get => Preferences.Get(nameof(RememberMe), false);
            set
            {
                Preferences.Set(nameof(RememberMe), true);
                OnPropertyChanged(nameof(RememberMe));
            }
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value)
            {
                string test;
            }
            else //off
            {
                string test_;
            }
        }

        private void Button_Clicked(object sender, EventArgs e) //load
        {
            flg_1 = GetValue_bool("mykey_flg_1");
        }

        private void Button_Clicked_1(object sender, EventArgs e) //save
        {
            AddValue("mykey_flg_1", flg_1);
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Preferences.Remove("mykey_flg_1");
        }
    }
}
