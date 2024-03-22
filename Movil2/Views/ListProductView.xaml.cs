using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Movil2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListProductView : ContentPage
    {
        public ListProductView()
        {
            InitializeComponent();

            BindingContext = new ViewModels.ListProductViewModel(Navigation);
        }
    }
}