using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syn.Bot;

namespace TryTrain
{
    public class KeyWordFinderUserBot : KeyWordFinder
    {
        public Tuple<string, bool> boilDown(string sentence)
        {
            /*string[] splitSentence = sentence.Split(' ');
            foreach (string str in splitSentence)
            {
                if (refUserFile(str))
                {
                    return new Tuple<string, bool>(str,true);
                }
            }
            return new Tuple<string, bool>(sentence, true);*/
			int max = -1;
			string maxFile = "";
			SynBot Chatbot;
            
			foreach(string fileName in directory)
			{
				Chatbot = new SynBot();
				Chatbot.PackageManager.LoadFromString(File.ReadAllText(fileName));
				var result = Chatbot.Chat(sentence);
				int test = Convert.ToInt32(result.BotMessage());
				maxFile = max < test ? fileName : maxFile;
			}
			return new Tuple(maxFile, true);
        }
    }
}
