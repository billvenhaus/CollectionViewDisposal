using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using CollectionViewDisposal;
using CollectionViewDisposal.iOS;

[assembly: ExportRenderer(typeof(MyCheckBox), typeof(MyCheckBoxRenderer))]
namespace CollectionViewDisposal.iOS
{
    public class MyCheckBoxRenderer : CheckBoxRenderer
    {
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}