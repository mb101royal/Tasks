namespace indexer__extension.Extensions
{
	public static class ExtensionMethods
	{
		public static bool IsPrime(this int number)
		{
			bool result = true;
			if (number <= 1)
            {
				return result = false; // actually -> neither true nor false from 1 until negative.
            }
            for (int i = 2; i < Math.Sqrt(number); i++)
			{
				if (number % i == 0)
				{
					result = false;
					return result;
				}
			}
			return result;
		}
		public static bool IsPowOfTwo(this int number)
		{
			bool result = true;
			if (number > 0)
			{
				for (int i = 2; i <= number;)
				{
					if (number % i != 0)
					{
						result = false;
						return result;
					}
					number /= 2;
				}
				return result;
			}
			else return result = false;
		}
	}
}
