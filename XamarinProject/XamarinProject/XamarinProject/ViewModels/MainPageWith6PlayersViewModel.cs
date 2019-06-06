using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinProject.Utils;
using XamarinProject.Views;

namespace XamarinProject.ViewModels
{
	public class MainPageWith6PlayersViewModel : ViewModelBase
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

        private ObservableCollection<PlayerScore6> _items = new ObservableCollection<PlayerScore6>();
        public ObservableCollection<PlayerScore6> Items
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
        private PlayerScore6 ps;
        private static int _turn = 0;

        public MainPageWith6PlayersViewModel(INavigationService navigationService, IPageDialogService dialogService, IEventAggregator eventAggregator)
            : base(navigationService, dialogService, eventAggregator)
        {
            eventAggregator.GetEvent<MessageSentEvent6Players>().Subscribe(MessageReceived);
            eventAggregator.GetEvent<ScoreSentEvent6Players>().Subscribe(ScoreReceived);
            Items = new ObservableCollection<PlayerScore6>();

            SelectGameClicked = new Command(Button_Clicked);
        }

        private async void Button_Clicked()
        {
            await NavigationMethod.NavigateAsync(nameof(ChooseGamePage));

            Players[_turn].Turn = true;

            EventAggregator.GetEvent<MessageSentEvent>().Publish(Players);
        }

        private void ScoreReceived(List<Player> players)
        {
            ps = new PlayerScore6(0, 0, 0, 0, 0, 0);

            Players = players;

            ps.CurrentGame = Players[_turn].CurrentGame;

            Players[_turn].Turn = false;
            _turn++;

            if (_turn == 6)
            {
                _turn = 0;
            }

            CurrentPlayer = Players[_turn].Name;

            ps.Player1Score = Players[0].Score;
            ps.Player2Score = Players[1].Score;
            ps.Player3Score = Players[2].Score;
            ps.Player4Score = Players[3].Score;
            ps.Player5Score = Players[4].Score;
            ps.Player6Score = Players[5].Score;

            Items.Add(ps);
        }

        private void MessageReceived(List<Player> players)
        {
            Players = players;

            Player1 = players[0].Name.ToUpper();
            Player2 = players[1].Name.ToUpper();
            Player3 = players[2].Name.ToUpper();
            Player4 = players[3].Name.ToUpper();
            Player5 = players[4].Name.ToUpper();
            Player6 = players[5].Name.ToUpper();

            CurrentPlayer = Player1;

            ps = new PlayerScore6(0, 0, 0, 0, 0, 0);
        }

    }

    public class PlayerScore6
    {
        int _p1score = 0;
        public int Player1Score { get { return _p1score; } set { _p1score += value; } }
        int _p2score = 0;
        public int Player2Score { get { return _p2score; } set { _p2score += value; } }
        int _p3score = 0;
        public int Player3Score { get { return _p3score; } set { _p3score += value; } }
        int _p4score = 0;
        public int Player4Score { get { return _p4score; } set { _p4score += value; } }
        int _p5score = 0;
        public int Player5Score { get { return _p5score; } set { _p5score += value; } }
        int _p6score = 0;
        public int Player6Score { get { return _p6score; } set { _p6score += value; } }
        public string CurrentGame { get; set; }

        public PlayerScore6(int player1score, int player2score, int player3score, int player4score,
            int player5score, int player6score)
        {
            Player1Score = player1score;
            Player2Score = player2score;
            Player3Score = player3score;
            Player4Score = player4score;
            Player5Score = player5score;
            Player6Score = player6score;
        }
    }
}

