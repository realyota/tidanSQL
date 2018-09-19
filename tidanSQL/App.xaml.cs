using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using tidanSQL.Models.Application;

namespace tidanSQL
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        void Application_Start(object sender, StartupEventArgs args)
        {
            InitializeConnectionList();
        }

        public void InitializeConnectionList()
        {
            
        }

        public void SaveConnectionList()
        {

        }

    }

    
}
