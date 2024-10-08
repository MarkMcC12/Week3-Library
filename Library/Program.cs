class Book
{

    //properties 
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for book object 
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;  

    }

    void DisplayInfo()
    {
        // output book information to console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"No of Pages: {NoOfPages}");
        Console.WriteLine("----------------");
        Console.WriteLine();

    }

    static void Main(string[] args)
    {
        // create a new instance of the book class 
        Book book = new Book("C# for beginners", "Bill Gates", "556453006", 200);
        Book book2 = new Book("Visual studio 2022", "Microsoft", "123", 70);
       
       //anoter instance
       //title = "Visual studio 2022"
       // Author = "Microsoft"
       //ISBN = "123"
       // No of pages = 70 

        // output book information to the console 
        book.DisplayInfo();
        book2.DisplayInfo();
        

       


    }

}