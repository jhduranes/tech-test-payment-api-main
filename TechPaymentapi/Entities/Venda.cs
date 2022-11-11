namespace Entities
{
    public class Venda
    {
        public int idVenda { get; set; }
        public int idProduto { get; set; }
        public DateTime data { get; set; }
        public decimal valorTotal { get; set; }
    }
}
