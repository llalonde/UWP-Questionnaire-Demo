using QuestionnaireDemo.ViewModels;
using Windows.UI.Xaml.Controls;

namespace QuestionnaireDemo.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel vm { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            vm = new MainViewModel();
            this.DataContext = vm;
        }
    }
}
