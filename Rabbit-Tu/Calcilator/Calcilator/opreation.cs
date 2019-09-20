using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcilator
{
    class opreation
    {
        public static void PrintCalculator(int n)
        {
            Random rd = new Random();
            int a, b, c, d, e, r;
            int i = 0;
            string str;
            do
            {
                a = rd.Next(0, 100);
                b = rd.Next(0, 100);
                c = rd.Next(0, 100);
                d = rd.Next(0, 100);
                e = rd.Next(1, 100);

                string t = Convert.ToString(rd.Next(7));
                switch (t)
                {
                    case "0":
                        r = a + b - c;
                        str = a + " + " + b + " - " + c + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);

                            i++;
                        }

                        break;
                    case "1":
                        r = a - b + c;
                        str = a + " - " + b + " + " + c + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            i++;
                        }

                        break;
                    case "2":
                        r = a / e - c;
                        str = a + " / " + e + " - " + c + " = " + r;
                        if (a % e == 0 && r >= 0)
                        {
                            Console.WriteLine(str);

                            i++;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "3":
                        r = a / e * c;
                        str = a + " / " + e + " * " + c + " = " + r;
                        if (a % e == 0 && r >= 0)
                        {
                            Console.WriteLine(str);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "4":
                        r = a * b - c + d;
                        str = a + " * " + b + " - " + c + " + " + d + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            i++;
                        }

                        break;
                    case "5":
                        r = a * b - c / e;
                        str = a + " * " + b + " - " + c + " / " + e + " = " + r;
                        if (c % e == 0 && r >= 0)
                        {
                            Console.WriteLine(str);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "6":
                        r = a * b * c + d;
                        str = a + " * " + b + " * " + c + " + " + d + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            i++;
                        }

                        break;
                }
            } while (i < n);
        }
    }
}
