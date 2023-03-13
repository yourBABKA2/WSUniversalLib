using WSUniversalLib;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        //“естирование метода вычислени€ необходимого сырь€ с заданными параметрами (1)
        [TestMethod]
        public void Test_GetQuantityForProduct_Successful()
        {
            int count = 15;
            float width = 20;
            float length = 45;
            int materialType = 1;
            int productType = 3;
            int expected = 114148;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта с шириной равной 0 (2)
        [TestMethod]
        public void Test_GetQuantityForProduct_ZeroWidth()
        {
            int count = 1;
            float width = 0;
            float length = 3;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта с длинной равной 0 (3)
        [TestMethod]
        public void Test_GetQuantityForProduct_ZeroLength()
        {
            int count = 1;
            float width = 2;
            float length = 0;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта кол-вом = 0 (4)
        [TestMethod]
        public void Test_GetQuantityForProduct_ZeroCount()
        {
            int count = 0;
            float width = 2;
            float length = 0;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта с несуществующим типом сырь€ (5)
        [TestMethod]
        public void Test_GetQuantityForProduct_NonExistentMaterialType()
        {
            int count = 2;
            float width = 2;
            float length = 0;
            int materialType = 5;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ кол-ва типа сырь€ дл€ несуществующего продукта (6)
        [TestMethod]
        public void Test_GetQuantityForProduct_NonExistentProductType()
        {
            int count = 2;
            float width = 2;
            float length = 0;
            int materialType = 1;
            int productType = 0;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ дл€ продукта кол-вом меньше нул€ (7)
        [TestMethod]
        public void Test_GetQuantityForProduct_CountBelowZero()
        {
            int count = -1;
            float width = 1;
            float length = 1;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ дл€ продукта c длинной меньше 0 (8)
        [TestMethod]
        public void Test_GetQuantityForProduct_LengthBelowZero()
        {
            int count = -1;
            float width = 1;
            float length = -1;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ дл€ продукта c шириной меньше 0 (9)
        [TestMethod]
        public void Test_GetQuantityForProduct_WidthBelowZero()
        {
            int count = -1;
            float width = -1;
            float length = 1;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }



        //                                                  —ложные unit-tests
        //------------------------------------------------------------------------------------------------------------------------//

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта с длинной и шириной равной 0 (1)
        [TestMethod]
        public void Test_GetQuantityForProduct_ZeroLengthAndWidth()
        {
            int count = 1;
            float width = 0;
            float length = 0;
            int materialType = 1;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта с неизвестным типом материала и длинной меньше 0 (2)
        [TestMethod]
        public void Test_GetQuantityForProduct_NonExistentMaterialType_LengthBelowZero()
        {
            int count = 1;
            float width = 1;
            float length = -12;
            int materialType = 12;
            int productType = 2;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }

        //“естирование метода вычислени€ необходимого сырь€ дл€ продукта с несуществующим типом сырь€ и типом продукта(3)
        [TestMethod]
        public void Test_GetQuantityForProduct_NonExistentMaterialType_NonExistentProductType()
        {
            int count = 1;
            float width = 1;
            float length = 2;
            int materialType = 12;
            int productType = 12;
            int expected = -1;

            int actual = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, actual);
        }
        //“естирование на возвращение правильного результата при передаче минимальных допустимых значений параметров (4)
        [TestMethod]
        public void GetQuantityForProduct_MinimumValues_ReturnsCorrectResult()
        {
            int count = 1;
            float width = 0.1f;
            float length = 0.1f;
            int materialType = 1;
            int productType = 1;
            int expected = 1;

            int result = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, result);
        }

        //“естирование на возвращение правильного результата при передаче максимальных допустимых значений параметров (5)
        [TestMethod]
        public void GetQuantityForProduct_MaximumValues_ReturnsCorrectResult()
        {
            int count = 10000;
            float width = 1000f;
            float length = 1000f;
            int materialType = 1;
            int productType = 1;
            int expected = 1;

            int result = Calculation.GetQuantityForProduct(count, width, length, materialType, productType);

            Assert.AreEqual(expected, result);
        }
    }
}