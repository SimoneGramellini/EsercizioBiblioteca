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

        public Biblioteca Biblioteca(string nome,string indirizzo,DateTime orario,List<Libro> lstLibri)
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
            }catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void RicercaLibro(Libro libro)
        {
            try
            {
                if (LstLibri.Contains(libro))
                    return libro;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public void RicercaLibriAutore(Libro autore)
        {
            try
            {
                if (LstLibri.Contains(autore))
                    return autore;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void NumeroLibri()
        {
            try
            {
                return LstLibri.Count;
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}