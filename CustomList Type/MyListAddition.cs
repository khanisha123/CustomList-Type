using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList_Type
{
    class MyListAddition
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Name}";
        }
    }
}
