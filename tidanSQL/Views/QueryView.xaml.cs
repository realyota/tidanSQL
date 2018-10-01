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
using tidanSQL.Models.Application;

namespace tidanSQL.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class QueryView : Window
    {
        public QueryView()
        {
            InitializeComponent();
        }

        private void rtQuery_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                // test
                string richText = new TextRange(rtQuery.Document.ContentStart, rtQuery.Document.ContentEnd).Text;

                ((RichTextBox)sender).AppendText(
                      "    --- rows: " + App.ExecuteQuery(richText).ToString()
                );
            }
        }
    }
}
