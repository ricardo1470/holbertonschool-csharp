﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLibrary
{
}

class User: Base
{
	public String name;

	public User (string name = "default")
	{
		this.name = name;
	}
}
