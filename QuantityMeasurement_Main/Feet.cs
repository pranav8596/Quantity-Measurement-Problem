using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement_Main
{
    public class Feet
    {
        public double value;

        public Feet()
        {
        }

        public Feet(double value)
        {
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
            Feet feet = (Feet)obj;
            return feet.value == value;
        }        
    }
}
