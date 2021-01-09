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
        string[] flg = new string[IMAGE_CNT];
        string[] strtime = new string[IMAGE_CNT];
        Image[] img_arr = new Image[IMAGE_CNT];
        Label[] label_arr = new Label[IMAGE_CNT];
        static DateTime[] lastcheck = new DateTime[IMAGE_CNT];
        public MainPage()
        {
            InitializeComponent();
            img_arr[0] = imgtest1;
            img_arr[1] = imgtest2;
            img_arr[2] = imgtest3;
            img_arr[3] = imgtest4;
            img_arr[4] = imgtest5;
            img_arr[5] = imgtest6;
            img_arr[6] = imgtest7;
            img_arr[7] = imgtest8;

            label_arr[0] = water1_eat_time;
            label_arr[1] = water2_eat_time;
            label_arr[2] = water3_eat_time;
            label_arr[3] = water4_eat_time;
            label_arr[4] = water5_eat_time;
            label_arr[5] = water6_eat_time;
            label_arr[6] = water7_eat_time;
            label_arr[7] = water8_eat_time;
#if true
            //TapGestureRecognizer 생성
            var tapImage1 = new TapGestureRecognizer();
            var tapImage2 = new TapGestureRecognizer();
            var tapImage3 = new TapGestureRecognizer();
            var tapImage4 = new TapGestureRecognizer();
            var tapImage5 = new TapGestureRecognizer();
            var tapImage6 = new TapGestureRecognizer();
            var tapImage7 = new TapGestureRecognizer();
            var tapImage8 = new TapGestureRecognizer();

            //이벤트 바인딩
            tapImage1.Tapped += tapImage_Tapped_1;
            tapImage2.Tapped += tapImage_Tapped_2;
            tapImage3.Tapped += tapImage_Tapped_3;
            tapImage4.Tapped += tapImage_Tapped_4;
            tapImage5.Tapped += tapImage_Tapped_5;
            tapImage6.Tapped += tapImage_Tapped_6;
            tapImage7.Tapped += tapImage_Tapped_7;
            tapImage8.Tapped += tapImage_Tapped_8;
            //탭 이벤트를 이미지 버튼에 연결
            imgtest1.GestureRecognizers.Add(tapImage1);
            img_arr[0].GestureRecognizers.Add(tapImage1);

            imgtest2.GestureRecognizers.Add(tapImage2);
            img_arr[1].GestureRecognizers.Add(tapImage2);

            imgtest3.GestureRecognizers.Add(tapImage3);
            img_arr[2].GestureRecognizers.Add(tapImage3);

            imgtest4.GestureRecognizers.Add(tapImage4);
            img_arr[3].GestureRecognizers.Add(tapImage4);

            imgtest5.GestureRecognizers.Add(tapImage5);
            img_arr[4].GestureRecognizers.Add(tapImage5);

            imgtest6.GestureRecognizers.Add(tapImage6);
            img_arr[5].GestureRecognizers.Add(tapImage6);

            imgtest7.GestureRecognizers.Add(tapImage7);
            img_arr[6].GestureRecognizers.Add(tapImage7);

            imgtest8.GestureRecognizers.Add(tapImage8);
            img_arr[7].GestureRecognizers.Add(tapImage8);
#endif
        }

        void tapImage_Tapped_1(object sender, EventArgs e)
        {
            if (flg[0] != "true")
            {
                imgtest1.IsVisible = false;
                water_eat_action();
                strtime[0] = DateTime.Now.ToString("HH:mm");
                label_arr[0].Text = strtime[0];
                //lasttime_eat_water.Text = strtime[0];
                lastcheck[0] = DateTime.Now;
            }
            flg[0] = "true";
        }
        void tapImage_Tapped_2(object sender, EventArgs e)
        {
            if (flg[1] != "true")
            {
                imgtest2.IsVisible = false;
                water_eat_action();
                strtime[1] = DateTime.Now.ToString("HH:mm");
                label_arr[1].Text = strtime[1];
                //lasttime_eat_water.Text = strtime[1];
                lastcheck[1] = DateTime.Now;
            }
            flg[1] = "true";
        }
        void tapImage_Tapped_3(object sender, EventArgs e)
        {
            if (flg[2] != "true")
            {
                imgtest3.IsVisible = false;
                water_eat_action();
                strtime[2] = DateTime.Now.ToString("HH:mm");
                label_arr[2].Text = strtime[2];
                //lasttime_eat_water.Text = strtime[2];
                lastcheck[2] = DateTime.Now;
            }
            flg[2] = "true";
        }
        void tapImage_Tapped_4(object sender, EventArgs e)
        {
            if (flg[3] != "true")
            {
                imgtest4.IsVisible = false;
                water_eat_action();
                strtime[3] = DateTime.Now.ToString("HH:mm");
                label_arr[3].Text = strtime[3];
                //lasttime_eat_water.Text = strtime[3];
                lastcheck[3] = DateTime.Now;
            }
            flg[3] = "true";
        }
        void tapImage_Tapped_5(object sender, EventArgs e)
        {
            if (flg[4] != "true")
            {
                imgtest5.IsVisible = false;
                water_eat_action();
                strtime[4] = DateTime.Now.ToString("HH:mm");
                label_arr[4].Text = strtime[4];
                //lasttime_eat_water.Text = strtime[4];
                lastcheck[4] = DateTime.Now;
            }
            flg[4] = "true";
        }
        void tapImage_Tapped_6(object sender, EventArgs e)
        {
            if (flg[5] != "true")
            {
                imgtest6.IsVisible = false;
                water_eat_action();
                strtime[5] = DateTime.Now.ToString("HH:mm");
                label_arr[5].Text = strtime[5];
                //lasttime_eat_water.Text = strtime[5];
                lastcheck[5] = DateTime.Now;
            }
            flg[5] = "true";
        }
        void tapImage_Tapped_7(object sender, EventArgs e)
        {
            if (flg[6] != "true")
            {
                imgtest7.IsVisible = false;
                water_eat_action();
                strtime[6] = DateTime.Now.ToString("HH:mm");
                label_arr[6].Text = strtime[6];
                //lasttime_eat_water.Text = strtime[6];
                lastcheck[6] = DateTime.Now;
            }
            flg[6] = "true";
        }
        void tapImage_Tapped_8(object sender, EventArgs e)
        {
            if (flg[7] != "true")
            {
                imgtest8.IsVisible = false;
                water_eat_action();
                strtime[7] = DateTime.Now.ToString("HH:mm");
                label_arr[7].Text = strtime[7];
                //lasttime_eat_water.Text = strtime[7];
                lastcheck[7] = DateTime.Now;
            }
            flg[7] = "true";
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
            string[] temp = new string[IMAGE_CNT];
            string tt;
            for (int i =0; i < IMAGE_CNT; i++)
            {
                string saveflg = "mykey_flg_";
                string savetime = "mykey_string_";
                saveflg += i;
                savetime += i;
                flg[i] = GetValue_bool(saveflg);
                strtime[i] = GetValue_bool(savetime);
                if( flg[i] =="true")
                {
                    img_arr[i].IsVisible = false;
                    label_arr[i].Text = strtime[i];
                }
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

        private void Button_Clicked_2(object sender, EventArgs e) //clear
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
