using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.ModalPagesDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModalLandingPageDemo : ContentPage
    {
        public ModalLandingPageDemo()
        {
            InitializeComponent();
        }

        private async void LaunchModalButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutModalDemo());
        }
    }
}