namespace fibonacci_and_swap_2_values
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Fibonacci:
			#region
			Console.Write("Enter a number: ");
			int userNum = Convert.ToInt32(Console.ReadLine());
			int index = 2;
			int[] arr = new int[999];
			arr[0] = 0;
			arr[1] = 1;
			arr[2] = 1;

			while (true)
			{
				arr[index] = arr[index - 1] + arr[index - 2];
				Console.Write(arr[index] + " ");
				if (userNum <= arr[index])
				{
					//Console.WriteLine(arr[index]); //1 result? -> uncomment this and comment previous one
					break;
				}
				index++;
			}
			#endregion

			// Swap 2 values:
			#region
			/*Console.WriteLine("Enter first number(a): ");
			int userNum1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number(b): ");
			int userNum2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Before: a = " + userNum1 + ", b = " + userNum2);

			userNum1 = userNum1 + userNum2;
			userNum2 = userNum1 - userNum2;
			userNum1 = userNum1 - userNum2;

			Console.WriteLine("\nAfter: a = " + userNum1 + ", b = " + userNum2);*/
			#endregion
		}
	}
}