namespace program_computing_tax
{
    public class Phone : Product
    {
        public override double computeTax()
        {
            return ProductPrice * 10 / 100;
        }
    }
}