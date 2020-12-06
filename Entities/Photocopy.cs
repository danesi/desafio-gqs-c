
using System.Globalization;
using Desafio.Enums;
using Desafio.Interfaces;

namespace Desafio.Entities
{
    public class Photocopy
    {
        public ColorEnum Color { get; set; }
        public bool Bind { get; set; }
        public int NumberCopies { get; set; }
        public int NumberPagesCopies { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Método que encaderna, adicionando mais 2 reais ao preço total da compra
        /// </summary>
        public void ToBind()
        {
            Price += 2;
        }

        /// <summary>
        /// Método que calcula o valor do pedido do cliente
        /// </summary>
        public void CalculateValue()
        {
            int numberCopies = NumberCopies * NumberPagesCopies;
            if (Bind)
                ToBind();
            
            Price += Color == ColorEnum.PretoBranco ? numberCopies * 0.05 : numberCopies * 0.10;
        }

        /// <summary>
        /// Método que pega o valor final do pedido
        /// </summary>
        /// <returns>Retorna o valor final</returns>
        public string GetPrice()
        {
            CalculateValue();
            return Price.ToString("C", CultureInfo.CurrentCulture);
        }
        
        /// <summary>
        /// Método que verifica se está ou não encadernado
        /// </summary>
        /// <returns>Retorna se está ou não encadernado</returns>
        public string GetBind()
        {
            return Bind ? "Sim" : "Não";
        }
    }
}