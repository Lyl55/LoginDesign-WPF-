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

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cmbbox(object sender, RoutedEventArgs e)
        {
            string[] Array = new string[]
            {
                "Month",
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            box.ItemsSource = Array;
            box.SelectedIndex = 0;
            
        }

        private void Cmbbox2(object sender, RoutedEventArgs e)
        {
            object[] Array2 = new Object[]
            {
                "Day",1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28,
                29, 30, 31
            };
            box2.ItemsSource = Array2;
            box2.SelectedIndex = 0;
        }

        private void Cmbbox3(object sender, RoutedEventArgs e)
        {
            object[] Array3 = new object[]
            {
                "Year",
                2021,
                2020,2019,2018,2017,2016,2015,2014,2013,2012,2011,
                2010,2009,2008,2007,2006,2005,2004,2003,2002,2001,
                2000,1999,1998,1997,1996,1995,1994,1993,1992,1991,
                1990,1989,1988,1987,1986,1985,1984,1983,1982,1981,
                1980,1979,1978,1977,1976,1975,1974,1973,1972,1971,
                1970,1969,1968,1967,1966,1965,1964,1963,1962,1961,
                1960,1959,1958,1957,1956,1955,1954,1953,1952,1951,
                1950,1949,1948,1947,1946,1945,1944,1943,1942,1941,
                1940,1939,1938,1937,1936,1935,1934,1933,1932,1931,
                1930,1929,1928,1927,1926,1925,1924,1923,1922,1921
            };
            box3.ItemsSource = Array3;
            box3.SelectedIndex = 0;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
