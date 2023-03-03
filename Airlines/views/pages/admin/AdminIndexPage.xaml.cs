using Airlines.database;
using Airlines.models;
using Airlines.utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
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

namespace Airlines.views.pages.admin
{
    
    public partial class AdminIndexPage : Page
    {
        DatabaseContext database;

        public AdminIndexPage()
        {
            InitializeComponent();

            database = DatabaseContext.GetInstance();

            LoadData();
        }

        private void LoadData()
        {
            List<Office> offices = database.Offices.ToList();

            Office allOffices = new Office { ID = -1, Title = "Все офисы" };

            offices.Add(allOffices);

            cbOffices.ItemsSource = offices;
            cbOffices.SelectedValue = allOffices;

            LoadUsersByOffice(allOffices);
        }

        private void LoadUsersByOffice(Office office)
        {
            List<User> users = new List<User>();

            if(office.ID == -1)
            {
                users = database.Users.ToList();
            }
            else
            {
                users = database.Users.Where(u => u.OfficeID == office.ID).ToList();
            }

            dgUsers.ItemsSource = users;
        }

        private void cbOffices_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Office office= ((ComboBox)sender).SelectedValue as Office;

            LoadUsersByOffice(office); 
        }

        private void MenuExit_Click(object sender, RoutedEventArgs e)
        {
            TemporaryStorage temporaryStorage = TemporaryStorage.GetInstance();

            Session session = temporaryStorage.Data["Session"] as Session;

            string loginDateTime = $"{session.Date} {session.LoginTime}";
            TimeSpan timeSpent = DateTime.Now - DateTime.ParseExact(loginDateTime, "MM.dd.yyyy HH:mm",
                CultureInfo.InvariantCulture);

            session.LogoutTime = DateTime.Now.ToShortTimeString();
            session.TimeSpentOnSystem = timeSpent.ToString("hh\\:mm");

            database.Sessions.AddOrUpdate(session);
            database.SaveChanges();

            temporaryStorage.Dispose();

            MainWindow.Frame.Navigate(new AuthorizationPage());
        }

        private void MenuAddUser_Click(object sender, RoutedEventArgs e)
        {
            AddUserWindow addUserWindow = new AddUserWindow();

            if(addUserWindow.ShowDialog() == true)
            {
                Office office = cbOffices.SelectedValue as Office;

                LoadUsersByOffice(office);
            }
            
        }

        private void btnEditRole_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = dgUsers.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Пользователь не выбран");

                return;
            }

            TemporaryStorage.GetInstance().Data.Add("EditUser", selectedUser);

            EditUserWindow editUserWindow = new EditUserWindow();
            if(editUserWindow.ShowDialog() == true)
            {
                Office office = cbOffices.SelectedValue as Office;

                LoadUsersByOffice(office);
            }
        }

        private void btnEnableLogin_Click(object sender, RoutedEventArgs e)
        {
            User selectedUser = dgUsers.SelectedItem as User;

            if (selectedUser == null)
            {
                MessageBox.Show("Пользователь не выбран");

                return;
            }

            selectedUser.Active = !selectedUser.Active;

            database.Users.AddOrUpdate(selectedUser);
            database.SaveChanges();

            Office office = cbOffices.SelectedValue as Office;

            LoadUsersByOffice(office);
        }
    }
}
