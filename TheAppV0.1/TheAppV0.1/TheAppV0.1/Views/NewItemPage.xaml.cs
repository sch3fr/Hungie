using System;
using System.Collections.Generic;
using System.ComponentModel;
using TheAppV0._1.Models;
using TheAppV0._1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheAppV0._1.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}