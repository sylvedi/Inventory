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
        private List<PhoneInventory> itemsList = new List<PhoneInventory>();

        

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
                //string dateTimePick = dataTimePicker.Value.Text;
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
            

           
        }

        private void newFile_Click(object sender, EventArgs e)
        {
            try
            {

                int s = listOutPut.SelectedIndex;

                //listOutPut.Items.RemoveAt(s);
                //listOutPut.Items.Insert(s, sModel.Text, memory.Text);
                
                sModel.Text = itemsList[s].model;
                memory.Text = itemsList[s].capacity;
                network.Text = itemsList[s].networks;
                sQuantity.Text = itemsList[s].quantity;
                sPrice.Text = itemsList[s].price;
                supplier.Text = itemsList[s].suppliers;
                buyer.Text = itemsList[s].buyers;

            }
            catch
            {

            }

        }

        private void listOutPut_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void deleteFile_Click(object sender, EventArgs e)
        {
            listOutPut.Items.RemoveAt(listOutPut.SelectedIndex);
        }

        private void sModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
