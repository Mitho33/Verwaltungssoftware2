using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfXmlDataSEt
{
    class Buch
    {
        protected string iD;//Eigenschaften ohne Ausprägung
        protected string autor;
        protected string titel;
        protected  string signatur;
        protected string person;
        protected DateTime datum;

        public string ID//Eigenschaftsmethoden
        {
            get
            {
                return iD;//Kopie lesen
            }
            set
            {
                iD = value;//Kopie überschreiben
            }
        }

        public string Autor

        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }


        public string Titel

        {
            get
            {
                return titel;
            }

            set
            {
                titel = value;
            }
        }

        public string Signatur
        {
            get
            {
                return signatur;
            }
            set
            {
                signatur = value;
            }
        }

        public string Person

        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public Buch()//leerer Konstruktor
        {

        }
    }
}

