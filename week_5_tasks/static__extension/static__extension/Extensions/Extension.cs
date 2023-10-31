namespace static__extension.Extensions
{
	internal static class Extension
	{
		public static bool CheckGroupNo(this string groupNum)
		{
			bool result;

			if (groupNum.Length == 4 && Char.IsLetter(groupNum[0]) && groupNum.Substring(1).All(char.IsDigit)) result = true;
			else
			{
				Console.WriteLine("Group Number isn't correct. Retry.");
				result = false;
			}

			return result;
		}

		public static bool CheckFullName(this string fullName)
		{
			fullName = fullName.Trim();

			int spaceCount = fullName.Count(char.IsWhiteSpace);

			return spaceCount == 1;
		}
	}
}
