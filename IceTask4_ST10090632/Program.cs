using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask4_ST10090632
{
    internal class Program 
    {
       

        static void Main(string[] args)
        {
            string option;
            Console.WriteLine("Enter either A - Add, D - Divide, M - Multiply, S - Subtract ");
            option= Console.ReadLine().ToUpper();

            CalcFactory fac= new CalcFactory();
            ICalc calc = fac.GetCalc(option);
            calc.Print();
            Console.Read();


        }
    }
    internal class Add : ICalc
    {
        private double ANum1;
        private double ANum2;
        public Add(double ax, double ay)
        {
            this.ANum1 = ax;
            this.ANum2 = ay;

        }
        public double Calc()
        {
            return ANum1 + ANum2;
        }
        public void Print()
        {
            Console.WriteLine($"Addition os {this} is:{Calc()} ");
        }

    }
    internal  class Divide : ICalc
    {
        private double DNum1;
        private double DNum2;
        public Divide(double dx, double dy)
        {
            this.DNum1 = dx;
            this.DNum2 = dy;
        }

        public double Calc()
        {
            return DNum1/ DNum2;
        }
        public void Print()
        {
            Console.WriteLine($"Addition os {this} is:{Calc()} ");
        }
    }

    internal class Multiply : ICalc
    {
        private double MNum1;
        private double MNum2;
        public Multiply(double mx, double my) 
        {
            this.MNum1 = mx;
            this.MNum2 = my;
        }

        public double Calc()
        {
            return MNum1 * MNum2;
        }

        public void Print()
        {
            Console.WriteLine($"Addition os {this} is:{Calc()} ");
        }
    }

    internal class Subtract : ICalc
    {
        private double SNum1;
        private double SNum2;

        public Subtract(double sx, double sy) 
        { 
            this.SNum1 = sx;
            this.SNum2 = sy;

        }
        public double Calc()
        {
            return SNum1 - SNum2;
        }
        public void Print()
        {
            Console.WriteLine($"Addition os {this} is:{Calc()} ");
        }

        
    }

    internal class CalcFactory
    {
        public ICalc GetCalc(string type)
        {
            ICalc obj = null;
            if (type.Equals("A"))
            {
                double ax, ay;
                Console.WriteLine("Enter first number: ");
                ax = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                ay = Convert.ToDouble(Console.ReadLine());

                obj = new Add(ax, ay);
            }
            else if (type.Equals("D"))
            {
                double dx, dy;
                Console.WriteLine("Enter first number: ");
                dx = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                dy = Convert.ToDouble(Console.ReadLine());

                obj = new Divide(dx, dy);
                if (dx ==0 || dy == 0)
                {
                    Console.WriteLine("ZERO IS NOT ALLOWED");
                }
            }
            else if (type.Equals("M"))
            {
                double mx, my;
                Console.WriteLine("Enter first number: ");
                mx = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                my = Convert.ToDouble(Console.ReadLine());

                obj = new Multiply(mx, my);
                if (mx == 0 || my == 0)
                {
                    Console.WriteLine("ZERO IS NOT ALLOWED");
                }
            }

            else if (type.Equals("S"))
            {
                double sx, sy;
                Console.WriteLine("Enter first number: ");
                sx = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                sy = Convert.ToDouble(Console.ReadLine());

                obj = new Subtract(sx, sy);
            }

            return obj;
        }
    }
}
