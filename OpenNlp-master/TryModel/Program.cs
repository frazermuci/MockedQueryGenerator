using OpenNLP.SentenceDetect;
using System;


namespace TryModel
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
