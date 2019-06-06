using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinProject.ViewModels;

namespace XamarinProject.Views
{
    public partial class MainPage : ContentPage
    {
        private bool _back;
        public MainPage()
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