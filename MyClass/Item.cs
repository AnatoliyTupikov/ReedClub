using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass
{
    internal class Item
    {

        private long invNumber;
        protected bool availability;

        public Item() { availability = true; }   
        public Item(long invNumber, bool availability) 
        {
            this.invNumber = invNumber;
            this.availability = availability;
        }

        public bool IsAvailable() => availability;
        public long GetInvNumber() => invNumber;

        public void Take() => availability = false;

        virtual public void Return() => availability = true;

        public void Show() => Console.WriteLine($"State: \nInventory number: {invNumber}, Availability: {availability}");

        public void TakeItem()
        {
            if (IsAvailable()) Take();
        }
    }
}
