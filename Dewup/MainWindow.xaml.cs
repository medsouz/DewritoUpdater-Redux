using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dewup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //temp: populate changelog
            changelog.Text = "Changelog for version 0.6: ";
            for (int i = 0; i < 50; i++)
            {
                changelog.Text += Environment.NewLine + "- Hi";
            }
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Rectangle)sender).Fill = new SolidColorBrush(Color.FromArgb(100, 255, 185, 0));
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Rectangle)sender).Fill = new SolidColorBrush(Color.FromArgb(127, 255, 185, 0));
        }

        private void button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ((Rectangle)sender).Fill = new SolidColorBrush(Color.FromArgb(50, 255, 185, 0));
        }

        private void button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ((Rectangle)sender).Fill = new SolidColorBrush(Color.FromArgb(100, 255, 185, 0));
        }

        private void closeButton_MouseUp(object sender, MouseButtonEventArgs e)
        {
            button_MouseUp(sender, e);
            Environment.Exit(0);
        }
        
        private void header_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        
    }
}
