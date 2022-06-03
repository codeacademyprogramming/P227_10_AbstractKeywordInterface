using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Cat : Animal
    {
        public byte Age;
        public override void MakeSound()
        {
            Console.WriteLine("Meow meow");
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Age: " + Age);
        }

    }
    
}
