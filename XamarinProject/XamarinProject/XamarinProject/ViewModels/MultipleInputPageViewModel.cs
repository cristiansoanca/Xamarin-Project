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
    public class MultipleInputPageViewModel : ViewModelBase
    {
        public bool Continue { get; set; }
        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }
        private int _queensScore;
        public int QueensScore
        {
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

        public ICommand SaveResultsClicked { get; set; }

        public MultipleInputPageViewModel(INavigationService navigationMethod, IPageDialogService dialogService, IEventAggregator eventAggregator)
            : base(navigationMethod, dialogService, eventAggregator)
        {
            SaveResultsClicked = new Command(SaveResultsButton_Clicked);

            eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        public bool Continue_King { get; set; }
        public bool Continue_Queens { get; set; }
        public bool Continue_Diamonds { get; set; }
        public bool Continue_Levate { get; set; }



        private async void SaveResultsButton_Clicked()
        {
            bool sum = Player1Input || Player2Input || Player3Input || Player4Input || Player5Input || Player6Input;
            int qSum = Player1QInput + Player2QInput + Player3QInput + Player4QInput + Player5QInput + Player6QInput;
            int dSum = Player1DInput + Player2DInput + Player3DInput + Player4DInput + Player5DInput + Player6DInput;
            int lSum = Player1LInput + Player2LInput + Player3LInput + Player4LInput + Player5LInput + Player6LInput;

            if (sum)
            {
                Continue_King = true;

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
                }

            }
            else
            {
                await DialogService.DisplayAlertAsync("", "Select one player for the King Of Hearts game", "OK");
            }

            if (qSum == 4)
            {
                Continue_Queens = true;

                if (Players.Count == 4)
                {
                    Players[0].Score = Player1QInput * QueensScore;
                    Players[1].Score = Player2QInput * QueensScore;
                    Players[2].Score = Player3QInput * QueensScore;
                    Players[3].Score = Player4QInput * QueensScore;
                }
                else if (Players.Count == 5)
                {
                    Players[0].Score = Player1QInput * QueensScore;
                    Players[1].Score = Player2QInput * QueensScore;
                    Players[2].Score = Player3QInput * QueensScore;
                    Players[3].Score = Player4QInput * QueensScore;
                    Players[4].Score = Player5QInput * QueensScore;
                }
                else
                {
                    Players[0].Score = Player1QInput * QueensScore;
                    Players[1].Score = Player2QInput * QueensScore;
                    Players[2].Score = Player3QInput * QueensScore;
                    Players[3].Score = Player4QInput * QueensScore;
                    Players[4].Score = Player5QInput * QueensScore;
                    Players[5].Score = Player6QInput * QueensScore;
                }

            }
            else
            {
                await DialogService.DisplayAlertAsync("", "Queens game should have 4 queens", "OK");
            }

            if (Players.Count == 4)
            {
                if (dSum == 8)
                {
                    Continue_Diamonds = true;

                    Players[0].Score = Player1DInput * DiamondsScore;
                    Players[1].Score = Player2DInput * DiamondsScore;
                    Players[2].Score = Player3DInput * DiamondsScore;
                    Players[3].Score = Player4DInput * DiamondsScore;

                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Diamonds game should have 8 diamonds", "OK");
                }
            }
            else if (Players.Count == 5)
            {
                if (dSum == 10)
                {
                    Continue_Diamonds = true;

                    Players[0].Score = Player1DInput * DiamondsScore;
                    Players[1].Score = Player2DInput * DiamondsScore;
                    Players[2].Score = Player3DInput * DiamondsScore;
                    Players[3].Score = Player4DInput * DiamondsScore;
                    Players[4].Score = Player5DInput * DiamondsScore;
  
                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Diamonds game should have 10 diamonds", "OK");
                }
            }
            else
            {
                if (dSum == 12)
                {
                    Continue_Diamonds = true;
                    
                    Players[0].Score = Player1DInput * DiamondsScore;
                    Players[1].Score = Player2DInput * DiamondsScore;
                    Players[2].Score = Player3DInput * DiamondsScore;
                    Players[3].Score = Player4DInput * DiamondsScore;
                    Players[4].Score = Player5DInput * DiamondsScore;
                    Players[5].Score = Player6DInput * DiamondsScore;

                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Diamonds game should have 12 diamonds", "OK");
                }
            }

            if (lSum == 8)
            {
                Continue_Levate = true;

                if (Players.Count == 4)
                {
                    Players[0].Score = Player1LInput * LevateScore;
                    Players[1].Score = Player2LInput * LevateScore;
                    Players[2].Score = Player3LInput * LevateScore;
                    Players[3].Score = Player4LInput * LevateScore;
                }
                else if (Players.Count == 5)
                {
                    Players[0].Score = Player1LInput * LevateScore;
                    Players[1].Score = Player2LInput * LevateScore;
                    Players[2].Score = Player3LInput * LevateScore;
                    Players[3].Score = Player4LInput * LevateScore;
                    Players[4].Score = Player5LInput * LevateScore;
                }
                else
                {
                    Players[0].Score = Player1LInput * LevateScore;
                    Players[1].Score = Player2LInput * LevateScore;
                    Players[2].Score = Player3LInput * LevateScore;
                    Players[3].Score = Player4LInput * LevateScore;
                    Players[4].Score = Player5LInput * LevateScore;
                    Players[5].Score = Player6LInput * LevateScore;
                }

            }
            else
            {
                await DialogService.DisplayAlertAsync("", "Levate game should have 8 hands", "OK");
            }

            if (Continue_King && Continue_Queens && Continue_Diamonds && Continue_Levate)
            {
                Continue = true;

                if (Players.Count == 4)
                {
                    EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                }
                else if (Players.Count == 5)
                {
                    EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                }
                else
                {
                    EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                }
            }

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
        private int _player1QInput;
        public int Player1QInput
        {
            get { return _player1QInput; }
            set { SetProperty(ref _player1QInput, value); }
        }
        private int _player1DInput;
        public int Player1DInput
        {
            get { return _player1DInput; }
            set { SetProperty(ref _player1DInput, value); }
        }
        private int _player1LInput;
        public int Player1LInput
        {
            get { return _player1LInput; }
            set { SetProperty(ref _player1LInput, value); }
        }


        private bool _player2Input;
        public bool Player2Input
        {
            get { return _player2Input; }
            set { SetProperty(ref _player2Input, value); }
        }
        private int _player2QInput;
        public int Player2QInput
        {
            get { return _player2QInput; }
            set { SetProperty(ref _player2QInput, value); }
        }
        private int _player2DInput;
        public int Player2DInput
        {
            get { return _player2DInput; }
            set { SetProperty(ref _player2DInput, value); }
        }
        private int _player2LInput;
        public int Player2LInput
        {
            get { return _player2LInput; }
            set { SetProperty(ref _player2LInput, value); }
        }


        private bool _player3Input;
        public bool Player3Input
        {
            get { return _player3Input; }
            set { SetProperty(ref _player3Input, value); }
        }
        private int _player3QInput;
        public int Player3QInput
        {
            get { return _player3QInput; }
            set { SetProperty(ref _player3QInput, value); }
        }
        private int _player3DInput;
        public int Player3DInput
        {
            get { return _player3DInput; }
            set { SetProperty(ref _player3DInput, value); }
        }
        private int _player3LInput;
        public int Player3LInput
        {
            get { return _player3LInput; }
            set { SetProperty(ref _player3LInput, value); }
        }


        private bool _player4Input;
        public bool Player4Input
        {
            get { return _player4Input; }
            set { SetProperty(ref _player4Input, value); }
        }
        private int _player4QInput;
        public int Player4QInput
        {
            get { return _player4QInput; }
            set { SetProperty(ref _player4QInput, value); }
        }
        private int _player4DInput;
        public int Player4DInput
        {
            get { return _player4DInput; }
            set { SetProperty(ref _player4DInput, value); }
        }
        private int _player4LInput;
        public int Player4LInput
        {
            get { return _player4LInput; }
            set { SetProperty(ref _player4LInput, value); }
        }



        private bool _player5Input;
        public bool Player5Input
        {
            get { return _player5Input; }
            set { SetProperty(ref _player5Input, value); }
        }
        private int _player5QInput;
        public int Player5QInput
        {
            get { return _player5QInput; }
            set { SetProperty(ref _player5QInput, value); }
        }
        private int _player5DInput;
        public int Player5DInput
        {
            get { return _player5DInput; }
            set { SetProperty(ref _player5DInput, value); }
        }
        private int _player5LInput;
        public int Player5LInput
        {
            get { return _player5LInput; }
            set { SetProperty(ref _player5LInput, value); }
        }



        private bool _player6Input;
        public bool Player6Input
        {
            get { return _player6Input; }
            set { SetProperty(ref _player6Input, value); }
        }
        private int _player6QInput;
        public int Player6QInput
        {
            get { return _player6QInput; }
            set { SetProperty(ref _player6QInput, value); }
        }
        private int _player6DInput;
        public int Player6DInput
        {
            get { return _player6DInput; }
            set { SetProperty(ref _player6DInput, value); }
        }
        private int _player6LInput;
        public int Player6LInput
        {
            get { return _player6LInput; }
            set { SetProperty(ref _player6LInput, value); }
        }
    }
}
