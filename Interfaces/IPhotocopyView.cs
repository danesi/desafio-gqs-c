using Desafio.Entities;

namespace Desafio.Interfaces
{
    public interface IPhotocopyView
    {
        /// <summary>
        /// Método que registra uma nova fotocópia
        /// </summary>
        public void RegisterPhotocopy();

        /// <summary>
        /// Método que mostra o resumo do pedido da fotocópia do usuário
        /// </summary>
        /// <param name="photocopy">Entidade que contem os dados do pedido da fotocópia do usuário</param> 
        public void Checkout(Photocopy photocopy);
    }
}