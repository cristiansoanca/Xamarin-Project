using System;
using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class MainPageWith6Players : ContentPage
    {
        private bool _back;
        public MainPageWith6Players()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override bool OnBackButtonPressed()
        {

            Device.BeginInvokeOnMainThread(new Action(async () =>
            {
                if (await DisplayAlert("", "Are you sure want to exit?", "Yes", "No"))
                {
                    _back = true;
                    await Navigation.PopAsync();
                }
            }));

            return true;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Send(this, "allowLandScapePortrait");
        }

        //during page close setting back to portrait
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (_back)
            {
                MessagingCenter.Send(this, "preventLandScape");
                _back = false;
            }
        }
    }
}
