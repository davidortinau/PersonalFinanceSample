using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace PersonalFinance.WPF
{
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();

            Forms.Init();
            LoadApplication(new PersonalFinance.App());
        }
    }
}