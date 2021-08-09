using System.ComponentModel;
using TheAppV0._1.ViewModels;
using Xamarin.Forms;

namespace TheAppV0._1.Views
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