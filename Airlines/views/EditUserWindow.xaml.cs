using Airlines.database;
using Airlines.models;
using Airlines.utils;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
   
    public partial class EditUserWindow : Window
    {
        DatabaseContext database;

        public EditUserWindow()
        {
            InitializeComponent();

            database = DatabaseContext.GetInstance();

            Closed += EditUserWindow_Closed;

            LoadData();
        }

        private void EditUserWindow_Closed(object sender, EventArgs e)
        {
            TemporaryStorage.GetInstance().Data.Remove("EditUser");
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            User editUser = TemporaryStorage.GetInstance().Data["EditUser"] as User;
            List<Role> roles = database.Roles.ToList();

            if (rbAdminRole.IsChecked == true)
            {
                editUser.Role = roles.Where(r => r.Title == "Administrator").FirstOrDefault();
            }
            else if (rbUserRole.IsChecked == true)
            {
                editUser.Role = roles.Where(r => r.Title == "User").FirstOrDefault();
            }

            database.Users.AddOrUpdate(editUser);
            database.SaveChanges();

            

            DialogResult = true;
        }

        private void LoadData()
        {
            List<Office> offices = database.Offices.ToList();
            cbOffices.ItemsSource = offices;

            User editUser = TemporaryStorage.GetInstance().Data["EditUser"] as User;

            tbBirthdate.Text = editUser.Birthdate.ToShortDateString();
            tbEmail.Text = editUser.Email;
            tbFirstName.Text = editUser.FirstName;
            tbLastName.Text = editUser.LastName;
            tbPassword.Text = editUser.Password;
            cbOffices.SelectedValue = editUser.Office;

            if (editUser.Role != null)
            {
                if (editUser.Role.Title == "User")
                {
                    rbUserRole.IsChecked = true;
                }
                else
                {
                    rbAdminRole.IsChecked = true;
                }
            }
        }

    }
}
