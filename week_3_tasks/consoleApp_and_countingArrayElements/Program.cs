namespace consoleApp_and_countingArrayElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region task 1
			/*int[] nums = { 1, 1, 2, 8, 3, 4, 5, 5, 6 };
			int size = nums.Length;
			int[] count = new int[size];

			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++) if (nums[j] == i) count[i]++;
			}
			for (int i = 0; i < size; i++)
			{
				if (count[i] > 0) Console.WriteLine(i + " -> " + count[i] + " dene");
			}*/
			#endregion
			#region task 2
			/*Console.Write("Array-in olcusunu daxil edin: ");
			int size = Convert.ToInt32(Console.ReadLine());
			int[] userNumbers = new int[size];
			Console.Write("Array-a eded elave edilsin? (yes/y/Yes/Y or whatever) ");
			string userAnswer = Console.ReadLine();

			if (userAnswer == "yes" || userAnswer == "y" || userAnswer == "Yes" || userAnswer == "Y")
			{
				Console.Write("Eded daxil edin: ");
				userNumbers[0] = Convert.ToInt32(Console.ReadLine());
				for (int i = 1; i < size; i++)
				{
					Console.Write("Davam? (yes or whatever) ");
					userAnswer = Console.ReadLine();
					if (userAnswer == "yes" || userAnswer == "y" || userAnswer == "Yes" || userAnswer == "Y")
					{
						Console.Write("Eded daxil edin: ");
						userNumbers[i] = Convert.ToInt32(Console.ReadLine());
					}
					else break;
				}
				for (int i = 0; i < size; i++) Console.Write(userNumbers[i] + " ");
			}
			else Console.WriteLine(-1);*/
			#endregion
		}
	}
}