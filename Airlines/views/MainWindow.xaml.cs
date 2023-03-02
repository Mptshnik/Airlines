using Airlines.database;
using Airlines.models;
using Airlines.utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace Airlines
{
    
    public partial class MainWindow : Window
    {
        public static Frame Frame;
        private DatabaseContext database;
        public MainWindow()
        {
            InitializeComponent();

            database = DatabaseContext.GetInstance();

            Frame = MainFrame;

            Closed += MainWindow_Closed;
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            
        }
    }
}
