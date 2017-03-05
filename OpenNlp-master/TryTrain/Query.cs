using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    
    public struct Query
    {
        public List<Attribute> attributeList { get; set; }
        public Tuple<int, bool> quantityOfResponses { get; set; }
        public string resourceExpected { get; set; }

        public Query(List<Attribute> attributeList, 
                     Tuple<int,bool> quantityOfResponses, 
                     string resourceExpected)
        {
            this.attributeList = attributeList;
            this.quantityOfResponses = quantityOfResponses;
            this.resourceExpected = resourceExpected;
        }
    }
}
