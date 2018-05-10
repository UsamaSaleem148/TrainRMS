using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RMS
{
    class Connection
    {
        string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString();
        public string Connect()
        {
            return conStr;
        }
    }
}
