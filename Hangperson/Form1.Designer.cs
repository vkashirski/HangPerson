namespace Hangperson
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.lb6 = new System.Windows.Forms.Label();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lettr1 = new System.Windows.Forms.Label();
            this.lettr2 = new System.Windows.Forms.Label();
            this.lettr3 = new System.Windows.Forms.Label();
            this.lettr6 = new System.Windows.Forms.Label();
            this.lettr4 = new System.Windows.Forms.Label();
            this.lettr5 = new System.Windows.Forms.Label();
            this.lettr7 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.EnteredLetter = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rightOrWrong = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.lab5 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab3 = new System.Windows.Forms.Label();
            this.lab2 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 423);
            this.progressBar1.Maximum = 90;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(724, 65);
            this.progressBar1.TabIndex = 0;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Transparent;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb1.Location = new System.Drawing.Point(664, 128);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(47, 42);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "O";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Transparent;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb3.Location = new System.Drawing.Point(659, 208);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(29, 42);
            this.lb3.TabIndex = 4;
            this.lb3.Text = "/";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.BackColor = System.Drawing.Color.Transparent;
            this.lb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb4.Location = new System.Drawing.Point(685, 208);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(29, 42);
            this.lb4.TabIndex = 5;
            this.lb4.Text = "\\";
            // 
            // lb6
            // 
            this.lb6.AutoSize = true;
            this.lb6.BackColor = System.Drawing.Color.Transparent;
            this.lb6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb6.Location = new System.Drawing.Point(693, 168);
            this.lb6.Name = "lb6";
            this.lb6.Size = new System.Drawing.Size(29, 42);
            this.lb6.TabIndex = 6;
            this.lb6.Text = "\\";
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.BackColor = System.Drawing.Color.Transparent;
            this.lb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb5.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb5.Location = new System.Drawing.Point(654, 168);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(29, 42);
            this.lb5.TabIndex = 8;
            this.lb5.Text = "/";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Transparent;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb2.Location = new System.Drawing.Point(674, 168);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(27, 42);
            this.lb2.TabIndex = 9;
            this.lb2.Text = "I";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(674, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 42);
            this.label7.TabIndex = 10;
            this.label7.Text = "I";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(585, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 42);
            this.label8.TabIndex = 11;
            this.label8.Text = "I";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(585, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 42);
            this.label9.TabIndex = 12;
            this.label9.Text = "I";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(585, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 42);
            this.label10.TabIndex = 13;
            this.label10.Text = "I";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(585, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 42);
            this.label11.TabIndex = 14;
            this.label11.Text = "I";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(585, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 42);
            this.label12.TabIndex = 15;
            this.label12.Text = "I";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(594, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 42);
            this.label13.TabIndex = 16;
            this.label13.Text = "_";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(618, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 42);
            this.label14.TabIndex = 17;
            this.label14.Text = "_";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(648, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 42);
            this.label15.TabIndex = 18;
            this.label15.Text = "_";
            // 
            // lettr1
            // 
            this.lettr1.AutoSize = true;
            this.lettr1.BackColor = System.Drawing.Color.Transparent;
            this.lettr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr1.ForeColor = System.Drawing.Color.Black;
            this.lettr1.Location = new System.Drawing.Point(12, 101);
            this.lettr1.Name = "lettr1";
            this.lettr1.Size = new System.Drawing.Size(68, 73);
            this.lettr1.TabIndex = 19;
            this.lettr1.Text = "_";
            this.lettr1.Visible = false;
            // 
            // lettr2
            // 
            this.lettr2.AutoSize = true;
            this.lettr2.BackColor = System.Drawing.Color.Transparent;
            this.lettr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr2.ForeColor = System.Drawing.Color.Black;
            this.lettr2.Location = new System.Drawing.Point(86, 101);
            this.lettr2.Name = "lettr2";
            this.lettr2.Size = new System.Drawing.Size(68, 73);
            this.lettr2.TabIndex = 20;
            this.lettr2.Text = "_";
            this.lettr2.Visible = false;
            // 
            // lettr3
            // 
            this.lettr3.AutoSize = true;
            this.lettr3.BackColor = System.Drawing.Color.Transparent;
            this.lettr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr3.ForeColor = System.Drawing.Color.Black;
            this.lettr3.Location = new System.Drawing.Point(159, 101);
            this.lettr3.Name = "lettr3";
            this.lettr3.Size = new System.Drawing.Size(68, 73);
            this.lettr3.TabIndex = 21;
            this.lettr3.Text = "_";
            this.lettr3.Visible = false;
            // 
            // lettr6
            // 
            this.lettr6.AutoSize = true;
            this.lettr6.BackColor = System.Drawing.Color.Transparent;
            this.lettr6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr6.ForeColor = System.Drawing.Color.Black;
            this.lettr6.Location = new System.Drawing.Point(380, 101);
            this.lettr6.Name = "lettr6";
            this.lettr6.Size = new System.Drawing.Size(68, 73);
            this.lettr6.TabIndex = 22;
            this.lettr6.Text = "_";
            this.lettr6.Visible = false;
            // 
            // lettr4
            // 
            this.lettr4.AutoSize = true;
            this.lettr4.BackColor = System.Drawing.Color.Transparent;
            this.lettr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr4.ForeColor = System.Drawing.Color.Black;
            this.lettr4.Location = new System.Drawing.Point(233, 101);
            this.lettr4.Name = "lettr4";
            this.lettr4.Size = new System.Drawing.Size(68, 73);
            this.lettr4.TabIndex = 23;
            this.lettr4.Text = "_";
            this.lettr4.Visible = false;
            // 
            // lettr5
            // 
            this.lettr5.AutoSize = true;
            this.lettr5.BackColor = System.Drawing.Color.Transparent;
            this.lettr5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr5.ForeColor = System.Drawing.Color.Black;
            this.lettr5.Location = new System.Drawing.Point(306, 101);
            this.lettr5.Name = "lettr5";
            this.lettr5.Size = new System.Drawing.Size(68, 73);
            this.lettr5.TabIndex = 24;
            this.lettr5.Text = "_";
            this.lettr5.Visible = false;
            // 
            // lettr7
            // 
            this.lettr7.AutoSize = true;
            this.lettr7.BackColor = System.Drawing.Color.Transparent;
            this.lettr7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lettr7.ForeColor = System.Drawing.Color.Black;
            this.lettr7.Location = new System.Drawing.Point(453, 101);
            this.lettr7.Name = "lettr7";
            this.lettr7.Size = new System.Drawing.Size(68, 73);
            this.lettr7.TabIndex = 25;
            this.lettr7.Text = "_";
            this.lettr7.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(341, 362);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(66, 55);
            this.labelTime.TabIndex = 26;
            this.labelTime.Text = "...";
            this.labelTime.Visible = false;
            // 
            // EnteredLetter
            // 
            this.EnteredLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteredLetter.Location = new System.Drawing.Point(232, 211);
            this.EnteredLetter.Mask = "L";
            this.EnteredLetter.Name = "EnteredLetter";
            this.EnteredLetter.ReadOnly = true;
            this.EnteredLetter.Size = new System.Drawing.Size(44, 62);
            this.EnteredLetter.TabIndex = 27;
            this.EnteredLetter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Guess here:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Wrong letters:";
            // 
            // rightOrWrong
            // 
            this.rightOrWrong.BackColor = System.Drawing.Color.Silver;
            this.rightOrWrong.Enabled = false;
            this.rightOrWrong.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightOrWrong.Location = new System.Drawing.Point(565, 24);
            this.rightOrWrong.Name = "rightOrWrong";
            this.rightOrWrong.Size = new System.Drawing.Size(149, 65);
            this.rightOrWrong.TabIndex = 31;
            this.rightOrWrong.Text = "...";
            this.rightOrWrong.UseVisualStyleBackColor = false;
            // 
            // enter
            // 
            this.enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter.Location = new System.Drawing.Point(282, 211);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(47, 62);
            this.enter.TabIndex = 32;
            this.enter.Text = "✓";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Visible = false;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.BackColor = System.Drawing.Color.Transparent;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.ForeColor = System.Drawing.Color.Black;
            this.lab5.Location = new System.Drawing.Point(327, 295);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(68, 73);
            this.lab5.TabIndex = 38;
            this.lab5.Text = "_";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.BackColor = System.Drawing.Color.Transparent;
            this.lab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab4.ForeColor = System.Drawing.Color.Black;
            this.lab4.Location = new System.Drawing.Point(254, 295);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(68, 73);
            this.lab4.TabIndex = 37;
            this.lab4.Text = "_";
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.BackColor = System.Drawing.Color.Transparent;
            this.lab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab6.ForeColor = System.Drawing.Color.Black;
            this.lab6.Location = new System.Drawing.Point(401, 295);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(68, 73);
            this.lab6.TabIndex = 36;
            this.lab6.Text = "_";
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.BackColor = System.Drawing.Color.Transparent;
            this.lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.ForeColor = System.Drawing.Color.Black;
            this.lab3.Location = new System.Drawing.Point(181, 295);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(68, 73);
            this.lab3.TabIndex = 35;
            this.lab3.Text = "_";
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.BackColor = System.Drawing.Color.Transparent;
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.ForeColor = System.Drawing.Color.Black;
            this.lab2.Location = new System.Drawing.Point(108, 295);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(68, 73);
            this.lab2.TabIndex = 34;
            this.lab2.Text = "_";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.BackColor = System.Drawing.Color.Transparent;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.ForeColor = System.Drawing.Color.Black;
            this.lab1.Location = new System.Drawing.Point(34, 295);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(68, 73);
            this.lab1.TabIndex = 33;
            this.lab1.Text = "_";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(429, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 39;
            this.button2.Text = "QUIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.enter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 500);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lab5);
            this.Controls.Add(this.lab4);
            this.Controls.Add(this.lab6);
            this.Controls.Add(this.lab3);
            this.Controls.Add(this.lab2);
            this.Controls.Add(this.lab1);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.rightOrWrong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnteredLetter);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.lettr7);
            this.Controls.Add(this.lettr5);
            this.Controls.Add(this.lettr4);
            this.Controls.Add(this.lettr6);
            this.Controls.Add(this.lettr3);
            this.Controls.Add(this.lettr2);
            this.Controls.Add(this.lettr1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb6);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Hangperson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb6;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lettr1;
        private System.Windows.Forms.Label lettr2;
        private System.Windows.Forms.Label lettr3;
        private System.Windows.Forms.Label lettr6;
        private System.Windows.Forms.Label lettr4;
        private System.Windows.Forms.Label lettr5;
        private System.Windows.Forms.Label lettr7;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.MaskedTextBox EnteredLetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rightOrWrong;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.Button button2;
    }
}

