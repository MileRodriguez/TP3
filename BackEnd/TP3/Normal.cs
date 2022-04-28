using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1SIM.BackEnd.TP3
{
    class Normal : Dist
    {
        private double media;
        private double[] numeritos;
        private double varianza;

        /*double[][] tablaNormal = {[0.5000, 0.5040, 0.5080, 0.5120, 0.5160, 0.5160, 0.5239, 0.5279, 0.5319, 0.5359],
        [0.5398, 0.5438, 0.5478, 0.5517, 0.5557, 0.5596, 0.5636, 0.5675, 0.5714, 0.5753],
        [0.5793, 0.5832, 0.5871, 0.5910, 0.5948, 0.5987, 0.6026, 0.6064, 0.6103, 0.6141],
        [0.6179, 0.6217, 0.6255, 0.6293, 0.6331, 0.6368, 0.6406, 0.6443, 0.6480, 0.6517],
        [0.6554, 0.6591, 0.6628, 0.6664, 0.6700, 0.6736, 0.6772, 0.6808, 0.6844, 0.6879],
        [0.6915, 0.6949, 0.6984, 0.7019, 0.7054, 0.7088, 0.7122, 0.7156, 0.7190, 0.7224],
        [0.7257, 0.7290, 0.7323, 0.7356, 0.7389, 0.7421, 0.7453, 0.7485, 0.7517, 0.7549],
        [0.7580, 0.7611, 0.7642, 0.7673, 0.7703, 0.7733, 0.7763, 0.7793, 0.7823, 0.7852],
        [0.7881, 0.7910, 0.7930, 0.7967, 0.7995, 0.8023, 0.8051, 0.8078, 0.8105, 0.8132],
        [0.8159, 0.8185, 0.8212, 0.8238, 0.8263, 0.8289, 0.8314, 0.8339, 0.8364, 0.8389],
        [0.8413, 0.8437, 0.8461, 0.8484, 0.8508, 0.8531, 0.8554, 0.8576, 0.8599, 0.8621],
        [0.8643, 0.8665, 0.8686, 0.8707, 0.8728, 0.8749, 0.8769, 0.8789, 0.8809, 0.8829],
        [0.8849, 0.8868, 0.8887, 0.8906, 0.8925, 0.8943, 0.8961, 0.8979, 0.8997, 0.9014],
        [0.9031, 0.9049, 0.9065, 0.9082, 0.9098, 0.9114, 0.9130, 0.9146, 0.9162, 0.9177],
        [0.9192, 0.9207, 0.9221, 0.9236, 0.9250, 0.9264, 0.9278, 0.9292, 0.9305, 0.9318],
        [0.9331, 0.9344, 0.9357, 0.9369, 0.9382, 0.9394, 0.9406, 0.9417, 0.9429, 0.9440],
        [0.9452, 0.9463, 0.9473, 0.9484, 0.9494, 0.9505, 0.9515, 0.9525, 0.9535, 0.9544],
        [0.9554, 0.9563, 0.9572, 0.9581, 0.9590, 0.9599, 0.9607, 0.9616, 0.9624, 0.9632],
        [0.9640, 0.9648, 0.9656, 0.9663, 0.9671, 0.9678, 0.9685, 0.9692, 0.9699, 0.9706],
        [0.9712, 0.9719, 0.9725, 0.9731, 0.9738, 0.9744, 0.9750, 0.9755, 0.9761, 0.9767],
        [0.9772, 0.9777, 0.9783, 0.9788, 0.9793, 0.9798, 0.9803, 0.9807, 0.9812, 0.9816],
        [0.9821, 0.9825, 0.9829, 0.9834, 0.9838, 0.9842, 0.9846, 0.9849, 0.9853, 0.9857],
        [0.9860, 0.9864, 0.9867, 0.9871, 0.9874, 0.9877, 0.9880, 0.9883, 0.9886, 0.9889],
        [0.9892, 0.9895, 0.9898, 0.9900, 0.9903, 0.9906, 0.9908, 0.9911, 0.9913, 0.9915],
        [0.9918, 0.9920, 0.9922, 0.9924, 0.9926, 0.9928, 0.9930, 0.9932, 0.9934, 0.9936],
        [0.9937, 0.9939, 0.9941, 0.9942, 0.9944, 0.9946, 0.9947, 0.9949, 0.9950, 0.9952],
        [0.9953, 0.9954, 0.9956, 0.9957, 0.9958, 0.9959, 0.9960, 0.9962, 0.9963, 0.9964],
        [0.9965, 0.9966, 0.9967, 0.9968, 0.9969, 0.9970, 0.9971, 0.9971, 0.9972, 0.9973],
        [0.9974, 0.9975, 0.9975, 0.9976, 0.9977, 0.9978, 0.9978, 0.9979, 0.9980, 0.9980],
        [0.9981, 0.9981, 0.9982, 0.9983, 0.9983, 0.9984, 0.9984, 0.9985, 0.9985, 0.9986],
        [0.9986, 0.9986, 0.9987, 0.9987, 0.9988, 0.9988, 0.9988, 0.9989, 0.9989, 0.9989],
        [0.9990, 0.9991, 0.9991, 0.9991, 0.9992, 0.9992, 0.9992, 0.9992, 0.9993, 0.9993],
        [0.9993, 0.9993, 0.9994, 0.9994, 0.9994, 0.9994, 0.9994, 0.9995, 0.9995, 0.9995],
        [0.9995, 0.9995, 0.9995, 0.9995, 0.9995, 0.9995, 0.9996, 0.9996, 0.9996, 0.9996],
        [0.9996, 0.9996, 0.9996, 0.9996, 0.9997, 0.9997, 0.9997, 0.9997, 0.9997, 0.9997],
        [0.9997, 0.9997, 0.9997, 0.9997, 0.9997, 0.9998, 0.9998, 0.9998, 0.9998, 0.9998],
        [0.9998, 0.9998, 0.9998, 0.9998, 0.9998, 0.9998, 0.9998, 0.9998, 0.9998, 0.9998],
        [0.9998, 0.9998, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999],
        [0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999],
        [0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999, 0.9999]};*/

        public void set(double varianza, double media, double[] numeritos)
        {
            this.varianza = varianza;
            this.media = media;
            this.numeritos = numeritos;
        }

        public double[] getNumeritos()
        {
            return this.numeritos;
        }

        public override void chiCuadrado(int muestra, int cantidadIntervalos, DataGridView tabla)
        {

            double min = numeritos.Min();
            double max = numeritos.Max();

            double paso = ((max - min) / cantidadIntervalos);
            double fe = 0;
            double fo = 0;
            double limInf = 0;
            double limSup = 0;
            double chi = 0;
            double chiA = 0;


            for (int i = 0; i < cantidadIntervalos; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                tabla.ColumnCount = 7;

                tabla.Columns[0].Name = "Iteracion";
                tabla.Columns[1].Name = "Limite Inferior";
                tabla.Columns[2].Name = "Limite Superior";
                tabla.Columns[3].Name = "Frecuencia Observada";
                tabla.Columns[4].Name = "Frecuencia Esperada";
                tabla.Columns[5].Name = "Chi";
                tabla.Columns[6].Name = "Chi Acumulado";

                limInf = min + (paso * i);
                limSup = min + (paso * (i + 1));
                fo = numeritos.Count(numerito => limInf <= numerito && numerito < limSup);
                //fe = calcularFe(media, varianza, limSup, limInf, numeritos.Length);
                chi = Math.Pow((fe - fo), 2) / fe;
                chiA = chiA + chi;

                Object[] cells = { i, limInf, limSup, fo, fe, chi, chiA };

                row.CreateCells(tabla, cells);
                tabla.Rows.Add(row);

            }

            estadisticoPrueba = chiA;
        }


        /*private double calcularFe(double media, double varianza, double limSup, double limInf, int cant)
        {
            double aux1 = ((limSup - media) / varianza);
            double fila1 = Math.Abs(aux1 * 10);
            double columna1 = (Math.Abs(aux1 * 10) - Math.Abs(aux1*10))*10;

            double v1, v2;
            if (aux1 < 0)
            {
                if (fila1 > 40 || columna1 > 9)
                {
                    v1 = 0.0001;
                }
                else
                {
                    v1 = 1 - tablaNormal[fila1][columna1];
               }
            }
            else
            {
                if (fila1 > 40 || columna1 > 9)
                {
                    v1 = 0.9999;
                }
                else
                {
                    v1 = tablaNormal[fila1][columna1];
               }
            }

            double aux2 = ((limInf - media) / varianza);
            double fila2 = Math.Abs(aux2 * 10);
            double columna2 = (Math.Abs(aux2 * 10) - Math.Abs(aux2 * 10)) * 10;

            if (aux2 < 0)
            {
                if (fila2 > 40 || columna2 > 9)
                {
                    v2 = 0.0001;
                }
                else
                {
                    v2 = 1 - tablaNormal[fila1][columna1];
                }
            }
            else
            {
                if (fila1 > 40 || columna1 > 9)
                {
                    v2 = 0.9999;
                }
                else
                {
                    v2 = tablaNormal[fila1][columna1];
                }
            }

            double valorFinal = v1 - v2;
            return valorFinal * cant;
        }*/
    }
}
