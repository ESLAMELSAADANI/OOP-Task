using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_enum___struct___class_
{
    internal class LibraryItem
    {
        #region Properties
        
        public int ItemId { get; set; }
        public static bool IsAvailable { get; set; }

        #endregion

        #region Methods

        public static void CheckOut()
        {
            IsAvailable = false;
        }
        public static void ReturnItem()
        {
            IsAvailable = true;
        }

        #endregion
    }
}
