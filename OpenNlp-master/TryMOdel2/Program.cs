using OpenNLP.Tools.SentenceDetect;
using SharpEntropy.IO;
using System;


namespace TryMOdel2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var paragraph = Console.ReadLine();
                var modelPath = "C:\\Users\\Matthew\\Desktop\\train\\model";
                var sentenceDetector = EnglishMaximumEntropySentenceDetector(modelPath);
                var sentences = sentenceDetector.SentenceDetect(paragraph);
                Console.WriteLine(sentences);
            }
        }
    }
}
