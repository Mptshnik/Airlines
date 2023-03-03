using Airlines.database;
using Airlines.models;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Airlines.views
{
    public partial class AddUserWindow : Window
    {
        DatabaseContext database;

        public AddUserWindow()
        {
            InitializeComponent();

            database = DatabaseContext.GetInstance();

            LoadData();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(tbBirthdate.Text == string.Empty || tbEmail.Text == string.Empty || tbFirstName.Text == string.Empty
                || tbLastName.Text == string.Empty || tbPassword.Text == string.Empty || cbOffices.SelectedValue == null)
            {
                MessageBox.Show("Все поля должны быть заполнены");

                return;
            }

            DateTime birthdate = DateTime.Now;
            try
            {
                birthdate = DateTime.ParseExact(tbBirthdate.Text, "mm\\.dd\\.yyyy", CultureInfo.InvariantCulture);
            }
            catch 
            {
                MessageBox.Show("Не удалось получить дату рождения");

                return;
            }
            

            User user = new User 
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Email = tbEmail.Text,
                Password = tbPassword.Text,
                Birthdate = birthdate,
                Active = true,
                Office = cbOffices.SelectedValue as Office
            };

            database.Users.Add(user);
            database.SaveChanges();

            DialogResult = true;
        }

        private void LoadData()
        {
            List<Office> offices = database.Offices.ToList();
            cbOffices.ItemsSource = offices;
        }
    }
}
