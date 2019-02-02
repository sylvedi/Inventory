using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Save file and exit", "Inventory System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
