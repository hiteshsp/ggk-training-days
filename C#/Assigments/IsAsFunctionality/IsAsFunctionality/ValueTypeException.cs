using System;
namespace IsAsFunctionality
{
    class ValueTypeException : Exception
    {
        public override string Message { get; }

        public ValueTypeException()
        {            
            Message = "Hey use a reference Type";
        }
    }
}
