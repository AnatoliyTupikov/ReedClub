using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Magazine : Item
    {
        private string volume;
        private int number;
        private string title;
        private int year;

        public Magazine(long invNumber, bool availability, string volume, int number, string title, int year ) : base(invNumber, availability)
        {
            this.volume = volume;
            this.number = number;
            this.title = title;
            this.year = year;
        }

        new public void Show() 
        {
            Console.WriteLine($"\nMagazine:\n Volume: {this.volume}\n Number: {number}\n Title: {title}\n Release Year: {year}\n");
            base.Show();
        }
    }
}
