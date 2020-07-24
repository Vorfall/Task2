namespace Prodicts
{
    public class Technic:BasicProduct
    {
        public Technic(string name, string type, double price) : base(name, type, price)
        {

        }

        /// <summary>
        /// addition
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>A new class combining classes a and b</returns>
        public static Technic operator +(Technic a, Technic b) => new Technic(a.Name + " - " + b.Name, a.Type, (a.Price + b.Price) / 2);
        

        /// <summary>
        /// Converts this class object into a HouseholdChemicals class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator HouseholdChemicals(Technic a) => new HouseholdChemicals(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Book class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Book(Technic a) => new Book(a.Name, a.Type, a.Price);
        

        /// <summary>
        /// Converts this class object into a Food class
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator Food(Technic a) => new Food(a.Name, a.Type, a.Price);
        


        /// <summary>
        /// Returns price
        /// </summary>
        /// <param name="a"></param>
        public static explicit operator double(Technic a) => a.Price;


        /// <summary>
        /// Сomparin
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>If equal / unequal <=> true / false</returns>
        public override bool Equals(object obj)
        {
            if (obj is Technic)
            {
                Technic technic = obj as Technic;

                if (this.Name == technic.Name && this.Price == technic.Price && this.Type == technic.Type)
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
        public override int GetHashCode() => (Type.GetHashCode() ^ Price.GetHashCode() ^ Name.GetHashCode());
        
    }
}
