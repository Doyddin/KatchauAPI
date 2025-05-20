namespace Katchau.Model.DTO
{
    public class PromocaoDTO
    {
        public float Porcentagem { get; set; }
        public string MarcaNome { get; set; }
        public int? ProdutoId { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Promocao toModel(int marcaId) { 
            return new Promocao(Porcentagem, marcaId, DataInicio, DataFim, ProdutoId); 
        }
    }
}
