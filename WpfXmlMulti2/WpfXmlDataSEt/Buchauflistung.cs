using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfXmlDataSEt
{
    class Buchauflistung
    { 
    DataSet myXmlDataSet;
    DataTable buchTable;
    
        protected ObservableCollection<Buch> buchliste;// Deklaration Dynamische Kollektion mit Objekten der Klasse Buch,  Veränderungen gebundener Controls werden umgesetzt

        public ObservableCollection<Buch> Buchliste//Eigenschaftsmethoden
        {
            get
            {
                return buchliste;
            }

            set
            {
                buchliste = value;
            }
        }

        public Buchauflistung()//Konstruktor
        {
            FillList();//Methodenaufruf      
        }

        public void FillList()
        {
            //füllt Table aus XML-Datei
            myXmlDataSet = new DataSet();
            myXmlDataSet.ReadXml("XMLFile1.xml");
            //myXmlDataSet.ReadXml("XMLFile1.xml");(@"C:\test.xml"
            buchTable = myXmlDataSet.Tables["Buch"];//Buch Knoten
          //füllt Collection aus Table
            if (buchliste == null)//wenn buchliste ohne Wert ist
                buchliste = new ObservableCollection<Buch>();//wird neue Kollektion instanziiert
            foreach (DataRow dr in buchTable.Rows)//für jede Zeile in der Tabelle buchTable
            {//fügt Collection Inhalt aus Cache hinzu
                buchliste.Add(new Buch
                {//Kopie ID erhält den Inhalt aus 1. Zeile und 1 Spalte, ToString liefert den Wert als Zeichenfolge, 
                  //dann die anderen spalten und dann ab in die nächste Zeile mit foreach
                    ID = (dr[0].ToString()),
                    Autor = dr[1].ToString(),
                    Titel = (dr[2].ToString()),
                    Signatur = (dr[3].ToString()),
                    Person = dr[4].ToString(),
                    Datum = Convert.ToDateTime(dr[5].ToString())
                });
                //durch das Binding im View wird aus Collection das DataGrid im View automatisch gefüllt

            }
        }

      public void BuchLöschen(int l)
        {
            try//wichtig Fehlerbehandlung
            {
                //Zähler für die Zeilen im Cache
                for (int i = 0; i < buchTable.Rows.Count; i++)
                {
                    //Wenn Parameter der jeweiligen Zeile gleich Signatur ist, Signatur ist einzigartig, deshalb geeignet zur Identifikation
                    if (l == Convert.ToInt32(buchTable.Rows[i]["Signatur"].ToString()))
                    {
                        buchTable.Rows[i].Delete();//Löschen im Cache
                    }

                }

               
                //Füllt XML aus Table
                buchTable.WriteXml("XMLFile1.xml");//neue XML erzeugt
                buchliste.Clear();//sonst wird der alte und der neue Cache angezeigt
                //DataGrid wird gefüllt      
                foreach (DataRow dr in buchTable.Rows)
                {  //fügt Collection Inhalt aus Cache hinzu
                    buchliste.Add(new Buch
                    {
                        ID = (dr[0].ToString()),
                        Autor = dr[1].ToString(),
                        Titel = (dr[2].ToString()),
                        Signatur = (dr[3].ToString()),
                        Person = dr[4].ToString(),
                        Datum = Convert.ToDateTime(dr[5].ToString())
                    });
                }
                MessageBox.Show("Verbindung erfolgreich");
            }
            catch (Exception ausnahme)
            {
                MessageBox.Show("Fehler: " + ausnahme.Message);
            }
        }

        //Ausleihe
        public void Buchupdate(int u,string a, DateTime dp)
        {
            try
            {
                for ( int i = 0; i < buchTable.Rows.Count; i++)
                {
                    if (u == Convert.ToInt32(buchTable.Rows[i]["Signatur"].ToString())) 
                    {
                        buchTable.Rows[i]["Person"] = a; //Cache wird geändert  
                        buchTable.Rows[i]["Datum"] = dp; //Cache wird geändert  
                    }
                   
                }

              
                buchTable.WriteXml("XMLFile1.xml");//xml
                //DataGrid wird mittels Collection neu gefüllt
                buchliste.Clear();//sonst wird der alte und der neue Cache angezeigt       
                foreach (DataRow dr in buchTable.Rows)
                {  //fügt Collection Inhalt aus Cache hinzu
                    buchliste.Add(new Buch
                    {
                        ID = (dr[0].ToString()),
                        Autor = dr[1].ToString(),
                        Titel = (dr[2].ToString()),
                        Signatur = (dr[3].ToString()),
                        Person = dr[4].ToString(),
                        Datum = Convert.ToDateTime(dr[5].ToString())
                    });
                }
                MessageBox.Show("Verbindung erfolgreich");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }

        public void BuchHinzufügen(string i, string a, string t, string s, string p, DateTime dp)
        {
            try//wichtig Fehlerbehandlung
            {
                DataRow zeile = buchTable.NewRow();//Cache wird verändert
                {
                    zeile[0] = i;
                    zeile[1] = a;
                    zeile[2] = t;
                    zeile[3] = s;
                    zeile[4] = p;
                    zeile[5] = dp;
                    buchTable.Rows.Add(zeile);
                    buchTable.WriteXml("XMLFile1.xml");//xml ergänzt
                    buchliste.Clear();//sonst wird der alte und der neue Cache angezeigt
                    foreach (DataRow dr in buchTable.Rows)
                    { //fügt Collection Inhalt aus Cache hinzu
                        buchliste.Add(new Buch
                        {
                            ID = (dr[0].ToString()),
                            Autor = dr[1].ToString(),
                            Titel = (dr[2].ToString()),
                            Signatur = (dr[3].ToString()),
                            Person = dr[4].ToString(),
                            Datum = Convert.ToDateTime(dr[5].ToString())
                        });
                    }

                    MessageBox.Show("Verbindung erfolgreich");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }


    }
}
