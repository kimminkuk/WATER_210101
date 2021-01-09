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
        const int IMAGE_CNT = 8;
        //bool rememberMe = false;
        string[] flg = new string[IMAGE_CNT];
        string[] strtime = new string[IMAGE_CNT];

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
            if (flg[0] != "true")
            {
                water1.IsVisible = false;
                water_eat_action();
                strtime[0] = DateTime.Now.ToString("HH:mm");
                water1_eat_time.Text = strtime[0];
                lasttime_eat_water.Text = strtime[0];
            }
            flg[0] = "true";
        }

        private void water2_Clicked(object sender, EventArgs e)
        {
            if (flg[1] != "true")
            {
                water2.IsVisible = false;
                water_eat_action();
                strtime[1] = DateTime.Now.ToString("HH:mm");
                water2_eat_time.Text = strtime[1];
                lasttime_eat_water.Text = strtime[1];
            }
            flg[1] = "true";
        }

        private void water3_Clicked(object sender, EventArgs e)
        {
            if (flg[2] != "true")
            {
                water3.IsVisible = false;
                water_eat_action();
                strtime[2] = DateTime.Now.ToString("HH:mm");
                water3_eat_time.Text = strtime[2];
                lasttime_eat_water.Text = strtime[2];
            }
            flg[2] = "true";
        }

        private void water4_Clicked(object sender, EventArgs e)
        {
            if (flg[3] != "true")
            {
                water4.IsVisible = false;
                water_eat_action();
                strtime[3] = DateTime.Now.ToString("HH:mm");
                water4_eat_time.Text = strtime[3];
                lasttime_eat_water.Text = strtime[3];
            }
            flg[3] = "true";
        }

        private void water5_Clicked(object sender, EventArgs e)
        {
            if (flg[4] != "true")
            {
                water5.IsVisible = false;
                water_eat_action();
                strtime[4] = DateTime.Now.ToString("HH:mm");
                water5_eat_time.Text = strtime[4];
                lasttime_eat_water.Text = strtime[4];
            }
            flg[4] = "true";
        }

        private void water6_Clicked(object sender, EventArgs e)
        {
            if (flg[5] != "true")
            {
                water6.IsVisible = false;
                water_eat_action();
                strtime[5] = DateTime.Now.ToString("HH:mm");
                water6_eat_time.Text = strtime[5];
                lasttime_eat_water.Text = strtime[5];
            }
            flg[5] = "true";
        }

        private void water7_Clicked(object sender, EventArgs e)
        {
            if (flg[6] != "true")
            {
                water7.IsVisible = false;
                water_eat_action();
                strtime[6] = DateTime.Now.ToString("HH:mm");
                water7_eat_time.Text = strtime[6];
                lasttime_eat_water.Text = strtime[6];
            }
            flg[6] = "true";
        }

        private void water8_Clicked(object sender, EventArgs e)
        {
            if (flg[7] != "true")
            {
                water8.IsVisible = false;
                water_eat_action();
                strtime[7] = DateTime.Now.ToString("HH:mm");
                water8_eat_time.Text = strtime[7];
                lasttime_eat_water.Text = strtime[7];
            }
            flg[7] = "true";
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
            for (int i =0; i < IMAGE_CNT; i++)
            {
                string saveflg = "mykey_flg_";
                string savetime = "mykey_string_";
                saveflg += i;
                savetime += i;
                flg[i] = GetValue_bool(saveflg);
                strtime[i] = GetValue_bool(savetime);
            }
            if (flg[0] == "true")
            {
                water1.IsVisible = false;
                water1_eat_time.Text = strtime[0];
                lasttime_eat_water.Text = strtime[0];
            }
            if (flg[1] == "true")
            {
                water2.IsVisible = false;
                water2_eat_time.Text = strtime[1];
                lasttime_eat_water.Text = strtime[1];
            }
            if (flg[2] == "true")
            {
                water3.IsVisible = false;
                water3_eat_time.Text = strtime[2];
                lasttime_eat_water.Text = strtime[2];
            }
            if (flg[3] == "true")
            {
                water4.IsVisible = false;
                water4_eat_time.Text = strtime[3];
                lasttime_eat_water.Text = strtime[3];
            }
            if (flg[4] == "true")
            {
                water5.IsVisible = false;
                water5_eat_time.Text = strtime[4];
                lasttime_eat_water.Text = strtime[4];
            }
            if (flg[5] == "true")
            {
                water6.IsVisible = false;
                water6_eat_time.Text = strtime[5];
                lasttime_eat_water.Text = strtime[5];
            }
            if (flg[6] == "true")
            {
                water7.IsVisible = false;
                water7_eat_time.Text = strtime[6];
                lasttime_eat_water.Text = strtime[6];
            }
            if (flg[7] == "true")
            {
                water8.IsVisible = false;
                water8_eat_time.Text = strtime[7];
                lasttime_eat_water.Text = strtime[7];
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e) //save
        {
            for( int i = 0; i < IMAGE_CNT; i++ )
            {
                string saveflg = "mykey_flg_";
                string savetime = "mykey_string_";
                saveflg += i;
                savetime += i;
                AddValue(saveflg, flg[i]);
                AddValue(savetime, strtime[i]);
            }
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            for (int i = 0; i < IMAGE_CNT; i++)
            {
                string saveflg = "mykey_flg_";
                string savetime = "mykey_string_";
                saveflg += i;
                savetime += i;
                Preferences.Remove(saveflg);
                Preferences.Remove(savetime);
            }
        }
    }
}
