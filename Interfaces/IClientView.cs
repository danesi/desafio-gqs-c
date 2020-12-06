using Desafio.Entities;

namespace Desafio.Interfaces
{
    public interface IClientView
    {
        /// <summary>
        /// Método que pede os dados do cliente pata inserir
        /// </summary>
        /// <returns>Retorna um Cliente com os dados do registro</returns>
        public Client InsertClient();
    }
}