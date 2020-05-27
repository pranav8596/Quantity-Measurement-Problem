using NUnit.Framework;
using QuantityMeasurement_Main;
using System;

namespace QuantityMeasurement_Test
{
    public class Tests
    {
        Length length = null;
        [SetUp]
        public void Setup()
        {
            length = new Length();
        }

        ///Test for FEETs
        /// <summary>
        /// Check if two Feets are 0, return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenBoth0_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// When the second feet is null, should return false
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSecondNull_ShouldReturnFalse()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
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
            Length feet2 = new Length(Length.Unit.FEET, 0.0);
            bool isEqual = feet2.Equals(feet1);
            Assert.IsFalse(isEqual);
        }

        /// <summary>
        /// When both feet reference is same, should return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameReference_ShouldReturnEqual()
        {
            
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = feet1;
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// When both feets are of same type , should return equal
        /// </summary>
        [Test]
        public void GivenFeetAndFeet_WhenSameType_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 0.0);
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
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
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
            bool compareCheck = length.UnitConversion(feet1, inch1);
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
            bool compareCheck = length.UnitConversion(feet1, feet2);
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
            bool compareCheck = length.UnitConversion(feet1, feet2);
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
            bool compareCheck = length.UnitConversion(inch1, inch2);
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
            bool compareCheck = length.UnitConversion(feet1, feet2);
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
            bool compareCheck = length.UnitConversion(feet1, inch1);
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
            bool compareCheck = length.UnitConversion(inch1, feet1);
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
            bool compareCheck =length.UnitConversion(feet1, inch1);
            //  bool compareCheck = feet1.Compare(inch1);
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
            bool compareCheck = length.UnitConversion(inch1, feet1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 3 feet and 1 yard  which should return equal
        /// </summary>
        [Test]
        public void Given3FeetAnd1Yard_WhenCompared_ShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 3.0);
            Length yard1 = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = length.UnitConversion(feet1, yard1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 1 yard and 3 feets  which should return equal
        /// </summary>
        [Test]
        public void Given1YardAnd3Feets_WhenCompared_ShouldReturnEqual()
        {

            Length yard1 = new Length(Length.Unit.YARD, 1.0);
            Length feet1 = new Length(Length.Unit.FEET, 3.0);
            bool compareCheck = length.UnitConversion(yard1, feet1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 1 yard and 36 inch  which should return equal
        /// </summary>
        [Test]
        public void Given1YardAnd36Inch_WhenCompared_ShouldReturnEqual()
        {
            Length yard1 = new Length(Length.Unit.YARD, 1.0);
            Length inch1 = new Length(Length.Unit.INCH, 36.0);
            bool compareCheck = length.UnitConversion(inch1, yard1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 36 inch and 1 yard which should return equal
        /// </summary>
        [Test]
        public void Given36InchAnd1Yard_WhenCompared_ShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 36.0);
            Length yard1 = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = length.UnitConversion(inch1, yard1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 1 feet and 1 yard  which should return not equal
        /// </summary>
        [Test]
        public void Given1FeetAnd1Yard_WhenCompared_ShouldReturnNotEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length yard1 = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = length.UnitConversion(feet1, yard1);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Compared 1 inch and 1 yard which should return not equal
        /// </summary>
        [Test]
        public void Given1InchAnd1Yard_WhenCompared_ShouldReturnFalse()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length yard1 = new Length(Length.Unit.YARD, 1.0);
            bool compareCheck = length.UnitConversion(inch1, yard1);
            Assert.IsFalse(compareCheck);
        }

        /// <summary>
        /// Compared 2 inch and 5 Cms which should return True
        /// </summary>
        [Test]
        public void Given2InchAnd5Cms_WhenCompared_ShouldReturnTrue()
        {
            Length inch1 = new Length(Length.Unit.INCH, 2.0);
            Length cms1 = new Length(Length.Unit.CMS, 5.0);
            bool compareCheck = length.UnitConversion(inch1, cms1);
            Assert.IsTrue(compareCheck);
        }

        /// <summary>
        /// Compared 5 inch and 5 Cms which should return False
        /// </summary>
        [Test]
        public void Given1InchAnd1Cms_WhenCompared_ShouldReturnFalse ()
        {
            Length inch1 = new Length(Length.Unit.INCH, 5.0);
            Length cms1 = new Length(Length.Unit.CMS, 5.0);
            bool compareCheck = length.UnitConversion(inch1, cms1);
            Assert.IsFalse(compareCheck);
        }
    }
}