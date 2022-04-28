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
                updated_nums[i] = -avg * Math.Log(1 - nums[i]);

            }

            return updated_nums;
        }

        public double[] Normal_conv(double[] nums, double avg, double sd)
        {
            double[] updated_nums = new double[nums.Length];
            int count = 0;
            double sum = 0;
            int ciclo = 0;


            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                count++;
                if (count == 12)
                {
                    updated_nums[ciclo] = (sum - 6) * sd + avg;
                    count = 0;
                    sum = 0;
                    ciclo++;
                }
            }

            return updated_nums;
        }

        public double[] Normal_box(double[] nums, double avg, double sd)
        {
            double[] updated_nums = new double[nums.Length];
            bool flag_cos = true;

            for (int i = 1; i < nums.Length; i += 2)
            {
                if (flag_cos)
                {
                    updated_nums[i - 1] = (Math.Sqrt(-2 * Math.Log(nums[i - 1])) * Math.Cos(2 * Math.PI * nums[i])) * sd + avg;
                    flag_cos = false;
                }
                else
                {
                    updated_nums[i - 1] = (Math.Sqrt(-2 * Math.Log(nums[i - 1])) * Math.Sin(2 * Math.PI * nums[i])) * sd + avg;
                    flag_cos = true;
                }

                if (nums.Length - 1f / (i + 2f) < 1)
                {
                    break;
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
            }
            while (i < nums.Length);
            return updated_nums;
        }

        public double[] Uniforme(double[] nums, int a, int b)
        {
            double[] updated_nums = new double[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                updated_nums[i] = a + nums[i] * (b - a);
            }
            return updated_nums;
        }
    }
}
