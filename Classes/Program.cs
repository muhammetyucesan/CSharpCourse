namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "İzmir";
            customer.Id = 1;
            customer.FirstName = "Muhammet";
            customer.LastName = "Yücesan";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Kadriye",
                LastName = "Yücesan"
            };

            Console.WriteLine("\n--customer-- \n");
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.City);

            Console.WriteLine("\n--customer2-- \n");
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.City);
        }
    }
}