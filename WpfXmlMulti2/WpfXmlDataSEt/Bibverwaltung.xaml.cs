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

namespace WpfXmlDataSEt
{
    /// <summary>
    /// Interaktionslogik für Bibverwaltung.xaml
    /// </summary>
    public partial class Bibverwaltung : Window
    {
        public Bibverwaltung()
        {
            InitializeComponent();
            co = new Buchauflistung();
            DataContext = co;
        }

        Buchauflistung co;


        private void CdbHinzufügen_Click(object sender, RoutedEventArgs e)
        {
            co = new Buchauflistung();
            co.BuchHinzufügen(TbId.Text, TbAutor.Text, TbTitel.Text,
              (TbSignatur.Text), TbPerson.Text,
                Convert.ToDateTime(DpDatum.Text));
            DataContext = co;
        }

        private void CdbLöschen_Click(object sender, RoutedEventArgs e)
        {
            co = new Buchauflistung();
            co.BuchLöschen(Convert.ToInt32(TbLöschen.Text));
            DataContext = co;
        }

        private void CdbZurück_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
