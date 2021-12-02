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

namespace WpfApp7
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Czytelnik
        {
            public string Name;
            public string Surname;
            public int ID;
        }

        public class Książka
        {
            public string Tytuł;
            public string Autor;
            public int ID;
            public int u_kogo;
        }

        private void Dodaj_czytelnika(string imie, string nazwisko, int id)
        {
            Czytelnik czytelnik = new Czytelnik();
            czytelnik.Name = imie;
            czytelnik.Surname = nazwisko;
            czytelnik.ID = id;
            Tabela_czyt.Items.Add(czytelnik);
        }

        private void Dodaj_ksiazke(string tytul, string autor, int id)
        {
            Książka ksiazka = new Książka();
            ksiazka.Tytuł = tytul;
            ksiazka.Autor = autor;
            ksiazka.ID = id;
            Tabela_ksiag.Items.Add(ksiazka);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
