namespace Prodicts
{
    public class Food : BasicProduct
    {
        public Food(string name, string type, double price) : base(name, type, price)
        {

        }

        /// <summary>
        /// Adition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>A new class combining classes a and b</returns> 
        public static Food operator +(Food a, Food b) => new Food(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        

        /// <summary>
        /// Converts this class object into a HouseholdChemicals class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator HouseholdChemicals(Food a) =>  new HouseholdChemicals(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Book class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Book(Food a) => new Book(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Technic class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Technic(Food a) => new Technic(a.Name, a.Type, a.Price);
        



        /// <summary>
        /// Returns price
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator double(Food a) => a.Price;


        /// <summary>
        /// Comparing 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If equal / unequal <=> true / false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Food)
            {
                Food food = obj as Food;

                if (this.Name == food.Name && this.Price == food.Price && this.Type == food.Type)
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
        /// Returns HashCode
        /// </summary>
        /// <returns>hashcode</returns>
        public override int GetHashCode() =>(Type.GetHashCode() ^ Price.GetHashCode() ^ Name.GetHashCode());
        
    }
}
