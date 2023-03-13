using WSUniversalLib;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {

        //������������ ������ ���������� ������������ ����� � ��������� ����������� (1)
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

        //������������ ������ ���������� ������������ ����� ��� �������� � ������� ������ 0 (2)
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

        //������������ ������ ���������� ������������ ����� ��� �������� � ������� ������ 0 (3)
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

        //������������ ������ ���������� ������������ ����� ��� �������� ���-��� = 0 (4)
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

        //������������ ������ ���������� ������������ ����� ��� �������� � �������������� ����� ����� (5)
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

        //������������ ������ ���������� ���-�� ���� ����� ��� ��������������� �������� (6)
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

        //������������ ������ ���������� ��� �������� ���-��� ������ ���� (7)
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

        //������������ ������ ���������� ��� �������� c ������� ������ 0 (8)
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

        //������������ ������ ���������� ��� �������� c ������� ������ 0 (9)
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



        //                                                  ������� unit-tests
        //------------------------------------------------------------------------------------------------------------------------//

        //������������ ������ ���������� ������������ ����� ��� �������� � ������� � ������� ������ 0 (1)
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

        //������������ ������ ���������� ������������ ����� ��� �������� � ����������� ����� ��������� � ������� ������ 0 (2)
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

        //������������ ������ ���������� ������������ ����� ��� �������� � �������������� ����� ����� � ����� ��������(3)
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
        //������������ �� ����������� ����������� ���������� ��� �������� ����������� ���������� �������� ���������� (4)
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

        //������������ �� ����������� ����������� ���������� ��� �������� ������������ ���������� �������� ���������� (5)
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