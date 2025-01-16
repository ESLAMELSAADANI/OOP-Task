using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_enum___struct___class_
{
    internal struct Book
    {
        #region Properties
        
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        #endregion

        #region Constructors

        public Book(string title,string author,string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        #endregion
    }
}
