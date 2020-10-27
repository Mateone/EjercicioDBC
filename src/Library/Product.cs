//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            try
            {    
                this.Description = description;
                this.UnitCost = unitCost;
            }
            catch (ArgumentNullOrEmptyException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NegativeValueException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (NotEqualException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        private string description;
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullOrEmptyException("El texto es null o se encuentra vacío");
                }
                this.description = value;

                if (this.description != value)
                {
                    throw new NotEqualException("La operación de asignación de la descripción del producto ha fallado");
                }
            }
        }
        public double unitCost;
        public double UnitCost
        {
            get
            {
                return this.unitCost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new NegativeValueException("El valor introducido es menor a cero");
                }
                this.unitCost = value;

                if (this.unitCost != value)
                {
                    throw new NotEqualException("La operación de asignación del unitCost del producto ha fallado");
                }
            }
        }
    }
}
