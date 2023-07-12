using DigiWork_MobileAPP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DigiWork_MobileAPP.Views
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