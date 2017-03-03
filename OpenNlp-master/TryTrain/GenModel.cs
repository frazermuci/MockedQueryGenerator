using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    public class GenModel
    {
        public GenModel(string htmlFile)
        {
            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.Load(htmlFile);
            Parser.ParsedCHM parsed = new Parser.ParsedCHM(htmlDoc);
        }
    }
}
