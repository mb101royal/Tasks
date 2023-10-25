namespace Weapons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weapon = new Weapon();

            weapon.BulletVolume = 40;
            weapon.BulletCount = 35;
            weapon.TimeUntilEmpty = 5;
            weapon.FiringMode = "auto";

            Info();

            char answer = Convert.ToChar(Console.ReadLine());
            while (answer != 'q')
            { 
                switch (answer)
                {
                    case '0':
                        weapon.Info();
                        break;
                    case '1':
                        weapon.Shoot();
                        break;
                    case '2':
                        weapon.Fire();
                        break;
                    case '3':
                        weapon.GetRemainBulletCount();
                        break;
                    case '4':
                        weapon.Reload();
                        break;
                    case '5':
                        weapon.ChangeFirinMode();
                        break;
                    case 'e':
                        weapon.NewWeapon();
                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }
                Info();
                answer = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("Exited.");
        }

        static void Info()
        {
            Console.WriteLine("0 - Informasiya ucun.");
            Console.WriteLine("1 - Shoot metodu ucun.");
            Console.WriteLine("2 - Fire metodu ucun.");
            Console.WriteLine("3 - GetRemainBulletCount metodu ucun.");
            Console.WriteLine("4 - Reload ucun.");
            Console.WriteLine("5 - Change firing mode.");
            Console.WriteLine("e - Yeni silah yaratmaq ucun.");
            Console.WriteLine("q - Proqrami dayandirmaq ucun.");
        }
    }
}