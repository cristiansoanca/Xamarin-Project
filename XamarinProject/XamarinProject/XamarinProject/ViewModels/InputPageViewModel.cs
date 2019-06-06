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
	public class InputPageViewModel : ViewModelBase
	{
        public bool Continue { get; set; }
        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }
        private int _queensScore;
        public int QueensScore {
            get
            {
                foreach (Player player in Players)
                {
                    if (player.Turn)
                    {
                        if (player.DoubleScore)
                        {
                            _queensScore = -25 * 2;
                        }
                        else
                        {
                            _queensScore = -25;
                        }
                    }
                }

                return _queensScore;
            }
        }
        private int _diamondsScore;
        public int DiamondsScore
        {
            get
            {
                foreach (Player player in Players)
                {
                    if (player.Turn)
                    {
                        if (player.DoubleScore)
                        {
                            _diamondsScore = -20 * 2;
                        }
                        else
                        {
                            _diamondsScore = -20;
                        }
                    }
                }

                return _diamondsScore;
            }
        }
        private int _whistScore;
        public int WhistScore
        {
            get
            {
                foreach (Player player in Players)
                {
                    if (player.Turn)
                    {
                        if (player.DoubleScore)
                        {
                            _whistScore = 10 * 2;
                        }
                        else
                        {
                            _whistScore = 10;
                        }
                    }
                }

                return _whistScore;
            }
        }
        private int _levateScore;
        public int LevateScore
        {
            get
            {
                foreach (Player player in Players)
                {
                    if (player.Turn)
                    {
                        if (player.DoubleScore)
                        {
                            _levateScore = -10 * 2;
                        }
                        else
                        {
                            _levateScore = -10;
                        }
                    }
                }

                return _levateScore;
            }
        }

        public ICommand SaveResultsClicked { get; set; }

        public InputPageViewModel(INavigationService navigationMethod, IPageDialogService dialogService, IEventAggregator eventAggregator)
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
            int sum = Player1Input + Player2Input + Player3Input + Player4Input + Player5Input + Player6Input;

            if (CurrentGame.Equals("Queens"))
            {
                if (sum == 4)
                {
                    Continue = true;
                    if (Players.Count == 4)
                    {
                        Players[0].Score = Player1Input * QueensScore;
                        Players[1].Score = Player2Input * QueensScore;
                        Players[2].Score = Player3Input * QueensScore;
                        Players[3].Score = Player4Input * QueensScore;

                        EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                    }
                    else if (Players.Count == 5)
                    {
                        Players[0].Score = Player1Input * QueensScore;
                        Players[1].Score = Player2Input * QueensScore;
                        Players[2].Score = Player3Input * QueensScore;
                        Players[3].Score = Player4Input * QueensScore;
                        Players[4].Score = Player5Input * QueensScore;

                        EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                    }
                    else
                    {
                        Players[0].Score = Player1Input * QueensScore;
                        Players[1].Score = Player2Input * QueensScore;
                        Players[2].Score = Player3Input * QueensScore;
                        Players[3].Score = Player4Input * QueensScore;
                        Players[4].Score = Player5Input * QueensScore;
                        Players[5].Score = Player6Input * QueensScore;

                        EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                    }

                } else
                {
                     await DialogService.DisplayAlertAsync("", "Queens game should have 4 queens", "OK");
                }
            } else if (CurrentGame.Equals("Diamonds"))
            {
                if (Players.Count == 4)
                {
                    if (sum == 8)
                    {
                        Continue = true;

                        Players[0].Score = Player1Input * DiamondsScore;
                        Players[1].Score = Player2Input * DiamondsScore;
                        Players[2].Score = Player3Input * DiamondsScore;
                        Players[3].Score = Player4Input * DiamondsScore;
                       
                        EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                    }
                    else
                    {
                        await DialogService.DisplayAlertAsync("", "Diamonds game should have 8 diamonds", "OK");
                    }
                } else if (Players.Count == 5)
                {
                    if (sum == 10)
                    {
                        Continue = true;
                        
                        Players[0].Score = Player1Input * DiamondsScore;
                        Players[1].Score = Player2Input * DiamondsScore;
                        Players[2].Score = Player3Input * DiamondsScore;
                        Players[3].Score = Player4Input * DiamondsScore;
                        Players[4].Score = Player5Input * DiamondsScore;

                        EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                    }
                    else
                    {
                        await DialogService.DisplayAlertAsync("", "Diamonds game should have 10 diamonds", "OK");
                    }
                } else
                {
                    if (sum == 12)
                    {
                        Continue = true;
                        
                        Players[0].Score = Player1Input * DiamondsScore;
                        Players[1].Score = Player2Input * DiamondsScore;
                        Players[2].Score = Player3Input * DiamondsScore;
                        Players[3].Score = Player4Input * DiamondsScore;
                        Players[4].Score = Player5Input * DiamondsScore;
                        Players[5].Score = Player6Input * DiamondsScore;
                        
                        EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                    }
                    else
                    {
                        await DialogService.DisplayAlertAsync("", "Diamonds game should have 12 diamonds", "OK");
                    }
                }
                
            } else if (CurrentGame.Equals("Whist"))
            {
                if (sum == 8)
                {
                    Continue = true;
                    if (Players.Count == 4)
                    {
                        Players[0].Score = Player1Input * WhistScore;
                        Players[1].Score = Player2Input * WhistScore;
                        Players[2].Score = Player3Input * WhistScore;
                        Players[3].Score = Player4Input * WhistScore;

                        EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                    }
                    else if (Players.Count == 5)
                    {
                        Players[0].Score = Player1Input * WhistScore;
                        Players[1].Score = Player2Input * WhistScore;
                        Players[2].Score = Player3Input * WhistScore;
                        Players[3].Score = Player4Input * WhistScore;
                        Players[4].Score = Player5Input * WhistScore;

                        EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                    }
                    else
                    {
                        Players[0].Score = Player1Input * WhistScore;
                        Players[1].Score = Player2Input * WhistScore;
                        Players[2].Score = Player3Input * WhistScore;
                        Players[3].Score = Player4Input * WhistScore;
                        Players[4].Score = Player5Input * WhistScore;
                        Players[5].Score = Player6Input * WhistScore;

                        EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                    }

                } else
                {
                    await DialogService.DisplayAlertAsync("", "Whist game should have 8 hands", "OK");
                }
            } else if (CurrentGame.Equals("Levate"))
            {
                if (sum == 8)
                {
                    Continue = true;
                    if (Players.Count == 4)
                    {
                        Players[0].Score = Player1Input * LevateScore;
                        Players[1].Score = Player2Input * LevateScore;
                        Players[2].Score = Player3Input * LevateScore;
                        Players[3].Score = Player4Input * LevateScore;

                        EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                    }
                    else if (Players.Count == 5)
                    {
                        Players[0].Score = Player1Input * LevateScore;
                        Players[1].Score = Player2Input * LevateScore;
                        Players[2].Score = Player3Input * LevateScore;
                        Players[3].Score = Player4Input * LevateScore;
                        Players[4].Score = Player5Input * LevateScore;

                        EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                    }
                    else
                    {
                        Players[0].Score = Player1Input * LevateScore;
                        Players[1].Score = Player2Input * LevateScore;
                        Players[2].Score = Player3Input * LevateScore;
                        Players[3].Score = Player4Input * LevateScore;
                        Players[4].Score = Player5Input * LevateScore;
                        Players[5].Score = Player6Input * LevateScore;

                        EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                    }

                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Levate game should have 8 hands", "OK");
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

        private int _player1Input;
        public int Player1Input
        {
            get { return _player1Input; }
            set { SetProperty(ref _player1Input, value); }
        }
        private int _player2Input;
        public int Player2Input
        {
            get { return _player2Input; }
            set { SetProperty(ref _player2Input, value); }
        }
        private int _player3Input;
        public int Player3Input
        {
            get { return _player3Input; }
            set { SetProperty(ref _player3Input, value); }
        }
        private int _player4Input;
        public int Player4Input
        {
            get { return _player4Input; }
            set { SetProperty(ref _player4Input, value); }
        }
        private int _player5Input;
        public int Player5Input
        {
            get { return _player5Input; }
            set { SetProperty(ref _player5Input, value); }
        }
        private int _player6Input;
        public int Player6Input
        {
            get { return _player6Input; }
            set { SetProperty(ref _player6Input, value); }
        }
    }
}
