using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace tidanSQL.Models.DataSource
{
    interface IDatasource
    {
        String ConName { get; set; }
        String ConString { get; set; }
    }

    // todo: savable interface
    /* interface ISavable
    {
        void Save(ISaveWorker AWorker);
    } */

    [Serializable]
    class CustomDatasource : IDatasource//, ISavable
    {
        public string ConName { get; set; }
        public string ConString { get; set; }
    }
}
