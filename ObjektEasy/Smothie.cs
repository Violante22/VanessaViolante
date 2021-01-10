using System;
using System.Collections.Generic;
using System.Text;

namespace ObjektEasy
{
   public class Smothie
    {
        public double IngredientsPrise { get; set; }
        public string IngredientsName { get; set; }
        public double GetCost()
        {
            IngredientsPrise++;
            return IngredientsPrise;
        }
        public double GetPrice()
        {
            return GetCost() + (GetCost() * 1.5);
        }
        //public  string GetName(string ingredients)
        //{
        //    IngredientsName = ingredients;
        //    string[] ingredientsName = new string[3] { "Banana", "Mela", "Pera" };
        //    ingredients = ingredientsName[3];


        //}
    }
}
