using Prism.Navigation;

namespace PrismApp.ViewModels
{
    public class HomeViewModel : ViewModelBase, IInitialize
    {
        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public void Initialize(INavigationParameters parameters)
        {
            
        }
    }
}