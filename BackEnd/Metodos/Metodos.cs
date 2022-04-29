using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1SIM.BackEnd.Metodos
{
    internal class Metodos
    {
        public double[] ExpNegativa(double[] nums, double avg)
        {

            double[] updated_nums = new double[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                updated_nums[i] = Math.Round(-avg * Math.Log(1 - nums[i]), 4);

            }

            return updated_nums;
        }

        public double[] Normal_conv(double[] nums, double avg, double var)
        {
            double[] updated_nums = new double[nums.Length/12];
            int count = 0;
            double sum = 0;
            int ciclo = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                count++;
                if (count == 12)
                {
                    updated_nums[ciclo] = Math.Round((sum - 6) * Math.Sqrt(var) + avg, 4);
                    count = 0;
                    sum = 0;
                    ciclo++;
                }
            }

            return updated_nums;
        }

        public double[] Normal_box(double[] nums, double avg, double var)
        {
            double[] updated_nums = new double[nums.Length/2];
            bool flag_cos = true;
            if (flag_cos)
            for (int i = 2; i < nums.Length+2; i+=2)
                {
                    if (flag_cos)
                    {
                        updated_nums[(i / 2) - 1] = Math.Round(Math.Sqrt(-2 * Math.Log(nums[i - 2])) * Math.Cos(2 * Math.PI * nums[i - 1]) * Math.Sqrt(var) + avg, 4);
                        flag_cos = false;
                    }
                    else
                    {
                        updated_nums[(i / 2) - 1] = Math.Round(Math.Sqrt(-2 * Math.Log(nums[i - 2])) * Math.Sin(2 * Math.PI * nums[i - 1]) * Math.Sqrt(var) + avg, 4);
                        flag_cos = true;
                    }
                }
            return updated_nums;
        }

        public int[] Poisson(double[] nums, double avg)
        {
            int[] updated_nums = new int[nums.Length];
            double p = 1;
            int x = -1;
            double a = Math.Pow(Math.E, -avg);
            int i = 0;
            int count = 0;
            do
            {
                p *= nums[i++];
                x++;

                if(p <= a)
                {
                    updated_nums[count++] = x;
                    x = -1;
                    p = 1;
                }

                if(i == nums.Length-1 && count != nums.Length-1)
                {
                    nums = combustible(nums.Length);
                    i = 0;
                }


            }
            while (count < updated_nums.Length);
            return updated_nums;
        }

        public double[] Uniforme(double[] nums, int a, int b)
        {
            double[] updated_nums = new double[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                updated_nums[i] = Math.Round(a + nums[i] * (b - a), 4);
            }
            return updated_nums;
        }

        private double[] combustible(int N)
        {
            Random rnd = new Random();
            double[] nros = new double[N];
            for (int j = 0; j < N; j++)
            {
                nros[j] = (rnd.NextDouble());
            }

            return nros;
        }
    }
}
