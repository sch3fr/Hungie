using System;
using System.Collections.Generic;
using TheAppV0._1.ViewModels;
using TheAppV0._1.Views;
using Xamarin.Forms;

namespace TheAppV0._1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
