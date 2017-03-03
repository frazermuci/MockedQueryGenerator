using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    public class QueryGenerator
    {
        private KeyWordFinder kwf;

        public QueryGenerator(KeyWordFinder kwf)
        {
            this.kwf = kwf;
        }

        public Query queryGen(string sentence)
        {
            Dictionary<string, Tuple<string, bool>> attributeMap = new Dictionary<string, Tuple<string, bool>>();
            attributeMap.Add("fileName", kwf.boilDown(sentence));
            return new TryTrain.Query(attributeMap, new Tuple<int, bool>(0, false), "text");
        }
    }
}
