using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Book : LibraryItem
    {
        public string author { get; private set; }
        public Book():base("", "") { }
        public Book(string id,string title,string author):base(id, title) { 
            this.author = author;
        }
    
        public void load(string[] arr)
        {
            id = arr[1];
            title = arr[2];
            availableStatus = bool.Parse(arr[3]);
            author = arr[4];
        }
        public override string ToString()
        {
            return "Book" + " " + base.ToString() + " " + author;
        }

}
        
}
