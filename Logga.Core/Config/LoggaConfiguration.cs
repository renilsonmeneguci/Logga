using Logga.DataBases;
using Logga.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logga
{
    public class LoggaConfiguration
    {
        public static String _connectionString;
        public static LoggaOptions LoggaOptions;

        public static void UseSqlServerData(LoggaOptions options)
        {
            if(options == null) throw new ArgumentNullException("options");

            var sql = new UseSqlServer(options);
            _connectionString = options.ConnectionString;
            LoggaOptions = options;
            //_sendEmail = options.SendEmail;
            //_receiver = options.Receiver;
        }
    }
}