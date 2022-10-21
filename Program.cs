using CadastroPedido.Entities;

namespace CadastroPedido
{
    class Program
    {
        public static void Main(string[] args)
        {
            // COLETA OS DADOS DOS PRODUTOS
            Order order = new Order();
            order.OrderInput();

            Console.WriteLine(order.ToString()); //IMPRIME NA TELA OS DADOS DA ORDEM
        }
    }
}