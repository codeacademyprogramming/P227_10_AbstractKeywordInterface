using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal interface IGun
    {
        int MagazineCapacity { get; set; }
        int CurrentMagazine { get; set; }
    }
}
