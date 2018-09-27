using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tidanSQL.Models.Application;
using tidanSQL.Models.Datasource; // temp

namespace tidanSQL.Models.FileHelper
{
    static class FileHelper
    {
        public static String GetAppFolder()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + tidanConst.AppFolder;
            try
            {
                if (!(Directory.Exists(path)))
                    Directory.CreateDirectory(path);
            } catch(IOException e) {
                throw e; // todo: app exception handling
            }
            return path;
        }

        public static String GetConnectionFilepath()
        {
            return GetAppFolder() + "\\" + tidanConst.ConnectionFilename;
        }

        // temp
        public static void SaveDatasource(CustomDatasource datasource) // todo: IDatasource
        {
            // simple save to xml file
            // todo: stream
            System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(CustomDatasource));
            System.IO.FileStream file = System.IO.File.Create(GetConnectionFilepath());

            writer.Serialize(file, datasource);
            file.Close();
        }

        public static CustomDatasource LoadDatasource()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(CustomDatasource));
            System.IO.FileStream file = System.IO.File.Create(GetConnectionFilepath());

            CustomDatasource res = (CustomDatasource)reader.Deserialize(file);
            return res;
        }
    }
}
