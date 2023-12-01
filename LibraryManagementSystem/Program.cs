using LibraryManagementSystem;

// Create books
Book book1 = new Book("The Hobbit", "J.R.R. Tolkien", 1937, 1, "Fantasy");
Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960, 2, "Southern Gothic");
Book book3 = new Book("1984", "George Orwell", 1949, 3, "Dystopia");
Book book4 = new Book("Lord of the Flies", "William Golding", 1954, 4, "Psychological");

// Create members
Member member1 = new Member("John", "Doe", 101);
Member member2 = new Member("Jane", "Smith", 102);

// Create library
Library library = new Library();

// Add books to the library
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book4);

// Add members to the library
library.AddMember(member1);
library.AddMember(member2);

// Display library information
Console.WriteLine("\nLibrary Information:");
Console.WriteLine("Books:");
foreach (Book book in library.Books)
{
    book.PrintInfo();
}

Console.WriteLine("Members:");
foreach (Member member in library.Members)
{
    member.PrintInfo();
}
Console.WriteLine("------------------------------------------------");

// Lend books
library.LendBook(book1, member1);
library.LendBook(book2, member2, true);
library.LendBook(book3, member2);

// Display books after lending
Console.WriteLine("\nBooks after lending:");
foreach (Book book in library.Books)
{
    book.PrintInfo();
}
Console.WriteLine("------------------------------------------------");

Console.WriteLine("Member info after lending:");
foreach (Member member in library.Members)
{
    member.PrintInfo();
}
Console.WriteLine("------------------------------------------------");

// Return books
library.ReturnBook(book1, member1);
library.ReturnBook(book2, member1);
library.ReturnBook(book2, member2, 15);

// Display books after returning
Console.WriteLine("\nBooks after returning:");
foreach (Book book in library.Books)
{
    book.PrintInfo();
}
Console.WriteLine("------------------------------------------------");