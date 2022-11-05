using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ООП.Options;

namespace ООП.Animals
{
    public class TigerAnimal: AbstractAnimals
    {
        public TigerAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            TypeOfAnimal = "Tiqr";
            Biom = BiomType.Jungle;
            Square = 200;
            IsPredator = true;
            Food = new List<FoodType>()
            {
                FoodType.Meat,
                FoodType.Fish
            };
            MaxFoodForDay = 40;
            _sound = "Rar";
        }
        public override Message ToPlay()
        {
            Message msg = new Message()
            {
                Text = $"{Name} beqayet",
                SenderName = Name,
                SenderType = TypeOfAnimal,
                MessageType = MessageType.Play
            };
            return msg;
        }
    }
}
