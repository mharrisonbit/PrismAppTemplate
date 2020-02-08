using Prism.Navigation;

namespace PrismApp.ViewModels
{
    public class TabbedPageViewModel : ViewModelBase
    {
        public TabbedPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public override void Destroy()
        {
            base.Destroy();
        }
    }
}