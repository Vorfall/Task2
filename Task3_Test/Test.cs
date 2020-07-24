using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prodicts;

namespace Task3_Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void ChemicalCreation()
        {
            string testName = "Poison";
            float testPrice = 2.5f;
            string testType = "Medicine";
            HouseholdChemicals chemicalToTest = new HouseholdChemicals(testName, testType, testPrice);

            string ex_name = "Poison";
            float ex_price = 2.5f;
            string ex_type = "Medicine";
            HouseholdChemicals chemicalExpected = new HouseholdChemicals(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, chemicalToTest);
        }

       

        [TestMethod]
        public void ChemicalAddition()
        {
            string test1Name = "Poison";
            float test1Price = 2.5f;
            string test1Type = "Medicine";
            HouseholdChemicals chemicalToTest1 = new HouseholdChemicals(test1Name, test1Type, test1Price);

            string test2Name = "Acetyl acid";
            float test2Price = 3.5f;
            string test2Type = "Medicine";
            HouseholdChemicals chemicalToTest2 = new HouseholdChemicals(test2Name, test2Type, test2Price);


            string ex_name = "Poison - Acetyl acid";
            float ex_price = 3f;
            string ex_type = "Medicine";
            HouseholdChemicals chemicalExpected = new HouseholdChemicals(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, chemicalToTest1 + chemicalToTest2);
        }

        [TestMethod]
        public void ChemicalCastToFood()
        {
            string testName = "Poison";
            float testPrice = 2.5f;
            string testType = "Medicine";
            HouseholdChemicals chemicalToTest = new HouseholdChemicals(testName, testType, testPrice);

            string ex_name = "Poison";
            float ex_price = 2.5f;
            string ex_type = "Medicine";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, (Food) chemicalToTest);
        }

        [TestMethod]
        public void ChemicalCastToBook()
        {
            string testName = "Poison";
            float testPrice = 2.5f;
            string testType = "Medicine";
            HouseholdChemicals chemicalToTest = new HouseholdChemicals(testName, testType, testPrice);

            string ex_name = "Poison";
            float ex_price = 2.5f;
            string ex_type = "Medicine";
            Book bookExpected = new Book(ex_name, ex_type, ex_price);

            Assert.AreEqual(bookExpected, (Book)chemicalToTest);
        }

        [TestMethod]
        public void ChemicalCastToTechnic()
        {
            string testName = "Poison";
            float testPrice = 2.5f;
            string testType = "Medicine";
            HouseholdChemicals chemicalToTest = new HouseholdChemicals(testName, testType, testPrice);

            string ex_name = "Poison";
            float ex_price = 2.5f;
            string ex_type = "Medicine";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Technic)chemicalToTest);
        }

        [TestMethod]
        public void FoodCreation()
        {
            string testName = "Pizza";
            float testPrice = 2.5f;
            string testType = "Italian Cuisine";
            Food foodToTest = new Food(testName, testType, testPrice);

            string ex_name = "Pizza";
            float ex_price = 2.5f;
            string ex_type = "Italian Cuisine";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, foodToTest);
        }

       

        [TestMethod]
        public void FoodMoney()
        {
            string testName = "Pizza";
            float testPrice = 2.5f;
            string testType = "Italian Cuisine";
            Food foodToTest = new Food(testName, testType, testPrice);

            float coins = 2.5f;

            Assert.AreEqual(coins, (float)foodToTest);
        }

        [TestMethod]
        public void FoodAddition()
        {
            string test1Name = "Pizza";
            float test1Price = 2.5f;
            string test1Type = "Italian Cuisine";
            Food foodToTest1 = new Food(test1Name, test1Type, test1Price);

            string test2Name = "Spaghetti";
            float test2Price = 3.5f;
            string test2Type = "Italian Cuisine";
            Food foodToTest2 = new Food(test2Name, test2Type, test2Price);


            string ex_name = "Pizza - Spaghetti";
            float ex_price = 3f;
            string ex_type = "Italian Cuisine";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, foodToTest1 + foodToTest2);
        }

        [TestMethod]
        public void FoodCastToFood()
        {
            string testName = "Pizza";
            float testPrice = 2.5f;
            string testType = "Italian Cuisine";
            Food foodToTest = new Food(testName, testType, testPrice);

            string ex_name = "Pizza";
            float ex_price = 2.5f;
            string ex_type = "Italian Cuisine";
            HouseholdChemicals chemicalExpected = new HouseholdChemicals(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, (HouseholdChemicals)foodToTest);
        }

        [TestMethod]
        public void FoodCastToBook()
        {
            string testName = "Pizza";
            float testPrice = 2.5f;
            string testType = "Italian Cuisine";
            Food foodToTest = new Food(testName, testType, testPrice);

            string ex_name = "Pizza";
            float ex_price = 2.5f;
            string ex_type = "Italian Cuisine";
            Book bookExpected = new Book(ex_name, ex_type, ex_price);

            Assert.AreEqual(bookExpected, (Book)foodToTest);
        }

        [TestMethod]
        public void FoodCastToTechnic()
        {
            string testName = "Pizza";
            float testPrice = 2.5f;
            string testType = "Italian Cuisine";
            Food foodToTest = new Food(testName, testType, testPrice);

            string ex_name = "Pizza";
            float ex_price = 2.5f;
            string ex_type = "Italian Cuisine";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Technic)foodToTest);
        }

        [TestMethod]
        public void BookCreation()
        {
            string testName = "Kerry";
            float testPrice = 232f;
            string testType = "horror";
            Book bookToTest = new Book(testName, testType, testPrice);

            string ex_name = "Kerry";
            float ex_price = 232f;
            string ex_type = "horror";
            Book bookExpected = new Book(ex_name, ex_type, ex_price);

            Assert.AreEqual(bookExpected, bookToTest);
        }


     

        [TestMethod]
        public void BookAddition()
        {
            string test1Name = "Kerry";
            float test1Price = 235f;
            string test1Type = "horror";
            Book bookToTest1 = new Book(test1Name, test1Type, test1Price);

            string test2Name = "Pet cemetery";
            float test2Price = 305f;
            string test2Type = "horror";
            Book bookToTest2 = new Book(test2Name, test2Type, test2Price);


            string ex_name = "Kerry - Pet cemetery";
            float ex_price = 270f;
            string ex_type = "horror";
            Book bookExpected = new Book(ex_name, ex_type, ex_price);

            Assert.AreEqual(bookExpected, bookToTest1 + bookToTest2);
        }

        [TestMethod]
        public void BookCastToBook()
        {
            string testName = "Kerry";
            float testPrice = 232f;
            string testType = "horror";
            Book bookToTest = new Book(testName, testType, testPrice);

            string ex_name = "Kerry";
            float ex_price = 232f;
            string ex_type = "horror";
            HouseholdChemicals chemicalExpected = new HouseholdChemicals(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, (HouseholdChemicals)bookToTest);
        }

        [TestMethod]
        public void BookCastToFood()
        {
            string testName = "Kerry";
            float testPrice = 232f;
            string testType = "horror";
            Book bookToTest = new Book(testName, testType, testPrice);

            string ex_name = "Kerry";
            float ex_price = 232f;
            string ex_type = "horror";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, (Food)bookToTest);
        }

        [TestMethod]
        public void BookCastToTechnic()
        {
            string testName = "Kerry";
            float testPrice = 232f;
            string testType = "horror";
            Book bookToTest = new Book(testName, testType, testPrice);

            string ex_name = "Kerry";
            float ex_price = 232f;
            string ex_type = "horror";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Technic)bookToTest);
        }

        [TestMethod]
        public void TechnicCreation()
        {
            string testName = "Nintendo DSI";
            float testPrice = 1232f;
            string testType = "Porhorror game console";
            Technic technicToTest = new Technic(testName, testType, testPrice);

            string ex_name = "Nintendo DSI";
            float ex_price = 1232f;
            string ex_type = "Porhorror game console";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, technicToTest);
        }

       

        
        [TestMethod]
        public void TechnicAddition()
        {
            string test1Name = "Nintendo DSI";
            float test1Price = 1235f;
            string test1Type = "Porhorror game console";
            Technic technicToTest1 = new Technic(test1Name, test1Type, test1Price);

            string test2Name = "PSP";
            float test2Price = 305f;
            string test2Type = "Porhorror game console";
            Technic technicToTest2 = new Technic(test2Name, test2Type, test2Price);


            string ex_name = "Nintendo DSI - PSP";
            float ex_price = 770f;
            string ex_type = "Porhorror game console";
            Technic technicExpected = new Technic(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, technicToTest1 + technicToTest2);
        }

        [TestMethod]
        public void TechnicCastToTechnic()
        {
            string testName = "Nintendo DSI";
            float testPrice = 1232f;
            string testType = "Porhorror game console";
            Technic technicToTest = new Technic(testName, testType, testPrice);

            string ex_name = "Nintendo DSI";
            float ex_price = 1232f;
            string ex_type = "Porhorror game console";
            HouseholdChemicals chemicalExpected = new HouseholdChemicals(ex_name, ex_type, ex_price);

            Assert.AreEqual(chemicalExpected, (HouseholdChemicals)technicToTest);
        }

        [TestMethod]
        public void TechnicCastToFood()
        {
            string testName = "Nintendo DSI";
            float testPrice = 1232f;
            string testType = "Porhorror game console";
            Technic technicToTest = new Technic(testName, testType, testPrice);

            string ex_name = "Nintendo DSI";
            float ex_price = 1232f;
            string ex_type = "Porhorror game console";
            Food foodExpected = new Food(ex_name, ex_type, ex_price);

            Assert.AreEqual(foodExpected, (Food)technicToTest);
        }

        [TestMethod]
        public void TechnicCastToBook()
        {
            string testName = "Nintendo DSI";
            float testPrice = 1232f;
            string testType = "Porhorror game console";
            Technic technicToTest = new Technic(testName, testType, testPrice);

            string ex_name = "Nintendo DSI";
            float ex_price = 1232f;
            string ex_type = "Porhorror game console";
            Book technicExpected = new Book(ex_name, ex_type, ex_price);

            Assert.AreEqual(technicExpected, (Book)technicToTest);
        }
    }
}
