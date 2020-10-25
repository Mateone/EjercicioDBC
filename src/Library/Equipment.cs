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
                if(String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullOrEmptyException("El texto es null o se encuentra vacío");
                }
                this.description = value;
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
                if (value < 0)
                {
                    throw new NegativeValueException("El valor introducido es menor a cero");
                }
                this.hourlyCost = value;
            }
        }
    }
}