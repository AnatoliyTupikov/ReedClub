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

        public bool IsAvailable() => availability;
        public long GetInvNumber() => invNumber;

        public void Take() => availability = false;

        public void Return() => availability = true;

        virtual public void Show() => Console.WriteLine($"State: \nInventory number: {invNumber}, Availability: {availability}");
    }
}
