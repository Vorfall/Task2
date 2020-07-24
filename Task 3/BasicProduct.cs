namespace Prodicts
{
    /// <summary>
    /// Base class for subsequent products
    /// </summary>
    public class BasicProduct
    {
        /// <summary>
        /// name
        /// </summary>
        private string _name;

        /// <summary>
        /// price
        /// </summary>
        private double _price;

        /// <summary>
        /// type
        /// </summary>
        private string _type;

        /// <summary>
        /// Constructor to initialize a product.    
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="price"></param>
        public BasicProduct(string name, string type, double price)
        {
            this._name = name;
            this._price = price;
            this._type = type;
        }

        /// <summary>
        /// Property returning a product name.
        /// </summary>
        public string Name { get => _name; set => _name = value; }


        /// <summary>
        /// Property returning a product price.
        /// </summary>
        public double Price { get => _price; set => _price = value; }

        /// <summary>
        /// Property returning a product type.
        /// </summary>
        public string Type { get => _type; set => _type = value; }

       
    }
}
