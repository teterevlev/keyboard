namespace keyboard_tester
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer2sec = new System.Windows.Forms.Timer(this.components);
            this.portList = new System.Windows.Forms.ListBox();
            this.openPortCheckbox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Online = new System.Windows.Forms.ProgressBar();
            this.log = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ProgramButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.trackBar10 = new System.Windows.Forms.TrackBar();
            this.trackBar11 = new System.Windows.Forms.TrackBar();
            this.trackBar12 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox10 = new System.Windows.Forms.ListBox();
            this.listBox11 = new System.Windows.Forms.ListBox();
            this.listBox12 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer2sec
            // 
            this.timer2sec.Enabled = true;
            this.timer2sec.Interval = 2000;
            this.timer2sec.Tick += new System.EventHandler(this.timer2sec_Tick);
            // 
            // portList
            // 
            this.portList.FormattingEnabled = true;
            this.portList.Location = new System.Drawing.Point(12, 23);
            this.portList.Name = "portList";
            this.portList.Size = new System.Drawing.Size(75, 43);
            this.portList.TabIndex = 15;
            this.portList.SelectedValueChanged += new System.EventHandler(this.portList_SelectedValueChanged);
            // 
            // openPortCheckbox
            // 
            this.openPortCheckbox.AutoSize = true;
            this.openPortCheckbox.Location = new System.Drawing.Point(12, 72);
            this.openPortCheckbox.Name = "openPortCheckbox";
            this.openPortCheckbox.Size = new System.Drawing.Size(75, 17);
            this.openPortCheckbox.TabIndex = 16;
            this.openPortCheckbox.Text = "Auto open";
            this.openPortCheckbox.UseVisualStyleBackColor = true;
            this.openPortCheckbox.CheckedChanged += new System.EventHandler(this.openPortCheckbox_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Online, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.log, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(355, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 97.02602F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 703);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // Online
            // 
            this.Online.Location = new System.Drawing.Point(3, 686);
            this.Online.Name = "Online";
            this.Online.Size = new System.Drawing.Size(329, 10);
            this.Online.Step = 100;
            this.Online.TabIndex = 23;
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log.ForeColor = System.Drawing.Color.Silver;
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.ReadOnly = true;
            this.log.Size = new System.Drawing.Size(329, 677);
            this.log.TabIndex = 14;
            this.log.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Serial port";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(127, 72);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Fuses";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(127, 52);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(68, 17);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "Firmware";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // ProgramButton
            // 
            this.ProgramButton.Location = new System.Drawing.Point(127, 23);
            this.ProgramButton.Name = "ProgramButton";
            this.ProgramButton.Size = new System.Drawing.Size(75, 23);
            this.ProgramButton.TabIndex = 27;
            this.ProgramButton.Text = "Program";
            this.ProgramButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Programmer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Light";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 676);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "FF";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 22);
            this.button1.TabIndex = 32;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 660);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Hex message:";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(128, 659);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox3.Size = new System.Drawing.Size(74, 17);
            this.checkBox3.TabIndex = 34;
            this.checkBox3.Text = "Auto send";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.Tomato;
            this.trackBar1.LargeChange = 16;
            this.trackBar1.Location = new System.Drawing.Point(9, 453);
            this.trackBar1.Maximum = 255;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(128, 20);
            this.trackBar1.TabIndex = 35;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar2
            // 
            this.trackBar2.AutoSize = false;
            this.trackBar2.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBar2.LargeChange = 16;
            this.trackBar2.Location = new System.Drawing.Point(9, 473);
            this.trackBar2.Maximum = 255;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(128, 20);
            this.trackBar2.TabIndex = 36;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar3
            // 
            this.trackBar3.AutoSize = false;
            this.trackBar3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar3.LargeChange = 16;
            this.trackBar3.Location = new System.Drawing.Point(9, 493);
            this.trackBar3.Maximum = 255;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(128, 20);
            this.trackBar3.TabIndex = 37;
            this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar4
            // 
            this.trackBar4.AutoSize = false;
            this.trackBar4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar4.LargeChange = 16;
            this.trackBar4.Location = new System.Drawing.Point(9, 578);
            this.trackBar4.Maximum = 255;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(128, 20);
            this.trackBar4.TabIndex = 40;
            this.trackBar4.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar5
            // 
            this.trackBar5.AutoSize = false;
            this.trackBar5.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBar5.LargeChange = 16;
            this.trackBar5.Location = new System.Drawing.Point(9, 558);
            this.trackBar5.Maximum = 255;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(128, 20);
            this.trackBar5.TabIndex = 39;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar6
            // 
            this.trackBar6.AutoSize = false;
            this.trackBar6.BackColor = System.Drawing.Color.Tomato;
            this.trackBar6.LargeChange = 16;
            this.trackBar6.Location = new System.Drawing.Point(9, 538);
            this.trackBar6.Maximum = 255;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(128, 20);
            this.trackBar6.TabIndex = 38;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar7
            // 
            this.trackBar7.AutoSize = false;
            this.trackBar7.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar7.LargeChange = 16;
            this.trackBar7.Location = new System.Drawing.Point(177, 493);
            this.trackBar7.Maximum = 255;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(128, 20);
            this.trackBar7.TabIndex = 43;
            this.trackBar7.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar8
            // 
            this.trackBar8.AutoSize = false;
            this.trackBar8.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBar8.LargeChange = 16;
            this.trackBar8.Location = new System.Drawing.Point(177, 473);
            this.trackBar8.Maximum = 255;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(128, 20);
            this.trackBar8.TabIndex = 42;
            this.trackBar8.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar9
            // 
            this.trackBar9.AutoSize = false;
            this.trackBar9.BackColor = System.Drawing.Color.Tomato;
            this.trackBar9.LargeChange = 16;
            this.trackBar9.Location = new System.Drawing.Point(177, 453);
            this.trackBar9.Maximum = 255;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(128, 20);
            this.trackBar9.TabIndex = 41;
            this.trackBar9.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar10
            // 
            this.trackBar10.AutoSize = false;
            this.trackBar10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trackBar10.LargeChange = 16;
            this.trackBar10.Location = new System.Drawing.Point(177, 578);
            this.trackBar10.Maximum = 255;
            this.trackBar10.Name = "trackBar10";
            this.trackBar10.Size = new System.Drawing.Size(128, 20);
            this.trackBar10.TabIndex = 46;
            this.trackBar10.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar11
            // 
            this.trackBar11.AutoSize = false;
            this.trackBar11.BackColor = System.Drawing.Color.LimeGreen;
            this.trackBar11.LargeChange = 16;
            this.trackBar11.Location = new System.Drawing.Point(177, 558);
            this.trackBar11.Maximum = 255;
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Size = new System.Drawing.Size(128, 20);
            this.trackBar11.TabIndex = 45;
            this.trackBar11.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // trackBar12
            // 
            this.trackBar12.AutoSize = false;
            this.trackBar12.BackColor = System.Drawing.Color.Tomato;
            this.trackBar12.LargeChange = 16;
            this.trackBar12.Location = new System.Drawing.Point(177, 538);
            this.trackBar12.Maximum = 255;
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Size = new System.Drawing.Size(128, 20);
            this.trackBar12.TabIndex = 44;
            this.trackBar12.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Keys";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.ColumnWidth = 30;
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Items.AddRange(new object[] {
            " 1",
            " 2"});
            this.listBox2.Location = new System.Drawing.Point(12, 288);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(62, 25);
            this.listBox2.TabIndex = 51;
            // 
            // listBox3
            // 
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.ColumnWidth = 30;
            this.listBox3.Enabled = false;
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Items.AddRange(new object[] {
            " 3",
            " 4"});
            this.listBox3.Location = new System.Drawing.Point(222, 288);
            this.listBox3.MultiColumn = true;
            this.listBox3.Name = "listBox3";
            this.listBox3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox3.Size = new System.Drawing.Size(62, 25);
            this.listBox3.TabIndex = 52;
            // 
            // listBox4
            // 
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.ColumnWidth = 30;
            this.listBox4.Enabled = false;
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 25;
            this.listBox4.Items.AddRange(new object[] {
            " 5",
            " 6",
            " 7",
            " 8",
            " 9",
            "10"});
            this.listBox4.Location = new System.Drawing.Point(41, 326);
            this.listBox4.MultiColumn = true;
            this.listBox4.Name = "listBox4";
            this.listBox4.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox4.Size = new System.Drawing.Size(186, 25);
            this.listBox4.TabIndex = 53;
            // 
            // listBox5
            // 
            this.listBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox5.ColumnWidth = 30;
            this.listBox5.Enabled = false;
            this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 25;
            this.listBox5.Items.AddRange(new object[] {
            "12"});
            this.listBox5.Location = new System.Drawing.Point(152, 363);
            this.listBox5.MultiColumn = true;
            this.listBox5.Name = "listBox5";
            this.listBox5.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox5.Size = new System.Drawing.Size(29, 25);
            this.listBox5.TabIndex = 55;
            // 
            // listBox6
            // 
            this.listBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox6.ColumnWidth = 30;
            this.listBox6.Enabled = false;
            this.listBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 25;
            this.listBox6.Items.AddRange(new object[] {
            "11"});
            this.listBox6.Location = new System.Drawing.Point(69, 363);
            this.listBox6.MultiColumn = true;
            this.listBox6.Name = "listBox6";
            this.listBox6.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox6.Size = new System.Drawing.Size(27, 25);
            this.listBox6.TabIndex = 54;
            // 
            // listBox7
            // 
            this.listBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox7.ColumnWidth = 30;
            this.listBox7.Enabled = false;
            this.listBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 25;
            this.listBox7.Items.AddRange(new object[] {
            "13",
            "14",
            "15",
            "16"});
            this.listBox7.Location = new System.Drawing.Point(304, 288);
            this.listBox7.MultiColumn = true;
            this.listBox7.Name = "listBox7";
            this.listBox7.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox7.Size = new System.Drawing.Size(39, 100);
            this.listBox7.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "RGB";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ColumnWidth = 30;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "13",
            "14",
            "15",
            "16"});
            this.listBox1.Location = new System.Drawing.Point(304, 138);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(39, 100);
            this.listBox1.TabIndex = 63;
            // 
            // listBox8
            // 
            this.listBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox8.ColumnWidth = 30;
            this.listBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 25;
            this.listBox8.Items.AddRange(new object[] {
            "12"});
            this.listBox8.Location = new System.Drawing.Point(152, 213);
            this.listBox8.MultiColumn = true;
            this.listBox8.Name = "listBox8";
            this.listBox8.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox8.Size = new System.Drawing.Size(29, 25);
            this.listBox8.TabIndex = 62;
            // 
            // listBox9
            // 
            this.listBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox9.ColumnWidth = 30;
            this.listBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 25;
            this.listBox9.Items.AddRange(new object[] {
            "11"});
            this.listBox9.Location = new System.Drawing.Point(69, 213);
            this.listBox9.MultiColumn = true;
            this.listBox9.Name = "listBox9";
            this.listBox9.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox9.Size = new System.Drawing.Size(27, 25);
            this.listBox9.TabIndex = 61;
            // 
            // listBox10
            // 
            this.listBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox10.ColumnWidth = 30;
            this.listBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 25;
            this.listBox10.Items.AddRange(new object[] {
            " 5",
            " 6",
            " 7",
            " 8",
            " 9",
            "10"});
            this.listBox10.Location = new System.Drawing.Point(41, 176);
            this.listBox10.MultiColumn = true;
            this.listBox10.Name = "listBox10";
            this.listBox10.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox10.Size = new System.Drawing.Size(186, 25);
            this.listBox10.TabIndex = 60;
            // 
            // listBox11
            // 
            this.listBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox11.ColumnWidth = 30;
            this.listBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox11.FormattingEnabled = true;
            this.listBox11.ItemHeight = 25;
            this.listBox11.Items.AddRange(new object[] {
            " 3",
            " 4"});
            this.listBox11.Location = new System.Drawing.Point(222, 138);
            this.listBox11.MultiColumn = true;
            this.listBox11.Name = "listBox11";
            this.listBox11.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox11.Size = new System.Drawing.Size(62, 25);
            this.listBox11.TabIndex = 59;
            // 
            // listBox12
            // 
            this.listBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox12.ColumnWidth = 30;
            this.listBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox12.FormattingEnabled = true;
            this.listBox12.ItemHeight = 25;
            this.listBox12.Items.AddRange(new object[] {
            " 1",
            " 2"});
            this.listBox12.Location = new System.Drawing.Point(12, 138);
            this.listBox12.MultiColumn = true;
            this.listBox12.Name = "listBox12";
            this.listBox12.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox12.Size = new System.Drawing.Size(62, 25);
            this.listBox12.TabIndex = 58;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(690, 703);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.listBox9);
            this.Controls.Add(this.listBox10);
            this.Controls.Add(this.listBox11);
            this.Controls.Add(this.listBox12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar10);
            this.Controls.Add(this.trackBar11);
            this.Controls.Add(this.trackBar12);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProgramButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.openPortCheckbox);
            this.Controls.Add(this.portList);
            this.MinimumSize = new System.Drawing.Size(570, 520);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer2sec;
        private System.Windows.Forms.ListBox portList;
        private System.Windows.Forms.CheckBox openPortCheckbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar Online;
        private System.Windows.Forms.RichTextBox log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button ProgramButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.TrackBar trackBar10;
        private System.Windows.Forms.TrackBar trackBar11;
        private System.Windows.Forms.TrackBar trackBar12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.ListBox listBox7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox8;
        private System.Windows.Forms.ListBox listBox9;
        private System.Windows.Forms.ListBox listBox10;
        private System.Windows.Forms.ListBox listBox11;
        private System.Windows.Forms.ListBox listBox12;
    }
}

