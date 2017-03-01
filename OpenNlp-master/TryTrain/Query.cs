using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    
    struct Query
    {
        public Dictionary<string, Tuple<string, bool>> attributeMap { get; set; }
        public Tuple<int, bool> quantityOfResponses { get; set; }
        public string resourceExpected { get; set; }

        public Query(Dictionary<string, Tuple<string, bool>> attributeMap, 
                     Tuple<int,bool> quantityOfResponses, 
                     string resourceExpected)
        {
            this.attributeMap = attributeMap;
            this.quantityOfResponses = quantityOfResponses;
            this.resourceExpected = resourceExpected;
        }
    }
}
