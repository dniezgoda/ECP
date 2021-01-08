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
    /// Interaction logic for SHA384Window.xaml
    /// </summary>
    public partial class SHA384Window : Window
    {
        public SHA384Window()
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
            TextBoxSecond.Text = SHA384Code.Hash(message);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBoxFirst.Text = "";
            TextBoxSecond.Text = "";
        }
    }
}
