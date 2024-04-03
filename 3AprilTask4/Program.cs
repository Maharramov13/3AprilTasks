internal class Program
{
    public static void Main(string[] args)
    {
        /*
            Create a library management system using interfaces. 
            Define an interface called ILibraryItem with properties like Title, 
            Author, and AvailableCopies, along with methods like CheckOut() and Return(). 
            Implement this interface in classes representing different types of library items such as Book,
            DVD, and Magazine. 
            Use these classes to manage library items by checking out and returning them based on user interactions.
        */

        Book book= new Book("Gun var esre Beraber","Chingiz Aytmatov",13);
        Magazine magazine=new Magazine("Kirpi","Samir Polad",5);
        DVD dvd=new DVD("Oppenheimer","Cristopher Nolan",3);
        book.CheckOut();

        dvd.CheckOut();
        magazine.CheckOut();


        book.Return();
        dvd.Return();
        magazine.Return();
       
    }
}