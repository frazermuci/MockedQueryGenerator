using OpenNLP.Tools.SentenceDetect;
using SharpEntropy.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TryTrain
{
    class Model
    {
        public static void run()
        {
            while (true)
            {
                var paragraph = Console.ReadLine();
                var modelPath = "C:\\Users\\Matthew\\Desktop\\train\\model";
                var trySomething = new OpenNLP.Tools.Chunker.MaximumEntropyChunker(new SharpEntropy.GisModel(new PlainTextGisModelReader(modelPath)));
               // var sentences = trySomething.c
              //  for (var i = 0; i < sentences.Count(); ++i)
               // {
                //    Console.WriteLine(sentences[i]);
               // }
            }
        }
    }
}
