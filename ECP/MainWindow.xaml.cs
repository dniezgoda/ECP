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
using ECP.window;

namespace ECP
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

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void ROT13Button_Click(object sender, RoutedEventArgs e)
        {
            ROT13Window window = new ROT13Window();
            window.Show();
        }

        private void CaesarCipherButton_Click(object sender, RoutedEventArgs e)
        {
            CaesarCipherWindow window = new CaesarCipherWindow();
            window.Show();
        }

        private void PlayfairCipherButton_Click(object sender, RoutedEventArgs e)
        {
            PlayfairCipherWindow window = new PlayfairCipherWindow();
            window.Show();
        }

        private void VigenereCipherButton_Click(object sender, RoutedEventArgs e)
        {
            VigenereCipherWindow window = new VigenereCipherWindow();
            window.Show();
        }

        private void XORCipherButton_Click(object sender, RoutedEventArgs e)
        {
            XORCipherWindow window = new XORCipherWindow();
            window.Show();
        }

        private void DESButton_Click(object sender, RoutedEventArgs e)
        {
            DESWindow window = new DESWindow();
            window.Show();
        }

        private void RC2Button_Click(object sender, RoutedEventArgs e)
        {
            RC2Window window = new RC2Window();
            window.Show();
        }

        private void ThreeDESButton_Click(object sender, RoutedEventArgs e)
        {
            ThreeDESWindow window = new ThreeDESWindow();
            window.Show();
        }

        private void AESButton_Click(object sender, RoutedEventArgs e)
        {
            AESWindow window = new AESWindow();
            window.Show();
        }

        private void SHA1Button_Click(object sender, RoutedEventArgs e)
        {
            SHA1Window window = new SHA1Window();
            window.Show();
        }

        private void SHA256Button_Click(object sender, RoutedEventArgs e)
        {
            SHA256Window window = new SHA256Window();
            window.Show();
        }

        private void SHA384Button_Click(object sender, RoutedEventArgs e)
        {
            SHA384Window window = new SHA384Window();
            window.Show();
        }

        private void SHA512Button_Click(object sender, RoutedEventArgs e)
        {
            SHA512Window window = new SHA512Window();
            window.Show();
        }

        private void MD5Button_Click(object sender, RoutedEventArgs e)
        {
            MD5Window window = new MD5Window();
            window.Show();
        }

        private void InformationsButton_Click(object sender, RoutedEventArgs e)
        {
            InformationsWindow window = new InformationsWindow();
            window.Show();
        }

        private void AttacksButton_Click(object sender, RoutedEventArgs e)
        {
            //AttacksWindow window = new AttacksWindow();
            //window.Show();
        }
    }
}
