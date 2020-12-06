using Desafio.Enums;

namespace Desafio.Entities
{
    public class Print : Photocopy
    {
        public int[] PrintRange { get; set; }
        public string FileName { get; set; }
        
    }
}