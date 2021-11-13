using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDisposal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
			BindingContext = new ViewModelForTest();
		}
	}


	public class ViewModelForTest
	{
		public ObservableCollection<ModelForTest> Items { get; set; }

		public ViewModelForTest()
		{
			var collection = new ObservableCollection<ModelForTest>();
			var pageSize = 5;

			for (var i = 0; i < pageSize; i++)
			{
				collection.Add(new ModelForTest
				{
					Text = "Item " + i,
				});
			}

			Items = collection;
		}
	}

	public class ModelForTest
	{
		public string Text { get; set; }

		public string Source { get; set; }
	}
}