namespace Project
{
    internal class Monitor : Product
    {
        public string Matrix { get; protected set; }
        public Monitor() : base()
        {
            Matrix = "matrix type";
        }

        public Monitor (string name, string matrix, double price, int count) : base (name, price, count)
        {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));
            if (matrix.Length == 0) throw new ArgumentException("matrix type name cannot be empty", nameof(matrix));
            Matrix = matrix;
        }

        public override string Display()
        {
            return $"{Name}, {Matrix}, {Price}, {Count}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Monitor monitor &&
                   base.Equals(obj) &&
                   Matrix == monitor.Matrix;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(base.GetHashCode(), Matrix);
        }
    }
}
