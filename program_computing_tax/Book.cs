namespace program_computing_tax
{
    public class Book :Product
    {
        public override double computeTax()
        {
            return ProductPrice * 5 / 100;
        }
    }
}