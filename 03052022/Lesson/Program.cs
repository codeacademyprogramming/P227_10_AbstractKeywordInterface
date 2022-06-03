using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string option;
            do
            {
                Console.WriteLine("1. Kitab elave etmek");
                Console.WriteLine("2. Kitab satmaq");
                Console.WriteLine("3. Kitablari gostermek");
                Console.WriteLine("4. Cixmaq");

                option = Console.ReadLine();

                switch (option)
                {
                    case "1":

                        Console.WriteLine("Kitab elave etmek emeliyyat");
                        break;
                    case "2":
                        Console.WriteLine("Kitab satmaq emeliyyat");
                        break;
                    case "3":
                        Console.WriteLine("Kitablari goster");
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Duzgun secin!");
                        break;
                }



            } while (option!="4");

            Cat cat = new Cat();
            cat.Name = "Mestan";
            cat.MakeSound();
            cat.Age = 2;

            Dog dog = new Dog();
            dog.Name = "Artur";
            dog.MakeSound();

            cat.ShowInfo();
            dog.ShowInfo();

            PetCat petCat = new PetCat();
            petCat.Name = "Elizabet";
            petCat.Owner = "Eli";
            petCat.Age = 3;

            petCat.ShowInfo();

            Employee emp1 = new Employee();
            emp1.Position = "Developer";

            Student std1 = new Student();
            std1.GroupNo = "P227";

            emp1.Introduce();
            std1.Introduce();
        }
    }
}
