using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaSimulacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int f1 = dataGridView2.Rows.Add();
            int f2 = dataGridView2.Rows.Add();
            int f3 = dataGridView2.Rows.Add();
            int f4 = dataGridView2.Rows.Add();
            int f5 = dataGridView2.Rows.Add();
            int f6 = dataGridView2.Rows.Add();
            int f7 = dataGridView2.Rows.Add();
            int f8 = dataGridView2.Rows.Add();
            int f9 = dataGridView2.Rows.Add();
            int f10 = dataGridView2.Rows.Add();
            int f11 = dataGridView2.Rows.Add();

            double suma1 = 0;
            double suma2 = 0;
            double suma3 = 0;
            double suma4 = 0;
            double suma5 = 0;
            double suma6 = 0;
            double suma7 = 0;
            double suma8 = 0;
            double suma9 = 0;
            double suma10 = 0;

            double promedio1 = 0;
            double promedio2 = 0;
            double promedio3 = 0;
            double promedio4 = 0;
            double promedio5 = 0;
            double promedio6 = 0;
            double promedio7 = 0;
            double promedio8 = 0;
            double promedio9 = 0;
            double promedio10 = 0;

            double movil1 = 0;
            double movil2 = 0;
            double movil3 = 0;
            double movil4 = 0;
            double movil5 = 0;
            double movil6 = 0;
            double movil7 = 0;
            double movil8 = 0;
            double movil9 = 0;
            double movil10 = 0;
            double movil11 = 0;

 
            foreach (DataGridViewRow filas in dataGridView1.Rows)
            {
                suma1 = suma1 + Convert.ToDouble(filas.Cells["Column1"].Value);
                suma2 = suma2 + Convert.ToDouble(filas.Cells["Column2"].Value);
                suma3 = suma3 + Convert.ToDouble(filas.Cells["Column3"].Value);
                suma4 = suma4 + Convert.ToDouble(filas.Cells["Column4"].Value);
                suma5 = suma5 + Convert.ToDouble(filas.Cells["Column5"].Value);
                suma6 = suma6 + Convert.ToDouble(filas.Cells["Column6"].Value);
                suma7 = suma7 + Convert.ToDouble(filas.Cells["Column7"].Value);
                suma8 = suma8 + Convert.ToDouble(filas.Cells["Column8"].Value);
                suma9 = suma9 + Convert.ToDouble(filas.Cells["Column9"].Value);
                suma10 = suma10 + Convert.ToDouble(filas.Cells["Column10"].Value);
            }

            promedio1 = suma1 / 10;
            promedio2 = suma2 / 10;
            promedio3 = suma3 / 10;
            promedio4 = suma4 / 10;
            promedio5 = suma5 / 10;
            promedio6 = suma6 / 10;
            promedio7 = suma7 / 10;
            promedio8 = suma8 / 10;
            promedio9 = suma9 / 10;
            promedio10 = suma10 / 10;

            movil1 = promedio1 / 1;
            movil2 = (promedio2) / 1;
            movil3 = (promedio1 + promedio2) / 2;
            movil4 = (promedio1 + promedio2 + promedio3) / 3;
            movil5 = (promedio1 + promedio2 + promedio3 + promedio4) / 4;
            movil6 = (promedio1 + promedio2 + promedio3 + promedio4 + promedio5) / 5;
            movil7 = (promedio1 + promedio2 + promedio3 + promedio4 + promedio5 + promedio6) / 6;
            movil8 = (promedio1 + promedio2 + promedio3 + promedio4 + promedio5 + promedio6 + promedio7) / 7;
            movil9 = (promedio1 + promedio2 + promedio3 + promedio4 + promedio5 + promedio6 + promedio7 + promedio8) / 8;
            movil10 = (promedio1 + promedio2 + promedio3 + promedio4 + promedio5 + promedio6 + promedio7 + promedio8 + promedio9) / 9;
            movil11 = (promedio1 + promedio2 + promedio3 + promedio4 + promedio5 + promedio6 + promedio7 + promedio8 + promedio9 + promedio10) / 10;

            txtSuma1.Text = Convert.ToString(suma1);
            txtSuma2.Text = Convert.ToString(suma2);
            txtSuma3.Text = Convert.ToString(suma3);
            txtSuma4.Text = Convert.ToString(suma4);
            txtSuma5.Text = Convert.ToString(suma5);
            txtSuma6.Text = Convert.ToString(suma6);
            txtSuma7.Text = Convert.ToString(suma7);
            txtSuma8.Text = Convert.ToString(suma8);
            txtSuma9.Text = Convert.ToString(suma9);
            txtSuma10.Text = Convert.ToString(suma10);

            txtPromedio1.Text = Convert.ToString(promedio1);
            txtPromedio2.Text = Convert.ToString(promedio2);
            txtPromedio3.Text = Convert.ToString(promedio3);
            txtPromedio4.Text = Convert.ToString(promedio4);
            txtPromedio5.Text = Convert.ToString(promedio5);
            txtPromedio6.Text = Convert.ToString(promedio6);
            txtPromedio7.Text = Convert.ToString(promedio7);
            txtPromedio8.Text = Convert.ToString(promedio8);
            txtPromedio9.Text = Convert.ToString(promedio9);
            txtPromedio10.Text = Convert.ToString(promedio10);

            dataGridView2.Rows[f1].Cells[0].Value = 1;
            dataGridView2.Rows[f2].Cells[0].Value = 2;
            dataGridView2.Rows[f3].Cells[0].Value = 3;
            dataGridView2.Rows[f4].Cells[0].Value = 4;
            dataGridView2.Rows[f5].Cells[0].Value = 5;
            dataGridView2.Rows[f6].Cells[0].Value = 6;
            dataGridView2.Rows[f7].Cells[0].Value = 7;
            dataGridView2.Rows[f8].Cells[0].Value = 8;
            dataGridView2.Rows[f9].Cells[0].Value = 9;
            dataGridView2.Rows[f10].Cells[0].Value = 10;
            dataGridView2.Rows[f11].Cells[0].Value = 11;

            dataGridView2.Rows[f1].Cells[1].Value = promedio1;
            dataGridView2.Rows[f2].Cells[1].Value = promedio2;
            dataGridView2.Rows[f3].Cells[1].Value = promedio3;
            dataGridView2.Rows[f4].Cells[1].Value = promedio4;
            dataGridView2.Rows[f5].Cells[1].Value = promedio5;
            dataGridView2.Rows[f6].Cells[1].Value = promedio6;
            dataGridView2.Rows[f7].Cells[1].Value = promedio7;
            dataGridView2.Rows[f8].Cells[1].Value = promedio8;
            dataGridView2.Rows[f9].Cells[1].Value = promedio9;
            dataGridView2.Rows[f10].Cells[1].Value = promedio10;

            dataGridView2.Rows[f1].Cells[2].Value = movil1;
            dataGridView2.Rows[f2].Cells[2].Value = movil2;
            dataGridView2.Rows[f3].Cells[2].Value = movil3;
            dataGridView2.Rows[f4].Cells[2].Value = movil4;
            dataGridView2.Rows[f5].Cells[2].Value = movil5;
            dataGridView2.Rows[f6].Cells[2].Value = movil6;
            dataGridView2.Rows[f7].Cells[2].Value = movil7;
            dataGridView2.Rows[f8].Cells[2].Value = movil8;
            dataGridView2.Rows[f9].Cells[2].Value = movil9;
            dataGridView2.Rows[f10].Cells[2].Value = movil10;
            dataGridView2.Rows[f11].Cells[2].Value = movil11;





        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
