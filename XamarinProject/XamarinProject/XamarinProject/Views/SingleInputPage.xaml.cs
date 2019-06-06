using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class SingleInputPage : ContentPage
    {
        public SingleInputPage()
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
            var vm = BindingContext as SingleInputPageViewModel;

            if (vm.Continue)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                await Navigation.PopAsync();
            }

        }

        private void Switch1_Toggled(object sender, ToggledEventArgs e)
        {

            if (BindingContext is SingleInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player1Input)
                    {
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player1Input)
                    {
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                    }
                }
                else
                {
                    if (vm.Player1Input)
                    {
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                        vm.Player6Input = false;
                    }
                }
            }

        }

        private void Switch2_Toggled(object sender, ToggledEventArgs e)
        {

            if (BindingContext is SingleInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player2Input)
                    {
                        vm.Player1Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player2Input)
                    {
                        vm.Player1Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                    }
                }
                else
                {
                    if (vm.Player2Input)
                    {
                        vm.Player1Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                        vm.Player6Input = false;
                    }
                }
            }
        }

        private void Switch3_Toggled(object sender, ToggledEventArgs e)
        {

            if (BindingContext is SingleInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player3Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player4Input = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player3Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                    }
                }
                else
                {
                    if (vm.Player3Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                        vm.Player6Input = false;
                    }
                }
            }
        }

        private void Switch4_Toggled(object sender, ToggledEventArgs e)
        {

            if (BindingContext is SingleInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player4Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player4Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player5Input = false;
                    }
                }
                else
                {
                    if (vm.Player4Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player5Input = false;
                        vm.Player6Input = false;
                    }
                }
            }
        }

        private void Switch5_Toggled(object sender, ToggledEventArgs e)
        {

            if (BindingContext is SingleInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player5Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player5Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player6Input = false;
                    }
                }
            }
        }

        private void Switch6_Toggled(object sender, ToggledEventArgs e)
        {

            if (BindingContext is SingleInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player6Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input)
                    {
                        vm.Player1Input = false;
                        vm.Player2Input = false;
                        vm.Player3Input = false;
                        vm.Player4Input = false;
                        vm.Player5Input = false;
                    }
                }
            }
        }
    }
}
