namespace november4_task.Models
{
    internal abstract class Person
    {
        static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public Person()
        {
            Id = _id;
            _id++;
        }

        public virtual string FullName() { return default; }
    }
}
