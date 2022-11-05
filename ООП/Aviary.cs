using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП.Animals;
using ООП.Options;

namespace ООП
{
    public class Aviary
    {
        public string Name { get; set; }
        public double Square { get; set; }
        public BiomType Biom { get; private set; }
        public Aviary(string name, double square)
        {
            Name = name;
            Square = square;    
        }
        
    }
}

    