using OnlineShop.Models.Products.ProductsModels.ComputersModels;


namespace OnlineShop.Models.Products.Computers
{
    public class Laptop : Computer
    {
        private const int OVERALL_PERFORMANCE = 15;

        public Laptop(int id, string manufacturer, string model, decimal price) 
            : base(id, manufacturer, model, price, OVERALL_PERFORMANCE)
        {
            
        }
    }
}
