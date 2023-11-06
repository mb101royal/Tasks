using delegates.Models;

namespace delegates
{
	delegate bool ExamFilterDelegate(Exam exam);
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Exam> Exams = new List<Exam>();

			Console.Write("Enter the number of exams: ");
			int numberOfExams = int.Parse(Console.ReadLine());

			for (int i = 0; i < numberOfExams; i++)
			{
				Console.Write($"Enter Student Name for Exam {i + 1}: ");
				string? studentName = Console.ReadLine();
				Student student = new Student { StudentName = studentName };

				Console.Write($"Enter Subject for Exam {i + 1}: ");
				string? subject = Console.ReadLine();

				Console.Write($"Enter Points for Exam {i + 1}: ");
				int points = int.Parse(Console.ReadLine());

				// input sample -> 11/06/2023 15:50
				Console.Write($"Enter Start Date and Time for Exam {i + 1} (MM/dd/yyyy HH:mm): ");
				DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", null);

				Console.Write($"Enter End Date and Time for Exam {i + 1} (MM/dd/yyyy HH:mm): ");
				DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy HH:mm", null);

				Exams.Add(new Exam
				{
					Student = student,
					Subject = subject,
					Point = points,
					StartDate = startDate,
					EndDate = endDate
				});
			}

			ExamFilterDelegate pointsFilter = exam => exam.Point > 50;
			ExamFilterDelegate lastWeekFilter = exam => (DateTime.Now - exam.StartDate).Days <= 7;
			ExamFilterDelegate durationFilter = exam => exam.DurationHours > 1;

			DisplayFilteredExams("Exams with Points > 50:", Exams, pointsFilter);
			DisplayFilteredExams("Exams in Last 1 week:", Exams, lastWeekFilter);
			DisplayFilteredExams("Exams took longer than 1 hour:", Exams, durationFilter);
		}

		static void DisplayFilteredExams(string message, List<Exam> exams, ExamFilterDelegate filter)
		{
			Console.WriteLine(message);
			foreach (var exam in exams)
			{
				if (filter(exam))
				{
					Console.WriteLine($"Student: {exam.Student.StudentName} | Subject: {exam.Subject} | Points: {exam.Point} | Duration: {exam.DurationHours} hours");
				}
			}
			Console.WriteLine();
		}
	}
}
