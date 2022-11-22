using Cinema.DB;
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
using Cinema.Windows;
using System.Net.Sockets;

namespace Cinema.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstHollPage.xaml
    /// </summary>
    public partial class FirstHollPage : Page
    {
        public static Seans seans = new Seans();
        MestoRyad KeyM = new MestoRyad();
        List<Ticket> TicketList = new List<Ticket>(BDConnection.cinemaEntities.Ticket.ToList());

        public FirstHollPage(Seans seans1)
        {
            InitializeComponent();
            //var buttons = ryad7Panel.Children.OfType<Button>().ToList();
            //buttons.ForEach(bth =>
            //{
            //    foreach(var ticket in TicketList)
            //    {
            //        if ( ticket.IdSeans == seans.Id)
            //            gh.Background = Brushes.DarkRed;
                        
            //    }
            //});
            seans = seans1;
            this.DataContext = seans;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            //условие с мессдж боксом что в бд уже не занято 

            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "7";
                    KeyM =  mestoRyad;
                }
            }


        }

        private void childBtn_Click(object sender, RoutedEventArgs e)
        {
            ChildTicketWindow childTicketWindow = new ChildTicketWindow();
            childTicketWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            //условие с мессдж боксом что в бд уже не занято 
            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "6";
                    KeyM =  mestoRyad;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            //условие с мессдж боксом что в бд уже не занято 
            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "5";
                    KeyM =  mestoRyad;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            //условие с мессдж боксом что в бд уже не занято 
            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "4";
                    KeyM =  mestoRyad;
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            //условие с мессдж боксом что в бд уже не занято 
            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "3";
                    KeyM =  mestoRyad;
                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            //условие с мессдж боксом что в бд уже не занято 
            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "2";
                    KeyM =  mestoRyad;
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var BtnSen = (sender as Button);
            foreach (var ticket in TicketList)
            {
                if (ticket.Ryad == 7 && ticket.Mesto == Convert.ToInt32(BtnSen.Content) && ticket.IdSeans == seans.Id)
                    MessageBox.Show("Это место занято, выберите другое!");
                else
                {
                    if (BtnSen.Background != Brushes.BlueViolet)
                        BtnSen.Background = Brushes.BlueViolet;
                    else
                        BtnSen.Background = Brushes.Bisque;
                    //string KeyR = BtnSen.Content.ToString().Split(':')[0];
                    MestoRyad mestoRyad = new MestoRyad();
                    mestoRyad.Mesto = BtnSen.Content.ToString();
                    mestoRyad.Ryad = "1";
                    KeyM =  mestoRyad;
                }
            }

        }

        private void buyBtn_Click(object sender, RoutedEventArgs e)
        {
            Ticket t = new Ticket();
            int f = seans.Id;
          //  t.Seans = f ;
            TicketWindow ticketWindow = new TicketWindow(KeyM, seans);
            ticketWindow.Show();

        }

        public class MestoRyad
        {
            public string Ryad { get; set; }
            public string Mesto { get; set; }
        }
    }
}
