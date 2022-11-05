using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП.Options;

namespace ООП.Animals
{
    public class FrogAnimal : AbstractAnimals
    {
        public FrogAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            Biom = BiomType.SouthPole;
            isPredator = true;
            Eats = new string[] { "Komari", "Chervi", "Raki" };
            sound = "Kva Kva";
        }
    }
}
