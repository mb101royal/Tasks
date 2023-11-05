using tlist.Models;

namespace tlist
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CustomList<int> myList = new CustomList<int>();

            for (int i = 0; i < 10; i++)
			{
				myList.Add(i);
			}
            Console.WriteLine("Added 10 elements(0-9).\n");

			Console.WriteLine("We have 1 -> " + myList.Exist(1));
			Console.WriteLine("We have 10 -> " + myList.Exist(10));
			
			Console.WriteLine("\nBefore removing at index 2: ");
			for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(myList[i] + " ");
			}

			myList.RemoveAt(2);
            Console.WriteLine("\nAfter removing at index 2: ");
            for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(myList[i] + " ");
			}

			Console.WriteLine("\n\nIndex of 5: " + myList.IndexOf(5));

			myList.Add(5);
			Console.WriteLine("Added 5.");

			Console.WriteLine("Last index of 5: " + myList.LastIndexOf(5));

            Console.WriteLine("\nChanging element via index(now index 2 has value of 2):");
            myList[2] = 2;
			for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(myList[i] + " ");
			}

			myList.Reverse();
            Console.WriteLine("\n\nReversed array: ");
            for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(myList[i] + " ");
			}

			myList.Clear();
			Console.WriteLine("\n\nCleared array: ");
			for (int i = 0; i < myList.Count; i++)
			{
				Console.Write(myList[i] + " ");
			}
		}
	}
}