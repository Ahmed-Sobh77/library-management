using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
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
    }
}
