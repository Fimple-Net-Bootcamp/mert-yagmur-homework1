namespace LibraryManagementSystem
{
    public class Book : WrittenWork
    {
        private string genre;

        public string Genre { get => genre; private set => genre = value; }
        
        public Book(string name, string author, int year, int id, string genre)
            : base(name, author, year, id)
        {
            Genre = genre;
        }
    }
}
