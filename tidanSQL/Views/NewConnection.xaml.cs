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
using tidanSQL.Models.FileHelper;
using tidanSQL.Models.Datasource;

namespace tidanSQL.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class NewConnection : Window
    {
        public NewConnection()
        {
            InitializeComponent();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {            
            SaveDatasource(tbConName.Text, tbConString.Text);
        }

        public void SaveDatasource(String conName, String conString)
        {            
            FileHelper.SaveDatasource(
                new CustomDatasource
                (
                   conName,
                   conString
                )
            );
        }
    }
}
