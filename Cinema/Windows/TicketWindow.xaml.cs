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
using Cinema.DB;
using Cinema.Pages;
using IronBarCode;

namespace Cinema.Windows
{
    /// <summary>
    /// Логика взаимодействия для TicketWindow.xaml
    /// </summary>
    public partial class TicketWindow : Window
    {
        public static Seans seans1 { get; set; } = new Seans();
        public TicketWindow(FirstHollPage.MestoRyad keyM, Seans seans)
        {
            InitializeComponent();
            GeneratedBarcode barcode = IronBarCode.BarcodeWriter.CreateBarcode("https://kinomax.ru/kazan", BarcodeEncoding.QRCode);
            barcode.AddAnnotationTextAboveBarcode("Hi");
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SaveAsPng("barcode.png");
            imgCode.Source = new BitmapImage(new Uri("C:\\Users\\ASUS\\source\\repos\\Cinema\\Cinema\\bin\\Debug\\barcode.png"));
            mestoTb.Text = keyM.Mesto;
            ryadTb.Text = keyM.Ryad;
            seans1 = seans;
            this.DataContext = this;
        }
    }
}
