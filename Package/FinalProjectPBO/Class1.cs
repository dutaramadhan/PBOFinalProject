using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDoPackage
{
    public class ToDo : ToDoBase
    {
        private List<DateTime> myList = new List<DateTime>();

        public void DateSort<T>(DateTime dt)
        {
            myList.Add(dt);
            myList.Sort((x, y) => DateTime.Compare(x, y));
            myList = myList.OrderBy(x => x).ToList();
        }
    }
}