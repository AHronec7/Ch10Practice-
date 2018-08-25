using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDemo
{
    class Cars : Car
    {
        private int doors;

       public Cars()
        {
            doors = 0;

        }
        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }
        
    }
}
