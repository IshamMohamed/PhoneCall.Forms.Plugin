using Microsoft.Phone.Tasks;
using PhoneCall.Forms.Plugin.Abstractions;
using PhoneCall.Forms.Plugin.WindowsPhone;
using System;
using System.Windows;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCallImplementation))]
namespace PhoneCall.Forms.Plugin.WindowsPhone
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
                PhoneCallTask phoneCallTask = new PhoneCallTask();
                phoneCallTask.PhoneNumber = PhoneNumber;
                phoneCallTask.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid phone number", "Error", MessageBoxButton.OK);
            }
        }
    }
}
