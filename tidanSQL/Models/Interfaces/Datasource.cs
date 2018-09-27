using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace tidanSQL.Models.Datasource
{
    interface IDatasource
    {
        String conName { get; set; }
        String conString { get; set; }
    }

    // todo: savable interface
    /* interface ISavable
    {
        void Save(ISaveWorker AWorker);
    } */

    [Serializable]
    public class CustomDatasource : IDatasource//, ISavable
    {
        public CustomDatasource() { }
        public CustomDatasource(String conName, String conString) {
            this.conName = conName;
            this.conName = conString;
        }
        
        public string conName { get; set; }
        public string conString { get; set; }
    }
}
