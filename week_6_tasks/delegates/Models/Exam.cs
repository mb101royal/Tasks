namespace delegates.Models
{
	internal class Exam
	{
		public Student? Student { get; set; }
		public string? Subject { get; set; }
		public int Point { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public double DurationHours => (EndDate - StartDate).TotalHours;
	}
}
