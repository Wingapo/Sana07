﻿namespace Project
{
    internal abstract class Product
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
        public int Count { get; set; }

        public Product()
        {
            Name = "product";
            Price = 0;
            Count = 0;
        }

        protected Product(string name, double price, int count)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));
            if (name.Length == 0) throw new ArgumentException("name cannot be empty", nameof(name));
            Name = name;
            if (price < 0) throw new ArgumentOutOfRangeException(nameof(price));
            Price = price;
            if (count < 0) throw new ArgumentOutOfRangeException(nameof(count));
            Count = count;
        }

        public abstract string Display();

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Name == product.Name &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Price);
        }
    }
}
