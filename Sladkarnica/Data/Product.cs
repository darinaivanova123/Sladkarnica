using System.ComponentModel;

namespace Sladkarnica.Data
{
    public enum Size { malka, golqma, sredna }
public class Product
    {
        public int Id { get; set; }
        public string Catalognumber { get; set; }
        public int CategoriesId { get; set; }
        public Category Categories { get; set; }
        public Size Size {get;set;}
        public decimal Weight { get; set; }
        public bool Gluten { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set;}
        public decimal Price { get; set;}
        public DateTime DateModification { get; set;}=DateTime.Now;
       public ICollection<Order> Orders { get; set; }
    }

   
}
