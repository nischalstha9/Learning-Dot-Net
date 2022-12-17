using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Rectangle:Shape
    {
        public override string Draw()
        {
            //return base.Draw();
            return "Draw rectangle!";
        }
        public override string Area()
        {
            return "I am rectangle!";
        }
    }
}
