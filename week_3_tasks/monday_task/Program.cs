namespace monday_task
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region task 1
			int[] array = { 96, 14, 214, 114, 114, 1, 1, 1, 1, 24, 42 };

			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == -1) continue;
				
				int count = 1;

				for (int j = i + 1; j < array.Length; j++)
				{
					if (array[i] == array[j])
					{
						count++;
						array[j] = -1;
					}
				}
				Console.WriteLine(array[i] + " -> " + count + " defe");
			}
			Console.ReadKey();
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
			else Console.WriteLine(-1);
			Console.ReadKey();*/
			#endregion
		}
	}
}