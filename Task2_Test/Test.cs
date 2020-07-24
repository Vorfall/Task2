using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Polynomial;

namespace Task2Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void PolyPositiveIntoNegative1()
        {
            double testX0 = 2;
            double testX1 = 3;
            double testX2 = 4;
            double testX3 = 5;
        
            Polymonial polyToTest = new Polymonial(testX0, testX1, testX2, testX3);

            double expectetX0 = -2;
            double expectetX1 = -3;
            double expectetX2 = -4;
            double expectetX3 = -5;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            polyToTest = -polyToTest;

            Assert.IsTrue(polyToExpected.Equals(polyToTest));
            
        }

        [TestMethod]
        public void PolyPositiveIntoNegative2()
        {
            double testX0 = -3;
            double testX1 = -4;
            double testX2 = -5;
            double testX3 = -6;

            Polymonial polyToTest = new Polymonial(testX0, testX1, testX2, testX3);

            double expectetX0 = 3;
            double expectetX1 = 4;
            double expectetX2 = 5;
            double expectetX3 = 6;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            polyToTest = -polyToTest;

            Assert.IsTrue(polyToExpected.Equals(polyToTest));

        }

        

        [TestMethod]
        public void PolyAdditions1()
        {
            double test1X0 = 1;
            double test1X1 = 2;
            double test1X2 = 3;
            double test1X3 = 4;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double test2X0 = 4;
            double test2X1 = 3;
            double test2X2 = 2;
            double test2X3 = 1;

            Polymonial polyToTest2 = new Polymonial(test2X0, test2X1, test2X2, test2X3);

            double expectetX0 = 5;
            double expectetX1 = 5;
            double expectetX2 = 5;
            double expectetX3 = 5;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + polyToTest2));
        }

        
       
        [TestMethod]
        public void PolySubstractio1()
        {
            double test1X0 = 1;
            double test1X1 = 1;
            double test1X2 = 1;
            double test1X3 = 1;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double test2X0 = 1;
            double test2X1 = 1;
            double test2X2 = 1;
            double test2X3 = 1;

            Polymonial polyToTest2 = new Polymonial(test2X0, test2X1, test2X2, test2X3);

            double expectetX0 = 0f;
            double expectetX1 = 0f;
            double expectetX2 = 0f;
            double expectetX3 = 0f;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 - polyToTest2));
        }

       
        [TestMethod]
        public void PolyMultiplicationWithDifferentDegrees()
        {
            double test1X0 = 10;
            double test1X1 = -1;
            double test1X2 = 0;
            double test1X3 = 4;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double test2X0 = 2;
            double test2X1 = -1;
            double test2X2 = 1;
            double test2X3 = 3;
            double test2X4 = 1;

            Polymonial polyToTest2 = new Polymonial(test2X0, test2X1, test2X2, test2X3, test2X4);

            double expectetX0 = 20;
            double expectetX1 = -12;
            double expectetX2 = 11;
            double expectetX3 = 37;
            double expectetX4 = 3;
            double expectetX5 = 3;
            double expectetX6 = 12;
            double expectetX7 = 4;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3,expectetX4, expectetX5, expectetX6, expectetX7);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * polyToTest2));
        }

        [TestMethod]
        public void PolyMultiplicationWithSameDegrees()
        {
            double test1X0 = 3;
            double test1X1 = 12;
            double test1X2 = 134;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double test2X0 = 2;
            double test2X1 = 3;
            double test2X2 = -5;

            Polymonial polyToTest2 = new Polymonial(test2X0, test2X1, test2X2);

            double expectetX0 = 6;
            double expectetX1 = 33;
            double expectetX2 = 289;
            double expectetX3 = 342;
            double expectetX4 = -670;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3, expectetX4);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * polyToTest2));
        }

        [TestMethod]
        public void PolyAdditionWithDouble()
        {
            double test1X0 = 3;
            double test1X1 = 33;
            double test1X2 = 289;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double b = -3;

            double expectetX0 = 0;
            double expectetX1 = 33;
            double expectetX2 = 289;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 + b));
        }


        [TestMethod]
        public void PolyAdditionWithDoubleButDoubleFirst()
        {
            double test1X0 = 3;
            double test1X1 = 33;
            double test1X2 = 289;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double b = -3;

            double expectetX0 = 0;
            double expectetX1 = 33;
            double expectetX2 = 289;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2);

            Assert.IsTrue(polyToExpected.Equals(b + polyToTest1));
        }

        [TestMethod]
        public void PolyAdditionWithDoubleButDoubleFirst2()
        {
            double test1X0 = 5124;
            double test1X1 = 33;
            double test1X2 = 289;
            double test1X3 = 41219;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double b = -512;

            double expectetX0 = 4612;
            double expectetX1 = 33;
            double expectetX2 = 289;
            double expectetX3 = 41219;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            Assert.IsTrue(polyToExpected.Equals(b + polyToTest1));
        }


       

             
        [TestMethod]
        public void PolySubstractionWithDoubleButDoubleFirst1()
        {
            double test1X0 = 3;
            double test1X1 = 33;
            double test1X2 = 289;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double b = -3;

            double expectetX0 = 6;
            double expectetX1 = 33;
            double expectetX2 = 289;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2);

            Assert.IsTrue(polyToExpected.Equals(b - polyToTest1));
        }

        [TestMethod]
        public void PolySubstractionWithDoubleButDoubleFirst2()
        {
            double test1X0 = 5124;
            double test1X1 = 33;
            double test1X2 = 289;
            double test1X3 = 41219;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double b = -512;

            double expectetX0 = 5636;
            double expectetX1 = 33;
            double expectetX2 = 289;
            double expectetX3 = 41219;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            Assert.IsTrue(polyToExpected.Equals(b - polyToTest1));
        }

       
        [TestMethod]
        public void PolyMultiplicationWithDouble1()
        {
            double test1X0 = 1;
            double test1X1 = 1;
            double test1X2 = 1;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double b = 3;

            double expectetX0 = 3;
            double expectetX1 = 3;
            double expectetX2 = 3;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * b));
        }

        [TestMethod]
        public void PolyMultiplicationWithDouble2()
        {
            double test1X0 = 10;
            double test1X1 = 15;
            double test1X2 = 20;
            double test1X3 = 25;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double b = 2;

            double expectetX0 = 20;
            double expectetX1 = 30;
            double expectetX2 = 40;
            double expectetX3 = 50;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 * b));
        }

       

        [TestMethod]
        public void PolyMultiplicationWithDoubleButDoubleFirst1()
        {
            double test1X0 = 3;
            double test1X1 = 33;
            double test1X2 = 333;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double b = 2;

            double expectetX0 = 6;
            double expectetX1 = 66;
            double expectetX2 = 666;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2);

            Assert.IsTrue(polyToExpected.Equals(b * polyToTest1));
        }

        [TestMethod]
        public void PolyMultiplicationWithDoubleButDoubleFirst2()
        {
            double test1X0 = 1;
            double test1X1 = 2;
            double test1X2 = 3;
            double test1X3 = 4;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2, test1X3);

            double b = 2;

            double expectetX0 = 2;
            double expectetX1 = 4;
            double expectetX2 = 6;
            double expectetX3 = 8;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2, expectetX3);

            Assert.IsTrue(polyToExpected.Equals(b * polyToTest1));
        }

       

        [TestMethod]
        public void PolyDivisionWithDouble1()
        {
            double test1X0 = 22;
            double test1X1 = 222;
            double test1X2 = 2222;

            Polymonial polyToTest1 = new Polymonial(test1X0, test1X1, test1X2);

            double b = 2;

            double expectetX0 = 11;
            double expectetX1 = 111;
            double expectetX2 = 1111;

            Polymonial polyToExpected = new Polymonial(expectetX0, expectetX1, expectetX2);

            Assert.IsTrue(polyToExpected.Equals(polyToTest1 / b));
        }

      

      
    }
}
