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

        public void MonthlySalesReport_Click(object sender, RoutedEventArgs args)
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

        public void TopTenAttractions_Click(object sender, RoutedEventArgs args)
        {
            uxReportList.Items.Clear();
            SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

            List<string> topTenAttractions = (List<string>)executor.ExecuteReader(new AgencyTopTenAttractionsDelegate());

            uxReportListLabel.Content = "ID, Attraction, Number of Customers, City, Country, Ticket Price";
            if(topTenAttractions.Count > 0)
            {
                foreach(string row in topTenAttractions)
                {
                    TextBlock t = new TextBlock();
                    t.Text = row;
                    uxReportList.Items.Add(t);
                }
            }
        }

        public void AgeReport_Click(object sender, RoutedEventArgs args)
        {
            uxReportList.Items.Clear();
            SqlCommandExecutor executor = new SqlCommandExecutor(connectionString);

            List<string> ageGroups = (List<string>)executor.ExecuteReader(new AgencyAgeReportDelegate());

            uxReportListLabel.Content = $"{Check.Format("Age Group", 12, true)}{Check.Format("Customers", 10, true)}" +
                $"{Check.Format("Ave. Budget", 13, true)}{Check.Format("Low. Budget",13,true)}" +
                $"{Check.Format("High. Budget",13,true)}{Check.Format("Ave. Age",10,true)}" +
                $"{Check.Format("Trip Count",10,true)}";
            if(ageGroups.Count > 0)
            {
                foreach(string row in ageGroups)
                {
                    string[] splitRow = row.Split(',');
                    TextBlock t = new TextBlock();
                    t.Text = $"{Check.Format(splitRow[0], 17, true)}{Check.Format(splitRow[1], 10, true)}" +
                        $"{Check.Format(splitRow[2], 15, true)}{Check.Format(splitRow[3],15,true)}" +
                        $"{Check.Format(splitRow[4],15,true)}{Check.Format(splitRow[5],12,true)}" +
                        $"{Check.Format(splitRow[6],10,true)}";
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

            uxReportListLabel.Content = $"{Check.Format("City, Country", 35, true)}{Check.Format("Cheapest Hotel",30,true)}" +
                $"{Check.Format("Cheapest Attraction",35,true)}";

            if (cheaperOptions.Count > 0)
            {
                foreach(string row in cheaperOptions)
                {
                    string[] splitRow = row.Split('-');
                    TextBlock t = new TextBlock();
                    t.Text = $"{Check.Format(splitRow[0], 35, true)}{Check.Format(splitRow[1],35,true)}" +
                        $"{Check.Format(splitRow[2],35,true)}";
                    uxReportList.Items.Add(t);
                }
            }
        }
    }
}
