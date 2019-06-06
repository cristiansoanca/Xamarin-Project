using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinProject.Utils;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class ChooseGamePage : ContentPage
    {
        private bool _flag;

        public ChooseGamePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void DoubleButton_Clicked(object sender, System.EventArgs e)
        {
            if (!_flag)
            {
                doubleButton.Text = "Double On";
                doubleButton.BackgroundColor = Color.DarkGray;
                _flag = true;
            }
            else
            {
                doubleButton.Text = "Double Off";
                doubleButton.BackgroundColor = Color.White;
                _flag = false;
            }
        }
        private async void RentzButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    if (!_flag)
                    {

                        var vm = BindingContext as ChooseGamePageViewModel;
                        await vm.NavigationService.NavigateAsync(nameof(RentzInputPage));

                        foreach (Player player in vm.Players)
                        {
                            if (player.Turn)
                            {
                                player.CurrentGame = "Rentz";
                                player.AvailableGames.Remove("Rentz");
                                player.RentzView = false;
                            }
                        }

                        vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                    } else
                    {
                        await DisplayAlert("", "The Rentz game cannot be doubled", "OK");

                        doubleButton.Text = "Double Off";
                        doubleButton.BackgroundColor = Color.White;
                        _flag = false;
                    }

                }
            }));

            await Task.Delay(0);
        }

        private async void TotaleButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(MultipleInputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "Totale";
                            player.AvailableGames.Remove("Totale");
                            player.TotaleView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                }
            }));

            await Task.Delay(0);
        }

        private async void KingOfHeartsButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(SingleInputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "King";
                            player.AvailableGames.Remove("King");
                            player.KingView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                }
            }));

            await Task.Delay(0);
        }

        private async void TenOfClubsButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(SingleInputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "Ten";
                            player.AvailableGames.Remove("Ten");
                            player.TenView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                }
            }));

            await Task.Delay(0);
        }
        private async void QueensButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(InputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "Queens";
                            player.AvailableGames.Remove("Queens");
                            player.QueensView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players); ;
                }
            }));

            await Task.Delay(0);
        }

        private async void WhistButton_Clicked(object sender, System.EventArgs e)
        {

            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(InputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "Whist";
                            player.AvailableGames.Remove("Whist");
                            player.WhistView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                }
            }));

            await Task.Delay(0);
        }
        private async void DiamondsButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(InputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "Diamonds";
                            player.AvailableGames.Remove("Diamonds");
                            player.DiamondsView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                }
            }));

            await Task.Delay(0);
        }
        private async void LevateButton_Clicked(object sender, System.EventArgs e)
        {
            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to continue?", "Yes", "No"))
                {
                    var vm = BindingContext as ChooseGamePageViewModel;
                    await vm.NavigationService.NavigateAsync(nameof(InputPage));

                    foreach (Player player in vm.Players)
                    {
                        if (player.Turn)
                        {
                            player.CurrentGame = "Levate";
                            player.AvailableGames.Remove("Levate");
                            player.LevateView = false;
                        }
                    }

                    vm.EventAggregatorr.GetEvent<MessageSentEvent>().Publish(vm.Players);
                }
            }));

            await Task.Delay(0);
        }

    }
}
