using System;

namespace Full_GRASP_And_SOLID
{
    public class NegativeValueException : Exception
    {
        public NegativeValueException(string message)
        : base(message)
        {
        }
    }
}