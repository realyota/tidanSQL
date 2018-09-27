using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tidanSQL.Models.Application
{
    public static class tidanConst
    {
        /// <summary>
        /// Main connection file (stored in application data folder) 
        /// </summary>         
        /// <remarks>
        /// Question: why use => operator instead of = ? in const static definition?
        /// </remarks>
        public static string ConnectionFilename => "connections.xml";
        public static string AppFolder => "tidanSQL";
    }
}
