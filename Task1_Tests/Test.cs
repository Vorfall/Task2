using System;
using SpaceVector;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1_Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void VectorNegativeIntoPositive1()
        {
            double testX = 9;
            double testY = 5;
            double testZ = 0;

            SpaceVector.SpaceVector spaceVectorToTest = new SpaceVector.SpaceVector(testX, testY, testZ);

            double expectetX = -9;
            double expectetY = -5;
            double expectetZ = -0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorToTest = -spaceVectorToTest;

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTest));
        }

        [TestMethod]
        public void VectorNegativeIntoPositive2()
        {
            double testX = 1;
            double testY = 5;
            double testZ = 0;

            SpaceVector.SpaceVector spaceVectorToTest = new SpaceVector.SpaceVector(testX, testY, testZ);

            double expectetX = -1;
            double expectetY = -5;
            double expectetZ = 0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorToTest = -spaceVectorToTest;

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTest));
        }
        [TestMethod]
        public void VectorDecrement1()
        {
            double testX = 100;
            double testY = 100;
            double testZ = 100;

            SpaceVector.SpaceVector spaceVectorToTest = new SpaceVector.SpaceVector(testX, testY, testZ);

            double expectetX = 99;
            double expectetY = 99;
            double expectetZ = 99;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorToTest = --spaceVectorToTest;

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTest));
        }

        [TestMethod]
        public void VectorDecrement2()
        {
            double testX = 0;
            double testY = 0;
            double testZ = 0;

            SpaceVector.SpaceVector spaceVectorToTest = new SpaceVector.SpaceVector(testX, testY, testZ);

            double expectetX = -1;
            double expectetY = -1;
            double expectetZ = -1;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorToTest = --spaceVectorToTest;

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTest));
        }

        [TestMethod]
        public void VectorDivisionByDouble1()
        {
            double testX1 = 30;
            double testY1 = -30;
            double testZ1 = 0;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double b = 2;

            double expectetX = 15;
            double expectetY = -15;
            double expectetZ = 0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA / b));
        }


        [TestMethod]
        public void VectorIncrement1()
        {
            double testX = 1;
            double testY = 2;
            double testZ = 3;

            SpaceVector.SpaceVector spaceVectorToTest = new SpaceVector.SpaceVector(testX, testY, testZ);

            double expectetX = 2;
            double expectetY = 3;
            double expectetZ = 4;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorToTest = ++spaceVectorToTest;

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTest));
        }

        [TestMethod]
        public void VectorIncrement2()
        {
            double testX = 99;
            double testY = 99;
            double testZ = 99;

            SpaceVector.SpaceVector spaceVectorToTest = new SpaceVector.SpaceVector(testX, testY, testZ);

            double expectetX = 100;
            double expectetY = 100;
            double expectetZ = 100;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorToTest = ++spaceVectorToTest;

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTest));
        }

       
        
        

        [TestMethod]
        public void VectorAddition1()
        {
            double testX1 = 123;
            double testY1 = 123;
            double testZ1 = 123;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 1;
            double testY2 = 1;
            double testZ2 = 1;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);



            double expectetX = 124;
            double expectetY = 124;
            double expectetZ = 124;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);


            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA + spaceVectorToTestB));
        }

      

        

        [TestMethod]
        public void VectorSubstraction1()
        {
            double testX1 = 1;
            double testY1 = 1;
            double testZ1 = 1;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 1;
            double testY2 = 1;
            double testZ2 = 1;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);

            double expectetX = 0;
            double expectetY = 0;
            double expectetZ = 0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);


            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA - spaceVectorToTestB));
        }

        

       

        [TestMethod]
        public void VectorMultiplication1()
        {
            double testX1 = 1;
            double testY1 = -1;
            double testZ1 = 0;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 515;
            double testY2 = 677;
            double testZ2 = -10000;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);

            double expectetX = 515;
            double expectetY = -677;
            double expectetZ = 0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA * spaceVectorToTestB));
        }

        [TestMethod]
        public void VectorMultiplication2()
        {
            double testX1 = 0;
            double testY1 = 0;
            double testZ1 = 0;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 5645;
            double testY2 = 546546;
            double testZ2 = -10546450;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);

            double expectetX = 0;
            double expectetY = 0;
            double expectetZ = 0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA * spaceVectorToTestB));
        }

       

        [TestMethod]
        public void VectorDivision1()
        {
            double testX1 = 150;
            double testY1 = 2;
            double testZ1 = 60;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 2;
            double testY2 = 2;
            double testZ2 = 2;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);

            double expectetX = 75;
            double expectetY = 1;
            double expectetZ = 30;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA / spaceVectorToTestB));
        }

        [TestMethod]
        public void VectorDivision2()
        {
            double testX1 = 100;
            double testY1 = 20;
            double testZ1 = 60;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 2;
            double testY2 = 2;
            double testZ2 = 2;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);

            double expectetX = 50;
            double expectetY = 10;
            double expectetZ = 30;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA / spaceVectorToTestB));
        }

       

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void VectorDivisionExeption()
        {
            double testX1 = -7856;
            double testY1 = 0;
            double testZ1 = 67890;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double testX2 = 0;
            double testY2 = 442;
            double testZ2 = 444;

            SpaceVector.SpaceVector spaceVectorToTestB = new SpaceVector.SpaceVector(testX2, testY2, testZ2);

            double expectetX = -25;
            double expectetY = 0;
            double expectetZ = 30;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            spaceVectorExpected.Equals(spaceVectorToTestA / spaceVectorToTestB);
        }

        [TestMethod]
        public void VectorMultiplicationByDouble1()
        {
            double testX1 = 154645;
            double testY1 = -154654;
            double testZ1 = 054645;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double b = 0;

            double expectetX = 0;
            double expectetY = 0;
            double expectetZ = 0;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA * b));
        }

        [TestMethod]
        public void VectorMultiplicationByDouble2()
        {
            double testX1 = 15;
            double testY1 = -15;
            double testZ1 =15;

            SpaceVector.SpaceVector spaceVectorToTestA = new SpaceVector.SpaceVector(testX1, testY1, testZ1);

            double b = 10;

            double expectetX = 150;
            double expectetY = -150;
            double expectetZ = 150;

            SpaceVector.SpaceVector spaceVectorExpected = new SpaceVector.SpaceVector(expectetX, expectetY, expectetZ);

            Assert.IsTrue(spaceVectorExpected.Equals(spaceVectorToTestA * b));
        }

        

       
       
    }
}
