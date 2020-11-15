using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.StackBasedNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackBased : ContentPage
    {
        public StackBased()
        {
            InitializeComponent();
        }

        private async void ProductsPage_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductsPage());
        }

        private async void SettingsPage_OnButtonClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingsPage());
        }
    }
}