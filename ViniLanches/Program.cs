 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViniLanches
{
    internal class Program
    {
       struct Pedidos 
        {
        public string Cliente;
        public string Nome;
        public string Código;
        public string Valor;

            public Pedidos(string Cliente, string Nome, string Código, string Valor)
            {
                this.Cliente = Cliente;
                this.Nome = Nome;
                this.Código = Código;
                this.Valor = Valor;
            }
            public void ExibirDados()
            {
                Console.WriteLine($"Cliente:{Cliente} \nNome: {Nome} \nCódigo: {Código} \nValor: {Valor}");
            }
       }

        static void Main(string[] args)
        {
            

            List<Pedidos> pedidos = new List<Pedidos>();

            pedidos.Add(new Pedidos("Maycon","X-salada", "003", "$21,00"));
            pedidos.Add(new Pedidos("Jonny", "X-burguer", "007", "$33,00"));
            pedidos.Add(new Pedidos("Marcos", "X-bacon", "001", "$19,00"));
            foreach (Pedidos Pedidos in pedidos)
            {
              Pedidos.ExibirDados();
              Console.WriteLine();
            }

            Queue<string> fila = new Queue<string>();
            fila.Enqueue("Maycon");
            fila.Enqueue("Jonny");
            fila.Enqueue("Marcos");

            Console.WriteLine($"Número de pessoas na fila: {fila.Count}");
            Console.WriteLine($"Próximo da fila: {fila.Peek()}");
            Console.WriteLine($"Retire seu pedido no balcão ao lado: {fila.Count}");







            Console.ReadKey();


        }
    }
}
