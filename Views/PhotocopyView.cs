using Desafio.Entities;
using Desafio.Interfaces;

namespace Desafio.Views
{
    public class PhotocopyView : OrderView, IPhotocopyView
    {
        private Photocopy Photocopy;
        private Client Client;
        public PhotocopyView(Client client) : base(client)
        {
            Photocopy = new Photocopy();
            Client = client;
        }

        /// <summary>
        /// Método que registra uma nova fotocópia
        /// </summary>
        public void RegisterPhotocopy()
        {
            Photocopy.Color = GetColor();
            Photocopy.Bind = GetBind();
            Photocopy.NumberCopies = GetNumberCopies();
            Photocopy.NumberPagesCopies = GetNumberPagesCopies();
            Checkout(Photocopy);
        }

        /// <summary>
        /// Método que mostra o resumo do pedido da fotocópia do usuário
        /// </summary>
        /// <param name="photocopy">Entidade que contem os dados do pedido da fotocópia do usuário</param>        
        public void Checkout(Photocopy photocopy)
        {
            Clear();
            Write("--------Resumo do pedido--------");
            Write("Cliente:");
            Write($"        Nome: {Client.Name}");
            Write($"        CPF: {Client.GetCpf()}");
            Write("Pedido:");
            Write($"        Cor: {photocopy.GetColor()}");
            Write($"        Encadernado: {photocopy.GetBind()}");
            Write($"        Número de cópias: {photocopy.NumberCopies}");
            Write($"        Número de páginas copiadas: {photocopy.NumberPagesCopies}");
            Write("");
            Write($"Preço final: {photocopy.GetPrice()}");
            ComeBack();
        }
    }
}