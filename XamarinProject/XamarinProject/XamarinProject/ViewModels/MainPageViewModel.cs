using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Events;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;
using XamarinProject.Utils;
using XamarinProject.Views;

namespace XamarinProject.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
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

        private ObservableCollection<PlayerScore> _items = new ObservableCollection<PlayerScore>();
        public ObservableCollection<PlayerScore> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }

        private string _currentPlayer;
        public string CurrentPlayer
        {
            get { return _currentPlayer; }
            set { SetProperty(ref _currentPlayer, value); }
        }

        

        public ICommand SelectGameClicked { get; set; }
        private PlayerScore ps;
        private static int _turn = 0;

        public MainPageViewModel(INavigationService navigationService, IPageDialogService dialogService, IEventAggregator eventAggregator)
            : base(navigationService, dialogService, eventAggregator)
        {
            eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
            eventAggregator.GetEvent<ScoreSentEvent>().Subscribe(ScoreReceived);
            Items = new ObservableCollection<PlayerScore>();

            SelectGameClicked = new Command(Button_Clicked);
        }

        private int _end = 0;
        private void ScoreReceived(List<Player> players)
        {
            Players = players;

            ps.CurrentGame = Players[_turn].CurrentGame;

            Players[_turn].Turn = false;
            _turn++;

            if (_turn == 4)
            {
                _turn = 0;
            }

            CurrentPlayer = Players[_turn].Name;

            ps.Player1Score = Players[0].Score;
            ps.Player2Score = Players[1].Score;
            ps.Player3Score = Players[2].Score;
            ps.Player4Score = Players[3].Score;

            Items.Add(ps);

            _end = 0;

            foreach (Player player in Players)
            {
                if (player.AvailableGames.Count == 0)
                {
                    _end++;
                }
            }

            if (_end == 4)
            {
                DialogService.DisplayAlertAsync("The End", "The End", "OK"); 
            }
        }

        private async void Button_Clicked()
        {
            await NavigationMethod.NavigateAsync(nameof(ChooseGamePage));


            Players[_turn].Turn = true;
          

            EventAggregator.GetEvent<MessageSentEvent>().Publish(Players);
        }

        private void MessageReceived(List<Player> players)
        {
            Players = players;

            Player1 = players[0].Name.ToUpper();
            Player2 = players[1].Name.ToUpper();
            Player3 = players[2].Name.ToUpper();
            Player4 = players[3].Name.ToUpper();

            CurrentPlayer = Player1;

            ps = new PlayerScore(0, 0, 0, 0);
        }

    }

    public class PlayerScore
    {
        int _p1score = 0;
        public int Player1Score { get { return _p1score;  } set { _p1score += value; }  }
        int _p2score = 0;
        public int Player2Score { get { return _p2score; } set { _p2score += value; } }
        int _p3score = 0;
        public int Player3Score { get { return _p3score; } set { _p3score += value; } }
        int _p4score = 0;
        public int Player4Score { get { return _p4score; } set { _p4score += value; } }
        public string CurrentGame { get; set; }


        public PlayerScore(int player1score, int player2score, int player3score, int player4score)
        {
            Player1Score = player1score;
            Player2Score = player2score;
            Player3Score = player3score;
            Player4Score = player4score;
        }
    }
}
