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
    public class RentzInputPageViewModel : ViewModelBase
    {
        public bool Continue { get; set; }
        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }
        public ICommand SaveResultsClicked { get; set; }

        private int _firstPlaceScore;
        public int FirstPlaceScore
        {
            get
            {
                if (Players.Count == 4)
                {
                    _firstPlaceScore = 300;

                }
                else if (Players.Count == 5)
                {
                    _firstPlaceScore = 400;

                }
                else
                {
                    _firstPlaceScore = 500;
                }


                return _firstPlaceScore;
            }
        }

        private int _secondPlaceScore;
        public int SecondPlaceScore
        {
            get
            {
                if (Players.Count == 4)
                {
                    _secondPlaceScore = 200;

                }
                else if (Players.Count == 5)
                {
                    _secondPlaceScore = 300;

                }
                else
                {
                    _secondPlaceScore = 400;
                }

                return _secondPlaceScore;
            }
        }
        private int _thirdPlaceScore;
        public int ThirdPlaceScore
        {
            get
            {
                if (Players.Count == 4)
                {
                    _thirdPlaceScore = 100;

                }
                else if (Players.Count == 5)
                {
                    _thirdPlaceScore = 200;

                }
                else
                {
                    _thirdPlaceScore = 300;
                }

                return _thirdPlaceScore;
            }
        }
        private int _fourthPlaceScore;
        public int FourthPlaceScore
        {
            get
            {
                if (Players.Count == 4)
                {
                    _fourthPlaceScore = 0;

                }
                else if (Players.Count == 5)
                {
                    _fourthPlaceScore = 100;

                }
                else
                {
                    _fourthPlaceScore = 200;
                }

                return _fourthPlaceScore;
            }
        }
        private int _fifthPlaceScore;
        public int FiftPhlaceScore
        {
            get
            {
                if (Players.Count == 5)
                {
                    _fifthPlaceScore = 0;

                }
                else
                {
                    _fifthPlaceScore = 100;
                }

                return _fifthPlaceScore;
            }
        }
        private int _sixthPlaceScore = 0;
        public int SixthPlaceScore
        {
            get
            {
                return _sixthPlaceScore;
            }
        }


        public RentzInputPageViewModel(INavigationService navigationMethod, IPageDialogService dialogService, IEventAggregator eventAggregator)
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
            bool sum1 = Player1Input1 || Player2Input1 || Player3Input1 || Player4Input1 || Player5Input1 || Player6Input1;
            bool sum2 = Player1Input2 || Player2Input2 || Player3Input2 || Player4Input2 || Player5Input2 || Player6Input2;
            bool sum3 = Player1Input3 || Player2Input3 || Player3Input3 || Player4Input3 || Player5Input3 || Player6Input3;
            bool sum4 = Player1Input4 || Player2Input4 || Player3Input4 || Player4Input4 || Player5Input4 || Player6Input4;
            bool sum5 = Player1Input5 || Player2Input5 || Player3Input5 || Player4Input5 || Player5Input5 || Player6Input5;
            bool sum6 = Player1Input6 || Player2Input6 || Player3Input6 || Player4Input6 || Player5Input6 || Player6Input6;

       
                    
        

            if (Players.Count == 4)
            {
                if (sum1 && sum2 && sum3 && sum4)
                {
                    if (Player1Input1)
                    {
                        Players[0].Score = FirstPlaceScore;
                    }
                    else if (Player1Input2)
                    {
                        Players[0].Score = SecondPlaceScore;
                    }
                    else if (Player1Input3)
                    {
                        Players[0].Score = ThirdPlaceScore;
                    }
                    else if (Player1Input4)
                    {
                        Players[0].Score = FourthPlaceScore;
                    }
                    if (Player2Input1)
                    {
                        Players[1].Score = FirstPlaceScore;
                    }
                    else if (Player2Input2)
                    {
                        Players[1].Score = SecondPlaceScore;
                    }
                    else if (Player2Input3)
                    {
                        Players[1].Score = ThirdPlaceScore;
                    }
                    else if (Player2Input4)
                    {
                        Players[1].Score = FourthPlaceScore;
                    }

                    if (Player3Input1)
                    {
                        Players[2].Score = FirstPlaceScore;
                    }
                    else if (Player3Input2)
                    {
                        Players[2].Score = SecondPlaceScore;
                    }
                    else if (Player3Input3)
                    {
                        Players[2].Score = ThirdPlaceScore;
                    }
                    else if (Player3Input4)
                    {
                        Players[2].Score = FourthPlaceScore;
                    }

                    if (Player4Input1)
                    {
                        Players[3].Score = FirstPlaceScore;
                    }
                    else if (Player4Input2)
                    {
                        Players[3].Score = SecondPlaceScore;
                    }
                    else if (Player4Input3)
                    {
                        Players[3].Score = ThirdPlaceScore;
                    }
                    else if (Player4Input4)
                    {
                        Players[3].Score = FourthPlaceScore;
                    }




                    Continue = true;
                    EventAggregator.GetEvent<ScoreSentEvent>().Publish(Players);
                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Place a position for each player in the Rentz game", "OK");
                }
            }
            else if (Players.Count == 5)
            {
                if (sum1 && sum2 && sum3 && sum4 && sum5)
                {
                    if (Player1Input1)
                    {
                        Players[0].Score = FirstPlaceScore;
                    }
                    else if (Player1Input2)
                    {
                        Players[0].Score = SecondPlaceScore;
                    }
                    else if (Player1Input3)
                    {
                        Players[0].Score = ThirdPlaceScore;
                    }
                    else if (Player1Input4)
                    {
                        Players[0].Score = FourthPlaceScore;
                    }
                    else if (Player1Input5)
                    {
                        Players[0].Score = FiftPhlaceScore;
                    }

                    if (Player2Input1)
                    {
                        Players[1].Score = FirstPlaceScore;
                    }
                    else if (Player2Input2)
                    {
                        Players[1].Score = SecondPlaceScore;
                    }
                    else if (Player2Input3)
                    {
                        Players[1].Score = ThirdPlaceScore;
                    }
                    else if (Player2Input4)
                    {
                        Players[1].Score = FourthPlaceScore;
                    }
                    else if (Player2Input5)
                    {
                        Players[1].Score = FiftPhlaceScore;
                    }

                    if (Player3Input1)
                    {
                        Players[2].Score = FirstPlaceScore;
                    }
                    else if (Player3Input2)
                    {
                        Players[2].Score = SecondPlaceScore;
                    }
                    else if (Player3Input3)
                    {
                        Players[2].Score = ThirdPlaceScore;
                    }
                    else if (Player3Input4)
                    {
                        Players[2].Score = FourthPlaceScore;
                    }
                    else if (Player3Input5)
                    {
                        Players[2].Score = FiftPhlaceScore;
                    }

                    if (Player4Input1)
                    {
                        Players[3].Score = FirstPlaceScore;
                    }
                    else if (Player4Input2)
                    {
                        Players[3].Score = SecondPlaceScore;
                    }
                    else if (Player4Input3)
                    {
                        Players[3].Score = ThirdPlaceScore;
                    }
                    else if (Player4Input4)
                    {
                        Players[3].Score = FourthPlaceScore;
                    }
                    else if (Player4Input5)
                    {
                        Players[3].Score = FiftPhlaceScore;
                    }

                    if (Player5Input1)
                    {
                        Players[4].Score = FirstPlaceScore;
                    }
                    else if (Player5Input2)
                    {
                        Players[4].Score = SecondPlaceScore;
                    }
                    else if (Player5Input3)
                    {
                        Players[4].Score = ThirdPlaceScore;
                    }
                    else if (Player5Input4)
                    {
                        Players[4].Score = FourthPlaceScore;
                    }
                    else if (Player5Input5)
                    {
                        Players[4].Score = FiftPhlaceScore;
                    }


                    Continue = true;
                    EventAggregator.GetEvent<ScoreSentEvent5Players>().Publish(Players);
                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Place a position for each player in the Rentz game", "OK");
                }
            }
            else
            {
                if (sum1 && sum2 && sum3 && sum4 && sum5 && sum6)
                {
                    if (Player1Input1)
                    {
                        Players[0].Score = FirstPlaceScore;
                    }
                    else if (Player1Input2)
                    {
                        Players[0].Score = SecondPlaceScore;
                    }
                    else if (Player1Input3)
                    {
                        Players[0].Score = ThirdPlaceScore;
                    }
                    else if (Player1Input4)
                    {
                        Players[0].Score = FourthPlaceScore;
                    }
                    else if (Player1Input5)
                    {
                        Players[0].Score = FiftPhlaceScore;
                    } else if (Player1Input6)
                    {
                        Players[0].Score = SixthPlaceScore;
                    }

                    if (Player2Input1)
                    {
                        Players[1].Score = FirstPlaceScore;
                    }
                    else if (Player2Input2)
                    {
                        Players[1].Score = SecondPlaceScore;
                    }
                    else if (Player2Input3)
                    {
                        Players[1].Score = ThirdPlaceScore;
                    }
                    else if (Player2Input4)
                    {
                        Players[1].Score = FourthPlaceScore;
                    }
                    else if (Player2Input5)
                    {
                        Players[1].Score = FiftPhlaceScore;
                    }
                    else if (Player2Input6)
                    {
                        Players[1].Score = SixthPlaceScore;
                    }

                    if (Player3Input1)
                    {
                        Players[2].Score = FirstPlaceScore;
                    }
                    else if (Player3Input2)
                    {
                        Players[2].Score = SecondPlaceScore;
                    }
                    else if (Player3Input3)
                    {
                        Players[2].Score = ThirdPlaceScore;
                    }
                    else if (Player3Input4)
                    {
                        Players[2].Score = FourthPlaceScore;
                    }
                    else if (Player3Input5)
                    {
                        Players[2].Score = FiftPhlaceScore;
                    }
                    else if (Player3Input6)
                    {
                        Players[2].Score = SixthPlaceScore;
                    }

                    if (Player4Input1)
                    {
                        Players[3].Score = FirstPlaceScore;
                    }
                    else if (Player4Input2)
                    {
                        Players[3].Score = SecondPlaceScore;
                    }
                    else if (Player4Input3)
                    {
                        Players[3].Score = ThirdPlaceScore;
                    }
                    else if (Player4Input4)
                    {
                        Players[3].Score = FourthPlaceScore;
                    }
                    else if (Player4Input5)
                    {
                        Players[3].Score = FiftPhlaceScore;
                    }
                    else if (Player4Input6)
                    {
                        Players[3].Score = SixthPlaceScore;
                    }

                    if (Player5Input1)
                    {
                        Players[4].Score = FirstPlaceScore;
                    }
                    else if (Player5Input2)
                    {
                        Players[4].Score = SecondPlaceScore;
                    }
                    else if (Player5Input3)
                    {
                        Players[4].Score = ThirdPlaceScore;
                    }
                    else if (Player5Input4)
                    {
                        Players[4].Score = FourthPlaceScore;
                    }
                    else if (Player5Input5)
                    {
                        Players[4].Score = FiftPhlaceScore;
                    }
                    else if (Player5Input6)
                    {
                        Players[4].Score = SixthPlaceScore;
                    }

                    if (Player6Input1)
                    {
                        Players[5].Score = FirstPlaceScore;
                    }
                    else if (Player6Input2)
                    {
                        Players[5].Score = SecondPlaceScore;
                    }
                    else if (Player6Input3)
                    {
                        Players[5].Score = ThirdPlaceScore;
                    }
                    else if (Player6Input4)
                    {
                        Players[5].Score = FourthPlaceScore;
                    }
                    else if (Player6Input5)
                    {
                        Players[5].Score = FiftPhlaceScore;
                    }
                    else if (Player6Input6)
                    {
                        Players[5].Score = SixthPlaceScore;
                    }

                    Continue = true;
                    EventAggregator.GetEvent<ScoreSentEvent6Players>().Publish(Players);
                }
                else
                {
                    await DialogService.DisplayAlertAsync("", "Place a position for each player in the Rentz game", "OK");
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



        private bool _player1Input1;
        public bool Player1Input1
        {
            get { return _player1Input1; }
            set { SetProperty(ref _player1Input1, value); }
        }
        private bool _player1Input2;
        public bool Player1Input2
        {
            get { return _player1Input2; }
            set { SetProperty(ref _player1Input2, value); }
        }
        private bool _player1Input3;
        public bool Player1Input3
        {
            get { return _player1Input3; }
            set { SetProperty(ref _player1Input3, value); }
        }
        private bool _player1Input4;
        public bool Player1Input4
        {
            get { return _player1Input4; }
            set { SetProperty(ref _player1Input4, value); }
        }
        private bool _player1Input5;
        public bool Player1Input5
        {
            get { return _player1Input5; }
            set { SetProperty(ref _player1Input5, value); }
        }
        private bool _player1Input6;
        public bool Player1Input6
        {
            get { return _player1Input6; }
            set { SetProperty(ref _player1Input6, value); }
        }




        private bool _player2Input1;
        public bool Player2Input1
        {
            get { return _player2Input1; }
            set { SetProperty(ref _player2Input1, value); }
        }
        private bool _player2Input2;
        public bool Player2Input2
        {
            get { return _player2Input2; }
            set { SetProperty(ref _player2Input2, value); }
        }
        private bool _player2Input3;
        public bool Player2Input3
        {
            get { return _player2Input3; }
            set { SetProperty(ref _player2Input3, value); }
        }
        private bool _player2Input4;
        public bool Player2Input4
        {
            get { return _player2Input4; }
            set { SetProperty(ref _player2Input4, value); }
        }
        private bool _player2Input5;
        public bool Player2Input5
        {
            get { return _player2Input5; }
            set { SetProperty(ref _player2Input5, value); }
        }
        private bool _player2Input6;
        public bool Player2Input6
        {
            get { return _player2Input6; }
            set { SetProperty(ref _player2Input6, value); }
        }


        private bool _player3Input1;
        public bool Player3Input1
        {
            get { return _player3Input1; }
            set { SetProperty(ref _player3Input1, value); }
        }
        private bool _player3Input2;
        public bool Player3Input2
        {
            get { return _player3Input2; }
            set { SetProperty(ref _player3Input2, value); }
        }
        private bool _player3Input3;
        public bool Player3Input3
        {
            get { return _player3Input3; }
            set { SetProperty(ref _player3Input3, value); }
        }
        private bool _player3Input4;
        public bool Player3Input4
        {
            get { return _player3Input4; }
            set { SetProperty(ref _player3Input4, value); }
        }
        private bool _player3Input5;
        public bool Player3Input5
        {
            get { return _player3Input5; }
            set { SetProperty(ref _player3Input5, value); }
        }
        private bool _player3Input6;
        public bool Player3Input6
        {
            get { return _player3Input6; }
            set { SetProperty(ref _player3Input6, value); }
        }




        private bool _player4Input1;
        public bool Player4Input1
        {
            get { return _player4Input1; }
            set { SetProperty(ref _player4Input1, value); }
        }
        private bool _player4Input2;
        public bool Player4Input2
        {
            get { return _player4Input2; }
            set { SetProperty(ref _player4Input2, value); }
        }
        private bool _player4Input3;
        public bool Player4Input3
        {
            get { return _player4Input3; }
            set { SetProperty(ref _player4Input3, value); }
        }
        private bool _player4Input4;
        public bool Player4Input4
        {
            get { return _player4Input4; }
            set { SetProperty(ref _player4Input4, value); }
        }
        private bool _player4Input5;
        public bool Player4Input5
        {
            get { return _player4Input5; }
            set { SetProperty(ref _player4Input5, value); }
        }
        private bool _player4Input6;
        public bool Player4Input6
        {
            get { return _player4Input6; }
            set { SetProperty(ref _player4Input6, value); }
        }





        private bool _player5Input1;
        public bool Player5Input1
        {
            get { return _player5Input1; }
            set { SetProperty(ref _player5Input1, value); }
        }
        private bool _player5Input2;
        public bool Player5Input2
        {
            get { return _player5Input2; }
            set { SetProperty(ref _player5Input2, value); }
        }
        private bool _player5Input3;
        public bool Player5Input3
        {
            get { return _player5Input3; }
            set { SetProperty(ref _player5Input3, value); }
        }
        private bool _player5Input4;
        public bool Player5Input4
        {
            get { return _player5Input4; }
            set { SetProperty(ref _player5Input4, value); }
        }
        private bool _player5Input5;
        public bool Player5Input5
        {
            get { return _player5Input5; }
            set { SetProperty(ref _player5Input5, value); }
        }
        private bool _player5Input6;
        public bool Player5Input6
        {
            get { return _player5Input6; }
            set { SetProperty(ref _player5Input6, value); }
        }






        private bool _player6Input1;
        public bool Player6Input1
        {
            get { return _player6Input1; }
            set { SetProperty(ref _player6Input1, value); }
        }
        private bool _player6Input2;
        public bool Player6Input2
        {
            get { return _player6Input2; }
            set { SetProperty(ref _player6Input2, value); }
        }
        private bool _player6Input3;
        public bool Player6Input3
        {
            get { return _player6Input3; }
            set { SetProperty(ref _player6Input3, value); }
        }
        private bool _player6Input4;
        public bool Player6Input4
        {
            get { return _player6Input4; }
            set { SetProperty(ref _player6Input4, value); }
        }
        private bool _player6Input5;
        public bool Player6Input5
        {
            get { return _player6Input5; }
            set { SetProperty(ref _player6Input5, value); }
        }
        private bool _player6Input6;
        public bool Player6Input6
        {
            get { return _player6Input6; }
            set { SetProperty(ref _player6Input6, value); }
        }

    }
}
