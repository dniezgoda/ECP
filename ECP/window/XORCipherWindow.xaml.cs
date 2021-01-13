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
using System.Windows.Shapes;
using ECP.code;

namespace ECP.window
{
    /// <summary>
    /// Interaction logic for XORCipherWindow.xaml
    /// </summary>
    public partial class XORCipherWindow : Window
    {
        private int number = 1;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                TextBoxKey.Text = value.ToString();
            }
        }
        public XORCipherWindow()
        {
            InitializeComponent();
            TextBoxKey.Text = number.ToString();
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

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxFirst.Text = "";
            TextBoxSecond.Text = "";
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            Number++;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if (Number > 1)
                Number--;
        }

        private void TextBoxKey_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TextBoxKey == null)
            {
                return;
            }

            if (!int.TryParse(TextBoxKey.Text, out number))
                TextBoxKey.Text = number.ToString();
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            string message = TextBoxFirst.Text;
            string key = TextBoxKey.Text;

            TextBoxSecond.Text = XORCipherCode.Encrypt(message, key);
        }

        private void InformationsButton_Click(object sender, RoutedEventArgs e)
        {
            XORCipherInformationsWindow window = new XORCipherInformationsWindow();
            window.Show();
        }
    }
}
