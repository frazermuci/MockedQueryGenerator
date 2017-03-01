using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    class QueryHandler
    {
        Func<string, string> stringOp;
        List<Query> queries;
        KeyWordFinder kwf;

        public QueryHandler(KeyWordFinder kwf, Func<string, string> stringOp) //later associate results with
        {                                                                               //query
            this.stringOp = stringOp;
            this.kwf = kwf;
            this.queries = new List<Query>();
        }

        private void genQueries(string[] sentences)
        {
            QueryGenerator queryGen = new QueryGenerator(kwf);
            foreach (string sentence in sentences)
            {
                queries.Add(queryGen.queryGen(sentence));
            }
        }

        private async Task<string[]> sendOff()
        {
            List<Task<string>> issuedQueries = new List<Task<string>>();
            foreach (Query q in queries)
            {
                issuedQueries.Add(Task<string>.Factory.StartNew(() => { return DataAccess.query(q); }));
               // Task.
            }
            return await Task.WhenAll(issuedQueries);
        }

        public List<string> handleQuery(string[] sentences)
        {
            genQueries(sentences);
            List<string> retList = new List<string>();
            string[] response = sendOff().Result;
            foreach (string r in response)
            {
               // string temp = r;
                //new HTMLMessager().removeFromLine(ref temp);//re encapsulate in return val
                retList.Add(stringOp(r));
            }
            return retList;
        }
    }
}
