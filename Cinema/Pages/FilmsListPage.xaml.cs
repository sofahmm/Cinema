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
using Cinema.DB;

namespace Cinema.Pages
{
    /// <summary>
    /// Логика взаимодействия для FilmsListPage.xaml
    /// </summary>
    public partial class FilmsListPage : Page
    {
        public static List<Film> films { get; set; }
        public static List<Seans> seans { get; set; }
        public FilmsListPage()
        {
            InitializeComponent();
            dateTb.DisplayDateStart = DateTime.Now;
            dateTb.DisplayDateEnd = DateTime.Now.AddDays(2);
            seans = new List<Seans>(BDConnection.cinemaEntities.Seans.Where(i => i.Date == DateTime.Today).ToList());
            films = new List<Film>(BDConnection.cinemaEntities.Film.ToList());
            this.DataContext = this;
        }

        private void dateTb_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var d = dateTb.SelectedDate;
            filmLv.ItemsSource = new List<Seans>(BDConnection.cinemaEntities.Seans.Where(i => i.Date == d).ToList());
        }

        private void addFilm_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddFilmPage());
        }

        private void filmLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var f = filmLv.SelectedItem as Seans;
            NavigationService.Navigate(new FirstHollPage(f));
        }

        private void nameFilmSortCb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Film n = nameFilmSortCb.SelectedItem as Film;
            filmLv.ItemsSource = new List<Seans>(BDConnection.cinemaEntities.Seans.Where(i => i.IdFilm == n.Id).ToList());
        }
    }
}
