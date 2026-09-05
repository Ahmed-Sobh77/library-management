using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Magazine : LibraryItem
    {
        public string issue { get; private set; }
        public Magazine():base("", "") { }
        public Magazine(string id, string title, string issue):base(id, title)
        {
            this.issue = issue;
        }
        public void load(string[] arr)
        {
           base.load(arr);
            issue = arr[4];
        }
        public override string ToString()
        {
            return "Magazine" + " " + base.ToString() + " " + issue;
        }

    }
}
