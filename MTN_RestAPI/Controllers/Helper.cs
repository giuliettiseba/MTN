using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MTN_RestAPI.Controllers
{
    public class Helper
    {

        public static string CnnVal(String name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }









    }
}