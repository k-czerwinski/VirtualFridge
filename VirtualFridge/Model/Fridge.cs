namespace VirtualFridge.Model
{
    public class Fridge
    {
        private static List<Product> _products = new List<Product>();
        public static List<Product> Products{ get { return _products; } } 

        public Fridge()
        {
            
        }
        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public static void RemoveProduct(Product product)
        {
            _products.Remove(product);
        }
    }
}
