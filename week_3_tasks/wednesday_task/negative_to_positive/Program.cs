namespace negative_to_positive
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] myArr1 = { 1, 2, 3, 4, 5, 6, 7, -1, 2, -3, 4, -5, -10}; // for ref

			int[] result1 = MyArr1(ref myArr1); // with ref
			int[] result2 = MyArr2(out int[] myArr2); // with out, could create above(like ref) tho.

			foreach (int num in result1) Console.Write(num + " "); // ref
			Console.WriteLine(); // blank space
			foreach (int num in result2) Console.Write(num + " "); // out
		}

		static int[] MyArr1(ref int[] array)
		{
			for (int i = 0; i < array.Length; i++) if (array[i] < 0) array[i] *= -1;

			return array;
		}

		static int[] MyArr2(out int[] array)
		{
			array = new int[] { 1, 2, 3, 4, 5, -2, -3, -5, -10 };
			for (int i = 0; i < array.Length; i++) if (array[i] < 0) array[i] *= -1;
		
			return array;
		}
	}
}