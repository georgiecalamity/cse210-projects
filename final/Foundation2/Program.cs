using System;

class Program
{
    static void Initialize(List<Order> orders){
        List<Product> products = new List<Product>(); Customer customer;
        Address address; Product product;Order order;
        address = new Address("123 Thunder Road", "San Bruno", "CA", "USA");
        customer = new Customer("Mike Angelo", address);
        product = new Product("Bear Brand", "LD1003242", 7.21, 3);
        products.Add(product);
        product = new Product("Lucky Me", "TY0097564", 2.11, 5);
        products.Add(product);
        product = new Product("Silver Swan", "BB0040506", 1.27, 6);
        products.Add(product);
        order = new Order(products, customer);

        orders.Add(order);
        products = new List<Product>();
        address = new Address("4372 L Avelino 1700", "Paranaque", "", "Philippines");
        customer = new Customer("Juan Dela Cruz", address);
        product = new Product("Fudge Bar", "MK0076093", 3.17, 5);
        products.Add(product);
        product = new Product("Young's Town", "LJ0041902", 8.33, 2);
        products.Add(product);
        product = new Product("Mega Sardines", "P1081239", 9.71, 5);
        products.Add(product);
        order = new Order(products, customer);

        orders.Add(order);
    }
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Initialize(orders);
        foreach(Order order in orders){
            Console.WriteLine("Packing Label");
            Console.WriteLine(order.PackingLabel());
            Console.WriteLine("Shipping Label");
            Console.WriteLine(order.ShippingLabel());
            Console.WriteLine();
            Console.WriteLine($"Shipping Price: ${order.GetShippingPrice()}.00");
            Console.WriteLine($"Total Price: ${Math.Round(order.CalcTotalPrice(), 2)}\n");
        }
    }
}