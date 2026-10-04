using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exaprogramac
{
    class salon
    {
        public string nom;
        public List<alumno> lista = new List<alumno>();

        public void reg(alumno a)
        {
            lista.Add(a);
        }

        public void rem(string n)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].nom == n)
                {
                    lista.RemoveAt(i);
                    break;
                }
            }
        }

        public int cantaprob()
        {
            int c = 0;
            foreach (alumno a in lista)
            {
                if (a.prom() >= 13)
                {
                    c = c + 1;
                }
            }
            return c;
        }

        public int cantdesaprob()
        {
            int c = 0;
            foreach (alumno a in lista)
            {
                if (a.prom() < 13)
                {
                    c = c + 1;
                }
            }
            return c;
        }

        public List<alumno> listaprob()
        {
            List<alumno> l = new List<alumno>();
            foreach (alumno a in lista)
            {
                if (a.prom() >= 13)
                {
                    l.Add(a);
                }
            }
            return l;
        }

        public List<alumno> listdesaprob()
        {
            List<alumno> l = new List<alumno>();
            foreach (alumno a in lista)
            {
                if (a.prom() < 13)
                {
                    l.Add(a);
                }
            }
            return l;
        }

        public void promalum(string n)
        {
            foreach (alumno a in lista)
            {
                if (a.nom == n)
                {
                    Console.WriteLine("n1: " + a.n1);
                    Console.WriteLine("n2: " + a.n2);
                    Console.WriteLine("n3: " + a.n3);
                    Console.WriteLine("promedio: " + a.prom());
                    return;
                }
            }
            Console.WriteLine("no existe");
        }
    }
}