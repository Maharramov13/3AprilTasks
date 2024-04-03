class DVD:ILibraryItem
{

    public string  Title { get; set; }
    public string Author  { get; set; }

    public int AvailableCopies { get; set; }
    public DVD(string title,string author,int availableCopies){
        Title=title;
        Author=author;
        AvailableCopies=availableCopies;
    }

    public void CheckOut(){
        if(AvailableCopies>0){
            AvailableCopies--;
            System.Console.WriteLine($"DVD {Title} by {Author} checked out successfully");
            System.Console.WriteLine(AvailableCopies);
        }
        else
        {
            System.Console.WriteLine($"DVD {Title } by {Author} is not available ");
        }

    }

    public void Return(){
        AvailableCopies++;
        System.Console.WriteLine($"DVD {Title } by {Author}  returned successfully ");
        System.Console.WriteLine(AvailableCopies);

    }

}