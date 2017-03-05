
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
				parsedCHMs[file] = new ParsedCHM(file);
			}
		}
		
		private void insertBlocksIntoDB(string filePath, List<List<Element>> blocks)
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
		
		private void insertHREFSOIntoDB(string filePath, List<string> hrefs)
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
				insertBlocksIntoDB(pair.First, pair.Second.blocks);
				insertHREFSOIntoDB(pair.Second.title, pair.Second.hrefs);
			}
        }
		
		private insertIntoOccuranceDict(ref Dictionary<string, int> occuranceOfWord, Element element)
		{
			if (element.name != "img")
            {
				foreach(string word in element.data.split(" "))//really need to fix this
				{
					if(occuranceOfWord.ContainsKey())
					{
						occuranceOfWord[word]= occuranceOfWord[word]+1;
					}
					else
					{
						occuranceOfWord[word] =1;
					}
				}
            }
		}
		
		private List<string> getKeyWords(List<List<Element>> elements)
		{
			Dictionary<string, int> occuranceOfWord = new Dictionary<string, int>();
			List<string> keywords = new List<string>();
			
			foreach (List<Element> block in blocks)
            {
                foreach (Element element in block)
                {
                    insertIntoOccuranceDict(ref occuranceOfWord, element);
                }
            }
			
			for(var i =0; i < 5; ++i)
			{
				string maxWord = occuranceOfWord.Max(x => x.Second).First;
				keywords.Add(maxWord);
				occuranceOfWord.Remove(maxWord);
			}
			return keywords;
		}
		
		public void genModel()
		{
			List<string> keywords = new List<string>();
			List<string> responseFileNames = new List<string>();
			string response;
 			foreach (Pair<string, ParsedCHM> pair in parsedCHMs)
			{
				responseFileNames.Add(pair.First);
				keywords.AddRange(getKeyWords(pair.Second.blocks));
			}
			response = responseFileNames.Join(";", responseFileNames.ToArray());
			Console.WriteLine(response);
			foreach(string keyword in keywords)
			{
				Console.WriteLine(keyword);
			}
		}
    }
}
