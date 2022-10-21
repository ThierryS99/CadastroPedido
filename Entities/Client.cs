namespace CadastroPedido.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }

        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public void DataEnter()
        {
            Console.WriteLine("ENTER CLIENTE DATA:");
            Console.WriteLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
            Console.Write("E-mail: ");
            Email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            BirthDate = DateTime.Parse(Console.ReadLine());
        }
    }
}