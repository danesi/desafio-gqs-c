using System;
using System.Linq;
using Desafio.Interfaces;

namespace Desafio.View
{
    public class ViewBase : IViewBase
    {
        /// <summary>
        /// Método que escreve no console
        /// </summary>
        /// <param name="words">Palavras que vão ser escritas</param>
        public void Write(string words)
        {
            Console.WriteLine(words);
        }

        /// <summary>
        /// Método para pausar a execução e continuar quando o usuário pecionar alguma tecla
        /// </summary>
        public void ComeBack()
        {
            Console.WriteLine("Precione enter para continuar");
            Console.ReadLine();
        }

        /// <summary>
        /// Método que limpa a tela do console
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// Método responsável pela leitura de valores em string
        /// </summary>
        /// <returns>retorna a string que o usuário digitou</returns>
        public string ReadString()
        {
            return Console.ReadLine();
        }
        
        /// <summary>
        /// Método que le e valida se o cpf tem 11 digitos, e se ele é composto somente por números
        /// </summary>
        /// <returns>Retorna o cpf digitado pelo usuário</returns>
        public string ReadCpf()
        {
            string cpf = Console.ReadLine();
            if (cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                Write("Valor invalido, tente novamente:");
                ReadCpf();
            }
            
            return cpf;
        }
        
        /// <summary>
        /// Método que le uma string e converte para um inteiro e verifica se ele é maior que 0
        /// </summary>
        /// <returns>Retorna o valor inteiro digitado pelo usuário</returns>
        public int ReadInt()
        {
            int value;
            try
            {
                value = int.Parse(ReadString());
                if (value > 0)
                    return value;
                else
                    throw new Exception();

            }
            catch (Exception e)
            {
                Write("Valor invalido, tente novamente:");
                return ReadInt();
            }
        }
        
        /// <summary>
        /// Método que le uma string e converte para inteiro e verifica se é o número 1 ou 2
        /// </summary>
        /// <returns>Retorna o numero digitado pelo usuário</returns>
        public int Read1Or2()
        {
            int value = ReadInt();
            if (value == 1 || value == 2)
                return value;
            else
            {
                Write("Valor invalido, tente novamente:");
                return Read1Or2();
            }
        }
    }
}