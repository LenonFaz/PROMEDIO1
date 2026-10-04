using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exaprogramac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<salon> salones = new List<salon>();
            int op = 0;

            while (op != 3)
            {
                Console.WriteLine("1 crear salon, 2 elegir salon, 3 salir");
                op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {
                    Console.WriteLine("nombre:");
                    salon s = new salon();
                    s.nom = Console.ReadLine();
                    salones.Add(s);
                }
                if (op == 2)
                {
                    for (int i = 0; i < salones.Count; i++)
                    {
                        Console.WriteLine(i + " " + salones[i].nom);
                    }
                    Console.WriteLine("numero de salon:");
                    int ind = Convert.ToInt32(Console.ReadLine());
                    salon act = salones[ind];

                    int op2 = 0;
                    while (op2 != 8)
                    {
                        Console.WriteLine("1 registrar alumno, 2 quitar alumno, 3 cuanntos aprobaron, 4 cuantos desaprobaron, 5 lista de aprobados, 6 lista de desaprobados, 7 calcular promedio de un alumno, 8 salir");
                        op2 = Convert.ToInt32(Console.ReadLine());

                        if (op2 == 1)
                        {
                            alumno a = new alumno();
                            Console.WriteLine("nombre:");
                            a.nom = Console.ReadLine();
                            Console.WriteLine("n1:");
                            a.n1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("n2:");
                            a.n2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("n3:");
                            a.n3 = Convert.ToDouble(Console.ReadLine());
                            act.reg(a);
                        }
                        if (op2 == 2)
                        {
                            Console.WriteLine("nombre a borrar:");
                            string n = Console.ReadLine();
                            act.rem(n);
                        }
                        if (op2 == 3)
                        {
                            Console.WriteLine(act.cantaprob());
                        }
                        if (op2 == 4)
                        {
                            Console.WriteLine(act.cantdesaprob());
                        }
                        if (op2 == 5)
                        {
                            foreach (alumno a in act.listaprob())
                            {
                                Console.WriteLine(a.nom);
                            }
                        }
                        if (op2 == 6)
                        {
                            foreach (alumno a in act.listdesaprob())
                            {
                                Console.WriteLine(a.nom);
                            }
                        }
                        if (op2 == 7)
                        {
                            Console.WriteLine("nombre del alumno:");
                            string n2 = Console.ReadLine();
                            act.promalum(n2);
                        }
                    }
                }
            }
        }
    }
}