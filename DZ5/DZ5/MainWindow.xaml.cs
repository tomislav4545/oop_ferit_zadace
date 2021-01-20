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
            List<ShowModel> shows = ShowProcessor.LoadShows(searchQuarey);
            ListOfShows.ItemsSource = shows;
        }
        private void textBoxTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Enter))
            {
                Button_Clicked(this, new RoutedEventArgs());
            }
        }

        private void showMoreInfo(object sender, EventArgs e)
        {
            ShowInfoWindow window = new ShowInfoWindow((ShowModel)ListOfShows.SelectedItem);
            window.Show();
        }
    }
        
}
