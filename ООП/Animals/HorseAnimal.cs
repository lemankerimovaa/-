using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП.Options;

namespace ООП.Animals
{
    public class HorseAnimal: AbstractAnimals
    {
        public HorseAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            TypeOfAnimal = "Loshad";
            Biom = BiomType.Stepi;
            Square = 110;
            IsPredator = true;
            Food = new List<FoodType>()
            {
                FoodType.Seno,
                FoodType.Grass
            };
            MaxFoodForDay = 17;
            _sound = "IQOQO";
        }
        public override Message ToPlay()
        {
            Message msg = new Message()
            {
                Text = $"{Name} iqrayet v doqonalki",
                SenderName = Name,
                SenderType = TypeOfAnimal,
                MessageType = MessageType.Play
            };
            return msg;
        }
    }
}
