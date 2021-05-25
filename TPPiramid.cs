using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Лабораторна
{
    class TPPiramid: TPTriangle
    {
        private double L1 { get; set; }
        private double L2 { get; set; }

        public TPPiramid(string s1, string s2)
        {
            if (s1 == "")
            {
                L1 = 1;
            }
            else L1 = Convert.ToDouble(s1);

            if (s2 == "")
            {
                L2 = 1;
            }
            else L2 = Convert.ToDouble(s2);
        }
        public double[] Vpiramid()
        {
            double[] arr = new double[2];
            arr[0] = (L1 * 3 / 2) * L1;
            arr[1] = (L1 * 3 / 2) * L2;

            return arr;
        }
        public double[] Spiramid()
        {
            double[] arr = new double[2];
            arr[0] = ((L1 * 3 / 2) * 2) + ((L1 * 2) * 3);
            arr[1] = ((L2 * 3 / 2) * 2) + ((L2 * 2) * 3);

            return arr;
        }

        public double[] Ppiramid()
        {
            double[] arr = new double[2];
            arr[0] = L1 * 9;
            arr[1] = L2 * 9;

            return arr;
        }
    }
}
