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
using tidanSQL.Views;

namespace tidanSQL
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

        private void miNewConnection_Click(object sender, RoutedEventArgs e)
        {
            // open new connection from
            NewConnection nc = new NewConnection();
            nc.ShowDialog();            
        }

        private void miNewQuery_Click(object sender, RoutedEventArgs e)
        {
            // open new query form
            QueryView qv = new QueryView();
            qv.ShowDialog();
        }
    }
}
