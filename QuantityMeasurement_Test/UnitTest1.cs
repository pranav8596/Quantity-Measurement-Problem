using NUnit.Framework;
using QuantityMeasurement_Main;
using System;

namespace QuantityMeasurement_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        ///Test for FEETs
        /// <summary>
        /// Check if two Feets are 0, return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenBoth0_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET,0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// When the second feet is null, should return false
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSecondNull_ShouldReturnFalse()
        {
            Length feet1 = new Length(Length.Unit.FEET,0.0);
            Length feet2 = null;
            bool isEqual = feet1.Equals(feet2);
            Assert.IsFalse(isEqual);

        }

        /// <summary>
        /// When the first feet is null, should return false
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenFirstNull_ShouldReturnFalse()
        {
            Length feet1 = null;
            Length feet2 = new Length(Length.Unit.FEET,0.0);
            bool isEqual = feet2.Equals(feet1);
            Assert.IsFalse(isEqual);
        }

        /// <summary>
        /// When both feet reference is same, should return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameReference_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET,0.0);
            Length feet2 = feet1;          
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// When both feets are of same type , should return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameType_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET,0.0);
            Length feet2 = new Length(Length.Unit.FEET,0.0);
            Type type1 = feet1.GetType();
            Type type2 = feet2.GetType();
            Assert.AreEqual(type1, type2);        
        }

        /// <summary>
        /// Given feets when equal, should return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenEqual_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 3.0);
            Length feet2 = new Length(Length.Unit.FEET, 3.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Given feets when not equal, should return not equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenNotEqual_ShouldReturnNotEqual()
        {
            Length inch1 = new Length(Length.Unit.FEET, 3.0);
            Length inch2 = new Length(Length.Unit.FEET, 1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        ///Test for INCHES
        /// <summary>
        /// Given two Inches when 0, should return equal
        /// </summary>
        [Test]
        public void GivenInchAndInch_When0_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// When the second inch is null, should return false
        /// </summary>
        [Test]
        public void GivenInchAndInch_WhenSecondNull_ShouldReturnFalse()
        {
            Length inch1 = new Length(Length.Unit.INCH,0.0);
            Length inch2 = null;
            bool isEqual = inch1.Equals(inch2);
            Assert.IsFalse(isEqual);
        }

        /// <summary>
        /// When the first inch is null, should return false
        /// </summary>
        [Test]
        public void GivenInchAndInch_WhenFirstNull_ShouldReturnFalse()
        {
            Length inch1 = null;
            Length inch2 = new Length(Length.Unit.INCH, 0.0); ;
            bool isEqual = inch2.Equals(inch1);
            Assert.IsFalse(isEqual);
        }

        /// <summary>
        /// When both inch reference is same, should return equal
        /// </summary>
        [Test]
        public void GivenInchAndInch_WhenSameReference_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0); ;
            Length inch2 = inch1;
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// When both inch having of same type , should return equal
        /// </summary>
        [Test]
        public void GivenInchAndInch_WhenSameType_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 0.0);
            Type type1 = inch1.GetType();
            Type type2 = inch2.GetType();
            Assert.AreEqual(type1, type2);
        }

        /// <summary>
        /// Given inches when equal, should return equal
        /// </summary>
        [Test]
        public void GivenInchAndInch_WhenEqual_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 3.0);
            Length inch2 = new Length(Length.Unit.INCH, 3.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Given inches when not equal, should return false
        /// </summary>
        [Test]
        public void GivenInchAndInch_WhenNotEqual_ShouldReturnNotEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 3.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// Given two Inches when 0, should return equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(feet1, inch1);
        }

        /// <summary>
        /// Compared 0 feet amd 0 inch which should return true
        /// </summary>
        [Test]
        public void Given0FeetAnd0Inch_WhenCompared_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            bool compareCheck = feet1.Compare(inch1);
            Assert.IsTrue(compareCheck);
        }
       
        /// <summary>
        /// Compared 1 feet amd 1 feet which should return true
        /// </summary>
        [Test]
        public void Given1FeetAnd1Feet_WhenCompared_ShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = feet1.Compare(feet2);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 1 feet amd 5 feet which should return false
        /// </summary>
        [Test]
        public void Given2FeetAnd5Feet_WhenCompared_ShouldReturnFalse()
        {
            Length feet1 = new Length(Length.Unit.FEET, 2.0);
            Length feet2 = new Length(Length.Unit.FEET, 5.0);
            bool compareCheck = feet1.Compare(feet2);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Compared 1 inch amd 1 inch which should return true
        /// </summary>
        [Test]
        public void Given1InchAnd1Inch_WhenCompared_ShouldReturnTrue()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            bool compareCheck = inch1.Compare(inch2);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 1 inch amd 5 inch which should return false
        /// </summary>
        [Test]
        public void Given1InchAnd5Inch_WhenCompared_ShouldReturnFalse()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = new Length(Length.Unit.FEET, 5.0);
            bool compareCheck = feet1.Compare(feet2);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Compared 1 feet amd 1 inch which should return false
        /// </summary>
        [Test]
        public void Given1FeetAnd1Inch_WhenCompared_ShouldReturnFalse()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            bool compareCheck = feet1.Compare(inch1);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Compared 1 inch amd 1 feet which should return false
        /// </summary>
        [Test]
        public void Given1InchAnd1Feet_WhenCompared_ShouldReturnFalse()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = inch1.Compare(feet1);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Compared 1 feet amd 12 inch which should return true
        /// </summary>
        [Test]
        public void Given1FeetAnd12Inch_WhenCompared_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length inch1 = new Length(Length.Unit.INCH, 12.0);
            bool compareCheck = feet1.Compare(inch1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 12 inch and 1 feet  which should return true
        /// </summary>
        [Test]
        public void Given12InchAnd1Feet_WhenCompared_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 12.0);
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            bool compareCheck = inch1.Compare(feet1);
            Assert.IsTrue(compareCheck);
        }
    }
} 