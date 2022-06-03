using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class PetCat:Cat
    {
        public string Owner;

        public override void ShowInfo()
        {
            Console.WriteLine($"Owner: {Owner} - Name: {Name}");
        }
    }
}
