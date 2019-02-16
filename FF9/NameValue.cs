using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF9
{
    class NameValue
    {
		public uint ID { get; private set; }
		public String Name { get; private set; }

		public bool Line(String text)
		{
			String[] item = text.Split('\t');
			if (item.Length != 2) return false;

			int fromBase = 10;
			if (item[0][1] == 'x') fromBase = 16;
			ID = Convert.ToUInt32(item[0], fromBase);
			Name = item[1];
			return true;
		}
	}
}
