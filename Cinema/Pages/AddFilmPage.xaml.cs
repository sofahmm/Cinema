using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Cinema.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddFilmPage.xaml
    /// </summary>
    public partial class AddFilmPage : Page
    {
        Film film = new Film();
        public AddFilmPage()
        {
            InitializeComponent();
        }

        private void addPostrBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter="*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };
            if (openFile.ShowDialog().GetValueOrDefault())
            {
                film.Poster = File.ReadAllBytes(openFile.FileName);
                posterFilm.Source = new BitmapImage(new Uri(openFile.FileName));
            }
        }

        private void saveFilmBtn_Click(object sender, RoutedEventArgs e)
        {
            film.Name = nameTb.Text.Trim();
            film.Description = descriptionTb.Text.Trim();
            film.Duration = Convert.ToInt32(durationTb.Text.Trim());
            film.AgeStop = Convert.ToInt32(ageStopTb.Text.Trim());
            BDConnection.cinemaEntities.Film.Add(film);
            BDConnection.cinemaEntities.SaveChanges();
            NavigationService.Navigate(new FilmsListPage());
        }
    }
}
