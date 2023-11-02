namespace reflection__task.Models
{
    public class User
    {
        int _id;
        string _name;
        static byte _age;
        public int Id { get; }
        public string Name { get => _name; set { if (value.Length >= 3 && value.Length <= 30) _name = value; } }
        public byte Age { get => _age; set { if (value > 0) _age = value; } }

        public User()
        {
            _id++;
            Id = _id;
        }
        public static void ChangeAge(byte age)
        {
            Console.WriteLine("Enter new age:");
            age = Convert.ToByte(Console.ReadLine());
            _age = age;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}.";
        }
    }
}