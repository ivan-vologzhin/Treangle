using Treangle;

namespace TriangleTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Test2() //���� �� ������������ �����������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3", "36", "5");
            Assert.AreEqual(expect, actual);
        }

        [Test]
        public void Test3() //���� �� ��� ������������ - ��������������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3", "3", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test4() // ���� �� 0-��� ��������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3", "0", "5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test5() //���� �� ��� ������������ - �������������� num1
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3", "4", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test6() //���� �� ��� ������������ - �������������� num2
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("4", "3", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test7() //���� �� ������ ��������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("", "6", "6");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test8() //���� �� ��� ������������ - �������������� num1
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3", "4", "5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test9() //���� �� ��� ������������ - �������������� num2
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("5", "4", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test10() //���� �� ��������� �������� (������ �������)
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("0,4", "0,4", "0,4");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test11() //���� �� ������� �����
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("8,5", "8,3", "8,2");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test12() //���� �� �����
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("5,7", "6,2", "9,4");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test13() //���� �� �������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("10", ";�4", "!5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test14() //���� �� ����� 
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("sdrZH", "3", "5");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test15() //���� �� ������������� ��������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("-3", "7", "4");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test16() //���� �� �������� 0
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("0", "0", "3");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test17() //���� �� ������� �����
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "��������������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3000000000000000000000000", "3000000000000000000000000", "3000000000000000000000000");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test18() //���� �� �������� 0
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("0", "0", "0");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test19() //���� �� ������ ��������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("", "", "");
            Assert.AreEqual(expect, actual);
        }
        [Test]
        public void Test20() //���� �� ������ ��������
        {
            string actual;
            float[] Coordinates_A = new float[2];
            float[] Coordinates_B = new float[2];
            float[] Coordinates_C = new float[2];
            var expect = "�� �����������";
            (actual, Coordinates_A, Coordinates_B, Coordinates_C) = Triangle.GoTriangle("3", "0", "0");
            Assert.AreEqual(expect, actual);
        }
    }
}