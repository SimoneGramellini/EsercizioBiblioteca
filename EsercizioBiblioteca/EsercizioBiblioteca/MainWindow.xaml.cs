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

namespace EsercizioBiblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Libro libro;
        Biblioteca biblioteca;
        List<Libro> libri;
        public MainWindow()
        {
            InitializeComponent();

            biblioteca = new Biblioteca("biblioteca malatestiana", "via piave 16", DateTime.Now, libri);
        }

        private void btnCreaLibro_Click(object sender, RoutedEventArgs e)
        {
            libro = new Libro(txtAutore.Text, txtTitolo.Text, int.Parse(txtAnnoPubblicazione.Text), txtEditore.Text, int.Parse(txtNumeroPagine.Text));
            biblioteca.AggiungiLibro(libro);
            lstLibri.Items.Clear();
            foreach(Libro libro in biblioteca.LstLibri)
            {
                lstLibri.Items.Add(libro.ToString());
            }
            lblNumeroLibri.Content = biblioteca.NumeroLibri();
        }

        private void btnCercaLibro_Click(object sender, RoutedEventArgs e)
        {
            lblCercaLibro.Content = biblioteca.RicercaLibro(txtRicercaNomeLibro.Text);
        }

        private void btnCercaLibri_Click(object sender, RoutedEventArgs e)
        {
            lblCercaLibro.Content = biblioteca.RicercaLibriAutore(txtRicercaLibriAutore.Text);
        }
    }
}
