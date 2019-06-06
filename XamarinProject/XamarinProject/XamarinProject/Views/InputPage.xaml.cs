using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class InputPage : ContentPage
    {
        public InputPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            var vm = BindingContext as InputPageViewModel;

            if (vm.Continue)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                await Navigation.PopAsync();
            }
            
        }
    }
}
