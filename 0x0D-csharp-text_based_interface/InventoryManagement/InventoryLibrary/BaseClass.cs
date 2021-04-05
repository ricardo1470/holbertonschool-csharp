using System;

namespace InventoryLibrary
{
}
public class Base
{
	private String id;
	private DateTime date_created;
	private DateTime date_updated;

	public BaseClass(String id = null, DateTime date_created = default(DateTime), DateTime date_updated = default(DateTime))
	{
		if (id == null)
		{
			this.id = Guid.NewGuid().ToString();
		}
		else
		{
			this.id = id;
		}
		if (date_created == default(DateTime))
		{
			this.date_created = DateTime.Now;
		}
		else
		{
			this.date_created = date_created;
		}
		if (date_updated == default(DateTime))
		{
			this.date_updated = DateTime.Now;
		}
		else
		{
			this.date_updated = date_updated;
		}
	}
}
