using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Book : LibraryItem
    {
        public Book():base("", "") { }
        public Book(string id,string title):base(id, title) { }
    
        public void load(string[] arr)
        {
            id = arr[1];
            title = arr[2];
            availableStatus = bool.Parse(arr[3]);
        }
        public override string ToString()
        {
            return "Book" + " " + base.ToString();
        }

}
        
}
