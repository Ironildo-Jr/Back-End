namespace Models
{
    public class CotacaoProd
    {
        public CotacaoProd() { }
        public CotacaoProd( int cotid, int prodid)
        {
            this.CotId = cotid;
            this.ProdId = prodid;
        }
        public int CotId { get; set; }
        public Cotacao Cotacao { get; set; }
        public int ProdId { get; set; }
        public Produto Produto { get; set; }
    }
}
