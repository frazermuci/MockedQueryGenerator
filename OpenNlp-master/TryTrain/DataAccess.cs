using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    public interface DataAccessDB
	{	
        public string query(Query query);
    }
}
