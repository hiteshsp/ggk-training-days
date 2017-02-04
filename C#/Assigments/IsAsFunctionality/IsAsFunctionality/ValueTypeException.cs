using System;
namespace IsAsFunctionality
{
    /// <summary>
    /// User Defined Exception for value types for "As" functionality.
    /// </summary>
    class ValueTypeException : Exception
    {
        // Message Property for the exception.
        public override string Message { get; }

        /// <summary>
        /// Constructor for the Class Initializing the message.
        /// </summary>
        public ValueTypeException()
        {            
            Message = "Hey use a reference Type";
        }
    }
}
