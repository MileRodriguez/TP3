using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1SIM.BackEnd.Congruencial
{
    class metodoCongruencial
    {

        public DataTable metodoCong(int n, double semilla, int k, int g, int c)
        {
            DataTable nrosRnd = createTable();
            int d = 0;
            metodoCongruencialLineal(n, semilla, k, g, c, nrosRnd, d);

            return nrosRnd;
        }

        public DataTable metodoCongruencialLineal(int n, double semilla, int k, int g, int c, DataTable nrosRnd, int d)
        {
            d++;

            double m = Math.Pow(2, g);
            int a = 1 + (4 * k);
            double fe = (a * semilla) + c;
            double semilla_creada = fe % m;
            double numeroRnd = semilla_creada / (m-1);

            DataRow row;
            row = nrosRnd.NewRow();
            row[0] = d;
            row[1] = fe;
            row[2] = semilla_creada;
            row[3] = numeroRnd;
            nrosRnd.Rows.Add(row);

            if (n == d) { metodoCongruencialLineal(n-1, semilla_creada, k, g, c, nrosRnd, d); }

            return nrosRnd;

        }

        public void metodoCongruencialMultiplicativo(int n, double semilla, int k, int g, DataTable nrosRnd)
        {
            metodoCongruencialLineal(n, semilla, k, g, 0, nrosRnd, 0);
        }


        public DataTable createTable()
        {
            DataTable numerosRnd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "Iteracion";
            numerosRnd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "a*Xi+c";
            numerosRnd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Xi+1";
            numerosRnd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "(Xi+1)/(m-1)";
            numerosRnd.Columns.Add(column);

            return numerosRnd;
        }

    }
}
