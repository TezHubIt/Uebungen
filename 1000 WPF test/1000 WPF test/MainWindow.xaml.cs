using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1000_WPF_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnde_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAendern_Click(object sender, RoutedEventArgs e)
        {
            lblEingabe.Content = "Marcel ist toll!";
            txtEingabe.Text = "alles ist doof";
        }

        private void txtEingabe_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}