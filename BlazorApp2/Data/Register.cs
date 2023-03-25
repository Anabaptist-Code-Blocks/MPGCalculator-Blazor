namespace BlazorApp2.Data
{
    public class Register
    {
        public string Payee { get; set; }
        public string CheckNumber { get; set; }
        public DateTime TxnDate { get; set; }
        public string Description { get; set; }
        public decimal Credit { get; set; }
        public decimal Debit  { get; set; }
        public decimal Balance { get; set; }
    }
}
