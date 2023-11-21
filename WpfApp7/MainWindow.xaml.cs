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
            public string Name { get; set; }
            public string Surname { get; set; }
            public int ID { get; set; }
        }

        public class Książka
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int id { get; set; }
            public string u_kogo { get; set; }
        }
        public List<Książka> Lista_książęk { get; set; } = new List<Książka>();

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
            ksiazka.Title = tytul;
            ksiazka.Author = autor;
            ksiazka.id = id;
            ksiazka.u_kogo = "-";
            Tabela_ksiag.Items.Add(ksiazka);
            Lista_książęk.Add(ksiazka);
            Tabela_ksiag.Items.Refresh();
        }

        public void Wypelnij_liste(ListView listview)
        {
            for(int i = 0; i < Lista_książęk.Count; i++) 
            {
                if (Lista_książęk[i].u_kogo == "-")
                    listview.Items.Add(Lista_książęk[i]);
            }
        }
        public void Wypozycz_ksiazke(int ID_ksiazki, int ID_wypozyczajacego)
        {

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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();

        }
    }
}
