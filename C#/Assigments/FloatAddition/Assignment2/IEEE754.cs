using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    /// <summary>
    /// Class that stores data in IEEE754 structure.
    /// </summary>
    class IEEE754
    {

        private byte _sign;
        private int _exponent;
        private int _power;
        private string _mantissa;

        public byte SignBit
        {
            get
            {
                return _sign;
            }
            set
            {
                _sign = value;
            }


        }
        public int Exponent { get; set; }
        public int Power { get; set; }
        public string Mantissa { get; set; }



    }
}
