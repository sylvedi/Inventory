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
    //sylvanus Edi
    //this is my own work
    //3/7/2019
    public partial class Form1 : Form
    {
        int idCounter = 0;


        //string orderList = "{0, -40} {1, -30}{2, -30}{3, -40}{4, -50}{5, -60}{6, -80}{7, -100}";

        public Form1()
        {
            InitializeComponent();

            //PhoneInventory input = new PhoneInventory();
            
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

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

       
        
        private void addIterm_Click(object sender, EventArgs e)
            
        {
            try
            {
                string id = idCounter.ToString();
                string Model = sModel.Text;
                string capacity = memory.Text;
                string networks = network.Text;
                string Quantity = sQuantity.Text;
                //string dateTimePick = dataTimePicker.Text;
                string Price = sPrice.Text;
                string suppliers = supplier.Text;
                string buyers = buyer.Text;


                PhoneInventory item = new PhoneInventory(id, Model, capacity, networks, Quantity, Price, suppliers, buyers);

                listOutPut.Items.Add(item.ToString());



                idCounter++;
            }
            catch
            {

            }

            sModel.Text = "";
            memory.Text = "";
            network.Text = "";
            sQuantity.Text = "";
            sPrice.Text = "";
            supplier.Text = "";
            buyer.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //listOutPut.Items.Add(string.Format(orderList, "Model", "Capacity", "Carrier", "Quantity", "Date", "Price", "Supplier", "Buyer"));
        }
    }
}
