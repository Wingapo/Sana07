using Project;

internal class Program
{
    private static void Main(string[] args)
    {
        ShoppingCart cart = new();

        try
        {
            cart.Add(new Laptop("Asus", "Zenbook 14", 40000, 1));
            cart.Add(new Project.Monitor("Gigabyte G27QC A", "VA", 12500, 1));
            cart.Add(new Tablet("Samsung Galaxy Tab S9 FE+", 11, 26000, 2));

            cart.DisplayAll(Console.WriteLine);
            Console.WriteLine("\nTotal price: " + cart.GetTotalPrice());
        }
        catch (ArgumentNullException e)
        {
            Console.WriteLine(e.ParamName + " cannot be null");
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.ParamName + " cannot be negative");
        }
        catch (ArgumentException e) 
        {
            Console.WriteLine(e.ParamName + " cannot be empty");
        }
        catch (Exception)
        {
            Console.WriteLine("Error");
        } 
    }
}