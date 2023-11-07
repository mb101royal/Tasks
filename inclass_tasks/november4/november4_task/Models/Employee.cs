namespace november4_task.Models
{
    internal class Employee : Person
    {
        public decimal Salary { get; set; }
        public Genders Gender { get; set; }
        public Positions Position { get; set; }
        public DateTime CreatedAt { get; set; }

        public override string FullName()
        {
            return $"{Id} => {Name} {Surname}, Age: {Age}, Gender: {Gender}, Position: {Position}, Salary: {Salary}.";
        }
    }
    public enum Genders
    {
        Male = 1,
        Female,
        Other
    }
    public enum Positions
    {
        FrontEnd = 1,
        BackEnd,
        FullStack,
        DevOps
    }
}
