using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal class Library
    {
        HashSet<LibraryItem> libraryItems;
        HashSet<Member> members;
        public Library()
        {
            libraryItems = new HashSet<LibraryItem>();
            members = new HashSet<Member>();
        }
        public void addLibraryItem(LibraryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item cannot be null.");
            }
            if (!libraryItems.Contains(item)) 
            libraryItems.Add(item);
        }
        public void addMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member), "Member cannot be null.");
            }
            if (!members.Contains(member))
                members.Add(member);
        }
        public void removeLibraryItem(LibraryItem item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item cannot be null.");
            }
            if (libraryItems.Contains(item))
                libraryItems.Remove(item);
        }
        public void removeMember(Member member)
        {
            if (member == null)
            {
                throw new ArgumentNullException(nameof(member), "Member cannot be null.");
            }
            if (members.Contains(member))
                members.Remove(member);
        }
       
        public List<string> showAvailableLibraryItems()
        {
            List<String> availableItems = new List<String>();
            foreach (LibraryItem item in libraryItems)
            {
                if (item.availableStatus)
                {
                    availableItems.Add(item.title);
                }
            }
            return availableItems;
        }
        public LibraryItem getLibraryItem(string id)
        {
            foreach (LibraryItem item in libraryItems)
            {
                if (item.id == id)
                {
                    return item;
                }
            }
            return null;
        }
        public void borrow(string id,Member m)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m), "Member cannot be null.");
            }
            LibraryItem item = getLibraryItem(id);
            if (item != null && item.availableStatus)
            {
                item.availableStatus = false;
                m.updateBorrowedItems(item);
            }
            else
            {
                throw new InvalidOperationException("Item is not available for borrowing.");
            }
        }
        public void returnBook(string id,Member m)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m), "Member cannot be null.");
            }
            LibraryItem item = getLibraryItem(id);
            if (item == null)
            {
                throw new ArgumentNullException( "this item not from here.");
            }
            if (!item.availableStatus)
            {
                item.availableStatus = true;
                m.removeBorrowedItems(item);
            }
            else
            {
                throw new InvalidOperationException("Item is already here.");
            }
        }
         public void saveLibraryData()
        {
            using (var sw=new StreamWriter("database"))
            {
                sw.WriteLine("LibraryItems:");
                foreach(LibraryItem li in libraryItems)
                {
                    sw.WriteLine(li.ToString());
                }
                sw.WriteLine("Members:");
                foreach (Member me in members)
                {
                    sw.WriteLine(me.ToString());
                }
            }
        }
        public void loadData()
        {
            using (var sr = new StreamReader("database"))
            {
                string ?line;
                bool items = false;
                while ((line = sr.ReadLine()) is not null)
                {
                    if (line== "LibraryItems")
                    {
                        items= true;
                    }else if(line== "Members")
                    {
                        items=false;
                    }
                    string[] arr = line.Split(' ');
                    if (items)
                    {
                      
                        if (arr[0] == "Book")
                        {
                            Book b = new Book();
                            b.load(arr);
                            libraryItems.Add(b);
                        }
                        else
                        {

                            Magazine b = new Magazine();
                            b.load(arr);
                            libraryItems.Add(b);
                        }
                    }
                    else
                    {
                        Member m=new Member(arr[1], arr[2]);
                        members.Add(m);
                    }

                }
            }
        }

    }
}
