namespace products
{
    internal abstract class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        protected float TotalIncome { get; set; }

        public Product()
        {
            _id += 1;
            Id = _id;
        }

        public abstract void Sell();
        public abstract string ShowInfo();
    }
}
