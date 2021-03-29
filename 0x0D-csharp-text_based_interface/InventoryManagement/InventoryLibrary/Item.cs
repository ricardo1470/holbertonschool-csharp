using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
	class Item : Base
	{
		public String name;
		public String description;
		public float price = 0.2f;
		public List<String> tags;

		public Item (string name = "name", string description = "description", float price = "price", List<string> tags = "tags")
		{
			this.name = name;
			this.description = description;
			this.price = price;
			this.List<String> = tags;
		}
	}
}
