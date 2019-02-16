using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FF9
{
	class DataContext
	{
		public RootObject Json { get; set; }

		public DataContext() { }
		public DataContext(String filename)
		{
			if (!System.IO.File.Exists(filename)) return;

			String text = System.IO.File.ReadAllText(filename);
			Json = JsonConvert.DeserializeObject<RootObject>(text);
		}

		public void Save(String filename)
		{
			if (Json == null) return;

			String text = JsonConvert.SerializeObject(Json);
			text = text.Replace(",", ", ");
			text = text.Replace("[{", "[ {");
			text = text.Replace("}]", "} ]");
			text = text.Replace("[\"", "[ \"");
			text = text.Replace("\"]", "\" ]");
			System.IO.File.WriteAllText(filename, text);
		}
	}
}
