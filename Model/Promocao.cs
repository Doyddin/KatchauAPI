using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Katchau.Model
{
    public class Promocao
    {
        [Key] public int Id { get; set; }

        public string Nome { get; set; }
        public float Porcentagem { get; set; }
        
        [ForeignKey(nameof(Marca.Id))] 
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }

        [ForeignKey(nameof(Produto.Id))]
        public int? ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public bool Ativo { get; set; }

        public Promocao(float porcentagem, int marcaId, DateTime dataInicio, DateTime dataFim, int? produtoId)
        {
            Porcentagem = porcentagem;
            MarcaId = marcaId;
            ProdutoId = produtoId;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }
    }
}
