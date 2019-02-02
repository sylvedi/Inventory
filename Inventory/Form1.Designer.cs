namespace Inventory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.addIterm = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.sQuantity = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.iphone = new System.Windows.Forms.RadioButton();
            this.samsung = new System.Windows.Forms.RadioButton();
            this.blackberry = new System.Windows.Forms.RadioButton();
            this.motorolla = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.network = new System.Windows.Forms.ComboBox();
            this.memory = new System.Windows.Forms.ComboBox();
            this.sModel = new System.Windows.Forms.ComboBox();
            this.supplier = new System.Windows.Forms.ComboBox();
            this.sPrice = new System.Windows.Forms.ComboBox();
            this.buyer = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.newFile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(40, 666);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2284, 676);
            this.panel1.TabIndex = 0;
            // 
            // addIterm
            // 
            this.addIterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIterm.Location = new System.Drawing.Point(1179, 579);
            this.addIterm.Name = "addIterm";
            this.addIterm.Size = new System.Drawing.Size(196, 67);
            this.addIterm.TabIndex = 1;
            this.addIterm.Text = "Add Iterm";
            this.addIterm.UseVisualStyleBackColor = true;
            // 
            // deleteFile
            // 
            this.deleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFile.Location = new System.Drawing.Point(2128, 579);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(196, 67);
            this.deleteFile.TabIndex = 2;
            this.deleteFile.Text = "Delete Iterm";
            this.deleteFile.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(27, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(2232, 564);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(1179, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1145, 502);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buyer);
            this.groupBox1.Controls.Add(this.sPrice);
            this.groupBox1.Controls.Add(this.supplier);
            this.groupBox1.Controls.Add(this.sModel);
            this.groupBox1.Controls.Add(this.memory);
            this.groupBox1.Controls.Add(this.network);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.motorolla);
            this.groupBox1.Controls.Add(this.blackberry);
            this.groupBox1.Controls.Add(this.samsung);
            this.groupBox1.Controls.Add(this.iphone);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.sQuantity);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1103, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(6, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(1091, 424);
            this.listBox2.TabIndex = 0;
            // 
            // sQuantity
            // 
            this.sQuantity.Location = new System.Drawing.Point(127, 365);
            this.sQuantity.Name = "sQuantity";
            this.sQuantity.Size = new System.Drawing.Size(175, 26);
            this.sQuantity.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(820, 81);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 26);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // iphone
            // 
            this.iphone.AutoSize = true;
            this.iphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphone.Location = new System.Drawing.Point(487, 83);
            this.iphone.Name = "iphone";
            this.iphone.Size = new System.Drawing.Size(121, 26);
            this.iphone.TabIndex = 10;
            this.iphone.TabStop = true;
            this.iphone.Text = "IPhone    ";
            this.iphone.UseVisualStyleBackColor = true;
            // 
            // samsung
            // 
            this.samsung.AutoSize = true;
            this.samsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samsung.Location = new System.Drawing.Point(487, 169);
            this.samsung.Name = "samsung";
            this.samsung.Size = new System.Drawing.Size(129, 26);
            this.samsung.TabIndex = 11;
            this.samsung.TabStop = true;
            this.samsung.Text = "Samsung  ";
            this.samsung.UseVisualStyleBackColor = true;
            // 
            // blackberry
            // 
            this.blackberry.AutoSize = true;
            this.blackberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackberry.Location = new System.Drawing.Point(487, 261);
            this.blackberry.Name = "blackberry";
            this.blackberry.Size = new System.Drawing.Size(132, 26);
            this.blackberry.TabIndex = 12;
            this.blackberry.TabStop = true;
            this.blackberry.Text = "BlackBerry";
            this.blackberry.UseVisualStyleBackColor = true;
            // 
            // motorolla
            // 
            this.motorolla.AutoSize = true;
            this.motorolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorolla.Location = new System.Drawing.Point(487, 364);
            this.motorolla.Name = "motorolla";
            this.motorolla.Size = new System.Drawing.Size(108, 24);
            this.motorolla.TabIndex = 11;
            this.motorolla.TabStop = true;
            this.motorolla.Text = "Motorolla";
            this.motorolla.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Carrier:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quantity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(664, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(653, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Supplier:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(664, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 19;
            this.label8.Text = "Buyer:";
            // 
            // network
            // 
            this.network.FormattingEnabled = true;
            this.network.Location = new System.Drawing.Point(127, 260);
            this.network.Name = "network";
            this.network.Size = new System.Drawing.Size(331, 28);
            this.network.TabIndex = 5;
            this.network.Text = "Select Network";
            // 
            // memory
            // 
            this.memory.FormattingEnabled = true;
            this.memory.Location = new System.Drawing.Point(127, 169);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(331, 28);
            this.memory.TabIndex = 20;
            this.memory.Text = "Select Memory Storage";
            // 
            // sModel
            // 
            this.sModel.FormattingEnabled = true;
            this.sModel.Location = new System.Drawing.Point(127, 81);
            this.sModel.Name = "sModel";
            this.sModel.Size = new System.Drawing.Size(331, 28);
            this.sModel.TabIndex = 21;
            this.sModel.Text = "SelectModel ";
            // 
            // supplier
            // 
            this.supplier.FormattingEnabled = true;
            this.supplier.Location = new System.Drawing.Point(745, 260);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(331, 28);
            this.supplier.TabIndex = 22;
            this.supplier.Text = "Select Suppliers";
            // 
            // sPrice
            // 
            this.sPrice.FormattingEnabled = true;
            this.sPrice.Location = new System.Drawing.Point(745, 168);
            this.sPrice.Name = "sPrice";
            this.sPrice.Size = new System.Drawing.Size(331, 28);
            this.sPrice.TabIndex = 23;
            this.sPrice.Text = "Select price";
            // 
            // buyer
            // 
            this.buyer.FormattingEnabled = true;
            this.buyer.Location = new System.Drawing.Point(745, 363);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(331, 28);
            this.buyer.TabIndex = 24;
            this.buyer.Text = "Select Buyer";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(40, 579);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 67);
            this.button3.TabIndex = 5;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(398, 26);
            this.textBox1.TabIndex = 6;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(694, 13);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(116, 35);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // newFile
            // 
            this.newFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newFile.Location = new System.Drawing.Point(1660, 579);
            this.newFile.Name = "newFile";
            this.newFile.Size = new System.Drawing.Size(196, 67);
            this.newFile.TabIndex = 8;
            this.newFile.Text = "New ";
            this.newFile.UseVisualStyleBackColor = true;
            this.newFile.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Model,
            this.capacity,
            this.Type,
            this.price,
            this.quantity,
            this.carrier});
            this.dataGridView1.Location = new System.Drawing.Point(37, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(2207, 535);
            this.dataGridView1.TabIndex = 1;
            // 
            // Model
            // 
            this.Model.HeaderText = "model";
            this.Model.Name = "Model";
            this.Model.Width = 500;
            // 
            // capacity
            // 
            this.capacity.HeaderText = "Memory size";
            this.capacity.Name = "capacity";
            this.capacity.Width = 400;
            // 
            // Type
            // 
            this.Type.HeaderText = "Phone Type";
            this.Type.Name = "Type";
            this.Type.Width = 362;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.Width = 200;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Width = 300;
            // 
            // carrier
            // 
            this.carrier.HeaderText = "Carrier";
            this.carrier.Name = "carrier";
            this.carrier.Width = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2361, 1371);
            this.Controls.Add(this.newFile);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.addIterm);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addIterm;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox sQuantity;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton blackberry;
        private System.Windows.Forms.RadioButton samsung;
        private System.Windows.Forms.RadioButton iphone;
        private System.Windows.Forms.RadioButton motorolla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sPrice;
        private System.Windows.Forms.ComboBox supplier;
        private System.Windows.Forms.ComboBox sModel;
        private System.Windows.Forms.ComboBox memory;
        private System.Windows.Forms.ComboBox network;
        private System.Windows.Forms.ComboBox buyer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button newFile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrier;
    }
}

