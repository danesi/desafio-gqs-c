using System;
using Desafio.Views;

namespace Desafio
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a nossa gráfica...");
            Console.WriteLine("Precione qualquer tecla para realizar seu pedido");
            Console.ReadLine();
            OrderView orderView = new OrderView();
            orderView.Start();
        }
    }
}
