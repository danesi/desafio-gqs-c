using System;

namespace Desafio.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string Cpf { get; set; }

        /// <summary>
        /// Método que formata o cpf do cliente
        /// </summary>
        /// <returns>Retorna o cpf formatado</returns>
        public string GetCpf()
        {
            return Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");
        }
        
    }
}