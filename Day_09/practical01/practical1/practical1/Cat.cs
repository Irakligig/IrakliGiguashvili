using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical1
{
    internal class Cat
    {
        private string _name;

        private string _breed;

        public int Age {  get;  set; }
        
        public bool IsMale { get; set; }

        private int caneat = 10;

        public string Name 
        {
            get
            {
                return _name;   
            }
            set
            {
                _name = value;
            }
        }
        public string Breed
        {
            get 
            { 
                return _breed;
            }
            set
            {
                _breed = value;
            }
        }

        public void mewing()
        {
            Console.WriteLine("Meowing");
        }

        public void eating(int grams)
        {
            Console.WriteLine("Tom start eating");
            for(int i = grams; i > 0; i = i - 10)
            {
                Console.WriteLine("Eating ...");
            }
            Console.WriteLine("Tom finished eating");
        }

    }
}
