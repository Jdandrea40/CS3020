using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment2_Cereal
{
    /// <summary>
    /// A class used to construct a new cereal
    /// </summary>
    class Cereal
    {
        string name;
        char mfr;
        char type;
        int calories;
        int protein;
        int fat;
        int sodium;
        float fiber;
        float carbs;
        int sugars;
        int potassium;
        int vitamins;
        int shelfLife;
        float weight;
        float cups;
        double rating;

        /// <summary>
        /// Cereal constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mfr"></param>
        /// <param name="type"></param>
        /// <param name="calories"></param>
        /// <param name="protein"></param>
        /// <param name="fat"></param>
        /// <param name="sodium"></param>
        /// <param name="fiber"></param>
        /// <param name="carbs"></param>
        /// <param name="sugars"></param>
        /// <param name="potassium"></param>
        /// <param name="vitamins"></param>
        /// <param name="shelfLife"></param>
        /// <param name="weight"></param>
        /// <param name="cups"></param>
        /// <param name="rating"></param>
        public Cereal(string name, char mfr, char type, int calories, int protein,
            int fat, int sodium, float fiber, float carbs, int sugars, int potassium,
            int vitamins, int shelfLife, float weight, float cups, double rating)
        {
            this.name = name;
            this.mfr = mfr;
            this.type = type;
            this.calories = calories;
            this.protein = protein;
            this.fat = fat;
            this.sodium = sodium;
            this.fiber = fiber;
            this.carbs = carbs;
            this.sugars = sugars;
            this.potassium = potassium;
            this.vitamins = vitamins;
            this.shelfLife = shelfLife;
            this.weight = weight;
            this.cups = cups;
            this.rating = rating;
        }
    }
}
