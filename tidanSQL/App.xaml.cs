using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using tidanSQL.Models.Application;
using tidanSQL.Models.FileHelper;
using tidanSQL.Models.Datasource;

namespace tidanSQL
{
    /// <summary>
    /// Logika interakcji dla klasy App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static CustomDatasource FDatasource;

        public static CustomDatasource Datasource { get => FDatasource; }

        void Application_Start(object sender, StartupEventArgs args)
        {
            InitializeConnectionList();
        }

        public void InitializeConnectionList()
        {
            if (File.Exists(FileHelper.GetConnectionFilepath()))
                FDatasource = FileHelper.LoadDatasource();
        }

        public void SaveConnectionList()
        {

        }

    }

    
}
