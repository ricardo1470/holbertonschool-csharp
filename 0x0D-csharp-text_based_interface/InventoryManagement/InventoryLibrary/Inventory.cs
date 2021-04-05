using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
}
class Inventory: Base
{
	public User user_id;
	public Item item_id;
	public int quantity = 1;

	public Inventory (string user_id = "", string item_id, int quantity = 1)
	{
		this.quantity = quantity;
		this.user_id = user_id;
		this item_id = item_id;
	}
}
