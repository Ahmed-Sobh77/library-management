using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint1_library_
{
    internal interface LibraryItem
    {
        string id { get; }
        string title { get; }
        bool availableStatus { get; set; }
        
    }
}
