using System.ComponentModel.DataAnnotations;

namespace Katchau.Model
{
    public class Marca
    {
        [Key] public int Id { get; set; }
        public string Nome { get; set; }
    }
}
