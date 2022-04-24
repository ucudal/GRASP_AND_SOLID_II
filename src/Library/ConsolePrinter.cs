using System;
using System.Text;
namespace Full_GRASP_And_SOLID.Library
{
    /// <summary>
    /// La clase ConsolePrinter fue creada con el hecho de cumplir con el patrón Expert, el cual dicta que una clase
    /// debe ser experta en conocer la información necesaria para cumplir con su responsabilidad, y es por lo que es correcto que
    /// esta clase sea la responable de imprimir la receta y no la clase Recipe, cuya funcionalidad es la de reproducir los steps
    /// necesarios para llegar al producto final.
    /// Además también cumple con el principio SRP, ya que la responsabilidad de la clase ConsolePrinter esta relacionada con una
    /// única funcionalidad de la aplicación, de forma que que no modifique ninguna de las otras clases existentes y logrando que
    /// el código sea más fácil de extender y más robusto a las modificaciones.
    /// </summary>
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            StringBuilder recibo = new StringBuilder($"Receta de {recipe.FinalProduct.Description}\n");
            foreach (Step step in recipe.Steps)
            {
                recibo.AppendLine($"{step.Quantity} de '{step.Input.Description}' usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine(recibo.ToString().TrimEnd());
        }
    }
}