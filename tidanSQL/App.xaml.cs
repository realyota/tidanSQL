using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Data.Odbc;
using System.Data.Common;
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
        private static OdbcConnection FCon;

        public static CustomDatasource Datasource { get => FDatasource; }

        void Application_Start(object sender, StartupEventArgs args)
        {
            InitializeConnectionList();
            if (Datasource != null) // for testing purposes only
                Connect(Datasource);
        }

        public void InitializeConnectionList()
        {
            if (File.Exists(FileHelper.GetConnectionFilepath()))
               FDatasource = FileHelper.LoadDatasource();   // for testing purposes only
        }

        public Boolean Connect(CustomDatasource Datasource)
        {
            //OdbcConnection con = new OdbcConnection(Datasource.conString);
            OdbcConnection con = new OdbcConnection("Driver={PostgreSQL Unicode(x64)};Server=127.0.0.1;Port=5432;Database=postgres;Uid=postgres;Pwd=postgres;");
            try
            {
                con.Open();
                // yuuugh
                FCon = con;
                return true;
            } catch (OdbcException e) {

                Console.WriteLine("connection to the DSN '" + Datasource.conString + "' failed");
                Console.WriteLine("The OdbcConnection returned the following message: ");
                Console.WriteLine(e.Message);
                return false;
            }


        }

        public static int ExecuteQuery(String query)
        {
            OdbcCommand DbCommand = FCon.CreateCommand(); // yuuugh
            DbCommand.CommandText = query;
            try
            {
                OdbcDataReader DbReader = DbCommand.ExecuteReader();
                return DbReader.RecordsAffected;
            }
            catch (OdbcException e)
            {
                Console.WriteLine("Executing the query '" + query + "' failed.");
                Console.WriteLine("The OdbcCommand returned the following message");
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public void SaveConnectionList()
        {

        }

    }

    
}
