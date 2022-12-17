using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Shape
    {
        public abstract string Area();

        public virtual string Draw()
        {
            return "Draw any shape";
        }

    }
}
