using Desafio.Entities;

namespace Desafio.Interfaces
{
    public interface IPrintView
    {
        /// <summary>
        /// Método que registra uma nova impressão
        /// </summary>
        public void RegisterPrint();

        /// <summary>
        /// Método que mostra o resumo do pedido de impressão do usuário
        /// </summary>
        /// <param name="print">Entidade que contem os dados do pedido da impressão do usuário</param>
        public void Checkout(Print print);
    }
}