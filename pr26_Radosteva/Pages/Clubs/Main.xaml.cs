using pr26_Radosteva.Classes;
using System.Windows;
using System.Windows.Controls;

namespace pr26_Radosteva.Pages.Clubs
{
    public partial class Main : Page
    {
        public ClubsContext AllClub = new ClubsContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Clubs Club in AllClub.Clubs) 
            {
                parent.Children.Add(new Elements.Item(Club, this));
            }
        }

        private void AddClub(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this));
        }
    }
}
