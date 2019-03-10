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
            this.addIterm = new System.Windows.Forms.Button();
            this.deleteFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buyer = new System.Windows.Forms.ComboBox();
            this.sPrice = new System.Windows.Forms.ComboBox();
            this.supplier = new System.Windows.Forms.ComboBox();
            this.sModel = new System.Windows.Forms.ComboBox();
            this.memory = new System.Windows.Forms.ComboBox();
            this.network = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.motorolla = new System.Windows.Forms.RadioButton();
            this.blackberry = new System.Windows.Forms.RadioButton();
            this.samsung = new System.Windows.Forms.RadioButton();
            this.iphone = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sQuantity = new System.Windows.Forms.TextBox();
            this.listBoxGrouper = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.Edit_File = new System.Windows.Forms.Button();
            this.listOutPut = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addIterm
            // 
            this.addIterm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIterm.Location = new System.Drawing.Point(1179, 578);
            this.addIterm.Name = "addIterm";
            this.addIterm.Size = new System.Drawing.Size(196, 68);
            this.addIterm.TabIndex = 1;
            this.addIterm.Text = "Add Iterm";
            this.addIterm.UseVisualStyleBackColor = true;
            this.addIterm.Click += new System.EventHandler(this.addIterm_Click);
            // 
            // deleteFile
            // 
            this.deleteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFile.Location = new System.Drawing.Point(2128, 578);
            this.deleteFile.Name = "deleteFile";
            this.deleteFile.Size = new System.Drawing.Size(196, 68);
            this.deleteFile.TabIndex = 2;
            this.deleteFile.Text = "Delete Iterm";
            this.deleteFile.UseVisualStyleBackColor = true;
            this.deleteFile.Click += new System.EventHandler(this.deleteFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(1179, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 502);
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
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.sQuantity);
            this.groupBox1.Controls.Add(this.listBoxGrouper);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1102, 460);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buyer
            // 
            this.buyer.FormattingEnabled = true;
            this.buyer.Items.AddRange(new object[] {
            "Consumer",
            "Retialer"});
            this.buyer.Location = new System.Drawing.Point(746, 363);
            this.buyer.Name = "buyer";
            this.buyer.Size = new System.Drawing.Size(331, 28);
            this.buyer.TabIndex = 24;
            this.buyer.Text = "Select Buyer";
            // 
            // sPrice
            // 
            this.sPrice.FormattingEnabled = true;
            this.sPrice.Items.AddRange(new object[] {
            "300",
            "450",
            "500",
            "600",
            "840",
            "920"});
            this.sPrice.Location = new System.Drawing.Point(746, 168);
            this.sPrice.Name = "sPrice";
            this.sPrice.Size = new System.Drawing.Size(331, 28);
            this.sPrice.TabIndex = 23;
            this.sPrice.Text = "Select price";
            // 
            // supplier
            // 
            this.supplier.FormattingEnabled = true;
            this.supplier.Items.AddRange(new object[] {
            "AT&T",
            "SPRINT",
            "VERISON",
            "APPLE",
            "SAMSUNG",
            "BLACKBERRY",
            "MOTOROLLA"});
            this.supplier.Location = new System.Drawing.Point(746, 260);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(331, 28);
            this.supplier.TabIndex = 22;
            this.supplier.Text = "Select Suppliers";
            // 
            // sModel
            // 
            this.sModel.FormattingEnabled = true;
            this.sModel.Items.AddRange(new object[] {
            "X",
            "6S",
            "6 Plus",
            "8S",
            "8 Plus"});
            this.sModel.Location = new System.Drawing.Point(128, 82);
            this.sModel.Name = "sModel";
            this.sModel.Size = new System.Drawing.Size(331, 28);
            this.sModel.TabIndex = 21;
            this.sModel.Text = "SelectModel ";
            // 
            // memory
            // 
            this.memory.FormattingEnabled = true;
            this.memory.Items.AddRange(new object[] {
            "64",
            "125",
            "245",
            "300"});
            this.memory.Location = new System.Drawing.Point(128, 169);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(331, 28);
            this.memory.TabIndex = 20;
            this.memory.Text = "Select Memory Storage";
            // 
            // network
            // 
            this.network.FormattingEnabled = true;
            this.network.Items.AddRange(new object[] {
            "AT&T",
            "VERISON",
            "SPRINT",
            "NO CARRIER"});
            this.network.Location = new System.Drawing.Point(128, 260);
            this.network.Name = "network";
            this.network.Size = new System.Drawing.Size(331, 28);
            this.network.TabIndex = 5;
            this.network.Text = "Select Network";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(652, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Supplier:";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Model:";
            // 
            // motorolla
            // 
            this.motorolla.AutoSize = true;
            this.motorolla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorolla.Location = new System.Drawing.Point(488, 365);
            this.motorolla.Name = "motorolla";
            this.motorolla.Size = new System.Drawing.Size(117, 26);
            this.motorolla.TabIndex = 11;
            this.motorolla.TabStop = true;
            this.motorolla.Text = "Motorolla";
            this.motorolla.UseVisualStyleBackColor = true;
            // 
            // blackberry
            // 
            this.blackberry.AutoSize = true;
            this.blackberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackberry.Location = new System.Drawing.Point(488, 262);
            this.blackberry.Name = "blackberry";
            this.blackberry.Size = new System.Drawing.Size(132, 26);
            this.blackberry.TabIndex = 12;
            this.blackberry.TabStop = true;
            this.blackberry.Text = "BlackBerry";
            this.blackberry.UseVisualStyleBackColor = true;
            // 
            // samsung
            // 
            this.samsung.AutoSize = true;
            this.samsung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.samsung.Location = new System.Drawing.Point(488, 169);
            this.samsung.Name = "samsung";
            this.samsung.Size = new System.Drawing.Size(129, 26);
            this.samsung.TabIndex = 11;
            this.samsung.TabStop = true;
            this.samsung.Text = "Samsung  ";
            this.samsung.UseVisualStyleBackColor = true;
            // 
            // iphone
            // 
            this.iphone.AutoSize = true;
            this.iphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iphone.Location = new System.Drawing.Point(488, 83);
            this.iphone.Name = "iphone";
            this.iphone.Size = new System.Drawing.Size(121, 26);
            this.iphone.TabIndex = 10;
            this.iphone.TabStop = true;
            this.iphone.Text = "IPhone    ";
            this.iphone.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(820, 82);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(170, 26);
            this.dateTimePicker.TabIndex = 9;
            // 
            // sQuantity
            // 
            this.sQuantity.Location = new System.Drawing.Point(128, 365);
            this.sQuantity.Name = "sQuantity";
            this.sQuantity.Size = new System.Drawing.Size(175, 26);
            this.sQuantity.TabIndex = 4;
            // 
            // listBoxGrouper
            // 
            this.listBoxGrouper.FormattingEnabled = true;
            this.listBoxGrouper.ItemHeight = 20;
            this.listBoxGrouper.Location = new System.Drawing.Point(6, 31);
            this.listBoxGrouper.Name = "listBoxGrouper";
            this.listBoxGrouper.Size = new System.Drawing.Size(1092, 424);
            this.listBoxGrouper.TabIndex = 0;
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
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(40, 578);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(196, 68);
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button3_Click);
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
            this.search.Location = new System.Drawing.Point(694, 12);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(116, 35);
            this.search.TabIndex = 7;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // Edit_File
            // 
            this.Edit_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_File.Location = new System.Drawing.Point(1660, 578);
            this.Edit_File.Name = "Edit_File";
            this.Edit_File.Size = new System.Drawing.Size(196, 68);
            this.Edit_File.TabIndex = 8;
            this.Edit_File.Text = "Edit";
            this.Edit_File.UseVisualStyleBackColor = true;
            this.Edit_File.Click += new System.EventHandler(this.newFile_Click);
            // 
            // listOutPut
            // 
            this.listOutPut.FormattingEnabled = true;
            this.listOutPut.ItemHeight = 20;
            this.listOutPut.Location = new System.Drawing.Point(170, 698);
            this.listOutPut.Name = "listOutPut";
            this.listOutPut.Size = new System.Drawing.Size(976, 404);
            this.listOutPut.TabIndex = 9;
            this.listOutPut.SelectedIndexChanged += new System.EventHandler(this.listOutPut_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(2392, 1129);
            this.Controls.Add(this.listOutPut);
            this.Controls.Add(this.Edit_File);
            this.Controls.Add(this.search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deleteFile);
            this.Controls.Add(this.addIterm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addIterm;
        private System.Windows.Forms.Button deleteFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox sQuantity;
        private System.Windows.Forms.ListBox listBoxGrouper;
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
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button Edit_File;
        private System.Windows.Forms.ListBox listOutPut;
    }
}

