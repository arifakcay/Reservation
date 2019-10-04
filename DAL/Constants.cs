using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public class Constants
    {
        internal static string strCon = ConfigurationManager.ConnectionStrings["ReservationDB"].ConnectionString;
    }
}
