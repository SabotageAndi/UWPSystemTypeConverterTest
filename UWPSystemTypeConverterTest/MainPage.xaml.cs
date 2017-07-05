using Windows.UI.Xaml.Controls;
using UWPSystemTypeConverterTest.Enum;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPSystemTypeConverterTest
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //public CustomEnum WithThisPropertyTheAppWorks { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}