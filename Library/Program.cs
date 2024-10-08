class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

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
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "556453006";
        book.NoOfPages = 200;
        
        

        Book book2 = new Book();
        book2.Title = "C# Methods and Classes";
        book2.Author = "Microsoft";
        book2.ISBN = "76251303";
        book2.NoOfPages = 50;

        // output book information to the console 
        book.DisplayInfo();
        book2.DisplayInfo();

       


    }

}