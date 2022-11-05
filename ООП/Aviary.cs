using ООП.Animals;
using ООП.Options;


namespace ООП
{
    public class Aviary
    {
        public List<AbstractAnimals> Animals { get; set; }
        public string AviaryName { get; set; }
        public int  AviarySquare { get; set; }
        public BiomType AviaryBiom { get; private set; }
        public Aviary(string aviaryname, int aviarysquare)
        {
            AviaryName = aviaryname;
            AviarySquare = aviarysquare;  
            AviaryBiom = AviaryBiom;
            Animals = new List<AbstractAnimals>();
        }
        public Message AddAnimal(AbstractAnimals animal)
        {
            if (AviaryBiom != animal.Biom)
            {
                return new Message()
                {
                    Text = $"{animal.Name} ne poselilsa ,ne podxodit biom",
                    SenderName=animal.Name,
                    SenderType= "Aviary",
                    MessageType=MessageType.AddingAnimalFailed
                };
            }
            else if (GetFreeSpace()<animal.Square)
            {
                return new Message()
                {
                    Text = $"v {animal.Name} ne poselilsa v {AviaryName}, ne xvatilo mesta",
                    SenderName = animal.Name,
                    SenderType = "Aviary",
                    MessageType = MessageType.AddingAnimalFailed 
                };
            }
            else if(PodxodatLiSosedi(animal)==false)
            {
                return new Message()
                {
                    Text = $"v {AviaryBiom} ne poselilsa v {animal.Square} {animal.Name}, sosedi ne podxodat",
                    SenderName = AviaryName,
                    SenderType = "Aviary",
                    MessageType=MessageType.AddingAnimalFailed
                };
            }
            else
            {
                Animals.Add(animal);
                return new Message()
                {
                    Text = $"{animal.Name} poselilsa v {AviaryName}",
                    SenderName = animal.Name,
                    SenderType = "Aviary",
                    MessageType= MessageType.AddingAnimal
                };
            }
        }
        private int GetFreeSpace()
        {
            int freeSpace = AviarySquare;
            foreach(AbstractAnimals i in Animals)
            {
                freeSpace-=i.Square;
            }
            return freeSpace;
        }
        private bool PodxodatLiSosedi(AbstractAnimals animal)
        { 
            for(int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].IsPredator  && animal.IsPredator)
                {
                    return true;
                }
            }
            return true;
        }
    }
}

    