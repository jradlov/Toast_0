using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Toast_0.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(ToastService))]
namespace Toast_0.Droid
{
    public class ToastService : IToast
    {
        // the app crashes if have empty constructor!

        //ToastService() { }

        public void Show(string msg)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, msg, ToastLength.Long).Show();
        }
    }
}