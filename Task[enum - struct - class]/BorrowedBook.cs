using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_enum___struct___class_
{
    internal class BorrowedBook : LibraryItem
    {
        #region Properties
        
        public Book BookDetails { get; set; }
        public string BorrowerName { get; set; }
        public DateTime BorrowedDate { get; set; }

        #endregion

        #region Constructors

        public BorrowedBook(Book bookDetails,string borrowerName, DateTime borrowedDate)
        {
            BookDetails = bookDetails;
            BorrowerName = borrowerName;
            BorrowedDate = borrowedDate;
        }

        #endregion

        #region Methods

        public int CalculateBorrowDuration(DateTime returnDate)
        {
            return returnDate.Day - BorrowedDate.Day;
        } 

        #endregion
    }
}
