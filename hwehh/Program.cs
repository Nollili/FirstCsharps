using System;

namespace hweh
{
    class Program
    {
        static void Main(string[] args)
        {
            //Books
            bookclass book1 = new bookclass("Lord of the rings", "J.R.R. Tolkien", 1137);
            bookclass book2 = new bookclass("Harry Potter", "JK. Rowling", 800);

            bookclass book3 = new bookclass();
            book3.title = "The Hobbit";
            book3.author = "J.R.R. Tolkien";
            book3.pages = 364;
            Console.WriteLine("The title is: ");
            Console.WriteLine(book3.title);

            // Students
            Student student1 = new Student("Lili", "Business", 3.9);
            Student student2 = new Student("Barbara", "Literature", 2.8);

            Console.WriteLine("Has honours: ");
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());

            // Movies
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "PG-13");
            Movie Shrek = new Movie("Shrek", "Adam Adamson", "PG");
            Console.WriteLine("The title is: ");
            Console.WriteLine(avengers.title);


            // Songs
            Console.WriteLine("The song count is: ");
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount);
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(kashmir.getSongCount());


            //Hi
            UsefulTools.SayHi("Lili");


            // Chef
            Console.Write("The Chef: ");
            Chef chef = new Chef();
            chef.MakeChicken();



            Console.Write("The Italian Chef: ");
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakePasta();

            Console.WriteLine("The Chefs makes special dishes: ");
            italianChef.MakeSpecialDish();
            chef.MakeSpecialDish();
        }
    }
}
