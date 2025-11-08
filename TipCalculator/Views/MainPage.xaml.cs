using TipCalculator.Models;
using TipCalculator.ViewModels;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {

        private MainViewModel _viewModel;
        public MainPage()
        {
            InitializeComponent(); 
            _viewModel = new MainViewModel();
            this.BindingContext = _viewModel;
        }       
    }
}
