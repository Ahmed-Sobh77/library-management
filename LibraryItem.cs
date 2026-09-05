using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    // Abstract class representing a library item 
    // i use an abstract class instead of an interface because i want to provide a common implementation for the id, title, and availableStatus properties, as well as the load method.
    // This allows me to avoid code duplication in the derived classes (Book and Magazine) and ensures that all library items have these common properties and behaviors.
    internal abstract class LibraryItem
    {
        public string id { get; protected set; }
        public string title { get; protected set; }
        public bool availableStatus { get; set; }

        protected LibraryItem(string id, string title)
        {
            this.id = id;
            this.title = title;
            availableStatus = true; // Default to available when created
        }
        public override string ToString() => $"{id} {title} {availableStatus}";
        public virtual void load(string []arr)
        {
            id = arr[1];
            title = arr[2];
            availableStatus = bool.Parse(arr[3]);
        }
    }
}
