namespace CollinsLab2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtMult = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picPet = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnData = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Purple;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.txtMult);
            this.groupBox1.Controls.Add(this.txtNum);
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Multiplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Multiplier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number:";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(112, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 23);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = " ";
            // 
            // txtMult
            // 
            this.txtMult.Location = new System.Drawing.Point(112, 134);
            this.txtMult.Name = "txtMult";
            this.txtMult.Size = new System.Drawing.Size(100, 23);
            this.txtMult.TabIndex = 1;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(112, 50);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 23);
            this.txtNum.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(137, 277);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(27, 277);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.picPet);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnHide);
            this.groupBox2.Controls.Add(this.btnData);
            this.groupBox2.Controls.Add(this.btnPicture);
            this.groupBox2.Location = new System.Drawing.Point(256, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(451, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Eleanor";
            // 
            // picPet
            // 
            this.picPet.Image = global::CollinsLab2.Properties.Resources.Eleanor;
            this.picPet.Location = new System.Drawing.Point(41, 50);
            this.picPet.Name = "picPet";
            this.picPet.Size = new System.Drawing.Size(398, 200);
            this.picPet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPet.TabIndex = 5;
            this.picPet.TabStop = false;
            this.picPet.Visible = false;
            this.picPet.Click += new System.EventHandler(this.picPet_Click);
            // 
            // lblData
            // 
            this.lblData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblData.Location = new System.Drawing.Point(41, 50);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(398, 200);
            this.lblData.TabIndex = 4;
            this.lblData.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(364, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(255, 277);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(75, 23);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "&Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(150, 277);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 1;
            this.btnData.Text = "&Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(41, 277);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(75, 23);
            this.btnPicture.TabIndex = 0;
            this.btnPicture.Text = "&Picture";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPicture;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(719, 331);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 2 by Chris Collins";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtMult;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picPet;
    }
}

