using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XAMARIN_TEST_1223.Droid
{
    class Setting
    {
        public bool check_water_1; // false, true
        public void Load()
        {
            ISharedPreferences prefs = Application.Context.GetSharedPreferences("setting", FileCreationMode.Private);
            this.check_water_1 = prefs.GetBoolean("Check_water_1", false);
        }
        public void Save()
        {
            ISharedPreferences prefs = Application.Context.GetSharedPreferences("setting", FileCreationMode.Private);
            ISharedPreferencesEditor editor = prefs.Edit();

            editor.PutBoolean("Check_water_1", this.check_water_1);
            editor.Apply();
        }
    }
}