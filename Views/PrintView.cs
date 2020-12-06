using Desafio.Entities;
using Desafio.Interfaces;

namespace Desafio.Views
{
    public class PrintView : OrderView, IPrintView
    {
        private Print Print;
        private Client Client;
        
        public PrintView(Client client) : base(client)
        {
            Print = new Print();
            Client = client;
        }
        
        /// <summary>
        /// Método que registra uma nova impressão
        /// </summary>
        public void RegisterPrint()
        {
            Print.Color = GetColor();
            Print.Bind = GetBind();
            Print.NumberCopies = GetNumberCopies();
            Print.NumberPagesCopies = GetNumberPagesCopies();
            Print.PrintRange = GetPrintRange();
            Print.FileName = GetFileName();
            Checkout(Print);
        }
        
        /// <summary>
        /// Método que mostra o resumo do pedido de impressão do usuário
        /// </summary>
        /// <param name="print">Entidade que contem os dados do pedido da impressão do usuário</param>
        public void Checkout(Print print)
        {
            Clear();
            Write("--------Resumo do pedido--------");
            Write("Cliente:");
            Write($"        Nome: {Client.Name}");
            Write($"        CPF: {Client.GetCpf()}");
            Write("Pedido:");
            Write($"        Cor: {print.Color}");
            Write($"        Encadernado: {print.GetBind()}");
            Write($"        Número de cópias: {print.NumberCopies}");
            Write($"        Número de páginas copiadas: {print.NumberPagesCopies}");
            Write($"        Intervalor de impressão: da página {print.PrintRange[0]} até a {print.PrintRange[1]}");
            Write($"        Nome do arquivo: {print.FileName}");
            Write("");
            Write($"Preço final: {print.GetPrice()}");
            ComeBack();
        }
    }
}