using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POD12
{
    /// <summary>
    /// Logika interakcji dla klasy RSApage.xaml
    /// </summary>
    public partial class RSApage : Page
    {
        RSA rsa;
        public RSApage()
        {
            InitializeComponent();
        }

        private void openText_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.ShowDialog();
                string path = dlg.FileName;
                rsa = new RSA(path, Convert.ToUInt32(textBoxP.Text), Convert.ToUInt32(textBoxQ.Text));
                textBoxN.Text = Convert.ToString(rsa.getN());
                textBoxE.Text = Convert.ToString(rsa.getE());
                textBoxD.Text = Convert.ToString(rsa.getD());
            }
            catch
            {
                MessageBox.Show("   Error");
            }
        }

        private void openEncrypted_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
                dlg.ShowDialog();
                string path = dlg.FileName;
                rsa = new RSA(Convert.ToUInt32(textBoxN.Text), Convert.ToUInt32(textBoxD.Text), path);
            }
            catch
            {
                MessageBox.Show("   Error");
            }
        }

        private void coding_Click(object sender, RoutedEventArgs e)
        {
            rsa.encrypting();
            rsa.saveEncrypted();
            MessageBox.Show("   Done");
        }

        private void decoding_Click(object sender, RoutedEventArgs e)
        {
            rsa.decrypting();
            rsa.saveDecrypted();
            MessageBox.Show("   Done");
        }

        private void documentation_Click(object sender, RoutedEventArgs e)
        {
            Dokumentation dok = new Dokumentation();
            this.NavigationService.Navigate(dok);
        }
    }
}
