﻿using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("Percent: {0:00.00%}", percent);
		Console.WriteLine("Currency: {0:C, en-US.utf-8}", currency);
	}
}
