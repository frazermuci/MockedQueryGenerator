using OpenNLP.Tools.SentenceDetect;
using OpenNLP.Tools.NameFind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    class Train
    {
        public void run()
        {
            while(true)
            {
                var paragraph = Console.ReadLine();
                var modelPath = "C:\\Users\\Matthew\\Desktop\\train\\model";
                var sentenceDetector = new EnglishMaximumEntropySentenceDetector(modelPath);
                var sentences = sentenceDetector.SentenceDetect(paragraph);
                Console.WriteLine(sentences);
                
            }
        }
    }
}
