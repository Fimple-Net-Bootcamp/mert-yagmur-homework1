namespace LibraryManagementSystem
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
        }

        public List<Book> Books => books;
        public List<Member> Members => members;

        // Method to add a book to the library
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Name}' added to the library.");
        }

        // Method to remove a book from the library
        public void RemoveBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                Console.WriteLine($"Book '{book.Name}' removed from the library.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Name}' not found in the library.");
            }
        }

        // Method to lend a book to a member
        public void LendBook(Book book, Member member)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                member.BorrowedBooks.Add(book);
                Console.WriteLine($"Book '{book.Name}' lent to {member.FirstName} {member.LastName}.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Name}' not available in the library for lending.");
            }
        }

        // Method to return a book to the library
        public void ReturnBook(Book book, Member member)
        {
            if (member.BorrowedBooks.Contains(book))
            {
                member.BorrowedBooks.Remove(book);
                books.Add(book);
                Console.WriteLine($"Book '{book.Name}' returned by {member.FirstName} {member.LastName}.");
            }
            else
            {
                Console.WriteLine($"Book '{book.Name}' not borrowed by {member.FirstName} {member.LastName}.");
            }
        }

        // Method to add a member to the library
        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine($"Member {member.FirstName} {member.LastName} (ID: {member.MembershipId}) added to the library.");
        }

        // Method to remove a member from the library
        public void RemoveMember(Member member)
        {
            if (members.Contains(member))
            {
                members.Remove(member);
                Console.WriteLine($"Member {member.FirstName} {member.LastName} (ID: {member.MembershipId}) removed from the library.");
            }
            else
            {
                Console.WriteLine($"Member {member.FirstName} {member.LastName} (ID: {member.MembershipId}) not found in the library.");
            }
        }
    }
}
