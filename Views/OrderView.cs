using System;
using Desafio.Entities;
using Desafio.Enums;
using Desafio.Interfaces;
using Desafio.View;

namespace Desafio.Views
{
    public class OrderView : ViewBase, IOrderView
    {
        private Client Client; 

        public OrderView(Client client = null)
        {
            Client = client;
        }

        /// <summary>
        /// Método que inicia o pedido, inserindo um novo cliente
        /// </summary>
        public void Start()
        {
            IClientView clientView = new ClientView();
            Client = clientView.InsertClient();
            PlaceOrder();
        }

        /// <summary>
        /// Método que o cliente escolhe qual pedido deseja
        /// </summary>
        public void PlaceOrder()
        {
            Clear();
            Write("Qual pedido você deseja?");
            Write("Digite 1 - Fotocópias / 2 - Impressão");
            int order = Read1Or2();

            if (order == 1)
            {
                IPhotocopyView photocopyView = new PhotocopyView(Client);
                photocopyView.RegisterPhotocopy();
            }
            else
            {
                IPrintView printView = new PrintView(Client);
                printView.RegisterPrint();
            }
        }

        /// <summary>
        /// Método que o cliente escolhe a cor
        /// </summary>
        /// <returns>Retorna o valor da cor que o cliente escolheu</returns>
        public ColorEnum GetColor()
        {
            Clear();
            Write("Escolha a cor a cor:");
            Write("1 - Preto e branco => R$ 0.05 / cópia");
            Write("2 - Colorido => R$ 0.10 / cópia");
            int color = Read1Or2();
            return color == 1 ? ColorEnum.PretoBranco : ColorEnum.Colorido;
        }
        
        /// <summary>
        /// Método que permite que o cliente escolhe se ele quer ou não encadernar
        /// </summary>
        /// <returns>Retorna se o usuário quer ou não que ele encaderne</returns>
        public bool GetBind()
        {
            Clear();
            Write("Deseja encadernar (1 - sim / 2 - não)");
            int option = Read1Or2();
            return option == 1;
        }

        /// <summary>
        /// Método em que solicita o número de cópias para o cliente
        /// </summary>
        /// <returns>Retorna o número de cópias</returns>
        public int GetNumberCopies()
        {
            Clear();
            Write("Digite o número de cópias:");
            return ReadInt(); 
        }

        /// <summary>
        /// Método em que solicita o número paginas a serem copiadas para o cliente
        /// </summary>
        /// <returns>Retorna o número paginas a serem copiadas</returns>
        public int GetNumberPagesCopies()
        {
            Clear();
            Write("Digite o número de páginas a serem copiadas:");
            return ReadInt(); 
        }

        /// <summary>
        /// Método que solicia o intervalo de impressão para o cliente, separdo por "-"
        /// </summary>
        /// <returns>Retorna um array com o intervalo da impressão</returns>
        public int[] GetPrintRange()
        {
            Clear();
            Write("Digite o intervalo de impressão (separado por - )");
            int[] range;
            try
            {
                range = Array.ConvertAll(ReadString().Split("-"), r => int.Parse(r));
                return range;
            }
            catch (Exception e)
            {
                Write("Intervalo inválido, tente novamente (precione enter para continuar)");
                ReadString();
                return GetPrintRange();
            }
        }

        /// <summary>
        /// Método que solocita ao cliente o nome do arquivo
        /// </summary>
        /// <returns>Retorna o nome do arquivo</returns>
        public string GetFileName()
        {
            Clear();
            Write("Digite o nome do arquivo");
            return ReadString();
        }
    }
}