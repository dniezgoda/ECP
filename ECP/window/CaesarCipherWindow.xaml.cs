using ECP.code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ECP.window
{
    /// <summary>
    /// Interaction logic for CaesarCipherWindow.xaml
    /// </summary>
    public partial class CaesarCipherWindow : Window
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
        public CaesarCipherWindow()
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
            if (Number < 25)
                Number++;
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            if(Number > 1)
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
            int key = int.Parse(TextBoxKey.Text);

            if (RadioButtonEncrypt.IsChecked == true)
                TextBoxSecond.Text = CaesarCipherCode.Encrypt(message, key);
            else
                TextBoxSecond.Text = CaesarCipherCode.Decrypt(message, key);
        }
    }
}
