namespace program_computing_tax
{
    public abstract class Product
    {
        private int productId;
        private string productName;
        private int productPrice;

        public int ProductId
        {
            get => productId;
            set => productId = value;
        }

        public string ProductName
        {
            get => productName;
            set => productName = value;
        }

        public int ProductPrice
        {
            get => productPrice;
            set => productPrice = value;
        }

        public Product(string productId, string productName, int productPrice)
        {
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
        }

        public Product()
        {
        }

        public abstract double computeTax();
    }
}