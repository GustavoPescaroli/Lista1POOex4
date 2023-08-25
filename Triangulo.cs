using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOOx4
{
    internal class Triangulo
    {
        private double b;
        private double h;
        private double a;


        public void setb(double l)
        {
            b = l;

        }
        public void seth(double l)
        {
            h = l;

        }
        public double geta()
        {
            return a;
        }
        public double getb()
        {
            return b;
        }

        public double geth()
        {
            return h;
        }

        public void calcular()
        {
           a  = b * h / 2;
        }
    }
}