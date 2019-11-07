using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiFormWPF
{
    class Semaphor
    {
        private int onColor; //0 = Red, 1 = Green , 2 = Green
        public Semaphor()
        {
            Random r = new Random();
            onColor = r.Next(1, 3);
        }
        public void ChangeColor()
        {
            onColor = (onColor + 1) % 3; //sequential values from 0 to 2
        }
        public int getColorOn()
        {
            return onColor;
        }
    }
}
