using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Member
    {
        public string id { get; private set; }
        public string name { get; private set; }
        HashSet<LibraryItem> borrowedItems;
        public Member(string id, string name)
        {
            this.id = id;
            this.name = name;
            borrowedItems = new HashSet<LibraryItem>();
        }
        public void updateBorrowedItems(LibraryItem item)
        {
            borrowedItems.Add(item);
        }
        public void removeBorrowedItems(LibraryItem item)
        {
            borrowedItems.Remove(item);
        }
        public override string ToString()
        {
            return "Member"+" "+id+" "+name;
        }

    }
}
