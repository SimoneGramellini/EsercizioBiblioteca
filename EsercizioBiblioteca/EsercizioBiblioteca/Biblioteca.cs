using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EsercizioBiblioteca
{
    public class Biblioteca
    {
        private string _nome;
        private string _indirizzo;
        private DateTime _orario;
        private List<Libro> _lstLibri;

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
            LstLibri.Add(libro);
        }

        public void RicercaLibro(Libro libro)
        {
            if (LstLibri.Contains(libro))
                return libro;
        }

        public void RicercaLibriAutore(Libro autore)
        {
            if (LstLibri.Contains(autore))
                return autore;
        }

        public void NumeroLibri()
        {
            return LstLibri.Count;
        }
    }
}