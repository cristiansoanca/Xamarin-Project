using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class RentzInputPage : ContentPage
    {
        public RentzInputPage()
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
            var vm = BindingContext as RentzInputPageViewModel;

            if (vm.Continue)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                await Navigation.PopAsync();
            }

        }

        private void Switch1_Toggled1(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player1Input1)
                    {
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;

                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player1Input1)
                    {
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;

                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                    }
                }
                else
                {
                    if (vm.Player1Input1)
                    {
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;
                        vm.Player1Input6 = false;

                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                        vm.Player6Input1 = false;
                    }
                }
            }
        }
        private void Switch1_Toggled2(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player1Input2)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;

                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player1Input2)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;

                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;

                    }
                }
                else
                {
                    if (vm.Player1Input2)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;
                        vm.Player1Input6 = false;

                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;
                        vm.Player6Input2 = false;
                    }
                }
            }
        }
        private void Switch1_Toggled3(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player1Input3)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input4 = false;

                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player1Input3)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;

                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;

                    }
                }
                else
                {
                    if (vm.Player1Input3)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;
                        vm.Player1Input6 = false;

                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;
                        vm.Player6Input3 = false;
                    }
                }
            }
        }
        private void Switch1_Toggled4(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player1Input4)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;

                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player1Input4)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input5 = false;

                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;

                    }
                }
                else
                {
                    if (vm.Player1Input4)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input5 = false;
                        vm.Player1Input6 = false;

                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;
                        vm.Player6Input4 = false;
                    }
                }
            }
        }
        private void Switch1_Toggled5(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player1Input5)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;

                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player1Input5)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input6 = false;

                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                        vm.Player6Input5 = false;
                    }
                }
            }
        }
        private void Switch1_Toggled6(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player1Input6)
                    {
                        vm.Player1Input1 = false;
                        vm.Player1Input2 = false;
                        vm.Player1Input3 = false;
                        vm.Player1Input4 = false;
                        vm.Player1Input5 = false;

                        vm.Player2Input6 = false;
                        vm.Player3Input6 = false;
                        vm.Player4Input6 = false;
                        vm.Player5Input6 = false;
                        vm.Player6Input6 = false;
                    }
                }
            }
        }

        private void Switch2_Toggled1(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player2Input1)
                    {
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;

                        vm.Player1Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player2Input1)
                    {
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;

                        vm.Player1Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                    }
                }
                else
                {
                    if (vm.Player2Input1)
                    {
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;
                        vm.Player2Input6 = false;

                        vm.Player1Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                        vm.Player6Input1 = false;
                    }
                }
            }
        }
        private void Switch2_Toggled2(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player2Input2)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;

                        vm.Player1Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player2Input2)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;

                        vm.Player1Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;
                    }
                }
                else
                {
                    if (vm.Player2Input2)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;
                        vm.Player2Input6 = false;

                        vm.Player1Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;
                        vm.Player6Input2 = false;
                    }
                }
            }
        }
        private void Switch2_Toggled3(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player2Input3)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input4 = false;

                        vm.Player1Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player2Input3)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;

                        vm.Player1Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;
                    }
                }
                else
                {
                    if (vm.Player2Input3)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;
                        vm.Player2Input6 = false;

                        vm.Player1Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;
                        vm.Player6Input3 = false;
                    }
                }
            }
        }
        private void Switch2_Toggled4(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player2Input4)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;

                        vm.Player1Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player2Input4)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input5 = false;

                        vm.Player1Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;
                    }
                }
                else
                {
                    if (vm.Player2Input4)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input5 = false;
                        vm.Player2Input6 = false;

                        vm.Player1Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;
                        vm.Player6Input4 = false;
                    }
                }
            }
        }
        private void Switch2_Toggled5(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player2Input5)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;

                        vm.Player1Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player2Input5)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input6 = false;

                        vm.Player1Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                        vm.Player6Input5 = false;
                    }
                }
            }
        }
        private void Switch2_Toggled6(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player2Input6)
                    {
                        vm.Player2Input1 = false;
                        vm.Player2Input2 = false;
                        vm.Player2Input3 = false;
                        vm.Player2Input4 = false;
                        vm.Player2Input5 = false;

                        vm.Player1Input6 = false;
                        vm.Player3Input6 = false;
                        vm.Player4Input6 = false;
                        vm.Player5Input6 = false;
                        vm.Player6Input6 = false;
                    }
                }
            }
        }

        private void Switch3_Toggled1(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player3Input1)
                    {
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player4Input1 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player3Input1)
                    {
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                    }
                }
                else
                {
                    if (vm.Player3Input1)
                    {
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;
                        vm.Player3Input6 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                        vm.Player6Input1 = false;
                    }
                }
            }
        }
        private void Switch3_Toggled2(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player3Input2)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player4Input2 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player3Input2)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;
                    }
                }
                else
                {
                    if (vm.Player3Input2)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;
                        vm.Player3Input6 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;
                        vm.Player6Input2 = false;
                    }
                }
            }
        }
        private void Switch3_Toggled3(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player3Input3)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input4 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player4Input3 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player3Input3)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;
                    }
                }
                else
                {
                    if (vm.Player3Input3)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;
                        vm.Player3Input6 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;
                        vm.Player6Input3 = false;
                    }
                }
            }
        }
        private void Switch3_Toggled4(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player3Input4)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player4Input4 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player3Input4)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input5 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;
                    }
                }
                else
                {
                    if (vm.Player3Input4)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input5 = false;
                        vm.Player3Input6 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;
                        vm.Player6Input4 = false;
                    }
                }
            }
        }
        private void Switch3_Toggled5(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player3Input5)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player3Input5)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input6 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                        vm.Player6Input5 = false;
                    }
                }
            }
        }
        private void Switch3_Toggled6(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player3Input6)
                    {
                        vm.Player3Input1 = false;
                        vm.Player3Input2 = false;
                        vm.Player3Input3 = false;
                        vm.Player3Input4 = false;
                        vm.Player3Input5 = false;

                        vm.Player1Input6 = false;
                        vm.Player2Input6 = false;
                        vm.Player4Input6 = false;
                        vm.Player5Input6 = false;
                        vm.Player6Input6 = false;
                    }
                }
            }
        }

        private void Switch4_Toggled1(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player4Input1)
                    {
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player4Input1)
                    {
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player5Input1 = false;
                    }
                }
                else
                {
                    if (vm.Player4Input1)
                    {
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;
                        vm.Player4Input6 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player5Input1 = false;
                        vm.Player6Input1 = false;
                    }
                }
            }
        }
        private void Switch4_Toggled2(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player4Input2)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player4Input2)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player5Input2 = false;
                    }
                }
                else
                {
                    if (vm.Player4Input2)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;
                        vm.Player4Input6 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player5Input2 = false;
                        vm.Player6Input2 = false;
                    }
                }
            }
        }
        private void Switch4_Toggled3(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player4Input3)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input4 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player4Input3)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player5Input3 = false;
                    }
                }
                else
                {
                    if (vm.Player4Input3)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;
                        vm.Player4Input6 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player5Input3 = false;
                        vm.Player6Input3 = false;
                    }
                }
            }
        }
        private void Switch4_Toggled4(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 4)
                {
                    if (vm.Player4Input4)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                    }
                }
                else if (vm.Players.Count == 5)
                {
                    if (vm.Player4Input4)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input5 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player5Input4 = false;
                    }
                }
                else
                {
                    if (vm.Player4Input4)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input5 = false;
                        vm.Player4Input6 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player5Input4 = false;
                        vm.Player6Input4 = false;
                    }
                }
            }
        }
        private void Switch4_Toggled5(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player4Input5)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player5Input5 = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player4Input5)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input6 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player5Input5 = false;
                        vm.Player6Input5 = false;
                    }
                }
            }
        }
        private void Switch4_Toggled6(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player4Input6)
                    {
                        vm.Player4Input1 = false;
                        vm.Player4Input2 = false;
                        vm.Player4Input3 = false;
                        vm.Player4Input4 = false;
                        vm.Player4Input5 = false;

                        vm.Player1Input6 = false;
                        vm.Player2Input6 = false;
                        vm.Player3Input6 = false;
                        vm.Player5Input6 = false;
                        vm.Player6Input6 = false;
                    }
                }
            }
        }

        private void Switch5_Toggled1(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player5Input1)
                    {
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;


                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                    }
                }
                else
                {
                    if (vm.Player5Input1)
                    {
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;
                        vm.Player5Input6 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player6Input1 = false;
                    }
                }
            }
        }
        private void Switch5_Toggled2(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
               if (vm.Players.Count == 5)
                {
                    if (vm.Player5Input2)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                    }
                }
                else
                {
                    if (vm.Player5Input2)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;
                        vm.Player5Input6 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player6Input2 = false;
                    }
                }
            }
        }
        private void Switch5_Toggled3(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player5Input3)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                    }
                }
                else
                {
                    if (vm.Player5Input3)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;
                        vm.Player5Input6 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player6Input3 = false;
                    }
                }
            }
        }
        private void Switch5_Toggled4(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player5Input4)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input5 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                    }
                }
                else
                {
                    if (vm.Player5Input4)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input5 = false;
                        vm.Player5Input6 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player6Input4 = false;
                    }
                }
            }
        }
        private void Switch5_Toggled5(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 5)
                {
                    if (vm.Player5Input5)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                    }
                }
                else if (vm.Players.Count == 6)
                {
                    if (vm.Player5Input5)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input6 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player6Input5 = false;
                    }
                }
            }
        }
        private void Switch5_Toggled6(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player5Input6)
                    {
                        vm.Player5Input1 = false;
                        vm.Player5Input2 = false;
                        vm.Player5Input3 = false;
                        vm.Player5Input4 = false;
                        vm.Player5Input5 = false;

                        vm.Player1Input6 = false;
                        vm.Player2Input6 = false;
                        vm.Player3Input6 = false;
                        vm.Player4Input6 = false;
                        vm.Player6Input6 = false;
                    }
                }
            }
        }

        private void Switch6_Toggled1(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input1)
                    {
                        vm.Player6Input2 = false;
                        vm.Player6Input3 = false;
                        vm.Player6Input4 = false;
                        vm.Player6Input5 = false;
                        vm.Player6Input6 = false;

                        vm.Player1Input1 = false;
                        vm.Player2Input1 = false;
                        vm.Player3Input1 = false;
                        vm.Player4Input1 = false;
                        vm.Player5Input1 = false;
                    }
                }
            }
        }
        private void Switch6_Toggled2(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input2)
                    {
                        vm.Player6Input1 = false;
                        vm.Player6Input3 = false;
                        vm.Player6Input4 = false;
                        vm.Player6Input5 = false;
                        vm.Player6Input6 = false;

                        vm.Player1Input2 = false;
                        vm.Player2Input2 = false;
                        vm.Player3Input2 = false;
                        vm.Player4Input2 = false;
                        vm.Player5Input2 = false;
                    }
                }
            }
        }
        private void Switch6_Toggled3(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input3)
                    {
                        vm.Player6Input1 = false;
                        vm.Player6Input2 = false;
                        vm.Player6Input4 = false;
                        vm.Player6Input5 = false;
                        vm.Player6Input6 = false;

                        vm.Player1Input3 = false;
                        vm.Player2Input3 = false;
                        vm.Player3Input3 = false;
                        vm.Player4Input3 = false;
                        vm.Player5Input3 = false;
                    }
                }
            }
        }
        private void Switch6_Toggled4(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input4)
                    {
                        vm.Player6Input1 = false;
                        vm.Player6Input2 = false;
                        vm.Player6Input3 = false;
                        vm.Player6Input5 = false;
                        vm.Player6Input6 = false;

                        vm.Player1Input4 = false;
                        vm.Player2Input4 = false;
                        vm.Player3Input4 = false;
                        vm.Player4Input4 = false;
                        vm.Player5Input4 = false;
                    }
                }
            }
        }
        private void Switch6_Toggled5(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input5)
                    {
                        vm.Player6Input1 = false;
                        vm.Player6Input2 = false;
                        vm.Player6Input3 = false;
                        vm.Player6Input4 = false;
                        vm.Player6Input6 = false;

                        vm.Player1Input5 = false;
                        vm.Player2Input5 = false;
                        vm.Player3Input5 = false;
                        vm.Player4Input5 = false;
                        vm.Player5Input5 = false;
                    }
                }
            }
        }
        private void Switch6_Toggled6(object sender, ToggledEventArgs e)
        {
            if (BindingContext is RentzInputPageViewModel vm)
            {
                if (vm.Players.Count == 6)
                {
                    if (vm.Player6Input6)
                    {
                        vm.Player6Input1 = false;
                        vm.Player6Input2 = false;
                        vm.Player6Input3 = false;
                        vm.Player6Input4 = false;
                        vm.Player6Input5 = false;

                        vm.Player1Input6 = false;
                        vm.Player2Input6 = false;
                        vm.Player3Input6 = false;
                        vm.Player4Input6 = false;
                        vm.Player5Input6 = false;
                    }
                }
            }
        }
    }
}
