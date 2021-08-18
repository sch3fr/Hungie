using BasedHungie.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace BasedHungie.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}