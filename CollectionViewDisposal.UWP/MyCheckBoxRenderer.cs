using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

using CollectionViewDisposal;
using CollectionViewDisposal.UWP;

[assembly: ExportRenderer(typeof(MyCheckBox), typeof(MyCheckBoxRenderer))]
namespace CollectionViewDisposal.UWP
{
    public class MyCheckBoxRenderer : CheckBoxRenderer
    {
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}