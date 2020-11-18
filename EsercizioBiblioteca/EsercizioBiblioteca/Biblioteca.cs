using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioBiblioteca
{
    class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private DateTime _orario; //problema di gestione degli orari di entrata e uscita, il programma lo gestisce bene nel main, ma il problema è risolvibile cambiando la classe Biblioteca mettendo due attributi OrarioApertura e OrarioChiusura
        private List<Libro> _lstLibri;

        public Biblioteca (string nome, string indirizzo, DateTime orario, List<Libro> lstLibri)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            Orari = orario;
            LstLibri = lstLibri;
        }

        public List<Libro> LstLibri
        {
            get
            {
                return _lstLibri;
            }
            set
            {

                _lstLibri = value;
            }
        }
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    new Exception("errore nome");
                _nome = value;
            }
        }

        public string Indirizzo
        {
            get
            {
                return _indirizzo;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    new Exception("errore indirizzo");
                _indirizzo = value;
            }
        }

        public DateTime Orari
        {
            get
            {
                return _orario;
            }
            set
            {


                _orario = value;
            }
        }

        public void AggiungiLibro(Libro libro)
        {
            try
            {
                LstLibri.Add(libro);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public string RicercaLibro(string nomeLibro)
        {
            try
            {

                foreach (Libro libro in LstLibri)
                {
                    if (libro.Autore == nomeLibro)
                    {
                        return libro.ToString();
                    }
                }
                return "libro non trovato";

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public string RicercaLibriAutore(string nomeAutore)
        {
            try
            {
                foreach (Libro libro in LstLibri)
                {
                    if (libro.Autore == nomeAutore)
                    {
                        return libro.ToString();
                    }
                }
                return "autore non trovato";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int NumeroLibri()
        {
            try
            {
                return LstLibri.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }

}
