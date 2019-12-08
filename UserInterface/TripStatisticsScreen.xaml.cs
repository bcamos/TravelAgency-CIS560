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
using DataAccess;
using DataModeling;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for TripStatisticsScreen.xaml
    /// </summary>
    public partial class TripStatisticsScreen : Page
    {
        private string connectionString;

        public TripStatisticsScreen()
        {
            InitializeComponent();
        }

        public TripStatisticsScreen(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        /// <summary>
        /// Return to the main menu when the user clicks "Main Menu" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void MainMenu_Click(object sender, RoutedEventArgs args)
        {
            NavigationService.GoBack();
        }

        public void Report1_Click(object sender, RoutedEventArgs args)
        {

            uxReportList.Items.Clear();
            SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

            List<string> monthlyDetail = (List<string>)executor.ExecuteReader(new AgencyDetailByMonthDelegate());

            uxReportListLabel.Content = "Month , NumberOfTrips , AverageCustomersPerAgent ,TotalSale";
            if (monthlyDetail.Count > 0)
            {
                foreach (string row in monthlyDetail)
                {
                    TextBlock t = new TextBlock();
                    t.Text = row;
                    uxReportList.Items.Add(t);
                }
            }
        }

        public void Report2_Click(object sender, RoutedEventArgs args)
        {
            // CONNECT
            // query report 2
            // load report 2 into uxReportList
            // set uxReportListLabel of what each column represents
        }

        public void Report3_Click(object sender, RoutedEventArgs args)
        {
            uxReportList.Items.Clear();
            SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

            List<string> ageGroups = (List<string>)executor.ExecuteReader(new AgencyAgeReportDelegate());

            uxReportListLabel.Content = "AgeGroup - Count, Average Budget, Lowest Budget - Highest Budget, Average Age, Trip Count";
            if(ageGroups.Count > 0)
            {
                foreach(string row in ageGroups)
                {
                    TextBlock t = new TextBlock();
                    t.Text = row;
                    uxReportList.Items.Add(t);
                }
            }
        }

        /// <summary>
        /// Cheaper options is the 4th report query which gets displays the cheapest amenities for each city within the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void CheaperOptions_Click(object sender, RoutedEventArgs args)
        {
            uxReportList.Items.Clear();
            SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

            List<string> cheaperOptions = (List<string>)executor.ExecuteReader(new AgencyCheapestOptionsDelegate());

            uxReportListLabel.Content = "City, Country - Cheapest Hotel - Cheapest Attraction";

            if (cheaperOptions.Count > 0)
            {
                foreach(string row in cheaperOptions)
                {
                    TextBlock t = new TextBlock();
                    t.Text = row;
                    uxReportList.Items.Add(t);
                }
            }
        }
    }
}
