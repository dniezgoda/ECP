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

        private void BookCipherButton_Click(object sender, RoutedEventArgs e)
        {
            BookCipherWindow window = new BookCipherWindow();
            window.Show();
        }

        private void PlayfairCipherButton_Click(object sender, RoutedEventArgs e)
        {
            PlayfairCipherWindow window = new PlayfairCipherWindow();
            window.Show();
        }

        private void TwoSquareCipherButton_Click(object sender, RoutedEventArgs e)
        {
            TwoSquareCipherWindow window = new TwoSquareCipherWindow();
            window.Show();
        }

        private void FourSquareCipherButton_Click(object sender, RoutedEventArgs e)
        {
            FourSquareCipherWindow window = new FourSquareCipherWindow();
            window.Show();
        }

        private void HillCipherButton_Click(object sender, RoutedEventArgs e)
        {
            HillCipherWindow window = new HillCipherWindow();
            window.Show();
        }

        private void TrithemiusCipherButton_Click(object sender, RoutedEventArgs e)
        {
            TrithemiusCipherWindow window = new TrithemiusCipherWindow();
            window.Show();
        }

        private void VinegereCipherButton_Click(object sender, RoutedEventArgs e)
        {
            VinegereCipherWindow window = new VinegereCipherWindow();
            window.Show();
        }

        private void BeaufortCipherButton_Click(object sender, RoutedEventArgs e)
        {
            BeaufortCipherWindow window = new BeaufortCipherWindow();
            window.Show();
        }

        private void CurrentKeyCipherButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentKeyCipherWindow window = new CurrentKeyCipherWindow();
            window.Show();
        }

        private void AutomaticKeyCipherButton_Click(object sender, RoutedEventArgs e)
        {
            AutomaticKeyCipherWindow window = new AutomaticKeyCipherWindow();
            window.Show();
        }

        private void NihilistCipherButton_Click(object sender, RoutedEventArgs e)
        {
            NihilistCipherWindow window = new NihilistCipherWindow();
            window.Show();
        }

        private void VICCipherButton_Click(object sender, RoutedEventArgs e)
        {
            VICCipherWindow window = new VICCipherWindow();
            window.Show();
        }

        private void XORCipherButton_Click(object sender, RoutedEventArgs e)
        {
            XORCipherWindow window = new XORCipherWindow();
            window.Show();
        }

        private void FenceCipherButton_Click(object sender, RoutedEventArgs e)
        {
            FenceCipherWindow window = new FenceCipherWindow();
            window.Show();
        }

        private void PathCipherButton_Click(object sender, RoutedEventArgs e)
        {
            PathCipherWindow window = new PathCipherWindow();
            window.Show();
        }

        private void ColumnCipherButton_Click(object sender, RoutedEventArgs e)
        {
            ColumnCipherWindow window = new ColumnCipherWindow();
            window.Show();
        }

        private void DoubleColumnCipherButton_Click(object sender, RoutedEventArgs e)
        {
            DoubleColumnCipherWindow window = new DoubleColumnCipherWindow();
            window.Show();
        }

        private void MyszkowskiCipherButton_Click(object sender, RoutedEventArgs e)
        {
            MyszkowskiCipherWindow window = new MyszkowskiCipherWindow();
            window.Show();
        }

        private void HebernMachineButton_Click(object sender, RoutedEventArgs e)
        {
            HebernMachineWindow window = new HebernMachineWindow();
            window.Show();
        }

        private void LorenzMachineButton_Click(object sender, RoutedEventArgs e)
        {
            LorenzMachineWindow window = new LorenzMachineWindow();
            window.Show();
        }

        private void EnigmaButton_Click(object sender, RoutedEventArgs e)
        {
            EnigmaWindow window = new EnigmaWindow();
            window.Show();
        }
    }
}
