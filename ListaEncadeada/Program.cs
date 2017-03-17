using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Number[] n = new Number[100];
            for (int i = 0; i < n.Length; i++)
            {
                n[i] = new Number(new Random().Next(0, 100), i);
                if(i != 0)
                {
                    n[i - 1].next = n[i];
                }
            }

            ListNumbers(n[0]);
            Console.ReadKey();
        }

        public static Number ListNumbers(Number number)
        {
            Number n = number;
            while(true)
            {
                if (n == null)
                {
                    Console.WriteLine("Busca Concluída");
                    return n;
                }
                Console.WriteLine("O numero " + n.n + " está na posição " + n.position);
                n = n.next;
            }
        }
    }

    public class Number
    {
        public int position;
        public int n;
        public Number next;

        public Number(int n, int position)
        {
            this.n = n;
            this.position = position;
        }
        
        public void Remove()
        {
            this.next = next.next;
        }

        public void Add(Number n)
        {
            this.next = n;
        }
    }

}
