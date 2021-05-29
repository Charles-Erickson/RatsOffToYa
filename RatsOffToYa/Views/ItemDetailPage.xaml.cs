using RatsOffToYa.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace RatsOffToYa.Views
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