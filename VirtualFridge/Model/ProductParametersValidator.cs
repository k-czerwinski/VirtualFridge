namespace VirtualFridge.Model
{
    public static class ProductParametersValidator
    {
        public static bool ValidateExpiryDate(DateTime expiryDate)
        {
            DateTime today = DateTime.Today.Date;
            if( expiryDate < today )
                return false;
            return true;
        }

        public static bool ValidateProteinPer100Gram(string txtproteinPer100Gram)
        {
            int proteinPer100Gram;
            if (!Int32.TryParse(txtproteinPer100Gram, out proteinPer100Gram))
                return false;    
         
            if ( proteinPer100Gram < 0 || proteinPer100Gram > 100)
                return false;
            return true;
        }

        public static bool ValidateProductName(string productName)
        {
            if ( string.IsNullOrEmpty(productName))
                return false;
            return true;
        }

    }
}
