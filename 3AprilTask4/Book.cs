class Book:ILibraryItem
{
    public string  Title { get; set; }
    public string Author  { get; set; }
    public int AvailableCopies { get; set; }

    public Book(string title,string author,int availableCopies){
        Title=title;
        Author=author;
        AvailableCopies=availableCopies;
    }



    public void CheckOut(){
        if(AvailableCopies>0){
            AvailableCopies--;
            System.Console.WriteLine($"Book '{Title}' by {Author} checked out succesfully");
            System.Console.WriteLine(AvailableCopies);
        }
        else
        { System.Console.WriteLine($"Book'{Title}' by {Author} is not available for checkout"); }

    }

    public void Return(){
        AvailableCopies++;
        System.Console.WriteLine($"Book {Title} by {Author} returned successfully ");
        System.Console.WriteLine(AvailableCopies);
         }
}