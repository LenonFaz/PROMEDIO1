using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exaprogramac
{
    class alumno
    {
        public string nom;
        public double n1;
        public double n2;
        public double n3;

        public double prom()
        {
            return (n1 + n2 + n3) / 3;
        }
    }
}