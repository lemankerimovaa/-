using ООП.Animals;

AbstractAnimals penguin = new PenguinAnimal("Tulupchik", 5, 10);
Console.WriteLine(penguin.ToEat(3,"fish").Text);
Console.WriteLine(penguin.ToSound("AAAAA").Text);
Console.WriteLine(penguin.ToPlay("Water").Text);

AbstractAnimals frog = new FrogAnimal("Vudi", 3, 0.6);
Console.WriteLine(frog.ToEat(1, "komari").Text);
Console.WriteLine(penguin.ToSound("Kva Kva").Text);
Console.WriteLine(penguin.ToPlay("Ice").Text);


