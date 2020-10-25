//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Equipment = equipment;
            this.Time = time;
        }

        public Product Input { get; set; }

        public double Quantity
        {
            get
            {
                return this.Time;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new NegativeOrZeroException("La cantidad introducida es menor o igual a cero!");
                }
            }
        }
        public int Time 
        {
            get
            {
                return this.Time;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new NegativeOrZeroException("El tiempo introducido es menor o igual a cero!");
                }
            }
        }

        public Equipment Equipment { get; set; }
    }
}