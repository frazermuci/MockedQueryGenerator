
////maybe store all these private methods in a helper module
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Parser
{
    class ParserWrapper
    {	
		Dictionary<string,ParsedCHM> parsedCHMs;
		
		public ParserWrapper(string filePath)
		{
			parsedCHMs = new Dictionary<string, ParsedCHM>();
			parsedCHMs[filePath] = new ParsedCHM(filePath);
		}
		
		public ParserWrapper(List<string> filePaths)
		{
			foreach(string file in filePaths)
			{
				parsedCHMs[file] = new ParsedCHM(filePath);
			}
		}
		
		private void iterateThroughBlocks(string filePath, List<Element> blocks)
		{
			foreach (List<Element> block in blocks)
            {
				int blockCount = 0;
                foreach (Element element in block)
                {
                    if (element.name == "img")
                    {
                        //NEED A MEANS TO RETRIEVE ID
                        ;//db.insertIntoImages();
                    }
                    else
                    {
                        //NEED A MEANS TO RETRIEVE ID
                        db.insertIntoElements(filePath, blockCount, element.data);
                    }
					++blockCount;
                }
            }
		}
		
		private void iterateThroughHREFS(string filePath, List<string> hrefs)
		{
			foreach (string href in pair.Second.hrefs)
			{
                //NEED A MEANS TO RETRIEVE ID
				db.insertIntoHyperlinks(pair.Second.title, href);
			}
		}
		
		public void persistData()
        {
            ActiveAIDDB db = new ActiveAIDDB();
            db.insertIntoFiles(title, "");            
			
			foreach (Pair<string, ParsedCHM> pair in parsedCHMs)
			{
				iterateThroughBlocks(pair.First, pair.Second.blocks);
				iterateThroughHREFS(pair.Second.title, pair.Second.hrefs);
				//SIML
			}
        }
    }
}
