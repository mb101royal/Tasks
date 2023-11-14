using Newtonsoft.Json;

namespace file__jsonserialize;

class Program
{
	public static string jsonFile = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "students.json"));
	static void Main()
	{
		List<Student> students = LoadStudentsFromJson(); // Load existing students from JSON

		while (true)
		{
			Console.WriteLine("1. Add Student");
			Console.WriteLine("2. Remove Student");
			Console.WriteLine("3. Edit Student");
			Console.WriteLine("4. Display Students");
			Console.WriteLine("5. Save and Exit");

			Console.Write("Enter your choice (1-5): ");
			string choice = Console.ReadLine();

			switch (choice)
			{
				case "1":
					AddStudent(students);
					break;
				case "2":
					RemoveStudent(students);
					break;
				case "3":
					EditStudent(students);
					break;
				case "4":
					DisplayStudents(students);
					break;
				case "5":
					SaveStudentsToJson(students); // Save students to JSON before exiting
					return;
				default:
					Console.WriteLine("Invalid choice. Please try again.");
					break;
			}
		}
	}

	static void AddStudent(List<Student> students)
	{
		Console.Write("Enter Name: ");
		string name = Console.ReadLine();

		Console.Write("Enter Surname: ");
		string surname = Console.ReadLine();

		Console.Write("Enter Code (must be unique): ");
		string code = Console.ReadLine();

		// Check if the Code is already in use
		if (students.Exists(s => s.Code == code))
		{
			Console.WriteLine("Code is not unique. Student not added.");
			return;
		}

		Student newStudent = new Student { Name = name, Surname = surname, Code = code };
		students.Add(newStudent);

		Console.WriteLine("Student added successfully.");
	}

	static void RemoveStudent(List<Student> students)
	{
		Console.Write("Enter Code of the student to remove: ");
		string codeToRemove = Console.ReadLine();

		Student studentToRemove = students.Find(s => s.Code == codeToRemove);

		if (studentToRemove != null)
		{
			students.Remove(studentToRemove);
			Console.WriteLine("Student removed successfully.");
		}
		else
		{
			Console.WriteLine("Student not found.");
		}
	}

	static void EditStudent(List<Student> students)
	{
		Console.Write("Enter Code of the student to edit: ");
		string codeToEdit = Console.ReadLine();

		Student studentToEdit = students.Find(s => s.Code == codeToEdit);

		if (studentToEdit != null)
		{
			Console.Write("Enter new Name: ");
			studentToEdit.Name = Console.ReadLine();

			Console.Write("Enter new Surname: ");
			studentToEdit.Surname = Console.ReadLine();

			Console.WriteLine("Student edited successfully.");
		}
		else
		{
			Console.WriteLine("Student not found.");
		}
	}

	static void DisplayStudents(List<Student> students)
	{
		Console.WriteLine("\nList of Students:");
		foreach (var student in students)
		{
			Console.WriteLine($"Name: {student.Name} | Surname: {student.Surname} | Code: {student.Code}");
		}
		Console.WriteLine();
	}

	static List<Student> LoadStudentsFromJson()
	{
		if (File.Exists(jsonFile))
		{
			string json = File.ReadAllText(jsonFile);
			return JsonConvert.DeserializeObject<List<Student>>(json);
		}
		return new List<Student>();
	}

	static void SaveStudentsToJson(List<Student> students)
	{
		string json = JsonConvert.SerializeObject(students, Formatting.Indented);
		File.WriteAllText(jsonFile, json);
		Console.WriteLine("Students saved to JSON.");
	}
}

class Student
{
	public string Name { get; set; }
	public string Surname { get; set; }
	public string Code { get; set; }
}