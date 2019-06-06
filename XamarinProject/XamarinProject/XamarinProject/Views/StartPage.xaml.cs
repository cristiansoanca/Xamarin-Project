using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var vm = BindingContext as StartPageViewModel;

            if (vm.CurrentSelectedIndex == 1)
            {
                vm.HiddenPlayer5 = true;
                vm.HiddenPlayer6 = false;
            }
            else if (vm.CurrentSelectedIndex == 2)
            {
                vm.HiddenPlayer5 = true;
                vm.HiddenPlayer6 = true;
            }
            else
            {
                vm.HiddenPlayer5 = false;
                vm.HiddenPlayer6 = false;
            }
        }
    }
}
