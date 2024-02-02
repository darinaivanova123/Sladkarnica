namespace Sladkarnica.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public Client Clients { get; set; }
        public int ProductsId { get; set; }
        public int Quantity { get; set; }
        public DateTime Created { get; set; }= DateTime.Now;
    }
}
