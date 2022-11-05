using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ООП.Options;

namespace ООП.Animals
{
    public class GiraffeAnimal:AbstractAnimals
    {
        public GiraffeAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            TypeOfAnimal = "Jiraf";
            Biom = BiomType.Savanna;
            Square = 110;
            IsPredator = true;
            Food = new List<FoodType>()
            {
                FoodType.Seno,
                FoodType.Banana,
                FoodType.Grass,
                FoodType.Bread,
                FoodType.Orange
            };
            MaxFoodForDay = 18;
            _sound = "AAAAAA";
        }
        public override Message ToPlay()
        {
            Message msg = new Message()
            {
                Text = $"{Name} igrayet s babochkami",
                SenderName = Name,
                SenderType = TypeOfAnimal,
                MessageType = MessageType.Play
            };
            return msg;
        }
    }
}
