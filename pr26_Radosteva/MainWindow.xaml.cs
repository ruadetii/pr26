using System.Windows;
using System.Windows.Controls;

namespace pr26_Radosteva
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
            OpenPages(new Pages.Clubs.Main());
        }
        public void OpenPages(Page Page) 
        {
            frame.Navigate(Page);
        }

        private void Clubs(object sender, RoutedEventArgs e)
        {
            OpenPages(new Pages.Clubs.Main());
        }

        private void Users(object sender, RoutedEventArgs e)
        {
            OpenPages(new Pages.Users.Main());
        }
    }
}