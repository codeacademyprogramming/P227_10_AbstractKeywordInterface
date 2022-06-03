using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal abstract class Animal
    {
        public string Name;

        public abstract void MakeSound();

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
