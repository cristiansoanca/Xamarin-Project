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

namespace XamarinProject.ViewModels
{
    public class SingleInputPageViewModel : ViewModelBase
    {
        public bool Continue { get; set; }
        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }
        private int _kingScore;
        public int KingScore
        {
            get
            {
                foreach (Player player in Players)
                {
                    if (player.Turn)
                    {
                        if (player.DoubleScore)
                        {
                            _kingScore = -100 * 2;
                        }
                        else
                        {
                            _kingScore = -100;
                        }
                    }
                }

                return _kingScore;
            }
        }
        private int _tenScore;
        public int TenScore
        {
            get
            {
                foreach (Player player in Players)
                {
                    if (player.Turn)
                    {
                        if (player.DoubleScore)
                        {
                            _tenScore = 100 * 2;
                        }
                        else
                        {
                            _tenScore = 100;
                        }
                    }
                }

                return _tenScore;
            }
        }

        public ICommand SaveResultsClicked { get; set; }

        public SingleInputPageViewModel(INavigationService navigationMethod, IPageDialogService dialogService, IEventAggregator eventAggregator)
            : base(navigationMethod, dialogService, eventAggregator)
        {
            SaveResultsClicked = new Command(SaveResultsButton_Clicked);

            eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(List<Player> players)
        {
            Players = players;

            foreach (Player player in Players)
            {
                if (player.Turn)
                {
                    CurrentGame = player.CurrentGame;
                }
            }

            Player1 = players[0].Name.ToUpper();
            Player2 = players[1].Name.ToUpper();
            Player3 = players[2].Name.ToUpper();
            Player4 = players[3].Name.ToUpper();

            if (players.Count == 5)
            {
                Player5 = players[4].Name.ToUpper();
                HiddenPlayer5 = true;
            }
            else if (players.Count == 6)
            {
                Player5 = players[4].Name.ToUpper();
                Player6 = players[5].Name.ToUpper();
                HiddenPlayer5 = true;
                HiddenPlayer6 = true;
            }
        }

        private async void SaveResultsButton_Clicked()
        {
            bool sum = Player1Input || Player2Input || Player3Input || Player4Input || Player5Input || Player6Input;

            if (CurrentGame.Equals("King"))
            {
                if (sum)
                {
                    Continue = true;

                    if (Players.Count == 4)
                    {
                        if (Player1Input)
                        {
                            Players[0].Score = KingScore;
                        }
                        else if (Player2Input)
                        {
                            Players[1].Score = KingScore;
                        }
                        else if (Player3Input)
                        {
                            Players[2].Score = KingScore;
                        }
                        else if (Player4Input)
                        {
                            Players[3].Score = KingScore;
                        }

                        EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                    }
                    else if (Players.Count == 5)
                    {
                        if (Player1Input)
                        {
                            Players[0].Score = KingScore;
                        }
                        else if (Player2Input)
                        {
                            Players[1].Score = KingScore;
                        }
                        else if (Player3Input)
                        {
                            Players[2].Score = KingScore;
                        }
                        else if (Player4Input)
                        {
                            Players[3].Score = KingScore;
                        }
                        else if (Player5Input)
                        {
                            Players[4].Score = KingScore;
                        }

                        EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                    }
                    else
                    {
                        if (Player1Input)
                        {
                            Players[0].Score = KingScore;
                        }
                        else if (Player2Input)
                        {
                            Players[1].Score = KingScore;
                        }
                        else if (Player3Input)
                        {
                            Players[2].Score = KingScore;
                        }
                        else if (Player4Input)
                        {
                            Players[3].Score = KingScore;
                        }
                        else if (Player5Input)
                        {
                            Players[4].Score = KingScore;
                        }
                        else if (Player6Input)
                        {
                            Players[5].Score = KingScore;
                        }

                        EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                    }
                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Select one player for the King Of Hearts game", "OK");
                }
            }
            else if (CurrentGame.Equals("Ten"))
            {
                if (sum)
                {
                    Continue = true;

                    if (Players.Count == 4)
                    {
                        if (Player1Input)
                        {
                            Players[0].Score = TenScore;
                        }
                        else if (Player2Input)
                        {
                            Players[1].Score = TenScore;
                        }
                        else if (Player3Input)
                        {
                            Players[2].Score = TenScore;
                        }
                        else if (Player4Input)
                        {
                            Players[3].Score = TenScore;
                        }

                        EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                    }
                    else if (Players.Count == 5)
                    {
                        if (Player1Input)
                        {
                            Players[0].Score = TenScore;
                        }
                        else if (Player2Input)
                        {
                            Players[1].Score = TenScore;
                        }
                        else if (Player3Input)
                        {
                            Players[2].Score = TenScore;
                        }
                        else if (Player4Input)
                        {
                            Players[3].Score = TenScore;
                        }
                        else if (Player5Input)
                        {
                            Players[4].Score = TenScore;
                        }

                        EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                    }
                    else
                    {
                        if (Player1Input)
                        {
                            Players[0].Score = TenScore;
                        }
                        else if (Player2Input)
                        {
                            Players[1].Score = TenScore;
                        }
                        else if (Player3Input)
                        {
                            Players[2].Score = TenScore;
                        }
                        else if (Player4Input)
                        {
                            Players[3].Score = TenScore;
                        }
                        else if (Player5Input)
                        {
                            Players[4].Score = TenScore;
                        }
                        else if (Player6Input)
                        {
                            Players[5].Score = TenScore;
                        }

                        EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                    }
                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Select one player for the Ten Of Clubs game", "OK");
                }
            }
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
        private bool _hiddenPlayer5;
        public bool HiddenPlayer5
        {
            get { return _hiddenPlayer5; }
            set { SetProperty(ref _hiddenPlayer5, value); }
        }
        private bool _hiddenPlayer6;
        public bool HiddenPlayer6
        {
            get { return _hiddenPlayer6; }
            set { SetProperty(ref _hiddenPlayer6, value); }
        }

        private string _currentGame;
        public string CurrentGame
        {
            get { return _currentGame; }
            set { SetProperty(ref _currentGame, value); }
        }
        private bool _player1Input;
        public bool Player1Input
        {
            get { return _player1Input; }
            set { SetProperty(ref _player1Input, value); }
        }
        private bool _player2Input;
        public bool Player2Input
        {
            get { return _player2Input; }
            set { SetProperty(ref _player2Input, value); }
        }
        private bool _player3Input;
        public bool Player3Input
        {
            get { return _player3Input; }
            set { SetProperty(ref _player3Input, value); }
        }
        private bool _player4Input;
        public bool Player4Input
        {
            get { return _player4Input; }
            set { SetProperty(ref _player4Input, value); }
        }
        private bool _player5Input;
        public bool Player5Input
        {
            get { return _player5Input; }
            set { SetProperty(ref _player5Input, value); }
        }
        private bool _player6Input;
        public bool Player6Input
        {
            get { return _player6Input; }
            set { SetProperty(ref _player6Input, value); }
        }
    }
}
