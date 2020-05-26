using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_Main
{
    public class Length
    {
        public const double FeetToInch = 12.0;
        public const double InchToFeet = 12.0;

        public Unit unit;
        public double value;

        /// <summary>
        /// Enums for the Units
        /// </summary>
        public enum Unit
        {
            FEET, INCH
        }

        public Length()
        {
        }

        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// To compare the units
        /// </summary>
        /// <param name="that"></param>
        /// <returns></returns>
        public bool Compare(Length that)
        {

            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.FEET) || this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.INCH))
            {
                return this.value.CompareTo(that.value) == 0;
            }

            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.INCH))
            {
                return (this.value*FeetToInch).CompareTo(that.value) == 0;
            }

            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.FEET))
            {
                return (this.value/InchToFeet).CompareTo(that.value) == 0;
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
            if(obj == null)
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
