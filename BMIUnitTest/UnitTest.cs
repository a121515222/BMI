using BMI;
using NUnit.Framework;

namespace BMIUnitTest
{
    public class UnitTest
    {
        [TestCase(0, 30.6)]
        [TestCase(1.4, 0)]
        public void ParamenterZeroTest(double height, double weight)
        {
            Assert.AreEqual("weight or height can't be 0", Bmi.GetBmi(height, weight));
        }
        
        [TestCase(1.75, 30.6)]
        [TestCase(1.4, 25.9)]
        public void UnderweightTest(double height, double weight)
        {
            Assert.AreEqual("Underweight", Bmi.GetBmi(height, weight));
        }
        
        [TestCase(1.75, 30.6)]
        [TestCase(1.4, 25.9)]
        public void NormalTest(double height, double weight)
        {
            Action<object?, object?> areEqual = Assert.AreEqual;
            areEqual("Underweight", Bmi.GetBmi(height, weight));
        }
        
        [TestCase(1.75, 200.6)]
        [TestCase(1.4, 150.9)]
        public void ObeseTest(double height, double weight)
        {
            Action<object?, object?> areEqual = Assert.AreEqual;
            areEqual("Obese", Bmi.GetBmi(height, weight));
        }
        
    }
}