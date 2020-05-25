namespace lab7_AntoniaCarrizo
{
    partial class Calculator
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultados = new System.Windows.Forms.TextBox();
            this.ac = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.multi = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::lab7_AntoniaCarrizo.Properties.Resources.calculadora;
            this.pictureBox1.Location = new System.Drawing.Point(-63, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resultados);
            this.panel1.Controls.Add(this.ac);
            this.panel1.Controls.Add(this.igual);
            this.panel1.Controls.Add(this.punto);
            this.panel1.Controls.Add(this.num0);
            this.panel1.Controls.Add(this.num7);
            this.panel1.Controls.Add(this.num3);
            this.panel1.Controls.Add(this.num2);
            this.panel1.Controls.Add(this.multi);
            this.panel1.Controls.Add(this.division);
            this.panel1.Controls.Add(this.resta);
            this.panel1.Controls.Add(this.suma);
            this.panel1.Controls.Add(this.num5);
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.ans);
            this.panel1.Controls.Add(this.num8);
            this.panel1.Controls.Add(this.num6);
            this.panel1.Controls.Add(this.num9);
            this.panel1.Controls.Add(this.num4);
            this.panel1.Controls.Add(this.num1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 316);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // resultados
            // 
            this.resultados.BackColor = System.Drawing.SystemColors.ControlDark;
            this.resultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultados.Location = new System.Drawing.Point(29, 28);
            this.resultados.Name = "resultados";
            this.resultados.ReadOnly = true;
            this.resultados.Size = new System.Drawing.Size(184, 35);
            this.resultados.TabIndex = 2;
            this.resultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ac
            // 
            this.ac.BackColor = System.Drawing.Color.Orchid;
            this.ac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ac.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ac.Location = new System.Drawing.Point(180, 198);
            this.ac.Name = "ac";
            this.ac.Size = new System.Drawing.Size(35, 25);
            this.ac.TabIndex = 21;
            this.ac.Text = "AC";
            this.ac.UseVisualStyleBackColor = false;
            this.ac.Click += new System.EventHandler(this.ac_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.HotPink;
            this.igual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.igual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(178, 235);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(35, 64);
            this.igual.TabIndex = 20;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.button18_Click);
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.punto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.punto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.Location = new System.Drawing.Point(82, 274);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(26, 25);
            this.punto.TabIndex = 18;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            this.punto.Click += new System.EventHandler(this.punto_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(29, 274);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(26, 25);
            this.num0.TabIndex = 17;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(29, 161);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(26, 25);
            this.num7.TabIndex = 16;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button14_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(135, 235);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(26, 25);
            this.num3.TabIndex = 15;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button13_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(82, 235);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(26, 25);
            this.num2.TabIndex = 14;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // multi
            // 
            this.multi.BackColor = System.Drawing.Color.Orchid;
            this.multi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multi.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multi.Location = new System.Drawing.Point(135, 123);
            this.multi.Name = "multi";
            this.multi.Size = new System.Drawing.Size(26, 25);
            this.multi.TabIndex = 13;
            this.multi.Text = "X";
            this.multi.UseVisualStyleBackColor = false;
            this.multi.Click += new System.EventHandler(this.multi_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.Color.Orchid;
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.division.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(187, 123);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(26, 25);
            this.division.TabIndex = 12;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.button10_Click);
            // 
            // resta
            // 
            this.resta.BackColor = System.Drawing.Color.Orchid;
            this.resta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resta.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(82, 123);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(26, 25);
            this.resta.TabIndex = 11;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = false;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // suma
            // 
            this.suma.BackColor = System.Drawing.Color.Orchid;
            this.suma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.suma.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(29, 123);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(26, 25);
            this.suma.TabIndex = 10;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = false;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(82, 198);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(26, 25);
            this.num5.TabIndex = 9;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Orchid;
            this.del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.del.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(180, 161);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(35, 25);
            this.del.TabIndex = 8;
            this.del.Text = "DEL";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // ans
            // 
            this.ans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ans.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ans.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ans.Location = new System.Drawing.Point(130, 274);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(35, 25);
            this.ans.TabIndex = 7;
            this.ans.Text = "Ans";
            this.ans.UseVisualStyleBackColor = false;
            this.ans.Click += new System.EventHandler(this.button5_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(82, 161);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(26, 25);
            this.num8.TabIndex = 6;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(135, 198);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(26, 25);
            this.num6.TabIndex = 5;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(135, 161);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(26, 25);
            this.num9.TabIndex = 4;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(29, 198);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(26, 25);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.num1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.num1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(29, 235);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(26, 25);
            this.num1.TabIndex = 2;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 316);
            this.Controls.Add(this.panel1);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button multi;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button ans;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.TextBox resultados;
        private System.Windows.Forms.Button ac;
    }
}