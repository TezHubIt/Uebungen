using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _1035_Palindrom_Check
{
    public partial class MainWindow : Window
    {
        private bool firstFocus = true;
        private bool resultShown = false;

        public MainWindow()
        {
            InitializeComponent();

            imgOk.Visibility = Visibility.Hidden;
            imgNo.Visibility = Visibility.Hidden;

            txtInput.GotFocus += TxtInput_GotFocus;
            txtInput.KeyDown += TxtInput_KeyDown;
            txtInput.PreviewTextInput += TxtInput_PreviewTextInput;
        }

        private void TxtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            if (firstFocus)
            {
                txtInput.Text = "";
                firstFocus = false;
            }
        }

        private void TxtInput_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (resultShown)
            {
                txtInput.Clear();
                resultShown = false;
            }
        }

        private void TxtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                string input = txtInput.Text;

                if (string.IsNullOrWhiteSpace(input))
                {
                    imgOk.Visibility = Visibility.Hidden;
                    imgNo.Visibility = Visibility.Hidden;
                    return;
                }

                if (PalindromCheck(input))
                {
                    imgOk.Visibility = Visibility.Visible;
                    imgNo.Visibility = Visibility.Hidden;
                }
                else
                {
                    imgOk.Visibility = Visibility.Hidden;
                    imgNo.Visibility = Visibility.Visible;
                }

                resultShown = true;
                e.Handled = true;
            }
        }

        private bool PalindromCheck(string input)
        {
            var cleaned = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            return cleaned.SequenceEqual(cleaned.Reverse());
        }
    }
}
