using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            Console.ReadKey();
            Console.WriteLine();

            Dog dog = new Dog();
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string NameAnimal { get; set; }
        public abstract void Say();

        public void ShowInfo()
        { 
            Console.WriteLine("Животное называется {0}", NameAnimal);
            Say();
        }
        public Animal(string nameAnimal = "Неведома зверюга")
        {
            NameAnimal = nameAnimal;
        }
    }
    class Cat : Animal
    {
        public static string voice = "МЯУ";
        public override string NameAnimal { get; set; }

        public Cat()
        {
            NameAnimal = "Кошка";
        }
        public override void Say()
        {
            Console.WriteLine("Животное говорит {0}", voice);
        }

    }
    class Dog : Animal
    {
        public static string voice = "ГАВ";
        public override string NameAnimal { get; set; }

        public Dog()
        {
            NameAnimal = "Собака";
        }
        public override void Say()
        {
            Console.WriteLine("Животное говорит {0}", voice);
        }

    }
}
