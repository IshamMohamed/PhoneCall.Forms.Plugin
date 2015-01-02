using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PhoneCall.Forms.Plugin.Abstractions;
using PhoneCall.Forms.Plugin.iOS;
using System;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCallImplementation))]
namespace PhoneCall.Forms.Plugin.iOS
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
                NSUrl url = new NSUrl(string.Format(@"telprompt://{0}", PhoneNumber));
                UIApplication.SharedApplication.OpenUrl(url);
            }
            else
            {
                UIAlertView alert = new UIAlertView();
                alert.Title = "Error";
                alert.AddButton("OK");
                alert.Message = "Please enter a valid phone number";
                alert.Show();
            }
        }
    }
}
