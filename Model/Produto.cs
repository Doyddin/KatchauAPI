using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katchau.Model
{
    public class Produto
    {
        [Key] public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        
        [ForeignKey(nameof(Marca.Id))]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}
