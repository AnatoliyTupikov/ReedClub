
namespace MyClass
{
    internal class Program
    {
        public static void Helpmethod (Item obj) => obj.Show ();
        static void Main(string[] args)
        {
            var item = new Item ();
            item.Show ();

            var book1 = new Book(112351, true, "Idiot", "Feodor Dostoevskiy", "Prosveschenie", 2017, 536);
            var book2 = new Book(112352, true, "Толстой Л.Н.", "Война и мир", "Наука", 823, 2013);
            var mag1 = new Magazine(112355, true, "Zima", 1, "Murzilka", 1985);

            book1.TakeItem();
            mag1.TakeItem();

            book1.Show ();
            book2.Show ();
            mag1.Show ();


            Book.SetRentCost(12);

            Item b = book1;

            b.TakeItem();
            b.Show ();

        }
    }
}
