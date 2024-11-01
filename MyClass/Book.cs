namespace MyClass
{
    internal class Book : Item
    {
        private string? title;
        private string? author;
        private string? publisher;
        private int releaseyear;
        private int pages;
        private bool returnExp;

        private static decimal rentCost = 9;
        public int Releaseyear
        {
            get => releaseyear;
            private set
            {
                if (value <= 0) releaseyear = 1;
                else releaseyear = value;
            }
        }
        public int Pages 
        {
            get => pages; 
            private set 
            {
                if (value <= 0) pages = 1;
                else pages = value;
            } 
        }
        //public Book (string title, string author, int releaseyear, int pages)
        //{
        //    this.title = title;
        //    this.author = author;
        //    this.releaseyear = releaseyear;
        //    this.pages = pages;xcvxcv
        //}
        static Book() { rentCost = 10; }
        public Book() {}
        public Book(long invNumber, bool availability, string title, string author, string publisher, int releaseyear, int pages) : base(invNumber, availability)
        {
            this.publisher = publisher;
            this.title = title;
            this.author = author;
            this.Releaseyear = (int)releaseyear;
            this.Pages = (int)pages;
        }

        public static void SetRentCost (decimal am) { Book.rentCost = am; }

        new public void Show()
        {
            Console.WriteLine($"Book title: \"{this.title ?? "Unknown"}\" \nAuthor: \"{this.author ?? "Unknown"}\" \nPublisher: \"{this.publisher ?? "Unknown"}\" \nRelease year: {this.releaseyear} \nPage amount: {this.pages} \nRent Cost per day: \"{Book.rentCost}\"\n");
            base.Show();
        }

        public decimal CostofRent(int days) => Book.rentCost * days;

        public int CompareTo(Book? other)
        {
            if(other == null) throw new ArgumentNullException();
            if (this.Releaseyear == other.releaseyear) return 0;
            if (this.Releaseyear > other.releaseyear) return 1;
            else return -1;
        }

        public void ReturnSrok() => this.returnExp = true;

        public override void Return()
        {
            if (returnExp) base.availability = true;
            else base.availability = false;
        }




    }
}
