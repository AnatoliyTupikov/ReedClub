
namespace MyClass
{
    internal class Program
    {
        public static void Helpmethod (Item obj) => obj.Show ();
        static void Main(string[] args)
        {

            var book1 = new Book("Idiot", "Feodor Dostoevskiy", "Prosveschenie", 2017, 536);
            var book2 = new Book("Толстой Л.Н.", "Война и мир", "Наука", 823, 2013);


            Book.SetRentCost(12);
            
            Helpmethod (book1);


        }
    }
}
