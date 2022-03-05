namespace Models
{
    public class CotacaoForn
    {
        public CotacaoForn() { }
        public CotacaoForn( int cotid, int fornid)
        {
            this.CotId = cotid;
            this.FornId = fornid;
        }
        public int CotId { get; set; }
        public Cotacao Cotacao { get; set; }
        public int FornId { get; set; }
        public Fornecedor Fornecedor { get; set; }
    }
}
