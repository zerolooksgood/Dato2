using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dato2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dato1 = new int[2];
            int[] dato2 = new int[2];
            //Definerer arraysene før loopen

            while (true)
            {
                try
                {
                    Console.WriteLine("Skriv inn den første datoen (dd/mm)");
                    string[] temp = Console.ReadLine().Split('/'); //Splitter svaret inn i dag og måned i en array
                    for (int i = 0; i < temp.Length; i++) //Converter string datoene fra temp til int datoer i dato1
                    {
                        dato1[i] = Convert.ToInt32(temp[i]);
                    }
                    Console.WriteLine("Skriv inn dne andre datoen (dd/mm)");
                    temp = Console.ReadLine().Split('/');
                    for (int i = 0; i < temp.Length; i++)
                    {
                        dato2[i] = Convert.ToInt32(temp[i]);
                    }
                    break;
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            if (dato1[1] == dato2[1] && dato1[0] == dato2[0])
            {
                Console.WriteLine("Det er samme dato");
            } else if (dato1[1] > dato2[1] || (dato1[1] == dato2[1] && dato1[0] > dato2[0]))
            {
                Console.WriteLine("Det er feil rekkefølge");
            } else
            {
                Console.WriteLine("Det er riktig rekkefølge");
            }

            Console.ReadLine();
        }
    }
}
