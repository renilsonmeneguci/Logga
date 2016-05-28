using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logga.Data
{
    public class LoggaOptions
    {
        public String ConnectionString { get; set; }
        public Boolean CreateSchema { get; set; }
        public Boolean CreateTables { get; set; }
        public Boolean HavePermission { get; set; }
        //public Boolean SendEmail { get; set; }
        //public String Receiver { get; set; }
    }
}