using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1Ejecutar_Click(object sender, EventArgs e)
        {
            int n = 0;
            int m = 0;

            n = Convert.ToInt32(FilastextBox1.Text);
            m = Convert.ToInt32(ColumnastextBox2.Text);
              

            //creando la Matriz
            int[,] Matriz1 = new int [n, m];

            Random Numero = new Random();

            for (int fila = 0; fila < n; fila++)
            {
                for (int Col = 0; Col < m; Col++)
                {
                    Matriz1[fila, Col] = Numero.Next(1, 100); 
                }
            }

            for (int fila = 0; fila < n; fila++)
            {
                for (int Col = 0; Col < m; Col++)
                {
                    MessageBox.Show("La posición es: " + fila + "," + Col + " = " + Matriz1[fila, Col].ToString());
                }
            }

        }

        private void button2Limpiar_Click(object sender, EventArgs e)
        {
            FilastextBox1.Clear();
            ColumnastextBox2.Clear();
               
                 
        }
    }
}
