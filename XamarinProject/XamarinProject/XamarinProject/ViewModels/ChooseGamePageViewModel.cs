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
    public class ChooseGamePageViewModel : ViewModelBase
    {
        private ImageSource _diammondsImageSource;
        public ImageSource DiamondsSource
        {
            get { return _diammondsImageSource; }
            set { SetProperty(ref _diammondsImageSource, value); }
        }
        private ImageSource _tenOfClubsImageSource;
        public ImageSource TenOfClubsSource
        {
            get { return _tenOfClubsImageSource; }
            set { SetProperty(ref _tenOfClubsImageSource, value); }
        }
        private ImageSource _kingOfHeartsImageSource;
        public ImageSource KingOfHeartsSource
        {
            get { return _kingOfHeartsImageSource; }
            set { SetProperty(ref _kingOfHeartsImageSource, value); }
        }
        private ImageSource _queensImageSource;
        public ImageSource QueensSource
        {
            get { return _queensImageSource; }
            set { SetProperty(ref _queensImageSource, value); }
        }

        private List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
            set { SetProperty(ref _players, value); }
        }
        private bool _currentPlayerTotaleView;
        public bool CurrentPlayerTotaleView
        {
            get { return _currentPlayerTotaleView; }
            set { SetProperty(ref _currentPlayerTotaleView, value); }
        }
        private bool _currentPlayerKingOfHeartsView;
        public bool CurrentPlayerKingOfHeartsView
        {
            get { return _currentPlayerKingOfHeartsView; }
            set { SetProperty(ref _currentPlayerKingOfHeartsView, value); }
        }
        private bool _currentPlayerTenOfClubsView;
        public bool CurrentPlayerTenOfClubsView
        {
            get { return _currentPlayerTenOfClubsView; }
            set { SetProperty(ref _currentPlayerTenOfClubsView, value); }
        }
        private bool _currentPlayerQueensView;
        public bool CurrentPlayerQueensView
        {
            get { return _currentPlayerQueensView; }
            set { SetProperty(ref _currentPlayerQueensView, value); }
        }
        private bool _currentPlayerRentzView;
        public bool CurrentPlayerRentzView
        {
            get { return _currentPlayerRentzView; }
            set { SetProperty(ref _currentPlayerRentzView, value); }
        }
        private bool _currentPlayerWhistView;
        public bool CurrentPlayerWhistView
        {
            get { return _currentPlayerWhistView; }
            set { SetProperty(ref _currentPlayerWhistView, value); }
        }
        private bool _currentPlayerDiamondsView;
        public bool CurrentPlayerDiamondsView
        {
            get { return _currentPlayerDiamondsView; }
            set { SetProperty(ref _currentPlayerDiamondsView, value); }
        }
        private bool _currentPlayerLevateView;
        public bool CurrentPlayerLevateView
        {
            get { return _currentPlayerLevateView; }
            set { SetProperty(ref _currentPlayerLevateView, value); }
        }

        private Player _currenntPlayer;
        public Player CurrentPlayer
        {
            get { return _currenntPlayer; }
            set { SetProperty(ref _currenntPlayer, value); }
        }

        public ICommand DoubleClicked { get; set; }

        public readonly INavigationService NavigationService;
        public readonly IEventAggregator EventAggregatorr;

        public ChooseGamePageViewModel(INavigationService navigationMethod, IPageDialogService dialogService, IEventAggregator eventAggregator)
            : base(navigationMethod, dialogService, eventAggregator)
        {
            NavigationService = navigationMethod;
            EventAggregatorr = eventAggregator;
            DoubleClicked = new Command(DoubleButton_Clicked);

            DiamondsSource = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("Resources/drawable/diamonds.jpg") : ImageSource.FromFile("Assets/diamonds.jpg");
            TenOfClubsSource = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("Resources/drawable/tenofclub.jpg") : ImageSource.FromFile("Assets/tenofclub.jpg");
            KingOfHeartsSource = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("Resources/drawable/King.jpg") : ImageSource.FromFile("Assets/King.jpg");
            QueensSource = Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("Resources/drawable/queens.jpg") : ImageSource.FromFile("Assets/queens.jpg");

            eventAggregator.GetEvent<MessageSentEvent>().Subscribe(MessageReceived);
        }

        private void MessageReceived(List<Player> players)
        {
            Players = players;

            foreach (Player player in Players)
            {
                if (player.Turn)
                {
                    CurrentPlayerTotaleView = player.TotaleView;
                    CurrentPlayerKingOfHeartsView = player.KingView;
                    CurrentPlayerRentzView = player.RentzView;
                    CurrentPlayerQueensView = player.QueensView;
                    CurrentPlayerTenOfClubsView = player.TenView;
                    CurrentPlayerWhistView = player.WhistView;
                    CurrentPlayerDiamondsView = player.DiamondsView;
                    CurrentPlayerLevateView = player.LevateView;
                }
            }
        }

        private void DoubleButton_Clicked()
        {
            foreach (Player player in Players)
            {
                if (player.Turn)
                {
                    if (!player.DoubleScore)
                    {
                        player.DoubleScore = true;
                    }
                    else
                    {
                        player.DoubleScore = false;
                    }
                }
            }            
        }


    }
}
