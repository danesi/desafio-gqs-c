using Desafio.Entities;
using Desafio.Enums;

namespace Desafio.Interfaces
{
    public interface IOrderView
    {
        /// <summary>
        /// Método que inicia o pedido, inserindo um novo cliente
        /// </summary>
        public void Start();
        
        /// <summary>
        /// Método que o cliente escolhe qual pedido deseja
        /// </summary>
        public void PlaceOrder();

        /// <summary>
        /// Método que o cliente escolhe a cor
        /// </summary>
        /// <returns>Retorna o valor da cor que o cliente escolheu</returns>
        public ColorEnum GetColor();

        /// <summary>
        /// Método que permite que o cliente escolhe se ele quer ou não encadernar
        /// </summary>
        /// <returns>Retorna se o usuário quer ou não que ele encaderne</returns>
        public bool GetBind();

        /// <summary>
        /// Método em que solicita o número de cópias para o cliente
        /// </summary>
        /// <returns>Retorna o número de cópias</returns>
        public int GetNumberCopies();

        /// <summary>
        /// Método em que solicita o número paginas a serem copiadas para o cliente
        /// </summary>
        /// <returns>Retorna o número paginas a serem copiadas</returns>
        public int GetNumberPagesCopies();

        /// <summary>
        /// Método que solicia o intervalo de impressão para o cliente, separdo por "-"
        /// </summary>
        /// <returns>Retorna um array com o intervalo da impressão</returns>
        public int[] GetPrintRange();

        /// <summary>
        /// Método que solocita ao cliente o nome do arquivo
        /// </summary>
        /// <returns>Retorna o nome do arquivo</returns>
        public string GetFileName();
    }
}