using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cronómetro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int contador;
        private void Button1_Click(object sender, EventArgs e)
        {
            
            contador = 10;
            lblcontador.Text = contador.ToString();
            tiempo.Enabled = true;

        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            contador = contador - 1;
            lblcontador.Text = contador.ToString();

            if(contador==0)
            {
                tiempo.Enabled = false;
                MessageBox.Show("conteo completo");
            }
        }
    }
}
