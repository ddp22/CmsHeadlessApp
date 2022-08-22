/*using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Wikitude.Architect;
using Com.Wikitude.Common.Camera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsHeadlessApp.Platforms.Android
{
    [Activity(Label = "SimpleArActivity", ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class SimpleArActivity : Activity
    {
        public ArchitectView architectView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            var config = new ArchitectStartupConfiguration
            {
                LicenseKey = "YOUR-LICENSE-KEY",
                CameraPosition = CameraSettings.CameraPosition.Back,
                CameraResolution = CameraSettings.CameraResolution.FULLHD1920x1080,
                CameraFocusMode = CameraSettings.CameraFocusMode.Continuous,
                ArFeatures = ArchitectStartupConfiguration.Features.ImageTracking
            };

            architectView = new ArchitectView(this);
            architectView.OnCreate(config);

            SetContentView(architectView);
        }
        protected override void OnPostCreate(Bundle savedInstanceState)
        {
            base.OnPostCreate(savedInstanceState);
            architectView.OnPostCreate();
        }
        protected override void OnResume()
        {
            base.OnResume();
            architectView.OnResume();
        }

        protected override void OnPause()
        {
            base.OnPause();
            architectView.OnPause();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            architectView.OnDestroy();
        }
    }
}*/
