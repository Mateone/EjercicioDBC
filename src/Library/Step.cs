//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Equipment = equipment;
            this.Input = input;

            try
            {
                this.Quantity = quantity;
                this.Time = time;
            }
            
            catch (NegativeOrZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        public Product Input { get; set; }

        private double quantity;
        public double Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new NegativeOrZeroException("La cantidad introducida es menor o igual a cero!");
                }
                this.quantity = value;
            }
        }

        private int time;

        public int Time 
        {
            get
            {
                return this.time;
            }
            set
            {
                if (value <= 0 )
                {
                    throw new NegativeOrZeroException("El tiempo introducido es menor o igual a cero!");
                }
                this.time = value;
            }
        }

        public Equipment Equipment { get; set; }
    }
}