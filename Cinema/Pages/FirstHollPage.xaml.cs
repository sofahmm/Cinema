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

namespace Cinema.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstHollPage.xaml
    /// </summary>
    public partial class FirstHollPage : Page
    {
        public FirstHollPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            MessageBox.Show(BtnSen.Content.ToString());
            //условие с мессдж боксом что в бд уже не занято 
            if (BtnSen.Background != Brushes.Orange)
                BtnSen.Background = Brushes.Orange;
            else
                BtnSen.Background = Brushes.White;
            string KeyR = BtnSen.Content.ToString().Split(':')[0];
            string KeyM = BtnSen.Content.ToString().Split(':')[1];
            MessageBox.Show(KeyM, KeyR);

        }

        private void childBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void saleBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void barBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
