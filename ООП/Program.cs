using ООП;
using ООП.Animals;
using ООП.Options;

/*AbstractAnimals penguin = new PenguinAnimal("Tulupchik", 5, 10);
Console.WriteLine(penguin.ToEat(3,"fish").Text);
Console.WriteLine(penguin.ToSound("AAAAA").Text);
Console.WriteLine(penguin.ToPlay("Ice").Text);

AbstractAnimals frog = new FrogAnimal("Vudi", 3, 0.6);
Console.WriteLine(frog.ToEat(1, "komari").Text);
Console.WriteLine(frog.ToSound("Kva Kva").Text);
Console.WriteLine(frog.ToPlay("Water").Text);*/

AbstractAnimals bear = new BearAnimal("Amur", 14, 27);
AbstractAnimals giraffe = new GiraffeAnimal("Vudi", 7, 15);
AbstractAnimals horse = new HorseAnimal("Barxat", 15, 24);
AbstractAnimals penguin = new PenguinAnimal("Tulupchik", 5, 11);
AbstractAnimals tiger = new TigerAnimal("Dobbi", 9, 25);

Aviary aviary1 = new Aviary("Forest", 372);
Aviary aviary2 = new Aviary("Savanna", 235);
Aviary aviary3 = new Aviary("Stepi", 380);
Aviary aviary4 = new Aviary("South Pole", 100);
Aviary aviary5 = new Aviary("Jungle", 270);

Console.WriteLine(aviary1.AddAnimal(bear).Text);

List<AbstractAnimals> animals = new List<AbstractAnimals>();
List<AbstractAnimals> aviaries = new List<AbstractAnimals>();
animals.Add(bear);
animals.Add(giraffe);
animals.Add(horse);
animals.Add(penguin);
animals.Add(tiger);
aviaries.Add(bear);
aviaries.Add(giraffe);
aviaries.Add(horse);
aviaries.Add(penguin);
aviaries.Add(tiger);
/*foreach (var animal in animals)
{
    //Console.WriteLine(animal.ToEat(9,TypeOfFood.Riba).Text);
    Console.WriteLine(animal.ToSound().Text);
    Console.WriteLine(animal.ToPlay().Text);
    Console.WriteLine(animal.AddAnimal(animal).Text);
}
for (int i = 0; i < aviaries.Count; i++)
{
    Console.WriteLine(aviaries[i].);
}
*/