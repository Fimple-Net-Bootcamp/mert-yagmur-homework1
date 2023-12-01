using LibraryManagementSystem;

// Create books
Book book1 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, 1, "Fantasy");
Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 2, "Southern Gothic");
Book book3 = new Book("1984", "George Orwell", 1949, 3, "Dystopia");

// Create members
Member member1 = new Member("John", "Doe", 101);
Member member2 = new Member("Jane", "Smith", 102);

// Create library
Library library = new Library();

// Add books to the library
library.AddBook(book1);
library.AddBook(book2);

// Add members to the library
library.AddMember(member1);
library.AddMember(member2);

// Display library information
Console.WriteLine("Library Information:");
Console.WriteLine("Books:");
foreach (Book book in library.Books)
{
    Console.WriteLine($"  {book.Name} by {book.Author} ({book.Year}), ID: {book.Id}");
}

Console.WriteLine("Members:");
foreach (Member member in library.Members)
{
    Console.WriteLine($"  {member.FirstName} {member.LastName} (ID: {member.MembershipId})");
}

// Lend books
library.LendBook(book1, member1);
library.LendBook(book2, member2);
library.LendBook(book3, member2);

// Display books after lending
Console.WriteLine("Books after lending:");
foreach (Book book in library.Books)
{
    Console.WriteLine($"  {book.Name} by {book.Author} ({book.Year}), ID: {book.Id}");
}

// Return books
library.ReturnBook(book1, member1);
library.ReturnBook(book2, member1);

// Display books after returning
Console.WriteLine("Books after returning:");
foreach (Book book in library.Books)
{
    Console.WriteLine($"  {book.Name} by {book.Author} ({book.Year}), ID: {book.Id}");
}