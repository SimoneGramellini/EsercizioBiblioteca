using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBiblioteca
{
    class Libro
    {
        //ATTRIBUTI
        string autore;
        string titoloLibro;
        int annoPubblicazione;
        string editore;
        int numeroPag;

        //COSTRUTTORE
        public Libro(string autor, string title, int pubblication, string editor, int pag )
        {
            autore = autor;
            titoloLibro = title;
            annoPubblicazione = pubblication;
            editore = editor;
            numeroPag = pag;
        }

        //PROPRIETA'
        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

        public string TitoloLibro
        {
            get { return titoloLibro; }
            set { titoloLibro = value; }
        }

        public int AnnoPubblicazione
        {
            get { return annoPubblicazione; }
            set { annoPubblicazione = value; }
        }

        public string Editore
        {
            get { return editore; }
            set { editore = value; }
        }

        public int NumeroPag
        {
            get { return numeroPag; }
            set { numeroPag = value; }
        }

        //METODI DI CLASSE

        public string ToString (Libro x)
        {
            string dati;
            dati = (x.autore + " " + x.titoloLibro + " " + x.annoPubblicazione + " " + x.editore + " " + x.numeroPag);
            return dati;
        }

        public string ReadingTime (Libro x)
        {
            string tempoLettura = " ";

            if (x.numeroPag < 100)
            {
                tempoLettura = "tempo lettura = 1h";
            }
            if (x.numeroPag >= 100 && x.numeroPag < 200)
            {
                tempoLettura = "tempo lettura = 2h";
            }
            if (x.numeroPag >= 200)
            {
                tempoLettura = "tempo lettura > 2h";
            }

            return tempoLettura;
        }



    }
    
}
