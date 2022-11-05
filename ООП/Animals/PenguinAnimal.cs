using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using ООП.Options;
using static System.Net.Mime.MediaTypeNames;

namespace ООП.Animals
{
    public class PenguinAnimal : AbstractAnimals
    {
        public PenguinAnimal(string name, int age, double weight) : base(name, age, weight)
        {
            TypeOfAnimal = "Pingvin";
            Biom = BiomType.SouthPole;
            Square = 75;
            IsPredator = true;
            Food = new List<FoodType> () 
            {
                FoodType.Riba
            };
            MaxFoodForDay = 10;
            _sound = "IIIIIII";
        }
        public override Message ToPlay()
        {
            Message msg = new Message()
            {
                Text = $"{Name} igrayet so ldem",
                SenderName = Name,
                SenderType = TypeOfAnimal,
                MessageType = MessageType.Play
            };
            return msg;
        }
    }
}
