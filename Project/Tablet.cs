namespace Project
{
    internal class Tablet : Product
    {
        public double Diagonal { get; protected set; }

        public Tablet() : base() 
        {
            Diagonal = 0;
        }

        public Tablet(string name, double diagonal, double price, int count) : base(name, price, count)
        {
            if (diagonal < 0) throw new ArgumentOutOfRangeException(nameof(diagonal));
            Diagonal = diagonal;
        }

        public override string Display()
        {
            return $"{Name}, {Diagonal}, {Price}, {Count}";
        }
    }
}
