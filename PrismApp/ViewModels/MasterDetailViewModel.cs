using Prism.Commands;
using Prism.Navigation;

namespace PrismApp.ViewModels
{
    public class MasterDetailViewModel : ViewModelBase
    {
        private INavigationService navigationService;

        public DelegateCommand<string> NavBtnClicked { get; private set; }

        public MasterDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            this.navigationService = navigationService;
            NavBtnClicked = new DelegateCommand<string>(NavigationCmd);
        }

        //a command parameter is passed through to change where the user is navigated.
        private void NavigationCmd(string obj)
        {
            var page = "/LoginView";
            switch (obj)
            {
                case "about":
                    page = "NavigationPage/HomeView";
                    break;
                case "home":
                    page = "NavigationPage/HomeView";
                    break;
                case "profile":
                    page = "NavigationPage/HomeView";
                    break;
            }
            this.navigationService.NavigateAsync(page);
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }
    }
}