using pr26_Radosteva.Classes;
using System.Windows;
using System.Windows.Controls;

namespace pr26_Radosteva.Pages.Users.Elements
{
    public partial class Item : UserControl
    {
        public ClubsContext AllClub = new ClubsContext();
        Main Main;
        Models.Users User;
        public Item(Models.Users User, Main Main)
        {
            InitializeComponent();
            this.tbFIO.Text = User.FIO;
            this.dpRentDate.Text = User.RentStart.ToString("yyyy-MM-dd");
            this.tbTimeRent.Text = User.RentStart.ToString("HH:mm");
            this.tbDurationRent.Text = User.Duration.ToString();
            this.tbClub.Text = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
            this.Main = Main;
            this.User = User;
        }

        private void EditUser(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Users.Add(this.Main, this.User));
        }

        private void DeleteUser(object sender, RoutedEventArgs e)
        {
            Main.AllUsers.Users.Remove(User);
            Main.AllUsers.SaveChanges();
            Main.parent.Children.Remove(this);
        }
    }
}
