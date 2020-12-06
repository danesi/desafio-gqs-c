using Desafio.Entities;
using Desafio.Interfaces;
using Desafio.View;

namespace Desafio.Views
{
    public class ClientView : ViewBase, IClientView
    {
        private Client Client;

        public ClientView()
        {
            Client = new Client();
        }

        /// <summary>
        /// Método que pede os dados do cliente pata inserir
        /// </summary>
        /// <returns>Retorna um Cliente com os dados do registro</returns>
        public Client InsertClient()
        {
            Clear();
            Write("----Registro de cliente----");
            Write("Digite seu nome:");
            string name = ReadString();
            
            Write("Digite seu CPF");
            string cpf = ReadCpf();

            Client.Name = name;
            Client.Cpf = cpf;
            return Client;
        }
    }
}