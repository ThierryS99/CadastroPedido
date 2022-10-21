using System.Globalization;
using System.Text;
using CadastroPedido.Entities.Enums;

namespace CadastroPedido.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }

        Client client = new Client();

        public List<Product> productsList { get; set; } = new List<Product>();

        public Order()
        {
        }

        public Order(DateTime moment)
        {
            Moment = moment;
        }

        public void AddItem(Product product)
        {
            productsList.Add(product);
        }

        public void RemoveItem(Product product)
        {
            productsList.Remove(product);
        }

        public double SubTotal(Product product)
        {
            return product.Price * product.Quantity;
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (Product product in productsList)
            {
                sum += SubTotal(product);
            }
            return sum;
        }

        public void OrderInput()
        {
            client.DataEnter(); // PRIMEIRAMENTE CADASTRA O CLIENTE

            Console.Clear();
            Moment = DateTime.Now;
            Console.WriteLine("ENTER ORDER DATA:");
            Console.WriteLine();
            Console.Write("Status: ");
            Console.WriteLine(OrderStatus.Processing);
            Console.Write("How many items to this order: ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Product product = new Product();

                Console.WriteLine();
                Console.WriteLine($"ENTER #{i} ITEM DATA: ");

                product.ProductCharacteristic();
                AddItem(product);
            }
        }

        public override string ToString()
        {
            Console.Clear();
            StringBuilder orderSumary = new StringBuilder();

            orderSumary.AppendLine("ORDER SUMARY");
            orderSumary.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
            orderSumary.AppendLine($"Order Status: {OrderStatus.Processing.ToString()}");
            orderSumary.AppendLine($"Client: {client.Name} ({client.BirthDate.ToString("dd/MM/yyyy")}) - {client.Email}");
            orderSumary.AppendLine($"Order Items: ");

            foreach (Product product in productsList)
            {
                orderSumary.AppendLine();
                orderSumary.AppendLine($"{product.ToString()}");
                orderSumary.AppendLine($"Subtotal: {SubTotal(product).ToString("F2", CultureInfo.InvariantCulture)}");
            }
            orderSumary.AppendLine();

            orderSumary.Append($"TOTAL PRICE: ${Total().ToString("F2", CultureInfo.InvariantCulture)}");
            return orderSumary.ToString();
        }
    }
}