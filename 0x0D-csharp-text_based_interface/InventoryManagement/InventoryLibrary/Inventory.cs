using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
	class Inventory: Base
	{
		public User user_id;
		public Item item_id;
		public int quantity = 1;
	}
}
