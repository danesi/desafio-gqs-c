namespace Desafio.Interfaces
{
    public interface IViewBase
    {
        /// <summary>
        /// Método que escreve no console
        /// </summary>
        /// <param name="words">Palavras que vão ser escritas</param>
        public void Write(string words);

        /// <summary>
        /// Método para pausar a execução e continuar quando o usuário pecionar alguma tecla
        /// </summary>
        public void ComeBack();

        /// <summary>
        /// Método que limpa a tela do console
        /// </summary>
        public void Clear();
        
        /// <summary>
        /// Método responsável pela leitura de valores em string
        /// </summary>
        /// <returns>retorna a string que o usuário digitou</returns>
        public string ReadString();

        /// <summary>
        /// Método que le e valida se o cpf tem 11 digitos, e se ele é composto somente por números
        /// </summary>
        /// <returns>Retorna o cpf digitado pelo usuário</returns>
        public string ReadCpf();

        /// <summary>
        /// Método que le uma string e converte para um inteiro e verifica se ele é maior que 0
        /// </summary>
        /// <returns>Retorna o valor inteiro digitado pelo usuário</returns>
        public int ReadInt();

        /// <summary>
        /// Método que le uma string e converte para inteiro e verifica se é o número 1 ou 2
        /// </summary>
        /// <returns>Retorna o numero digitado pelo usuário</returns>
        public int Read1Or2();
    }
}