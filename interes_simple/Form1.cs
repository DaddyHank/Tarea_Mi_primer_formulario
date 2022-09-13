using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interes_simple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string op = comboBoxOp.Text;
            string capital = txtCapital.Text;
            string tiempo = txtTiempo.Text;
            string interes = txtInteres.Text;
            string calculo;
            if (capital == "" || tiempo == "" || interes == "")
            {
                MessageBox.Show("Llene los espacios anteriores para poder continuar.");
            }
            else
            {
                switch (op)
                {
                    case "Anual":
                        calculo = Convert.ToString(double.Parse(capital) * double.Parse(tiempo) / 100 * double.Parse(interes));
                        MessageBox.Show("El interés es de: " + calculo);
                        break;
                    case "Mensual":
                        calculo = Convert.ToString(double.Parse(capital) * double.Parse(tiempo) / 100 * double.Parse(interes) / 12);
                        MessageBox.Show("El interés es de: " + calculo);
                        break;
                    case "Diario":
                        calculo = Convert.ToString(double.Parse(capital) * double.Parse(tiempo) / 100 * double.Parse(interes) / 360);
                        MessageBox.Show("El interés es de: " + calculo);
                        break;
                }
            }
        }
    }
}