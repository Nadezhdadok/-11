using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_11
{
    struct Lineyka
    {
        double k;
        double b;

        public Lineyka(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0 || b == 0)
            {
                return "Нет решения";
            }
            double x = -b / k;
            return $"Ответ ({x}:0)";
           
        }
    }
}
