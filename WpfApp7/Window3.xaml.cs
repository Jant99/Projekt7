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
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Logika interakcji dla klasy Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            ((MainWindow)Application.Current.MainWindow).Wypelnij_liste(Booklist);
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string id_czytelnika = id.Text;
            string id_ksiazki = Booklist.SelectedItem.ToString();
        }
    }
}
