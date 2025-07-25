namespace BookClassDriverInterface
{
    public class Book : ICloneable
    {
        //author, title, keywords, publication date, ISBN
        private string _author;
        private string _title;
        private List<string> _keywords;
        private string _publicationDate;
        private string _isbn;

        public string Author
        {
            get => _author;
            set => _author = value;
        }
        public string Title
        {
            get => _title;
            set => _title = value;
        }
        public List<string> Keywords
        {
            get => _keywords;
            set => _keywords = value;
        }
        public string PublicationDate
        {
            get => _publicationDate;
            set => _publicationDate = value;
        }
        public string Isbn
        {
            get => _isbn;
            set => _isbn = value;
        }
        public Book()
        {
            Author = "";
            Title = "";
            Keywords = new List<string>();
            PublicationDate = "";
            Isbn = "";
        }

        public Book(string author, string title, List<string> keywords, string publicationDate, string isbn)
        {
            Author = author;
            Title = title;
            Keywords = keywords;
            PublicationDate = publicationDate;
            Isbn = isbn;
        }
        public Book(Book original)
        {
            Author = original.Author;
            Title = original.Title;
            Keywords = new List<string>(original.Keywords);
            PublicationDate = original.PublicationDate;
            Isbn = original.Isbn;
        }

        public override string ToString()
        {
            return (Title + ", written by " + Author + ", was published " + PublicationDate +
                " under the ISBN " + Isbn + " and is listed under these keywords: " + string.Join(", ", Keywords) + ".");
        }

        public object Clone()
        {
            return new Book(this);
        }


    }
}