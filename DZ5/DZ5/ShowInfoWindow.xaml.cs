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
using System.Windows.Shapes;
using ApiUtilities;

namespace DZ5
{
    /// <summary>
    /// Interaction logic for ShowInfoWindow.xaml
    /// </summary>
    public partial class ShowInfoWindow : Window
    {
        public ShowInfoWindow(ShowModel show)
        {
            InitializeComponent();
            ShowName.Text = show.Show.Name;
            Summary.Text = show.Show.Summary;
            List<SeasonModel> seasons = SeasonProcesor.LoadSeasons(show.Show.Id);
            Seasons.ItemsSource = seasons;
            
        }
    }
}
