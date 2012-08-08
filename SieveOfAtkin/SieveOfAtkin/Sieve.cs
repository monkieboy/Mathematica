using System.Collections.Generic;

namespace SieveOfAtkin
{
	public class Sieve
	{
		private readonly long limit;
		public List<long> Primes { get; set; }
		private readonly IDictionary<long, bool> numbersToCheck = new Dictionary<long, bool>();
		private readonly IList<long> checkCriteria = new List<long>{1,13,17,29,37,41,49,53,7,19,31,43,11,23,47,59};


		public Sieve(long limit)
		{
			this.limit = limit;
			SetUp();
			GetPrimes();
		}

		private void SetUp()
		{
			Primes = new List<long> { 2L, 3L, 5L };
			for (var i = 6L; i < limit; i++)
			{
				numbersToCheck.Add(i, false);
			}
		}

		public void GetPrimes()
		{
			long currentPrime = 7;

			for (var i = currentPrime; i < limit; i += currentPrime)
			{
				if (CheckIfTheValueCanBeSkipped(i)) continue;


				Primes.Add(i);
			}
		}

		private bool CheckIfTheValueCanBeSkipped(long i)
		{
			var modulo = (i%60);

			return !checkCriteria.Contains(modulo);
		}
	}
}
