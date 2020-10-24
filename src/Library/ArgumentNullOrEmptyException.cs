using System;

namespace Full_GRASP_And_SOLID
{
    public class ArgumentNullOrEmptyException : Exception
    {
        public ArgumentNullOrEmptyException(string message)
        : base(message)
        {
        }
    }
}