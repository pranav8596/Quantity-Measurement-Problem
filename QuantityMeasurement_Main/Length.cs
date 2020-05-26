using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_Main
{
    public class Length
    {
        public enum Unit
        {
            FEET, INCH
        }

        public Unit unit;
        public double value;

        public Length()
        {
        }

        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
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

        public bool compare(Length inch1)
        {
            return true;
        }
    }
}
