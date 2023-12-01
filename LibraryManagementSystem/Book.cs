namespace LibraryManagementSystem
{
    public class Book
    {
        private string name;
        private string author;
        private int year;
        private int id;

        public string Name { get => name; private set => name = value; }
        public string Author { get => author; private set => author = value; }
        public int Year { get => year; private set => year = value; }
        public int Id { get => id; private set => id = value; }

        public Book(string name, string author, int year, int id)
        {
            Name = name;
            Author = author;
            Year = year;
            Id = id;
        }
    }
}
