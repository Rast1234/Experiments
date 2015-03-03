using System;
using Experiments;

namespace ExperimentsConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var foo = new Foo();
			var s = foo.Do();
			Console.Write(s);
			Console.ReadKey();
		}
	}
}
