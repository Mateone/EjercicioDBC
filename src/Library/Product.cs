//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            if(String.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentNullOrEmptyException("El texto es null o se encuentra vacío");
            }
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
    }
}