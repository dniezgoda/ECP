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
        public XORCipherWindow()
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

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            string message = TextBoxFirst.Text;
            string key = TextBoxKey.Text;

            //if (RadioButtonEncrypt.IsChecked == true)
                TextBoxSecond.Text = XORCipherCode.Encrypt(message, key);
            //else
                //TextBoxSecond.Text = XORCipherCode.Decrypt(message, key);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxFirst.Text = "";
            TextBoxSecond.Text = "";
        }
    }
}
