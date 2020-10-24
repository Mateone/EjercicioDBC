using System;

namespace Full_GRASP_And_SOLID
{
    public class StepNotFoundException : Exception
    {
        public StepNotFoundException(string message) : base(message)
        {
            
        }
    }
}