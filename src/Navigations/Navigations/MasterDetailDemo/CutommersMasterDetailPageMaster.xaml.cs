using Navigations.ModalPagesDemo;
using Navigations.StackBasedNavigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigations.MasterDetailDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CutommersMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public CutommersMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new CutommersMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class CutommersMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<CutommersMasterDetailPageMasterMenuItem> MenuItems { get; set; }

            public CutommersMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<CutommersMasterDetailPageMasterMenuItem>(new[]
                {
                    new CutommersMasterDetailPageMasterMenuItem { Id = 0, Title = "Stack Based", TargetType=(typeof(StackBased)) },
                    new CutommersMasterDetailPageMasterMenuItem { Id = 1, Title = "Tab Pages", TargetType=(typeof( Navigations.TabPagesDemo.TabbedPageDemo)) },
                    new CutommersMasterDetailPageMasterMenuItem { Id = 2, Title = "Modal Pages", TargetType=(typeof(ModalLandingPageDemo)) },

                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}