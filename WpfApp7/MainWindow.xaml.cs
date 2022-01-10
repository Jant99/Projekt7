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

        public void Dodaj_czytelnika(string imie, string nazwisko)
        {
            int id = Tabela_czyt.Items.Count + 1;
            Czytelnik czytelnik = new Czytelnik();
            czytelnik.Name = imie;
            czytelnik.Surname = nazwisko;
            czytelnik.ID = id;
            Tabela_czyt.Items.Add(czytelnik);
            Tabela_czyt.Items.Refresh();
        }

        public void Dodaj_ksiazke(string tytul, string autor)
        {
            int id = Tabela_ksiag.Items.Count + 1;
            Książka ksiazka = new Książka();
            ksiazka.Tytuł = tytul;
            ksiazka.Autor = autor;
            ksiazka.ID = id;
            Tabela_ksiag.Items.Add(ksiazka);
            Tabela_ksiag.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
