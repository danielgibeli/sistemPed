using System;
using System.Globalization;
using SistemPed.Entities;
using SistemPed.Entities.Enums;

namespace SistemPed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter cliente data:");
            System.Console.Write("Name: ");
            string name = Console.ReadLine();
            System.Console.Write("Email: ");
            string email = Console.ReadLine();
            System.Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse("dd/MM/yyyy");

            Client client = new Client(name, email, birthDate);

            System.Console.WriteLine("Enter order data:");
            System.Console.Write("Status: ");

            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now, status, client);

            System.Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            for (int i = 0; i < items; i++)
            {
                Console.WriteLine("Enter #" + i + " item data:");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);

                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price);
                order.AddItem(orderItem);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("ORDER SUMMARY:");
            System.Console.WriteLine(order);
        }
    }
}
