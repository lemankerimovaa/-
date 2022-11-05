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
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public BiomType Biom { get; set; }
        public double square { get; set; }
        public bool isPredator;
        public string[] Eats { get; set; }
        public string sound;
        public AbstractAnimals(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public void Print(string name, string age, double weight)
        {
            return $"Imya:{Name} Vozrast:{Age} Vesit:{Weight}";        //???
        }
        public Message ToEat(int kg, string eat)
        {
            if (Eats.Contains(eat))
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
            }
        }
        public Message ToSound(string sound)
        {
            Message msg = new Message()
            {
                Text = $"{Name} izdayet zvuki {sound}",
                Name = Name,
                MessageType = MessageType.Sound
            };
            return msg;
        }
        public Message ToPlay(string playwith)
        {
            Message msg = new Message()
            {
                Text = $"{Name} play with {playwith}",
                Name = this.Name,
                MessageType = MessageType.Play
            };
            return msg;
        }
    }
}
