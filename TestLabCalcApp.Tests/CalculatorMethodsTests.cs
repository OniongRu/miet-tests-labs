using NUnit.Framework;
using System;

namespace TestLabCalcApp.Tests
{
    public class Tests
    {
        [Test]
        public void Sum_test()
        {
            Assert.AreEqual((double)8, Calculator.Add((double)3, (double)5));
            Assert.AreEqual((double)-2, Calculator.Add((double)3, (double)-5));
            Assert.AreEqual((double)1800000, Calculator.Add((double)300000, (double)1500000));
            Assert.AreEqual((double)-8, Calculator.Add((double)-3, (double)-5));
            Assert.AreEqual((double)0, Calculator.Add((double)0, (double)0));
        }

        [Test]
        public void Sub_test()
        {
  
            Assert.AreEqual((double)-2, Calculator.Sub((double)3, (double)5));
            Assert.AreEqual((double)8, Calculator.Sub((double)3, (double)-5));
            Assert.AreEqual((double)1200000, Calculator.Sub((double)1500000, (double)300000));
            Assert.AreEqual((double)2, Calculator.Sub((double)-3, (double)-5));
            Assert.AreEqual((double)0, Calculator.Sub((double)0, (double)0));
        }

        [Test]
        public void Mult_test()
        {

            Assert.AreEqual((double)15, Calculator.Mult((double)3, (double)5));
            Assert.AreEqual((double)-15, Calculator.Mult((double)3, (double)-5));
            Assert.AreEqual((double)4500000, Calculator.Mult((double)1500, (double)3000));
            Assert.AreEqual((double)15, Calculator.Mult((double)-3, (double)-5));
            Assert.AreEqual((double)0, Calculator.Mult((double)3, (double)0));
        }

        [Test]
        public void Div_test()
        {

            Assert.AreEqual((double)0.6, Calculator.Div((double)3, (double)5));
            Assert.AreEqual((double)-0.6, Calculator.Div((double)3, (double)-5));
            Assert.AreEqual((double)0.5, Calculator.Div((double)1500, (double)3000));
            Assert.AreEqual((double)0.6, Calculator.Div((double)-3, (double)-5));
            Assert.AreEqual((double)0, Calculator.Div((double)0, (double)3));
            Assert.Throws<DivideByZeroException>(() => Calculator.Div((double)3, (double)0));
            Assert.AreEqual((double)0, Calculator.Div((double)0, (double)3));
        }

        
    }
}