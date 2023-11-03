namespace operator_overloading.Models
{
    public class Car
    {
        public decimal Price { get; set; }

        public static bool operator >(Car car1, Car car2)
        {
            decimal price1 = car1.Price;
            decimal price2 = car2.Price;

            if (price1 > price2) return true;

            return false;
        }
        public static bool operator <(Car car1, Car car2)
        {
            return !(car1 > car2);
        }
    }
}
