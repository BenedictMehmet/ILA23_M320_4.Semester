using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25.Aufgaben.Lösung.Rezeptverwaltung
{
    class ReceipeBook
    {
        List<Recipe> recipes = new List<Recipe>();

        public void AddRecipe()
        {
            Console.WriteLine("Names des Rezepts: ");
            string name = Console.ReadLine();


            Console.Write("Anzahl der Zutaten");
            int ingCount = int.Parse(Console.ReadLine());
            string[] ingredients = new string[ingCount];
            for (int i = 0; i < ingCount; i++)
            {
                Console.Write($"Zutat {i+ 1} ");
                ingredients[i] = Console.ReadLine();
            }


            Console.Write("Anzahl der Zubereitungsschritte: ");
            int stepCount = int.Parse(Console.ReadLine());
            string[] steps = new string[stepCount];
            for(int i = 0; i < stepCount; i++)
            {
                Console.Write($"Schritt {i + 1} ");
                steps[i] = Console.ReadLine();
            }

            recipes.Add(new Recipe(name, ingredients, steps));
        }


        private void DisplayIngredients(Recipe r)
        {
            string strich = "-";
            Console.WriteLine("Zutaten");
            for(int i = 0; i < r.Ingredients.Length; i++)
            {
                Console.Write(strich);
                Console.WriteLine(r.Ingredients[i]);
            }
        }

        private void DisplayPreperation(Recipe r)
        {
            string strich = "-";
            Console.WriteLine("Zutaten");
            for (int i = 0; i < r.PreperationSteps.Length; i++)
            {
                Console.Write(strich);
                Console.WriteLine(r.PreperationSteps[i]);
            }
        }

        public void ShowAllRecipes()
        {
            Console.WriteLine("Alle Rezpete");
            int RecipeNumber = 1;

            foreach(Recipe r in recipes)
            {
                Console.WriteLine($"Rezept {RecipeNumber++}: {r.Name}");
                DisplayIngredients(r);
                DisplayPreperation(r);
            }

            Console.WriteLine();
        }
    }
}
