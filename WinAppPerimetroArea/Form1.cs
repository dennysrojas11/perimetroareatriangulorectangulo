using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppPerimetroArea
{
    public partial class Form1 : Form
    {
        private TextBox[] textboxs;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxBase.Focus();
            labelRespuesta1.Visible = false;
            labelRespuesta2.Visible = false; 
        }

        private void textBoxBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.validar(e);
        }

        private void textBoxHipotenusa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.validar(e);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textboxs = new TextBox[] { textBoxBase, textBoxHipotenusa };
            bool datosCorrectos = !textboxs.Any(X => String.IsNullOrEmpty(X.Text));

            if (datosCorrectos)
            {
                PerimetroArea pa = new PerimetroArea(double.Parse(textBoxBase.Text), double.Parse(textBoxHipotenusa.Text));
                labelRespuesta1.Text = pa.calcularperimetro().ToString();
                labelRespuesta2.Text = pa.calculararea().ToString();
                labelRespuesta1.Visible = true;
                labelRespuesta2.Visible = true;
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
        }
    }
}
