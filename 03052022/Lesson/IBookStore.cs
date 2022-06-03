using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal interface IBookStore
    {
        Book[] Books { get; }
        int BookLimit { get; set; }
        void AddBook(Book book);
        void Sell(string no);
        double TotalIncome { get; }
    }
}
