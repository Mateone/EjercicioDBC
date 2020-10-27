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
            int oldcount = steps.Count;
            //Precondición
            if (step == null)
            {
                throw new NullValueException("El value ingresado es null");
            }
            this.steps.Add(step);
            int newcount = steps.Count;
            //Poscondición
            if (newcount != oldcount + 1)
            {
                throw new WrongListLengthException("No step added");
            }
        }

        public void RemoveStep(Step step)
        {
            int oldcount = steps.Count;
            //Precondición
            if (step == null)
            {
                throw new NullValueException("El value ingresado es null");
            }
            //Precondición
            if(!steps.Contains(step))
            {
                throw new StepNotFoundException("Step not found in recipe");
            }

            //Operación
            this.steps.Remove(step);
            int newcount = steps.Count;
            //Poscondición
            if (newcount != oldcount - 1)
            {
                throw new WrongListLengthException("No step removed");
            }
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