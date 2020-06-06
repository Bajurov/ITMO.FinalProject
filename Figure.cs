using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NewProject
{
    class Figure
    {
        // 0 - Cirle
        // 1 - Triangle
        // 2 - Square
        int type = -1;
        double x, y, a, b;
        // a - base
        // b - height
        // x, y - coordinates


        public void init(int type, double a, double b, double x, double y)
        {
            this.type = type;
            this.a = a;
            this.b = b;
            this.x = x;
            this.y = y;
        }

        public double getR()
        {
            return a;
        }

        public double getP()
        {
            double p = 0;
            switch (type)
            {
                case 0:
                    p = 2 * Math.PI * a;
                    break;
                case 1:
                    p = (2 * b) + a;
                    break;
                case 2:
                    p = (2 * a) + (2 * b);
                    break;

                default:
                    Console.WriteLine("Unknown figure!");
                    break;
            }
            return p;
        }

        public double getS()
        {
            double s = 0;
            switch (type)
            {
                case 0:
                    s = (Math.PI * (a * a));
                    break;
                case 1:
                    s = (a / 2) * Math.Sqrt((b * b) - (a * a) / 4);
                    break;
                case 2:
                    s = a * b;
                    break;
                default:
                    Console.WriteLine("Unknown figure!");
                    break;
            }
            return s;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        public void print()
        {
            if (type == 0)
            {
                Console.WriteLine("Circle");
            }
            else if (type == 1)
            {
                Console.WriteLine("Triangle");
            }
            else if (type == 2)
            {
                Console.WriteLine("Square");
            }
            else
            {
                Console.WriteLine("Unknown figure!");
                return;
            }

            Console.WriteLine("r = " + a);
            Console.WriteLine("P = " + getP());
            Console.WriteLine("S = " + getS());
            Console.WriteLine("Centre is in [" + getX() + ":" + getY() + "]");
        }
    }
}
