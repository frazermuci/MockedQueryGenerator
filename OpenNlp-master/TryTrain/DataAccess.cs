using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    class DataAccess
    {
        public static string query(Query query)
        {
            //logic to handle query
            return query.attributeMap["fileName"].Item1;
        }
    }
}
