using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_Main
{
    public class Inch
    {
        public double value;

        public Inch(double value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Inch inch = (Inch)obj;
            return inch.value == value;
        }
    }
}
