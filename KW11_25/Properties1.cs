using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILA23_M320_4.Semester.KW11_25
{
    class Properties1
    {
        public int Speed {

            get { return _speed; }
            set { _speed = value; }

        }

        private int _speed = 50;

       

        public void Drive()
        {
            Console.WriteLine($"Das Auto fährt mit {_speed} km/h.");
        }

        public void ChangeSpeed(int s)
        {
            if(s < 0 || s > 210)
            {
                return;
            }
            _speed = s;
        }
    }
}
