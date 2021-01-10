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

namespace ArreyTelefonnummer
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

        private void btntelefonnummer_Click(object sender, RoutedEventArgs e)
        {
            int[] nummer = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            string telnummer;
            bool istelnummer=true;
            if(istelnummer)
            {
                telnummer = "(" + nummer[0] + nummer[1] + nummer[2] + ")" + nummer[3] + nummer[4] + nummer[5] + "-" + nummer[6] + nummer[7] + nummer[8] + nummer[9];
                MessageBox.Show($"{telnummer}");
            }
            
        }

       
    }
}
