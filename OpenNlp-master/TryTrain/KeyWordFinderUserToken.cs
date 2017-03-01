using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    class KeyWordFinderUserToken : KeyWordFinder
    {
        private bool refUserFile(string str)
        {
            string lowered = str.ToLower();
            return lowered.Equals("user") || lowered.Equals("users") || lowered.Equals("person") || lowered.Equals("people");
        }

        public Tuple<string, bool> boilDown(string sentence)
        {
            string[] splitSentence = sentence.Split(' ');
            foreach (string str in splitSentence)
            {
                if (refUserFile(str))
                {
                    return new Tuple<string, bool>(str,true);
                }
            }
            return new Tuple<string, bool>(sentence, true);
        }
    }
}
