using pr26_Radosteva.Classes;
using System.Windows;
using System.Windows.Controls;

namespace pr26_Radosteva.Pages.Users
{
    public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();
        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users) 
            {
                parent.Children.Add(new Elements.Item(User, this));
            }
        }

        private void AddUser(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Users.Add(this));
        }
    }
}
