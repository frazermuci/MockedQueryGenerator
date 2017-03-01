using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    interface KeyWordFinder
    {
        Tuple<string, bool> boilDown(string sentecnce);
    }
}
