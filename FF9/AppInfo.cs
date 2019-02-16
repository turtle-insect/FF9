using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FF9
{
    class AppInfo
    {
		public static AppInfo Info { get; private set; } = new AppInfo();

		public Dictionary<uint, String> Items { get; set; } = new Dictionary<uint, String>();
		public Dictionary<uint, String> Cards { get; set; } = new Dictionary<uint, String>();
		private AppInfo()
		{
			CreateDictionary("info\\item.txt", Items);
			CreateDictionary("info\\card.txt", Cards);
		}

		private void CreateDictionary(String filename, Dictionary<uint, String> dictionary)
		{
			if (!System.IO.File.Exists(filename)) return;
			String text = System.IO.File.ReadAllText(filename);
			text = text.Replace("\r\n", "\n");
			String[] lines = text.Split('\n');

			foreach (var line in lines)
			{
				if (line.Length <= 0) continue;
				if (line[0] == '#') continue;
				String[] item = line.Split('\t');
				if (item.Length != 2) continue;

				int fromBase = 10;
				if (item[0][1] == 'x') fromBase = 16;
				dictionary.Add(Convert.ToUInt32(item[0], fromBase), item[1]);
			}
		}
	}
}
