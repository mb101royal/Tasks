namespace overloading
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*#region task overload
			Console.WriteLine("Cevrenin sahesi: " + area(5));
			Console.WriteLine("Duzbucaqlinin sahesi: " + area(5, 4));
			Console.WriteLine("Duzbucaqli paralelepipedin tam sethinin sahesi: " + area(2, 3, 4));
			Console.WriteLine("Ucbucaqlinin daxiline cekilmis cevrenin sahesi: " + area(5, 6, 7, 8, 9));
			#endregion*/

			/*#region task 2: a
			Console.Write("Birinci ededi daxil edin(a): ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ikinci ededi daxil edin(b): ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ne edek?(+, -, *, /): ");
			char operation = Convert.ToChar(Console.ReadLine());

			float result = calculate(a, b, operation);
			Console.Write("Netice: " + result);
			#endregion*/

			#region task 2: b
			Console.Write("Eded daxil edin: ");
			int userNum = Convert.ToInt32(Console.ReadLine());
			Console.Write("Uzeri nece olacaq?: ");
			int power = Convert.ToInt32(Console.ReadLine());

			int result = pow(userNum, power); // pow(userNum, empty) -> exception :(

			Console.Write("Netice: " + result);
			#endregion

			/*#region task 2: c
			Console.Write("Ad daxil edin: ");
			string name = Console.ReadLine();
			Console.Write("Soyad daxil edin: ");
			string surname = Console.ReadLine();
			Console.Write("Ata adi daxil edin: ");
			string fatherName = Console.ReadLine();

			string result1 = fullname(name);
			string result2 = fullname(name, surname);
			string result3 = fullname(name, surname, fatherName);

			Console.WriteLine(result1);
			Console.WriteLine(result2);
			Console.WriteLine(result3);
			#endregion*/
		}


		static int area(int side1)
		{
			int side2 = 3;
			int result = side2 * side1 * side1;
			return result;
		}
		static int area(int side1, int side2)
		{
			int result = side1 * side2;
			return result;
		}
		static int area(int side1, int side2, int side3)
		{
			int result = 2 * (side1 * side2 + side1 * side3 + side2 * side3);
			return result;
		}
		static int area(int side1, int side2, int side3, int side4, int side5)
		{
			side2 = (side3 + side4 + side5) / 2;
			int result = side1 * side2;
			return result;
		}


		static float calculate(int a, int b, char operation)
		{
			if (operation == '+') return sum(a, b);
			else if (operation == '-') return substraction(a, b);
			else if (operation == '*') return multiplic(a, b);
			else if (operation == '/') return division(a, b);
			else return -1;
		}
		static int sum(int a, int b)
		{
			int summary = a + b;
			return summary;
		}
		static int substraction(int a, int b)
		{
			int difference = a - b;
			return difference;
		}
		static int multiplic(int a, int b)
		{
			int multi = a * b;
			return multi;
		}
		static float division(int a, float b)
		{
			float divide = a / b;
			return divide;
		}


		static int pow(int userNum, int power = 2)
		{
			if (power == 0) return 1;

			int answer = userNum;
			int increment = userNum;

			for (int i = 1; i < power; i++)
			{
				for (int j = 1; j < userNum; j++) answer += increment;
				increment = answer;
			}
			return answer;
		}


		static string fullname(string name)
		{
			return name;
		}
		static string fullname(string name, string surname)
		{
			string result = "";
			if (surname.Length > 0) result = surname + " " + name;
			return result;
		}
		static string fullname(string name, string surname, string fatherName)
		{
			string result = "";
			if (fatherName.Length > 0) result = fatherName[0] + ". " + surname + " " + name;
			return result;
		}
	}
}