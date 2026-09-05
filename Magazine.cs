using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Magazine : LibraryItem
    {
       
  
        public Magazine():base("", "") { }
        public Magazine(string id, string title):base(id, title)
        {
        }
        public void load(string[] arr)
        {
            id= arr[1];
            title= arr[2];
            availableStatus=bool.Parse(arr[3]);
        }
        public override string ToString()
        {
            return "Magazine" + " " + base.ToString();
        }

    }
}
