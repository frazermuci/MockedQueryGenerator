using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    public interface DataAccess
    {
       string query(Query query);
    }
}
