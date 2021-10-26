using System;
using System.Collections.Generic;
using System.Text;

namespace CustomList_Type
{
    class MyList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private MyListAddition[] _MyListAddition;

        public MyList(int size = 100)
        {
            _MyListAddition = new MyListAddition[size];
        }
        public MyListAddition this[int index]
        {

            get
            {
                try
                {
                    return _MyListAddition[index];

                }
                catch (Exception)
                {

                    return _MyListAddition[0];
                }
            }
            set
            {
                try
                {
                    _MyListAddition[index] = value;

                }
                catch (Exception)
                {

                    Console.WriteLine("Out of Range");
                }
            }
        }
    }

}

