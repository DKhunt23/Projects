namespace Lab2B
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCalculatePrice = new System.Windows.Forms.Button();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonSamley = new System.Windows.Forms.RadioButton();
            this.radioButtonJohnson = new System.Windows.Forms.RadioButton();
            this.radioButtonChambers = new System.Windows.Forms.RadioButton();
            this.radioButtonPallon = new System.Windows.Forms.RadioButton();
            this.radioButtonRenkins = new System.Windows.Forms.RadioButton();
            this.radioButtonAdult = new System.Windows.Forms.RadioButton();
            this.radioButtonChildUnder12 = new System.Windows.Forms.RadioButton();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonSenior = new System.Windows.Forms.RadioButton();
            this.checkBoxCut = new System.Windows.Forms.CheckBox();
            this.checkBoxColour = new System.Windows.Forms.CheckBox();
            this.checkBoxHighlights = new System.Windows.Forms.CheckBox();
            this.checkBoxExtensions = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClientVisits = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(639, 495);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 39);
            this.buttonClose.TabIndex = 13;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(406, 495);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(112, 39);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCalculatePrice
            // 
            this.buttonCalculatePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculatePrice.Location = new System.Drawing.Point(159, 495);
            this.buttonCalculatePrice.Name = "buttonCalculatePrice";
            this.buttonCalculatePrice.Size = new System.Drawing.Size(114, 39);
            this.buttonCalculatePrice.TabIndex = 11;
            this.buttonCalculatePrice.Text = "Calculate";
            this.buttonCalculatePrice.UseVisualStyleBackColor = true;
            this.buttonCalculatePrice.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(289, 431);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(129, 25);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "Total Price: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonSenior);
            this.groupBox3.Controls.Add(this.radioButtonStudent);
            this.groupBox3.Controls.Add(this.radioButtonChildUnder12);
            this.groupBox3.Controls.Add(this.radioButtonAdult);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(93, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(350, 168);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Client Type";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxClientVisits);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(498, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(332, 168);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Client Visits";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxExtensions);
            this.groupBox2.Controls.Add(this.checkBoxHighlights);
            this.groupBox2.Controls.Add(this.checkBoxColour);
            this.groupBox2.Controls.Add(this.checkBoxCut);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(498, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 181);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Services";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRenkins);
            this.groupBox1.Controls.Add(this.radioButtonPallon);
            this.groupBox1.Controls.Add(this.radioButtonChambers);
            this.groupBox1.Controls.Add(this.radioButtonJohnson);
            this.groupBox1.Controls.Add(this.radioButtonSamley);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(93, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 181);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hairdresser";
            // 
            // radioButtonSamley
            // 
            this.radioButtonSamley.AutoSize = true;
            this.radioButtonSamley.Checked = true;
            this.radioButtonSamley.Location = new System.Drawing.Point(35, 31);
            this.radioButtonSamley.Name = "radioButtonSamley";
            this.radioButtonSamley.Size = new System.Drawing.Size(145, 26);
            this.radioButtonSamley.TabIndex = 0;
            this.radioButtonSamley.TabStop = true;
            this.radioButtonSamley.Text = "Jane Samley";
            this.radioButtonSamley.UseVisualStyleBackColor = true;
            // 
            // radioButtonJohnson
            // 
            this.radioButtonJohnson.AutoSize = true;
            this.radioButtonJohnson.Location = new System.Drawing.Point(35, 57);
            this.radioButtonJohnson.Name = "radioButtonJohnson";
            this.radioButtonJohnson.Size = new System.Drawing.Size(142, 26);
            this.radioButtonJohnson.TabIndex = 1;
            this.radioButtonJohnson.Text = "Pat Johnson";
            this.radioButtonJohnson.UseVisualStyleBackColor = true;
            // 
            // radioButtonChambers
            // 
            this.radioButtonChambers.AutoSize = true;
            this.radioButtonChambers.Location = new System.Drawing.Point(35, 85);
            this.radioButtonChambers.Name = "radioButtonChambers";
            this.radioButtonChambers.Size = new System.Drawing.Size(159, 26);
            this.radioButtonChambers.TabIndex = 2;
            this.radioButtonChambers.Text = "Ron chambers";
            this.radioButtonChambers.UseVisualStyleBackColor = true;
            // 
            // radioButtonPallon
            // 
            this.radioButtonPallon.AutoSize = true;
            this.radioButtonPallon.Location = new System.Drawing.Point(35, 113);
            this.radioButtonPallon.Name = "radioButtonPallon";
            this.radioButtonPallon.Size = new System.Drawing.Size(128, 26);
            this.radioButtonPallon.TabIndex = 3;
            this.radioButtonPallon.Text = "Sue Pallon";
            this.radioButtonPallon.UseVisualStyleBackColor = true;
            // 
            // radioButtonRenkins
            // 
            this.radioButtonRenkins.AutoSize = true;
            this.radioButtonRenkins.Location = new System.Drawing.Point(35, 141);
            this.radioButtonRenkins.Name = "radioButtonRenkins";
            this.radioButtonRenkins.Size = new System.Drawing.Size(160, 26);
            this.radioButtonRenkins.TabIndex = 4;
            this.radioButtonRenkins.Text = "Laura Renkins";
            this.radioButtonRenkins.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdult
            // 
            this.radioButtonAdult.AutoSize = true;
            this.radioButtonAdult.Checked = true;
            this.radioButtonAdult.Location = new System.Drawing.Point(35, 31);
            this.radioButtonAdult.Name = "radioButtonAdult";
            this.radioButtonAdult.Size = new System.Drawing.Size(164, 26);
            this.radioButtonAdult.TabIndex = 1;
            this.radioButtonAdult.TabStop = true;
            this.radioButtonAdult.Text = "Standard Adult";
            this.radioButtonAdult.UseVisualStyleBackColor = true;
            // 
            // radioButtonChildUnder12
            // 
            this.radioButtonChildUnder12.AutoSize = true;
            this.radioButtonChildUnder12.Location = new System.Drawing.Point(35, 60);
            this.radioButtonChildUnder12.Name = "radioButtonChildUnder12";
            this.radioButtonChildUnder12.Size = new System.Drawing.Size(215, 26);
            this.radioButtonChildUnder12.TabIndex = 2;
            this.radioButtonChildUnder12.Text = "Child (12 and under)";
            this.radioButtonChildUnder12.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(35, 89);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(100, 26);
            this.radioButtonStudent.TabIndex = 3;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            // 
            // radioButtonSenior
            // 
            this.radioButtonSenior.AutoSize = true;
            this.radioButtonSenior.Location = new System.Drawing.Point(35, 121);
            this.radioButtonSenior.Name = "radioButtonSenior";
            this.radioButtonSenior.Size = new System.Drawing.Size(176, 26);
            this.radioButtonSenior.TabIndex = 4;
            this.radioButtonSenior.Text = "Senior (over 65)";
            this.radioButtonSenior.UseVisualStyleBackColor = true;
            this.radioButtonSenior.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // checkBoxCut
            // 
            this.checkBoxCut.AutoSize = true;
            this.checkBoxCut.Checked = true;
            this.checkBoxCut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCut.Location = new System.Drawing.Point(37, 31);
            this.checkBoxCut.Name = "checkBoxCut";
            this.checkBoxCut.Size = new System.Drawing.Size(63, 26);
            this.checkBoxCut.TabIndex = 0;
            this.checkBoxCut.Text = "Cut";
            this.checkBoxCut.UseVisualStyleBackColor = true;
            // 
            // checkBoxColour
            // 
            this.checkBoxColour.AutoSize = true;
            this.checkBoxColour.Location = new System.Drawing.Point(37, 59);
            this.checkBoxColour.Name = "checkBoxColour";
            this.checkBoxColour.Size = new System.Drawing.Size(91, 26);
            this.checkBoxColour.TabIndex = 1;
            this.checkBoxColour.Text = "Colour";
            this.checkBoxColour.UseVisualStyleBackColor = true;
            // 
            // checkBoxHighlights
            // 
            this.checkBoxHighlights.AutoSize = true;
            this.checkBoxHighlights.Location = new System.Drawing.Point(37, 88);
            this.checkBoxHighlights.Name = "checkBoxHighlights";
            this.checkBoxHighlights.Size = new System.Drawing.Size(121, 26);
            this.checkBoxHighlights.TabIndex = 2;
            this.checkBoxHighlights.Text = "Highlights";
            this.checkBoxHighlights.UseVisualStyleBackColor = true;
            // 
            // checkBoxExtensions
            // 
            this.checkBoxExtensions.AutoSize = true;
            this.checkBoxExtensions.Location = new System.Drawing.Point(37, 120);
            this.checkBoxExtensions.Name = "checkBoxExtensions";
            this.checkBoxExtensions.Size = new System.Drawing.Size(130, 26);
            this.checkBoxExtensions.TabIndex = 3;
            this.checkBoxExtensions.Text = "Extensions";
            this.checkBoxExtensions.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Client Visits:";
            // 
            // textBoxClientVisits
            // 
            this.textBoxClientVisits.Location = new System.Drawing.Point(57, 64);
            this.textBoxClientVisits.Name = "textBoxClientVisits";
            this.textBoxClientVisits.Size = new System.Drawing.Size(186, 28);
            this.textBoxClientVisits.TabIndex = 1;
            this.textBoxClientVisits.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 560);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculatePrice);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCalculatePrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonSenior;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonChildUnder12;
        private System.Windows.Forms.RadioButton radioButtonAdult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRenkins;
        private System.Windows.Forms.RadioButton radioButtonPallon;
        private System.Windows.Forms.RadioButton radioButtonChambers;
        private System.Windows.Forms.RadioButton radioButtonJohnson;
        private System.Windows.Forms.RadioButton radioButtonSamley;
        private System.Windows.Forms.TextBox textBoxClientVisits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxExtensions;
        private System.Windows.Forms.CheckBox checkBoxHighlights;
        private System.Windows.Forms.CheckBox checkBoxColour;
        private System.Windows.Forms.CheckBox checkBoxCut;
    }
}

