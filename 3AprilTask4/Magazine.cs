class Magazine:ILibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int AvailableCopies { get; set; }

    public Magazine(string title,string author,int availableCopies){
        Title=title;
        Author=author;
        AvailableCopies=availableCopies;
    }
    
    public void CheckOut(){
        if(AvailableCopies>0){
            AvailableCopies--;
            System.Console.WriteLine($"Magazine {Title} by {Author} checked out successfully");
            System.Console.WriteLine(AvailableCopies);
        }
        else
        {
            System.Console.WriteLine($"Magazine {Title} by {Author} is not available. ");
        }

    }
    public void Return()
    {
        AvailableCopies++;
        System.Console.WriteLine($"Magazine {Title } by {Author}  returned successfully ");
        System.Console.WriteLine(AvailableCopies);

    }
}