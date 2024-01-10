namespace Lab3B
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
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.comboBoxHairDresser = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxCharge = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxPrice = new System.Windows.Forms.ListBox();
            this.listBoxTotalPrice = new System.Windows.Forms.ListBox();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.buttonCalculatePrice = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(494, 293);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(97, 22);
            this.labelTotalPrice.TabIndex = 4;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // comboBoxHairDresser
            // 
            this.comboBoxHairDresser.FormattingEnabled = true;
            this.comboBoxHairDresser.Items.AddRange(new object[] {
            "Jane Samley",
            "Pat Johnson",
            "Ron Chambers",
            "Sue Pallon",
            "Laura Renkins"});
            this.comboBoxHairDresser.Location = new System.Drawing.Point(6, 21);
            this.comboBoxHairDresser.Name = "comboBoxHairDresser";
            this.comboBoxHairDresser.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHairDresser.TabIndex = 5;
            this.comboBoxHairDresser.Text = "Jane Samley";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxHairDresser);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 205);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Hairdresser";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxService);
            this.groupBox2.Location = new System.Drawing.Point(233, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 205);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select a Service";
            // 
            // listBoxService
            // 
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.ItemHeight = 16;
            this.listBoxService.Items.AddRange(new object[] {
            "Cut",
            "Wash, blow-dry, and style",
            "Colour",
            "Highlights",
            "Extension",
            "Up-do"});
            this.listBoxService.Location = new System.Drawing.Point(6, 21);
            this.listBoxService.Name = "listBoxService";
            this.listBoxService.Size = new System.Drawing.Size(188, 180);
            this.listBoxService.TabIndex = 8;
            this.listBoxService.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxService_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxCharge);
            this.groupBox3.Location = new System.Drawing.Point(439, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 205);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Charged Items";
            // 
            // listBoxCharge
            // 
            this.listBoxCharge.FormattingEnabled = true;
            this.listBoxCharge.ItemHeight = 16;
            this.listBoxCharge.Location = new System.Drawing.Point(6, 21);
            this.listBoxCharge.Name = "listBoxCharge";
            this.listBoxCharge.Size = new System.Drawing.Size(188, 180);
            this.listBoxCharge.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxPrice);
            this.groupBox4.Location = new System.Drawing.Point(645, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(143, 201);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Price";
            // 
            // listBoxPrice
            // 
            this.listBoxPrice.FormattingEnabled = true;
            this.listBoxPrice.ItemHeight = 16;
            this.listBoxPrice.Location = new System.Drawing.Point(6, 15);
            this.listBoxPrice.Name = "listBoxPrice";
            this.listBoxPrice.Size = new System.Drawing.Size(131, 180);
            this.listBoxPrice.TabIndex = 0;
            // 
            // listBoxTotalPrice
            // 
            this.listBoxTotalPrice.FormattingEnabled = true;
            this.listBoxTotalPrice.ItemHeight = 16;
            this.listBoxTotalPrice.Location = new System.Drawing.Point(611, 293);
            this.listBoxTotalPrice.Name = "listBoxTotalPrice";
            this.listBoxTotalPrice.Size = new System.Drawing.Size(171, 20);
            this.listBoxTotalPrice.TabIndex = 10;
            // 
            // buttonAddService
            // 
            this.buttonAddService.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonAddService.Location = new System.Drawing.Point(201, 388);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(107, 37);
            this.buttonAddService.TabIndex = 11;
            this.buttonAddService.Text = "Add Service";
            this.buttonAddService.UseVisualStyleBackColor = false;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // buttonCalculatePrice
            // 
            this.buttonCalculatePrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalculatePrice.Location = new System.Drawing.Point(330, 388);
            this.buttonCalculatePrice.Name = "buttonCalculatePrice";
            this.buttonCalculatePrice.Size = new System.Drawing.Size(163, 39);
            this.buttonCalculatePrice.TabIndex = 12;
            this.buttonCalculatePrice.Text = "Calculate Total Price";
            this.buttonCalculatePrice.UseVisualStyleBackColor = false;
            this.buttonCalculatePrice.Click += new System.EventHandler(this.buttonCalculatePrice_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonReset.Location = new System.Drawing.Point(513, 388);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(120, 39);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.IndianRed;
            this.buttonExit.Location = new System.Drawing.Point(651, 386);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(131, 39);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCalculatePrice);
            this.Controls.Add(this.buttonAddService);
            this.Controls.Add(this.listBoxTotalPrice);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTotalPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.ComboBox comboBoxHairDresser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxCharge;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxPrice;
        private System.Windows.Forms.ListBox listBoxTotalPrice;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.Button buttonCalculatePrice;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
    }
}

