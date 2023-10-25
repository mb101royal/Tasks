namespace Weapons;

internal class Weapon
{
    private int _bulletVolume;
    private int _bulletCount;
    private double _timeUntilEmpty;
    private string _firingMode;

    public int BulletVolume { get => _bulletVolume;
        set
        {
            if (value >= 0) _bulletVolume = value;
            else
            {
                Console.WriteLine("Error. Bullet volume can't be negative. Changed to 0");
                _bulletVolume = 0;
            }
        }
    }
    public int BulletCount { get => _bulletCount;
        set
        {
            if (value > BulletVolume)
            {
                Console.WriteLine("Error. Bullet count can't be greater than Bullet volume. changed to 0");
                _bulletCount = BulletVolume;
            }
            else if (value < 0)
            {
                Console.WriteLine("Error. Bullet count can't be negative.");
                _bulletCount = 0;
            } 
            else _bulletCount = value;
        }
    }
    public double TimeUntilEmpty { get => _timeUntilEmpty;
        set
        {
            if (value > 0) _timeUntilEmpty = value;
            else
            {
                Console.WriteLine("Error. Time can't be negative. Changed to at least 1");
                _timeUntilEmpty = 1;
            }
        }
    }
    public string FiringMode { get => _firingMode;
        set
        {
            value = value.Trim();
            if (value == "single" || value == "sing") _firingMode = value;
            else if (value == "automatic" || value == "auto") _firingMode = value;
            else Console.WriteLine("Error. Can't change the firing mode.");
        }
    }

    public void Shoot()
    {
        if (BulletCount > 0)
        {
            Console.WriteLine("Shooted!");
            BulletCount--;
        }
        else Console.WriteLine("You have 0 bullet.");
    }

    public void Fire()
    {
        if (BulletCount > 0 && (FiringMode == "single" || FiringMode == "sing"))
        {
            Console.WriteLine("Fire!");
            BulletCount--;
        }
        else if (BulletCount > 0 && (FiringMode == "auto" || FiringMode == "automatic"))
        {
            Console.WriteLine($"Fired until empty, time passed ~ {Convert.ToDouble((TimeUntilEmpty/BulletVolume) * BulletCount)} sec.");
            BulletCount = 0;
        }
        else Console.WriteLine("You have 0 bullet.");
    }

    public void GetRemainBulletCount()
    {
        Console.WriteLine($"You have: {BulletCount} bullets.");
    }

    public void Reload()
    {
        BulletCount = BulletVolume;
        Console.WriteLine($"Reloaded. Now you have: {BulletCount} bullets");
    }

    public void ChangeFirinMode()
    {
        if (FiringMode == "single" || FiringMode == "sing")
        {
            FiringMode = "auto";
            Console.WriteLine($"Firing mode has changed to: {FiringMode}.");
        }
        
        else if (FiringMode == "auto" || FiringMode == "automatic")
        {
            FiringMode = "single";
            Console.WriteLine($"Firing mode has changed to: {FiringMode}.");
        }
        else Console.WriteLine("Error. Can't change the firing mode.");
    }

    public void NewWeapon()
    {
        Console.Write("Bullet volume: ");
        BulletVolume = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bullet count: ");
        BulletCount = Convert.ToInt32(Console.ReadLine());
        Console.Write("Time until empty: ");
        TimeUntilEmpty = Convert.ToInt32(Console.ReadLine());
        Console.Write("Firing mode: ");
        FiringMode = Console.ReadLine();

        Console.WriteLine("Tried to create a new weapon.");
    }

    public void Info()
    {
        Console.Write($"Daragin tutumu: {BulletVolume}, daragdaki gulle: {BulletCount}, bitene qeder zaman: {TimeUntilEmpty}, atis modu: {FiringMode}.\n");
    }
}