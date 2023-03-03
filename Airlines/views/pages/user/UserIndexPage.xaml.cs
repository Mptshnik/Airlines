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

namespace Airlines.views.pages.user
{
    
    public partial class UserIndexPage : Page
    {
        private DatabaseContext database;
        private TemporaryStorage temporaryStorage;
        private Session currentSession;

        public UserIndexPage()
        {
            InitializeComponent();

            database = DatabaseContext.GetInstance();
            temporaryStorage = TemporaryStorage.GetInstance();

            currentSession = temporaryStorage.Data["Session"] as Session;

            Welcome();
            LoadData();
        }

        private void LoadData()
        {
            int currentUserID = (temporaryStorage.Data["User"] as User).ID;

            List<Session> sessions = database.Sessions
                .Where(s => s.ID != currentSession.ID)
                .Where(s => s.UserID == currentUserID)
                .OrderByDescending(s => s.Date)
                .ThenByDescending(s => s.LoginTime)
                .ToList();

            TimeSpan timeSpentOnSystem = TimeSpan.Zero;
            foreach(Session session in sessions)
            {
                if(session.TimeSpentOnSystem == null)
                {
                    continue;
                }

                var timeSpan = TimeSpan.ParseExact(session.TimeSpentOnSystem, "hh\\:mm", CultureInfo.InvariantCulture);
                timeSpentOnSystem += timeSpan;
            }


            tbTimeSpent.Text = $"Time spent on system : {timeSpentOnSystem.ToString("dd\\:hh\\:mm")}";
            dgSessions.ItemsSource = sessions;
        }

        private void Welcome()
        {
            string name = temporaryStorage.Data["FirstName"].ToString();
            tbWelcome.Text = $"Hi {name}, Welcome to AMONIC Airlines.";
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
    }
}
