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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace Info_APP
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Switch_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void ClickAbout(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromSeconds(1));
            EllipseLoc.BeginAnimation(OpacityProperty, animation1);
            TextBlockLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockSearch.BeginAnimation(OpacityProperty, animation1);
            TextBlockSet.BeginAnimation(OpacityProperty, animation1);
            RectangleSet.BeginAnimation(OpacityProperty, animation1);
            buttonBlue.BeginAnimation(OpacityProperty, animation1);
            buttonGreen.BeginAnimation(OpacityProperty, animation1);
            buttonGrey.BeginAnimation(OpacityProperty, animation1);
            buttonRed.BeginAnimation(OpacityProperty, animation1);
            buttonStandard.BeginAnimation(OpacityProperty, animation1);
            buttonViolet.BeginAnimation(OpacityProperty, animation1);
            buttonYellow.BeginAnimation(OpacityProperty, animation1);

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            TextBlockAbout.BeginAnimation(OpacityProperty, animation);
            TextBlockAbout1.BeginAnimation(OpacityProperty, animation);
   
        }
    
        private void Localization_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            TextBlockAbout.BeginAnimation(OpacityProperty, animation1);
            TextBlockAbout1.BeginAnimation(OpacityProperty, animation1);
            RectangleContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockSearch.BeginAnimation(OpacityProperty, animation1);
            TextBlockSet.BeginAnimation(OpacityProperty, animation1);
            RectangleSet.BeginAnimation(OpacityProperty, animation1);
            buttonBlue.BeginAnimation(OpacityProperty, animation1);
            buttonGreen.BeginAnimation(OpacityProperty, animation1);
            buttonGrey.BeginAnimation(OpacityProperty, animation1);
            buttonRed.BeginAnimation(OpacityProperty, animation1);
            buttonStandard.BeginAnimation(OpacityProperty, animation1);
            buttonViolet.BeginAnimation(OpacityProperty, animation1);
            buttonYellow.BeginAnimation(OpacityProperty, animation1);

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            EllipseLoc.BeginAnimation(OpacityProperty, animation);
            TextBlockLoc.BeginAnimation(OpacityProperty, animation);
            RectangleLoc.BeginAnimation(OpacityProperty, animation);

        }

        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            TextBlockAbout.BeginAnimation(OpacityProperty, animation1);
            TextBlockAbout1.BeginAnimation(OpacityProperty, animation1);
            EllipseLoc.BeginAnimation(OpacityProperty, animation1);
            TextBlockLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleLoc.BeginAnimation(OpacityProperty, animation1);
            TextBlockSearch.BeginAnimation(OpacityProperty, animation1);
            TextBlockSet.BeginAnimation(OpacityProperty, animation1);
            RectangleSet.BeginAnimation(OpacityProperty, animation1);
            buttonBlue.BeginAnimation(OpacityProperty, animation1);
            buttonGreen.BeginAnimation(OpacityProperty, animation1);
            buttonGrey.BeginAnimation(OpacityProperty, animation1);
            buttonRed.BeginAnimation(OpacityProperty, animation1);
            buttonStandard.BeginAnimation(OpacityProperty, animation1);
            buttonViolet.BeginAnimation(OpacityProperty, animation1);
            buttonYellow.BeginAnimation(OpacityProperty, animation1);

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            RectangleContact.BeginAnimation(OpacityProperty, animation);
            TextBlockContact.BeginAnimation(OpacityProperty, animation);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            TextBlockAbout.BeginAnimation(OpacityProperty, animation1);
            TextBlockAbout1.BeginAnimation(OpacityProperty, animation1);
            EllipseLoc.BeginAnimation(OpacityProperty, animation1);
            TextBlockLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockSet.BeginAnimation(OpacityProperty, animation1);
            RectangleSet.BeginAnimation(OpacityProperty, animation1);
            buttonBlue.BeginAnimation(OpacityProperty, animation1);
            buttonGreen.BeginAnimation(OpacityProperty, animation1);
            buttonGrey.BeginAnimation(OpacityProperty, animation1);
            buttonRed.BeginAnimation(OpacityProperty, animation1);
            buttonStandard.BeginAnimation(OpacityProperty, animation1);
            buttonViolet.BeginAnimation(OpacityProperty, animation1);
            buttonYellow.BeginAnimation(OpacityProperty, animation1);

            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            TextBlockSearch.BeginAnimation(OpacityProperty, animation);
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation animation1 = new DoubleAnimation();
            animation1.From = 0;
            animation1.To = 0;
            animation1.Duration = new Duration(TimeSpan.FromMilliseconds(1));
            TextBlockAbout.BeginAnimation(OpacityProperty, animation1);
            TextBlockAbout1.BeginAnimation(OpacityProperty, animation1);
            EllipseLoc.BeginAnimation(OpacityProperty, animation1);
            TextBlockLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleLoc.BeginAnimation(OpacityProperty, animation1);
            RectangleContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockContact.BeginAnimation(OpacityProperty, animation1);
            TextBlockSearch.BeginAnimation(OpacityProperty, animation1);


            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0;
            animation.To = 1;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));
            TextBlockSet.BeginAnimation(OpacityProperty, animation);
            RectangleSet.BeginAnimation(OpacityProperty, animation);
            buttonBlue.BeginAnimation(OpacityProperty, animation);
            buttonGreen.BeginAnimation(OpacityProperty, animation);
            buttonGrey.BeginAnimation(OpacityProperty, animation);
            buttonRed.BeginAnimation(OpacityProperty, animation);
            buttonStandard.BeginAnimation(OpacityProperty, animation);
            buttonViolet.BeginAnimation(OpacityProperty, animation);
            buttonYellow.BeginAnimation(OpacityProperty, animation);

        }

        private void ButtonRed_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = Brushes.Red;
        }

        private void ButtonGrey_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(102, 102, 102));
        }

        private void ButtonYellow_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(220, 241, 0));
        }

        private void ButtonViolet_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = new SolidColorBrush(Color.FromRgb(110, 10, 255));
        }

        private void ButtonGreen_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = Brushes.Green;
        }

        private void ButtonStandard_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = Brushes.White;
        }

        private void ButtonBlue_Click(object sender, RoutedEventArgs e)
        {
            BG.Background = Brushes.Blue;
        }
    }
}
