using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS17FormsApp01
{
    public class Soldier
    {

        static public int _id = 1;
        public string name, surname, fathers_name, born, rank, position, platoon, serve_since;
        public int id = _id;

        public Soldier()
        {
            _id++;
        }
    }
}
