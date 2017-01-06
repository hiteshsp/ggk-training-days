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
        
        public byte SignBit{ get; set; }
        public int Exponent { get; set; }
        public int Power { get; set; }
        public string Mantissa { get; set; }
        
    }
}
