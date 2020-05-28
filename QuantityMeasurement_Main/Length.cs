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
            INCH, FEET, YARD, CMS, GALLON, LITRE, ML, KG, GRAM, TON, FAHRENHEIT, CELSIUS
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
                case Unit.GALLON:
                    return 3.78;
                case Unit.LITRE:
                    return 1;
                case Unit.ML:
                    return 0.001;
                case Unit.KG:
                    return 1;
                case Unit.GRAM:
                    return 0.001;
                case Unit.TON:
                    return 1000.0;
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
            return (unit1.value * baseUnit1).CompareTo(unit2.value * baseUnit2) == 0;
        }

        public double Addition(Length unit1, Length unit2)
        {
            double baseUnit1 = GetUnitsFloatValue(unit1.unit);
            double baseUnit2 = GetUnitsFloatValue(unit2.unit);
            return (unit1.value * baseUnit1) + (unit2.value * baseUnit2);
        }

        public bool TempConversion(Length temp1, Length temp2)
        {
            if (temp1.unit.Equals(Unit.FAHRENHEIT) && temp2.unit.Equals(Unit.CELSIUS))
            {
                return ((temp1.value - 32) * 5 / 9).CompareTo(temp2.value) == 0;
            }
            else if (temp1.unit.Equals(Unit.CELSIUS) && temp2.unit.Equals(Unit.FAHRENHEIT))
            {
                return ((temp1.value * 9 / 5) + 32).CompareTo(temp2.value) == 0;
            }
            return false;
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
