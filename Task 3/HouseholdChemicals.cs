namespace Prodicts
{
    public class HouseholdChemicals:BasicProduct
    {
        public HouseholdChemicals(string name, string type, double price): base(name, type, price)
        {
           
        }

        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>A new class combining classes a and b</returns>
        public static HouseholdChemicals operator +(HouseholdChemicals a, HouseholdChemicals b) => new HouseholdChemicals(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        


        /// <summary>
        /// Converts this class object into a Food class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Food(HouseholdChemicals a) => new Food(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Book class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Book(HouseholdChemicals a) => new Book(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Technic class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Technic(HouseholdChemicals a) => new Technic(a.Name, a.Type, a.Price);
        

       
        /// <summary>
        /// Returns price
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator double(HouseholdChemicals a) => a.Price;


        /// <summary>
        /// Comparing
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If equal / unequal <=> true / false</returns>
        public override bool Equals(object obj)
        {
            if(obj is HouseholdChemicals)
            {
                HouseholdChemicals chemical = obj as HouseholdChemicals;

                if(this.Name == chemical.Name && this.Price == chemical.Price && this.Type == chemical.Type)
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
        public override int GetHashCode() => Type.GetHashCode() ^ Price.GetHashCode() ^ Name.GetHashCode();
        
    }
}
