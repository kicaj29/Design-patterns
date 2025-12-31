namespace FactoryPattern
{
    public static class CustomerFactory
    {
        private static int _idCounter = 1;

        public static Customer CreateCustomer(string name)
        {
            return new Customer
            {
                Id = _idCounter++,
                Name = name
            };
        }
    }
}
