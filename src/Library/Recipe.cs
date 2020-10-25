//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            if (step == null)
            {
                throw new NullReferenceException("El objeto ingresado es null");
            }
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            //Precondición
            if (step == null)
            {
                throw new NullReferenceException("El objeto ingresado es null");
            }
            //Precondición
            if(!steps.Contains(step))
            {
                throw new StepNotFoundException("Step not found in recipe");
            }

            //Operación
            this.steps.Remove(step);

            //Poscondicion: El largo de la lista de steps es menor a lo que era antes.
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}