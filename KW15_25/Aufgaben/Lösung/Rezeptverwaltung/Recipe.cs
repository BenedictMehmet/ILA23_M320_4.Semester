using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW15_25.Aufgaben.Lösung.Rezeptverwaltung
{
    class Recipe
    {
        public string Name { get; set; }

        public string[] Ingredients { get; set; }

        public string[] PreperationSteps { get; set; }

        public Recipe(string name, string[] ingredients, string[] preperationsteps)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.PreperationSteps = preperationsteps;
        }
    }
}
