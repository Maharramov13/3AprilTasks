using System.Dynamic;

interface ILibraryItem
{
 string Title { get; set; }
 string Author { get; set; }
 int AvailableCopies { get; set; }

 void CheckOut(){


}
 void Return(){

}

    
}