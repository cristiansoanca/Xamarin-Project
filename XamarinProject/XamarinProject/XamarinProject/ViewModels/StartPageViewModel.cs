using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinProject.Utils;
using XamarinProject.Views;

namespace XamarinProject.ViewModels
{
    public class StartPageViewModel : ViewModelBase
    {
        private int _currentSelectedIndex;
        public int CurrentSelectedIndex
        {
            get { return _currentSelectedIndex; }
            set { SetProperty(ref _currentSelectedIndex, value); }
        }

        private string _player1;
        public string Player1
        {
            get { return _player1; }
            set { SetProperty(ref _player1, value); }
        }
        private string _player2;
        public string Player2
        {
            get { return _player2; }
            set { SetProperty(ref _player2, value); }
        }
        private string _player3;
        public string Player3
        {
            get { return _player3; }
            set { SetProperty(ref _player3, value); }
        }
        private string _player4;
        public string Player4
        {
            get { return _player4; }
            set { SetProperty(ref _player4, value); }
        }
        private string _player5;
        public string Player5
        {
            get { return _player5; }
            set { SetProperty(ref _player5, value); }
        }
        private string _player6;
        public string Player6
        {
            get { return _player6; }
            set { SetProperty(ref _player6, value); }
        }

        private bool _hiddenPlayer5 = false;
        public bool HiddenPlayer5
        {
            get { return _hiddenPlayer5; }
            set { SetProperty(ref _hiddenPlayer5, value); }
        }

        private bool _hiddenPlayer6 = false;
        public bool HiddenPlayer6
        {
            get { return _hiddenPlayer6; }
            set { SetProperty(ref _hiddenPlayer6, value); }
        }

        public ICommand StartClicked { get; set; }

        public StartPageViewModel(INavigationService navigationMethod, IPageDialogService dialogService, IEventAggregator eventAgreggator)
            : base(navigationMethod, dialogService, eventAgreggator)
        {
            _currentSelectedIndex = 0;

            StartClicked = new Command(Button_Clicked);
        }

        private async void Button_Clicked()
        {
            if (CurrentSelectedIndex == 0)
            {
                if (string.IsNullOrWhiteSpace(Player1))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 1", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player2))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 2", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player3))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 3", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player4))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 4", "OK");
                    return;
                }

            } else if (CurrentSelectedIndex == 1)
            {
                if (string.IsNullOrWhiteSpace(Player1))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 1", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player2))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 2", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player3))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 3", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player4))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 4", "OK");
                    return;
                } else if (string.IsNullOrWhiteSpace(Player5))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 5", "OK");
                    return;
                }
            } else
            {
                if (string.IsNullOrWhiteSpace(Player1))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 1", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player2))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 2", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player3))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 3", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player4))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 4", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player5))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 5", "OK");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(Player6))
                {
                    await DialogService.DisplayAlertAsync("", "Please insert player 6", "OK");
                    return;
                }
            }

            List<Player> players = new List<Player>();

            if (CurrentSelectedIndex == 0)
            {
                await NavigationMethod.NavigateAsync(nameof(MainPage));
            
                players.Add(new Player(Player1.ToString()));
                players.Add(new Player(Player2.ToString()));
                players.Add(new Player(Player3.ToString()));
                players.Add(new Player(Player4.ToString()));

                EventAggregator.GetEvent<MessageSentEvent>().Publish(players);
            } else if (CurrentSelectedIndex == 1)
            {
                await NavigationMethod.NavigateAsync(nameof(MainPageWith5Players));

                players.Add(new Player(Player1.ToString()));
                players.Add(new Player(Player2.ToString()));
                players.Add(new Player(Player3.ToString()));
                players.Add(new Player(Player4.ToString()));
                players.Add(new Player(Player5.ToString()));

                EventAggregator.GetEvent<MessageSentEvent5Players>().Publish(players);
            } else
            {
                await NavigationMethod.NavigateAsync(nameof(MainPageWith6Players));

                players.Add(new Player(Player1.ToString()));
                players.Add(new Player(Player2.ToString()));
                players.Add(new Player(Player3.ToString()));
                players.Add(new Player(Player4.ToString()));
                players.Add(new Player(Player5.ToString()));
                players.Add(new Player(Player6.ToString()));

                EventAggregator.GetEvent<MessageSentEvent6Players>().Publish(players);
            }

        }

    }
}
