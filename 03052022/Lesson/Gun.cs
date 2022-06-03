using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal abstract class Gun
    {
        public abstract int MagazineCapacity { get; set; }
        public abstract int CurrentCapacity { get; set; }
    }
}
