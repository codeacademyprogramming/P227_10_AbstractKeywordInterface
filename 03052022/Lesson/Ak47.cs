using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Ak47 : IGun,IFireable
    {
        private int _magazineCapacity;
        public int MagazineCapacity
        { 
            get => _magazineCapacity;
            set => _magazineCapacity = value; 
        }
        public int CurrentMagazine { get; set; }

        public void Fire()
        {
            if (CurrentMagazine > 1)
                CurrentMagazine -= 2;
            else
                Console.WriteLine("Gulle bitib");
        }
    }
}
