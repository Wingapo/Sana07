namespace Project
{
    internal abstract class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Count { get; private set; }

        public abstract string Display();
    }
}
