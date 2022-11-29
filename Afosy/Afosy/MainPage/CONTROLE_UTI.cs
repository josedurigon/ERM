using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Afosy
{
    public partial class CONTROLE_UTI : Form
    {
        public CONTROLE_UTI()
        {
            InitializeComponent();
        }

        private void DataGrid_controle_internacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eXPORTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void DataAlta_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                DataAlta.Enabled = false;
            }
            else
            {
                DataAlta.Enabled = true;
               
            }
        }
    }
}
