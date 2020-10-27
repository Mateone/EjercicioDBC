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
            try
            {
                this.Quantity = quantity;
                this.Time = time;
                this.Input = input;
                this.Equipment = equipment;

            }

            catch (NegativeOrZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (NotEqualException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NullValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private Product input;
        public Product Input
        {
            get
            {
                return this.input;
            }
            set
            {
                //Precondición
                if (value == null)
                {
                throw new NullValueException("El value ingresado es null");
                }
                this.input = value;

                //Postcondicion
                if (this.input != value)
                {
                    throw new NotEqualException("La operación de asignación del producto ha fallado");
                }
            }
        }

        private double quantity;
        public double Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                //Precondición
                if (value <= 0 )
                {
                    throw new NegativeOrZeroException("La cantidad introducida es menor o igual a cero!");
                }
                this.quantity = value;

                //Postcondicion 
            
                if (this.quantity != value)
                {
                    throw new NotEqualException("La operación de asignación de la cantidad ha fallado");
                }
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
                //Precondición
                if (value <= 0 )
                {
                    throw new NegativeOrZeroException("El tiempo introducido es menor o igual a cero!");
                }
                this.time = value;
                
                //Postcondicion 

                if (this.time != value)
                {
                    throw new NotEqualException("La operación de asignación del tiempo del step ha fallado");
                }
            }
        }

        private Equipment equipment;
        public Equipment Equipment
        {
            get
            {
                return this.equipment;
            }
            set
            {
                //Precondición
                if (value == null)
                {
                    throw new NullValueException("El value ingresado es null");
                }
                this.equipment = value;

                //Postcondicion 

                if (this.equipment != value)
                {
                    throw new NotEqualException("La operación de asignación del Equipment del step ha fallado");
                }

                
            }
        }
    }
}