using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryTrain
{
    
    public struct Attribute
    {
		public string name;
		public string value;
		public bool negate;
		
		public Attribute(string name, string value, bool negate)
		{
			this.name = name;
			this.value = value;
			this.negate = negate;
		}
	}
}
