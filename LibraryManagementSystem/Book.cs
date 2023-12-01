namespace LibraryManagementSystem
{
    public class Book : WrittenWork, IPrintable
    {
        private string genre;

        public string Genre { get => genre; private set => genre = value; }
        
        public Book(string name, string author, int year, int id, string genre)
            : base(name, author, year, id)
        {
            Genre = genre;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} by {Author} ({Year}, ID: {Id}, Genre: {Genre})");
        }
    }
}
