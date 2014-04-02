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

using Spectafy.Core;

namespace Spectafy.Android
{
    [Application]
    class SpectafyApplication : Application
    {
        public SpectafyApplication(IntPtr javaReference, JniHandleOwnership transfer) 
            : base(javaReference, transfer) { }

        public override void OnCreate()
        {
            base.OnCreate();
            ServiceRegistrar.Setup();
        }
    }
}