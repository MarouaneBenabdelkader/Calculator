namespace Calculator
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnMenu = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.BtnPrct = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnDevise = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnPow = new System.Windows.Forms.Button();
            this.BtnReverse = new System.Windows.Forms.Button();
            this.BtnMultp = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.BtnSous = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.BtnEgal = new System.Windows.Forms.Button();
            this.BtnPoint = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnNeg = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 40);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(210, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 40);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(260, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.Location = new System.Drawing.Point(310, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(50, 40);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnMenu);
            this.panel3.Controls.Add(this.BtnHistory);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 40);
            this.panel3.TabIndex = 2;
            // 
            // BtnMenu
            // 
            this.BtnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnMenu.FlatAppearance.BorderSize = 0;
            this.BtnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenu.Image")));
            this.BtnMenu.Location = new System.Drawing.Point(0, 0);
            this.BtnMenu.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMenu.Name = "BtnMenu";
            this.BtnMenu.Size = new System.Drawing.Size(50, 40);
            this.BtnMenu.TabIndex = 4;
            this.BtnMenu.UseVisualStyleBackColor = true;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Image = ((System.Drawing.Image)(resources.GetObject("BtnHistory.Image")));
            this.BtnHistory.Location = new System.Drawing.Point(310, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(50, 40);
            this.BtnHistory.TabIndex = 2;
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.ForeColor = System.Drawing.Color.DarkGray;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(360, 25);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.TextChanged += new System.EventHandler(this.TxtDisplay2_TextChanged);
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold);
            this.TxtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 105);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(360, 50);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay1.TextChanged += new System.EventHandler(this.TxtDisplay1_TextChanged);
            // 
            // BtnPrct
            // 
            this.BtnPrct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPrct.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPrct.FlatAppearance.BorderSize = 0;
            this.BtnPrct.Font = new System.Drawing.Font("Gadugi", 12F);
            this.BtnPrct.ForeColor = System.Drawing.Color.White;
            this.BtnPrct.Location = new System.Drawing.Point(0, 183);
            this.BtnPrct.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPrct.Name = "BtnPrct";
            this.BtnPrct.Size = new System.Drawing.Size(84, 59);
            this.BtnPrct.TabIndex = 16;
            this.BtnPrct.Text = "%";
            this.BtnPrct.UseVisualStyleBackColor = false;
            this.BtnPrct.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.Font = new System.Drawing.Font("Gadugi", 12F);
            this.BtnDelete.Location = new System.Drawing.Point(90, 183);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(84, 59);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "CE";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClear.FlatAppearance.BorderSize = 0;
            this.BtnClear.Font = new System.Drawing.Font("Gadugi", 12F);
            this.BtnClear.ForeColor = System.Drawing.Color.Snow;
            this.BtnClear.Location = new System.Drawing.Point(180, 183);
            this.BtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(84, 59);
            this.BtnClear.TabIndex = 18;
            this.BtnClear.Text = "C";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRemove.FlatAppearance.BorderSize = 0;
            this.BtnRemove.Font = new System.Drawing.Font("Gadugi", 12F);
            this.BtnRemove.ForeColor = System.Drawing.Color.White;
            this.BtnRemove.Image = ((System.Drawing.Image)(resources.GetObject("BtnRemove.Image")));
            this.BtnRemove.Location = new System.Drawing.Point(270, 183);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(0);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(84, 59);
            this.BtnRemove.TabIndex = 19;
            this.BtnRemove.UseVisualStyleBackColor = false;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnDevise
            // 
            this.BtnDevise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnDevise.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnDevise.FlatAppearance.BorderSize = 0;
            this.BtnDevise.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnDevise.Location = new System.Drawing.Point(270, 245);
            this.BtnDevise.Margin = new System.Windows.Forms.Padding(0);
            this.BtnDevise.Name = "BtnDevise";
            this.BtnDevise.Size = new System.Drawing.Size(84, 59);
            this.BtnDevise.TabIndex = 23;
            this.BtnDevise.Text = "÷";
            this.BtnDevise.UseVisualStyleBackColor = false;
            this.BtnDevise.Click += new System.EventHandler(this.button7_Click);
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSqrt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSqrt.FlatAppearance.BorderSize = 0;
            this.BtnSqrt.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnSqrt.Location = new System.Drawing.Point(180, 245);
            this.BtnSqrt.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(84, 59);
            this.BtnSqrt.TabIndex = 22;
            this.BtnSqrt.Text = "√x";
            this.BtnSqrt.UseVisualStyleBackColor = false;
            this.BtnSqrt.Click += new System.EventHandler(this.button8_Click);
            // 
            // BtnPow
            // 
            this.BtnPow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPow.FlatAppearance.BorderSize = 0;
            this.BtnPow.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnPow.Location = new System.Drawing.Point(90, 245);
            this.BtnPow.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPow.Name = "BtnPow";
            this.BtnPow.Size = new System.Drawing.Size(84, 59);
            this.BtnPow.TabIndex = 21;
            this.BtnPow.Text = "x²";
            this.BtnPow.UseVisualStyleBackColor = false;
            this.BtnPow.Click += new System.EventHandler(this.button9_Click);
            // 
            // BtnReverse
            // 
            this.BtnReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnReverse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnReverse.FlatAppearance.BorderSize = 0;
            this.BtnReverse.Font = new System.Drawing.Font("Gadugi", 12F);
            this.BtnReverse.Location = new System.Drawing.Point(0, 245);
            this.BtnReverse.Margin = new System.Windows.Forms.Padding(0);
            this.BtnReverse.Name = "BtnReverse";
            this.BtnReverse.Size = new System.Drawing.Size(84, 59);
            this.BtnReverse.TabIndex = 20;
            this.BtnReverse.Text = "1/x";
            this.BtnReverse.UseVisualStyleBackColor = false;
            this.BtnReverse.Click += new System.EventHandler(this.button10_Click);
            // 
            // BtnMultp
            // 
            this.BtnMultp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnMultp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnMultp.FlatAppearance.BorderSize = 0;
            this.BtnMultp.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnMultp.Location = new System.Drawing.Point(270, 306);
            this.BtnMultp.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMultp.Name = "BtnMultp";
            this.BtnMultp.Size = new System.Drawing.Size(84, 59);
            this.BtnMultp.TabIndex = 27;
            this.BtnMultp.Text = "x";
            this.BtnMultp.UseVisualStyleBackColor = false;
            this.BtnMultp.Click += new System.EventHandler(this.button11_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn9.Location = new System.Drawing.Point(180, 306);
            this.Btn9.Margin = new System.Windows.Forms.Padding(0);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(84, 59);
            this.Btn9.TabIndex = 26;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.button12_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn8.Location = new System.Drawing.Point(90, 306);
            this.Btn8.Margin = new System.Windows.Forms.Padding(0);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(84, 59);
            this.Btn8.TabIndex = 25;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.button13_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn7.Location = new System.Drawing.Point(0, 306);
            this.Btn7.Margin = new System.Windows.Forms.Padding(0);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(84, 59);
            this.Btn7.TabIndex = 24;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.button14_Click);
            // 
            // BtnSous
            // 
            this.BtnSous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnSous.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnSous.FlatAppearance.BorderSize = 0;
            this.BtnSous.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnSous.Location = new System.Drawing.Point(270, 367);
            this.BtnSous.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSous.Name = "BtnSous";
            this.BtnSous.Size = new System.Drawing.Size(84, 59);
            this.BtnSous.TabIndex = 31;
            this.BtnSous.Text = "-";
            this.BtnSous.UseVisualStyleBackColor = false;
            this.BtnSous.Click += new System.EventHandler(this.button15_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn6.Location = new System.Drawing.Point(180, 367);
            this.Btn6.Margin = new System.Windows.Forms.Padding(0);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(84, 59);
            this.Btn6.TabIndex = 30;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.button16_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn5.Location = new System.Drawing.Point(90, 367);
            this.Btn5.Margin = new System.Windows.Forms.Padding(0);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(84, 59);
            this.Btn5.TabIndex = 29;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.button17_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn4.Location = new System.Drawing.Point(0, 367);
            this.Btn4.Margin = new System.Windows.Forms.Padding(0);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(84, 59);
            this.Btn4.TabIndex = 28;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.button18_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.Font = new System.Drawing.Font("Gadugi", 16F);
            this.BtnAdd.Location = new System.Drawing.Point(270, 429);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(84, 59);
            this.BtnAdd.TabIndex = 35;
            this.BtnAdd.Text = "+";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.button19_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn3.Location = new System.Drawing.Point(180, 429);
            this.Btn3.Margin = new System.Windows.Forms.Padding(0);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(84, 59);
            this.Btn3.TabIndex = 34;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.button20_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.Font = new System.Drawing.Font("Gadugi", 16F);
            this.Btn2.Location = new System.Drawing.Point(90, 429);
            this.Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(84, 59);
            this.Btn2.TabIndex = 33;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.button21_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.Location = new System.Drawing.Point(0, 429);
            this.Btn1.Margin = new System.Windows.Forms.Padding(0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(84, 59);
            this.Btn1.TabIndex = 32;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.button22_Click);
            // 
            // BtnEgal
            // 
            this.BtnEgal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnEgal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnEgal.FlatAppearance.BorderSize = 0;
            this.BtnEgal.Location = new System.Drawing.Point(270, 494);
            this.BtnEgal.Margin = new System.Windows.Forms.Padding(0);
            this.BtnEgal.Name = "BtnEgal";
            this.BtnEgal.Size = new System.Drawing.Size(84, 59);
            this.BtnEgal.TabIndex = 39;
            this.BtnEgal.Text = "=";
            this.BtnEgal.UseVisualStyleBackColor = false;
            this.BtnEgal.Click += new System.EventHandler(this.button23_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnPoint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnPoint.FlatAppearance.BorderSize = 0;
            this.BtnPoint.Location = new System.Drawing.Point(180, 494);
            this.BtnPoint.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(84, 59);
            this.BtnPoint.TabIndex = 38;
            this.BtnPoint.Tag = "";
            this.BtnPoint.Text = ".";
            this.BtnPoint.UseVisualStyleBackColor = false;
            this.BtnPoint.Click += new System.EventHandler(this.button24_Click);
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Btn0.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.Location = new System.Drawing.Point(90, 494);
            this.Btn0.Margin = new System.Windows.Forms.Padding(0);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(84, 59);
            this.Btn0.TabIndex = 37;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.button25_Click);
            // 
            // BtnNeg
            // 
            this.BtnNeg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BtnNeg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnNeg.FlatAppearance.BorderSize = 0;
            this.BtnNeg.Location = new System.Drawing.Point(0, 494);
            this.BtnNeg.Margin = new System.Windows.Forms.Padding(0);
            this.BtnNeg.Name = "BtnNeg";
            this.BtnNeg.Size = new System.Drawing.Size(84, 59);
            this.BtnNeg.TabIndex = 36;
            this.BtnNeg.Text = "+/-";
            this.BtnNeg.UseVisualStyleBackColor = false;
            this.BtnNeg.Click += new System.EventHandler(this.button26_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(360, 570);
            this.Controls.Add(this.BtnEgal);
            this.Controls.Add(this.BtnPoint);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.BtnNeg);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.BtnSous);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.BtnMultp);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnDevise);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnPow);
            this.Controls.Add(this.BtnReverse);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnPrct);
            this.Controls.Add(this.TxtDisplay1);
            this.Controls.Add(this.TxtDisplay2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 16F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnMenu;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.Button BtnEgal;
        private System.Windows.Forms.Button BtnPoint;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnNeg;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button BtnSous;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button BtnMultp;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button BtnDevise;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnPow;
        private System.Windows.Forms.Button BtnReverse;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPrct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

