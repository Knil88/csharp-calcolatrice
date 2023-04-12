using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharp_calcolatrice
{
    public static class CalcoliHelper
    {
        public static int Somma(int a, int b) => a + b;
        public static double Somma(double a, double b) => a + b;
        public static int Differenza(int a, int b) => a - b;
        public static double Differenza(double a, double b) => a - b;
        public static int Moltiplicazione(int a, int b) => a * b;
        public static double Moltiplicazione(double a, double b) => a * b;
        public static int ValoreAssoluto(int n) => Math.Abs(n);
        public static double ValoreAssoluto(double n) => Math.Abs(n);
        public static int Minimo(int a, int b) => Math.Min(a, b);
        public static double Minimo(double a, double b) => Math.Min(a, b);
        public static int Massimo(int a, int b) => Math.Max(a, b);
        public static double Massimo(double a, double b) => Math.Max(a, b);



    }
}
