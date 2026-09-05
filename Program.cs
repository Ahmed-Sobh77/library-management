namespace Checkpoint1_library_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.loadData();
            LibraryItem book1 = new Book("B001", "The Great Gatsby", true);
            try
            {
                library.addLibraryItem(book1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error adding library item: {ex.Message}");
            }
            Member member1 = new Member("M001", "John Doe");
            try
            {
                library.addMember(member1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Error adding member: {ex.Message}");
            }
            try
            {
                library.borrow("B001", member1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error borrowing item: {ex.Message}");
            }
            library.showAvailableLibraryItems();
            library.saveLibraryData();
        }
    }
}
