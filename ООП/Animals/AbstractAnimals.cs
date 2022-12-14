using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ООП.Options;
using static System.Net.Mime.MediaTypeNames;

namespace ООП.Animals
{
    public abstract class AbstractAnimals
    {
        public string TypeOfAnimal { get; protected set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public BiomType Biom { get; protected set; }
        public int Square { get; protected set; } 
        public bool IsPredator { get; protected set; }
        public List<FoodType> Food { get; protected set; }
        public int MaxFoodForDay { get; protected set; }
        public int EatenFood { get; protected set; }

        protected string _sound;
        public AbstractAnimals(string name, int age, double weight) // 
        {
            Name = name;
            Age = age;
            Weight = weight;
            EatenFood = 0;
        }
        /*public Message ToEat(int kg, FoodType eat)
        {
            if (Food.Contains(eat))
            {
                Message msg = new Message()
                {
                    Text = $"{Name} poyel {kg} kilogramma {eat}",
                    Name = Name,
                    MessageType = MessageType.Eat
                };
                return msg;
            }
            else if (kg>MaxFoodForDay)
            {
                Message msg = new Message()
                {
                    Text = $"{Name} poyel {kg} kilogramma {eat}",
                    Name = Name,
                    MessageType = MessageType.Eat
                };
                return msg;
            }
            else
            {
                Message msg = new Message()
                {
                    Text = $"{Name} otkazalsa ot {eat}",
                    Name = Name,
                    MessageType = MessageType.Eat
                };
                return msg;
            }*/
        public virtual Message ToSound()
        {
            Message msg = new Message()
            {
                Text = $"{Name} izdayet zvuki {_sound}",
                SenderName = Name,
                SenderType = TypeOfAnimal,
                MessageType = MessageType.Sound
            };
            return msg;
        }
        public abstract Message ToPlay();

    }
}
