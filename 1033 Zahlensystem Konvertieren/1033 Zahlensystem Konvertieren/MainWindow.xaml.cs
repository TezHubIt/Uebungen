using System;
using System.Windows;
using System.Windows.Input;

namespace DezimalUmwandler
{
    public partial class MainWindow : Window
    {
        private bool sollTextfeldGeleertWerden = false;
        public MainWindow()
        {
            InitializeComponent();
         }

        private void textBoxDezimal_KeyDown(object sender, KeyEventArgs e)
        {
            if (sollTextfeldGeleertWerden)
            {
                textBoxDezimal.Clear();
                sollTextfeldGeleertWerden = false;
            }

            if (e.Key == Key.Enter)
            {
                Umwandeln();
                e.Handled = true; // verhindert "Ding"-Sound bei Enter
            }
            

        }




        private void Umwandeln()
        {
            string input = textBoxDezimal.Text;

            if (int.TryParse(input, out int zahl))
            {
                string binaer = Convert.ToString(zahl, 2);

                // Auf ein Vielfaches von 4 auffüllen
                int padding = 4 - (binaer.Length % 4);
                if (padding != 4)
                {
                    binaer = binaer.PadLeft(binaer.Length + padding, '0');
                }

                // 4er-Gruppierung
                string gruppiert = "";
                for (int i = 0; i < binaer.Length; i += 4)
                {
                    if (i > 0) gruppiert += " ";
                    gruppiert += binaer.Substring(i, 4);
                }

                textBlockBinaer.Text = $"Binär: {gruppiert}";
                textBlockHex.Text = $"Hexadezimal: {Convert.ToString(zahl, 16).ToUpper()}";
                sollTextfeldGeleertWerden = true;

            }
            else
            {
                MessageBox.Show("Bitte eine gültige ganze Zahl eingeben.", "Ungültige Eingabe", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            
        }
    }
}
