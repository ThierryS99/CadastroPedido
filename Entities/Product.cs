using System.Globalization;

namespace CadastroPedido.Entities
{
    class Product
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void ProductCharacteristic()
        {
            Console.Write("Product name: ");
            Name = Console.ReadLine();
            Console.Write("Product price: ");
            Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: ${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantity: {Quantity}";
        }
    }
}