using helo_world_x.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace helo_world_x.Views
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