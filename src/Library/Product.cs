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
            this.Description = description;
            this.UnitCost = unitCost;
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
                    throw new NotEqualException("La operación de asignación ha fallado");
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
            }
        }
    }
}
