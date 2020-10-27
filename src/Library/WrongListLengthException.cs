using System;

namespace Full_GRASP_And_SOLID
{
    public class WrongListLengthException : Exception
    {
        public WrongListLengthException(string message)
        : base(message)
        {
        }
    }
}