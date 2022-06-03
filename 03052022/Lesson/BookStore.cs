using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class BookStore : IBookStore
    {
        private Book[] _books;
        public Book[] Books { get=>_books ; }
        private double _totalIncome;

        public int BookLimit { get; set; }
        public double TotalIncome { get=>_totalIncome; }

        public void AddBook(Book book)
        {
            Array.Resize(ref _books, 1);
        }

        public void Sell(string no)
        {
           
        }


    }
}
