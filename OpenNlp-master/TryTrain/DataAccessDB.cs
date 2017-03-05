using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    public class DataAccessDB : DataAccess
    {
		private ActivAIDDB db;
		
		public DataAccessDB()
		{
			db = new ActivAIDDB();
		}
		
        public string query(Query query)
        {
            //logic to handle query
            //return query.attributeMap["fileName"].Item1;
			foreach(Attribute attribute in query.attributeList)
			{
				//keywords
				//db.getFileElements(attribute.Item1, keywords);
			}
        }
    }
}
