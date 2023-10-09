using System;
using System.Collections.Generic;
using System.Data;
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

namespace WpfXmlDataSEt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }



        private void CdbVerwaltung_Click(object sender, RoutedEventArgs e)
        {
            Bibverwaltung bibverwaltung = new Bibverwaltung();
            bibverwaltung.Show();
        }

        private void CdbAusleihe_Click(object sender, RoutedEventArgs e)
        {
            Ausleihe ausleihe = new Ausleihe();
            ausleihe.Show();
        }

        private void CdbRückgabe_Click(object sender, RoutedEventArgs e)
        {
            Rückgabe rückgabe = new Rückgabe();
            rückgabe.Show();
        }

        private void CdbSchließen_Click(object sender, RoutedEventArgs e)
        {
            Close();

        }
    }
}
