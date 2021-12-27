namespace Models
{
    public class Product
    {
        string name;
        string description;
        decimal price;

        //Properties ************************
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        //Constructors ************************
        public Product()
        {

        }

        public Product(string Name, decimal Price, string Description)
        {
            name = Name;
            price = Price;
            description = Description;
        }
    }
}