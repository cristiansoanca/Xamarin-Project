using Prism;
using Prism.Ioc;
using XamarinProject.ViewModels;
using XamarinProject.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinProject
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/StartPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<StartPage, StartPageViewModel>();
            containerRegistry.RegisterForNavigation<ChooseGamePage, ChooseGamePageViewModel>();
            containerRegistry.RegisterForNavigation<MainPageWith6Players, MainPageWith6PlayersViewModel>();
            containerRegistry.RegisterForNavigation<MainPageWith5Players, MainPageWith5PlayersViewModel>();
            containerRegistry.RegisterForNavigation<InputPage, InputPageViewModel>();
            containerRegistry.RegisterForNavigation<SingleInputPage, SingleInputPageViewModel>();
            containerRegistry.RegisterForNavigation<MultipleInputPage, MultipleInputPageViewModel>();
            containerRegistry.RegisterForNavigation<RentzInputPage, RentzInputPageViewModel>();
        }
    }
}
