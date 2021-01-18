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
using System.Net;
using System.IO;
using ApiUtilities;

namespace DZ5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();                      
        }
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            string searchQuarey = SearchQuarey.Text;
            List<Root> shows = ShowProcessor.LoadShows(searchQuarey);
            ListOfShows.ItemsSource = shows;        
        }

        private void MoreInfoButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
