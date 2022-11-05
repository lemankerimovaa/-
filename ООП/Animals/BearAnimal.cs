using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ООП.Options;

namespace ООП.Animals
{
    public class BearAnimal: AbstractAnimals
    {
        public BearAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            TypeOfAnimal = "Medved";
            Biom = BiomType.Forest;
            Square = 150;
            IsPredator = true;
            Food = new List<FoodType>()
            {
                FoodType.Honey,
                FoodType.Grass,
                FoodType.Berry,
            };
            MaxFoodForDay = 20;
            _sound = "rrrr";
        }
        public override Message ToPlay()
        {
            Message msg = new Message()
            {
                Text = $"{Name} igrayet shishksmi",
                SenderName = Name,
                SenderType = TypeOfAnimal,
                MessageType = MessageType.Play
            };
            return msg;
        }
    }
}
