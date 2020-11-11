using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tamgiac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;decimal;
            Console.WriteLine("nhap canh thu nhat");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap canh thu 2:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap canh thu ba:");
            c = int.Parse(Console.ReadLine());

            if (a > a + b || b > a + c || c > a + b)
            {
                Console.WriteLine("nhap sai:");
            }
            else
            {
                if(a==b&& a==c&& b == c)
                {
                    Console.WriteLine("day la tam giac deu");
                }else
                    if((a==b )|| (a==c) || (b==c))
                {
                    Console.WriteLine("day la tam giac can:");
                }else
                    if((a*a == b*b + c*c)||(b*b == a*a+c*c)||(c*c == a * a + b * b))
                {
                    Console.WriteLine("day la tam giac vuong");
                }
                else
                {
                    Console.WriteLine("day la tam thuong");
                }
            }

            float chuvi = (a + b + c);
            Console.WriteLine("chu vi cua tam giac la:{0}", chuvi);
            float p = (chuvi)*1/2;
            float dientich = (p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("dien tich tam giac la:{0}", Math.Sqrt(dientich));
            Console.ReadKey();

        }
    }
}
