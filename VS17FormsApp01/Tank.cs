using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS17FormsApp01
{
    public class Tank
    {
        static public int _id = 1;
        public string model, number;
        public int id = _id;

        public Tank()
        {
            _id++;
        }
    }
}
