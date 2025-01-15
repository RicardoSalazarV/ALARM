using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace no_me_truene
{
    public partial class Form1 : Form
    {
        
        public Form1()

        {
            InitializeComponent();
        }
         
        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text+"Agendo su cita con fecha"+dateTimePicker1.Value.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void cOMPUTADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SELECCIONO COMOUTADORA");
            
           
        }

        private void sMARTPHONEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SELECCION  SMARTHPHONE");
        }

        private void tABLETToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SELECCION  TABLET");
        }

        private void oTROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SELECCION  OTRO");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar2.Value < progressBar2.Maximum)
            {
                progressBar2.Value += 20; // Incrementar el valor correctamente
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("1 2 3 tu tiempo se acabó");
            }
        }
    }
    
}
