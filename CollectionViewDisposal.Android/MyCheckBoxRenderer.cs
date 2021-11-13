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

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using CollectionViewDisposal.Droid;
using CollectionViewDisposal;

[assembly: ExportRenderer(typeof(MyCheckBox), typeof(MyCheckBoxRenderer))]
namespace CollectionViewDisposal.Droid
{
    public class MyCheckBoxRenderer : CheckBoxRenderer
    {
        public MyCheckBoxRenderer(Context context) : base(context)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}