namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnfaiz = new System.Windows.Forms.Button();
            this.btnce = new System.Windows.Forms.Button();
            this.btnc = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnberaber = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btntoplama = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.btncixma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(1, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(386, 47);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            // 
            // btnfaiz
            // 
            this.btnfaiz.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnfaiz.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnfaiz.Location = new System.Drawing.Point(1, 99);
            this.btnfaiz.Name = "btnfaiz";
            this.btnfaiz.Size = new System.Drawing.Size(118, 52);
            this.btnfaiz.TabIndex = 1;
            this.btnfaiz.Text = "%";
            this.btnfaiz.UseVisualStyleBackColor = false;
            this.btnfaiz.Click += new System.EventHandler(this.btnfaiz_Click);
            // 
            // btnce
            // 
            this.btnce.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnce.Location = new System.Drawing.Point(125, 100);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(109, 50);
            this.btnce.TabIndex = 2;
            this.btnce.Text = "CE";
            this.btnce.UseVisualStyleBackColor = false;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btnc
            // 
            this.btnc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnc.Location = new System.Drawing.Point(183, 411);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(77, 55);
            this.btnc.TabIndex = 3;
            this.btnc.Text = "C";
            this.btnc.UseVisualStyleBackColor = false;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.BackgroundImage = global::WinFormsApp8.Properties.Resources.delete;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndelete.Location = new System.Drawing.Point(240, 102);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(104, 49);
            this.btndelete.TabIndex = 4;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn0.Location = new System.Drawing.Point(95, 411);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(82, 55);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnberaber
            // 
            this.btnberaber.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnberaber.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnberaber.Location = new System.Drawing.Point(97, 472);
            this.btnberaber.Name = "btnberaber";
            this.btnberaber.Size = new System.Drawing.Size(80, 53);
            this.btnberaber.TabIndex = 6;
            this.btnberaber.Text = "=";
            this.btnberaber.UseVisualStyleBackColor = false;
            this.btnberaber.Click += new System.EventHandler(this.btnberaber_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1.Location = new System.Drawing.Point(12, 166);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 71);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn2.Location = new System.Drawing.Point(95, 166);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 71);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn3.Location = new System.Drawing.Point(183, 166);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 71);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn4.Location = new System.Drawing.Point(12, 257);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(73, 66);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn5.Location = new System.Drawing.Point(97, 257);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 66);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn6.Location = new System.Drawing.Point(180, 257);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 66);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn7.Location = new System.Drawing.Point(14, 339);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 66);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn8.Location = new System.Drawing.Point(97, 339);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(80, 66);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn9.Location = new System.Drawing.Point(183, 338);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 67);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button16.Location = new System.Drawing.Point(12, 411);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(77, 55);
            this.button16.TabIndex = 16;
            this.button16.Text = ".";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // btnmult
            // 
            this.btnmult.BackColor = System.Drawing.Color.DarkOrange;
            this.btnmult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnmult.Location = new System.Drawing.Point(283, 166);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(95, 71);
            this.btnmult.TabIndex = 17;
            this.btnmult.Text = "X";
            this.btnmult.UseVisualStyleBackColor = false;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btntoplama
            // 
            this.btntoplama.BackColor = System.Drawing.Color.DarkOrange;
            this.btntoplama.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btntoplama.Location = new System.Drawing.Point(283, 339);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(95, 62);
            this.btntoplama.TabIndex = 18;
            this.btntoplama.Text = "+";
            this.btntoplama.UseVisualStyleBackColor = false;
            this.btntoplama.Click += new System.EventHandler(this.btntoplama_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.BackColor = System.Drawing.Color.DarkOrange;
            this.btnbolme.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbolme.Location = new System.Drawing.Point(283, 253);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(95, 66);
            this.btnbolme.TabIndex = 19;
            this.btnbolme.Text = "/";
            this.btnbolme.UseVisualStyleBackColor = false;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // btncixma
            // 
            this.btncixma.BackColor = System.Drawing.Color.DarkOrange;
            this.btncixma.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btncixma.Location = new System.Drawing.Point(283, 411);
            this.btncixma.Name = "btncixma";
            this.btncixma.Size = new System.Drawing.Size(95, 59);
            this.btncixma.TabIndex = 20;
            this.btncixma.Text = "-";
            this.btncixma.UseVisualStyleBackColor = false;
            this.btncixma.Click += new System.EventHandler(this.btncixma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(387, 545);
            this.Controls.Add(this.btncixma);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btntoplama);
            this.Controls.Add(this.btnmult);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnberaber);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnfaiz);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button btnfaiz;
        private Button btnce;
        private Button btnc;
        private Button btndelete;
        private Button btn0;
        private Button btnberaber;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button button16;
        private Button btnmult;
        private Button btntoplama;
        private Button btnbolme;
        private Button btncixma;
    }
}