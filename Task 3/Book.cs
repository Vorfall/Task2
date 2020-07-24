namespace Prodicts
{
    public class Book : BasicProduct
    {
        public Book(string name, string type, double price) : base(name, type, price)
        {

        }

        /// <summary>
        /// addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>A new class combining classes a and b</returns>
        public static Book operator +(Book a, Book b)=> new Book(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);


        /// <summary>
        /// Converts this class object into a HouseholdChemicals class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator HouseholdChemicals(Book a) => new HouseholdChemicals(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Food class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Food(Book a)=>  new Food(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Technic class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Technic(Book a) => new Technic(a.Name, a.Type, a.Price);
        

        
        /// <summary>
        /// Returns price
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator double(Book a) => a.Price;


        /// <summary>
        /// comparing
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If equal / unequal <=> true / false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Book)
            {
                Book furniture = obj as Book;

                if (this.Name == furniture.Name && this.Price == furniture.Price && this.Type == furniture.Type)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns HashCode of the object
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode() => (Type.GetHashCode() ^ Price.GetHashCode() ^ Name.GetHashCode());
        
    }
}
