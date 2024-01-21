namespace Project
{
    internal class Laptop : Product
    {
        public string Producer { get; protected set; }

        public Laptop() : base()
        {
            Producer = "producer";
        }

        public Laptop(string producer, string name, double price, int count) : base(name, price, count)
        {
            if (producer == null) throw new ArgumentNullException();
            if (producer.Length == 0) throw new ArgumentException("producer name cannot be empty");
            Producer = producer;
        }

        public override string Display()
        {
            return $"{Producer}, {Name}, {Price}, {Count}";
        }
    }
}
