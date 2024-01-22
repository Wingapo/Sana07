namespace Project
{
    internal class ShoppingCart
    {
        protected HashSet<Product> Products;

        public ShoppingCart()
        {
            Products = new HashSet<Product>();
        }

        public void Add(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            Products.Add(product);
        }

        public void DisplayAll(Action<string> output)
        {
            foreach (Product product in Products)
                output(product.Display());
        }

        public double GetTotalPrice()
        {
            double price = 0;
            foreach (Product product in Products)
            {
                price += product.Price * product.Count;
            }
            return price;
        }
    }
}
