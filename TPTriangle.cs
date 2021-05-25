using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Лабораторна
{
    class TPTriangle
    {
        private double L1;
        public double l1
        {
            get { return L1; }
            set
            {
                if (value >= 0) L1 = value;
            }
        }

        private double L2;
        public double l2
        {
            get { return L2; }
            set
            {
                if (value > 0) L2 = value;
            }
        }

        public TPTriangle()
        {
            L1 = 1;
            L2 = 1;
        }

        public TPTriangle(TPTriangle square)
        {
            L1 = 1;
            L2 = 1;
        }
        public TPTriangle(double l1, double l2)
        {
            L1 = l1;
            L2 = l2;
        }
        public TPTriangle(double s) : this(s, 0)
        {
        }
        public TPTriangle(string l1, string l2)
        {
            if (l1 == "")
            {
                L1 = 0;
            }
            else L1 = Convert.ToDouble(l1);

            if (l2 == "")
            {
                L2 = 0;
            }
            else L2 = Convert.ToDouble(l2);
        }

        public double[] S()
        {
            double[] arr = new double[2];
            arr[0] = L1 * 3;
            arr[1] = L2 * 3;

            return arr;
        }

        public double[] P()
        {
            double[] arr = new double[2];
            double p1 = L1 * 3 / 2;
            double p2 = L1 * 3 / 2;
            arr[0] = Math.Sqrt(p1 * Math.Pow(p1 * L1, 3));
            arr[1] = Math.Sqrt(p2 * Math.Pow(p2 * L2, 3));

            return arr;
        }

        public double comprasion()
        {
            double[] arr = new double[2];
            arr = S();
            double result = Math.Abs(arr[0] - arr[1]);

            return result;
        }

        public static TPTriangle operator +(TPTriangle fr, TPTriangle sc)
        {
            return new TPTriangle(fr.L1 + sc.L2);
        }
        public static TPTriangle operator -(TPTriangle fr, TPTriangle sc)
        {
            return new TPTriangle(fr.L1 - sc.L2);
        }
        public static TPTriangle operator *(TPTriangle fr, TPTriangle sc)
        {
            return new TPTriangle(fr.L1 * sc.L2);
        }
    }
}
   
