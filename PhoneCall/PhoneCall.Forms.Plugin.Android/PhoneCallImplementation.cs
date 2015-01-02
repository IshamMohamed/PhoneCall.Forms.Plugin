using PhoneCall.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using PhoneCall.Forms.Plugin.Droid;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

[assembly: Dependency(typeof(PhoneCallImplementation))]
namespace PhoneCall.Forms.Plugin.Droid
{
    /// <summary>
    /// PhoneCall Implementation
    /// </summary>
    public class PhoneCallImplementation : IPhoneCall
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        public void MakeQuickCall(string PhoneNumber)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber, "^(\\(?\\+?[0-9]*\\)?)?[0-9_\\- \\(\\)]*$"))
            {
                var uri = Android.Net.Uri.Parse(String.Format("tel:{0}", PhoneNumber));
                var intent = new Intent(Intent.ActionView, uri);
				Xamarin.Forms.Forms.Context.StartActivity (intent);
            }
            else
            {
				new AlertDialog.Builder(Application.Context)
                      .SetPositiveButton("OK", (sender, args) =>
                      {
                          // User pressed OK
                      })
                      .SetMessage("Please enter a valid phone number")
                      .SetTitle("Error")
                      .Show();
            }
        }
    }
}
