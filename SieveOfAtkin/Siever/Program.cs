using System;
using SieveOfAtkin;

namespace Siever
{
	class Program
	{
		static void Main(string[] args)
		{
			var s = new Sieve(15L);
			s.Primes.ForEach(Console.WriteLine);
			Console.ReadKey();
		}
	}
}
