using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    class People
    {
        Person[] data;
        public People(int quantity)
        {
            data = new Person[quantity];
        }
        public Person this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}
