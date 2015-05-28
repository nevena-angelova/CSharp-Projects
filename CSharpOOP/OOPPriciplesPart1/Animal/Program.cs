using System;

namespace Animal
{

    public interface ISound
    {
        string ProduceSound();
    }

    public enum Gender
    {
        Male, Female
    }

    public abstract class Animal : ISound
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Gender Sex { get; set; }

        public abstract string ProduceSound();

        public static decimal Average(Animal[] animals)
        {
            decimal sum = 0;
            foreach (Animal animal in animals)
            {
                sum += animal.Age;
            }

            return sum / animals.Length;
        }

    }

    public class Frog : Animal
    {
        public Frog(int age, string name, Gender sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public override string ProduceSound()
        {
            return "Kva kva";
        }

    }

    public class Dog : Animal
    {
        public Dog(int age, string name, Gender sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public override string ProduceSound()
        {
            return "Bau bau bau";
        }
    }

    public abstract class Cat : Animal
    {
        public override string ProduceSound()
        {
            return "Miauuuuu";
        }
    }

    public class Kitten : Cat
    {
        public Kitten(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = Gender.Female;
        }
    }

    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = Gender.Male;
        }
    }


    class Program
    {
        static void Main()
        {

            Frog[] frogs = 
            {
            new Frog(4, "Froggy", Gender.Male),
            new Frog(2, "Jumpy", Gender.Male),
            new Frog(1, "Sara", Gender.Female),
            };

            Dog[] dogs = 
            {
            new Dog(1, "Mecho", Gender.Male),
            new Dog(4, "Lisa", Gender.Female),
            new Dog(6, "Sharo", Gender.Male)
            };

            Cat[] cats = 
            {
            new Kitten(2, "Pissi"),
            new Kitten(5, "Cleopatra"),
            new Tomcat(3, "Tom")
            };


            Console.WriteLine("Dog {0} said {1}", dogs[0].Name, dogs[0].ProduceSound());
            Console.WriteLine("Frog {0} siad {1}", frogs[1].Name, frogs[1].ProduceSound());
            Console.WriteLine("Cat {0} siad {1}", cats[1].Name, cats[1].ProduceSound());


            Console.WriteLine("Frog's age avarage is: {0}", Animal.Average(frogs));
            Console.WriteLine("Dog's age average is: {0}", Animal.Average(dogs));
            Console.WriteLine("Cat's age average is: {0}", Animal.Average(cats));

        }
    }
}
