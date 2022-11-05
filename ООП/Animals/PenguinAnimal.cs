using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ООП.Options;

namespace ООП.Animals
{
    public class PenguinAnimal : AbstractAnimals
    {
        public PenguinAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            Biom = BiomType.SouthPole;
            isPredator = true;
            Eats = new string[] { "Riba", "Anchous", "Sardini" };
            sound = "AAAAAA";

        }

    }
}
