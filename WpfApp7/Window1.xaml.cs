﻿using System;
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
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Imie = name.Text;
            string Nazwisko = surname.Text;
            ((MainWindow)Application.Current.MainWindow).Dodaj_czytelnika(Imie, Nazwisko);
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
