//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------
using System;

namespace Full_GRASP_And_SOLID
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
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
                //Precondición
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullOrEmptyException("El texto es null o se encuentra vacío");
                }
                //Operación
                this.description = value;

                //Poscondición: Description toma el valor que se intenta asignarle

                if (this.description != value)
                {
                    throw new NotEqualException("La operación de asignación de descripción del Equipment ha fallado");
                }
            }
        }

        private double hourlyCost;
        public double HourlyCost
        {
            get
            {
                return this.hourlyCost;
            }
            set
            {
                //Precondición
                if (value < 0)
                {
                    throw new NegativeValueException("El valor introducido es menor a cero");
                }
                //Operación
                this.hourlyCost = value;

                //Poscondición: HourlyCost toma el valor que se intenta asignarle

                if (this.hourlyCost != value)
                {
                    throw new NotEqualException("La operación de asignación del hourlyCost ha fallado");
                }
            }
        }
    }
}