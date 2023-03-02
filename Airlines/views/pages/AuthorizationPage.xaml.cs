using Airlines.database;
using Airlines.models;
using Airlines.utils;
using Airlines.views.pages.admin;
using Airlines.views.pages.user;
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

namespace Airlines.views.pages
{
   
    public partial class AuthorizationPage : Page
    {
        DatabaseContext database;

        public AuthorizationPage()
        {
            InitializeComponent();

            database = DatabaseContext.GetInstance();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string email = username.Text;
            string pwd = password.Password;

            User user = database.Users.Where(u => u.Email == email && u.Password == pwd).FirstOrDefault();

            if(user == null)
            {
                MessageBox.Show("Не правильно введен логин или пароль");

                return;
            }

            TemporaryStorage temporaryStorage = TemporaryStorage.GetInstance();

            temporaryStorage.Data.Add("FirstName", user.FirstName);
            Session session = new Session()
            {
                Date = DateTime.Today.ToShortDateString(),
                LoginTime = DateTime.Now.ToShortTimeString(),
                User = user
            };

            session = database.Sessions.Add(session);
            database.SaveChanges();

            temporaryStorage.Data.Add("Session", session);
             
            if(user.Role.Title == "User")
            {
                MainWindow.Frame.Navigate(new UserIndexPage());
            }
            else
            {
                MainWindow.Frame.Navigate(new AdminIndexPage());
            }

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }
    }
}
