using NUnit.Framework;
using QuantityMeasurement_Main;

namespace QuantityMeasurement_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Check if two Feet objects are equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenBoth0_ShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// When the second object is null, should return false
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSecondNull_ShouldReturnFalse()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = null;
            bool isEqual = feet1.Equals(feet2);
            Assert.IsFalse(isEqual);
        }

        /// <summary>
        /// When the first object is null, should return false
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenFirstNull_ShouldReturnFalse()
        {
            Feet feet1 = null;
            Feet feet2 = new Feet(0.0);
            bool isEqual = feet2.Equals(feet1);
            Assert.IsFalse(isEqual);
        }
    }
}