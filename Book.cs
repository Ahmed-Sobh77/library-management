using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Book : LibraryItem
    {
        public string id { get; private set; }
   
    public string title { get; private set; }
    public bool availableStatus { get; set; }
        public Book() { }
    public Book( string id, string title, bool availableStatus)
    {
        this.id = id;
        this.title = title;
        this.availableStatus = availableStatus;
    }
        public void load(string[] arr)
        {
            id = arr[1];
            title = arr[2];
            availableStatus = bool.Parse(arr[3]);
        }
        public override string ToString()
        {
            return "Book"+" "+id+" "+title+" "+availableStatus;
        }

}
        
}
