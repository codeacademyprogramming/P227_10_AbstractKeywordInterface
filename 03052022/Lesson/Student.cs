using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Student:Human
    {
        public string GroupNo;
        public override void Introduce()
        {
            Console.WriteLine($"Men telebeyem, {GroupNo} nomreli qrupda oxuyuram");
        }
    }
}
