using pr26_Radosteva.Classes;
using System.Windows;
using System.Windows.Controls;

namespace pr26_Radosteva.Pages.Users
{
    public partial class Add : Page
    {
        public ClubsContext AllClub = new ClubsContext();
        public Models.Users User;
        public Main Main;
        public Add(Main Main, Models.Users User = null)
        {
            InitializeComponent();
            this.Main = Main;
            foreach (Models.Clubs Club in AllClub.Clubs) 
            {
                cbClub.Items.Add(Club.Name);
            }
            cbClub.Items.Add("Выберите...");
            if (User != null) 
            {
                this.User = User;
                this.tbFIO.Text = User.FIO;
                this.dpRentDate.Text = User.RentStart.ToString("yyyy-MM-dd");
                this.tbTimeRent.Text = User.RentStart.ToString("HH:mm");
                this.tbDurationRent.Text = User.Duration.ToString();
                cbClub.SelectedItem = AllClub.Clubs.Where(x => x.Id == User.IdClub).First().Name;
                btnAdd.Content = "Изменить";
            }
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            DateTime DTRentStart = new DateTime();
            DateTime.TryParse(this.dpRentDate.Text, out DTRentStart);
            DTRentStart = DTRentStart.Add(TimeSpan.Parse(this.tbTimeRent.Text));
            if (this.User == null)
            {
                User = new Models.Users();
                User.FIO = this.tbFIO.Text;
                User.RentStart = DTRentStart;
                User.Duration = Convert.ToInt32(this.tbDurationRent.Text);
                User.IdClub = AllClub.Clubs.Where(x => x.Name == cbClub.SelectedItem).First().Id;
                this.Main.AllUsers.Users.Add(this.User);
            }
            else
            {
                User.FIO = this.tbFIO.Text;
                User.RentStart = DTRentStart;
                User.Duration = Convert.ToInt32(this.tbDurationRent.Text);
                User.IdClub = AllClub.Clubs.Where(x => x.Name == cbClub.SelectedItem).First().Id;
            }
            this.Main.AllUsers.SaveChanges();
            MainWindow.init.OpenPages(new Pages.Users.Main());
        }
    }
}
