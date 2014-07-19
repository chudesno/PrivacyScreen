using System;

using Microsoft.Phone.Controls;

using WPCordovaClassLib.Cordova;
using WPCordovaClassLib.Cordova.Commands;
using WPCordovaClassLib.Cordova.JSON;

namespace Cordova.Extension.Commands
{
    public class PrivacyScreenPlugin : BaseCommand
    {
        public override void OnInit() {
            if (Environment.OSVersion.Version >= new Version(8, 0, 10322)) {
                var propertyInfo = typeof(PhoneApplicationPage).GetProperty("IsScreenCaptureEnabled");
                if (propertyInfo != null) {
                    propertyInfo.SetValue(this, false);
                }
            }
        }
   }
}