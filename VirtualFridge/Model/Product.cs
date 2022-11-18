namespace VirtualFridge.Model
{
    public class Product
    {
        public DateTime ExpirationDate { get; }
        public string ProductName { get; }
        public int ProteinPer100Grams { get; }

        public Product(DateTime expirationDate, string productName, int proteinPer100grams)
        {
            ExpirationDate = expirationDate;
            ProductName = productName;
            ProteinPer100Grams = proteinPer100grams;
        }
    }
}
