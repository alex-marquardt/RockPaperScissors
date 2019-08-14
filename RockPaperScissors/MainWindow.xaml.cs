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

namespace RockPaperScissors
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
        
        private void ImagePlayerRock_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagePlayerRock.Opacity = 1.0;
        }

        private void ImagePlayerPaper_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagePlayerPaper.Opacity = 1.0;
        }

        private void ImagePlayerScissors_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagePlayerScissors.Opacity = 1.0;
        }

        private void ImagePlayerRock_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagePlayerRock.Opacity = 0.7;
        }

        private void ImagePlayerPaper_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagePlayerPaper.Opacity = 0.7;
        }

        private void ImagePlayerScissors_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagePlayerScissors.Opacity = 0.7;
        }

        private void ImagePlayerRock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var uriSource = new Uri(@"Images/rock.png", UriKind.Relative);
            ImagePlayerSelected.Source = new BitmapImage(uriSource);
            TextBlockPlayerStatus.Text = "Rock";
        }

        private void ImagePlayerPaper_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var uriSource = new Uri(@"Images/paper.png", UriKind.Relative);
            ImagePlayerSelected.Source = new BitmapImage(uriSource);
            TextBlockPlayerStatus.Text = "Paper";
        }

        private void ImagePlayerScissors_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var uriSource = new Uri(@"Images/scissors.png", UriKind.Relative);
            ImagePlayerSelected.Source = new BitmapImage(uriSource);
            TextBlockPlayerStatus.Text = "Scissors";
        }
    }
}
