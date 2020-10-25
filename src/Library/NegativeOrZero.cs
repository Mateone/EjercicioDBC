using System;

namespace Full_GRASP_And_SOLID
{

    public class NegativeOrZeroException : Exception
    {
        public NegativeOrZeroException(string message) : base (message)
        {
        }
    }



}