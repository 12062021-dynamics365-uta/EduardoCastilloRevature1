namespace Models
{
    public class Product
    {
        string name;
        string description;
        double price;

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
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //Constructors ************************
        public Product()
        {

        }

        public Product(string Name, double Price, string Description)
        {
            name = Name;
            price = Price;
            description = Description;
        }
    }
}