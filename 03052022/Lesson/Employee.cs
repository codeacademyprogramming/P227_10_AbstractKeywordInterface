using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Employee:Human
    {
        public string Position;
        public override void Introduce()
        {
            Console.WriteLine($"Men isciyem, {Position} vezifede calisiram");
        }
    }
}
