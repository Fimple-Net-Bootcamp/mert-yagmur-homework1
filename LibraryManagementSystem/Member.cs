namespace LibraryManagementSystem
{
    public class Member : IPrintable
    {
        private string firstName;
        private string lastName;
        private int membershipId;
        private List<Book> borrowedBooks;

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public int MembershipId { get => membershipId; private set => membershipId = value; }
        public List<Book> BorrowedBooks { get => borrowedBooks; private set => borrowedBooks = value; }

        public Member(string firstName, string lastName, int membershipId)
        {
            FirstName = firstName;
            LastName = lastName;
            MembershipId = membershipId;
            BorrowedBooks = new List<Book>();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | (ID: {MembershipId}) | Borrowed Books: {string.Join(", ", BorrowedBooks.Select(book => book.Name))}");
        }
    }
}
