using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_Main
{
    public class Length
    {
        public Unit unit;
        public double value;

        /// <summary>
        /// Enums for the Units
        /// </summary>
        public enum Unit
        {
            INCH, FEET, YARD, CMS
        }

        public Length()
        {
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="value"></param>
        public Length(Unit unit, double value)
        {

            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// To get the baseunits of units
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        private double GetUnitsFloatValue(Unit unit)
        {
            switch (unit)
            {
                case Unit.INCH:
                    return 1;
                case Unit.FEET:
                    return 12;
                case Unit.YARD:
                    return 36;
                case Unit.CMS:
                    return 0.4;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// To convert the values of the units
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <returns></returns>
        public bool UnitConversion(Length unit1, Length unit2)
        {
            double baseUnit1 = GetUnitsFloatValue(unit1.unit);
            double baseUnit2 = GetUnitsFloatValue(unit2.unit);
            return CompareUnits(unit1, unit2, baseUnit1, baseUnit2);
        }

        /// <summary>
        /// To compare the values of the units
        /// </summary>
        /// <param name="unit1"></param>
        /// <param name="unit2"></param>
        /// <param name="baseUnit1"></param>
        /// <param name="baseUnit2"></param>
        /// <returns></returns>
        private bool CompareUnits(Length unit1, Length unit2, double baseUnit1, double baseUnit2)
        {
            return Math.Round(unit1.value * baseUnit1).CompareTo(Math.Round(unit2.value * baseUnit2)) == 0;
        }

        /// <summary>
        /// Override equals method
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj == this)
            {
                return true;
            }
            Length length = (Length)obj;
            return length.value == value && unit == length.unit;
        }
    }
}
