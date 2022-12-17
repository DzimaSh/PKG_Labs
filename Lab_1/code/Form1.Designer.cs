
namespace ColorConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbVariants = new System.Windows.Forms.ComboBox();
            this.pColorPad = new System.Windows.Forms.PictureBox();
            this.pPalette = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tBox12 = new System.Windows.Forms.TextBox();
            this.tBox11 = new System.Windows.Forms.TextBox();
            this.tBox10 = new System.Windows.Forms.TextBox();
            this.tBox9 = new System.Windows.Forms.TextBox();
            this.tBox8 = new System.Windows.Forms.TextBox();
            this.tBox7 = new System.Windows.Forms.TextBox();
            this.tBox6 = new System.Windows.Forms.TextBox();
            this.tBox5 = new System.Windows.Forms.TextBox();
            this.tBox4 = new System.Windows.Forms.TextBox();
            this.tBox3 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.trackBar34 = new System.Windows.Forms.TrackBar();
            this.trackBar33 = new System.Windows.Forms.TrackBar();
            this.trackBar32 = new System.Windows.Forms.TrackBar();
            this.trackBar31 = new System.Windows.Forms.TrackBar();
            this.trackBar24 = new System.Windows.Forms.TrackBar();
            this.trackBar23 = new System.Windows.Forms.TrackBar();
            this.trackBar22 = new System.Windows.Forms.TrackBar();
            this.trackBar21 = new System.Windows.Forms.TrackBar();
            this.trackBar14 = new System.Windows.Forms.TrackBar();
            this.trackBar13 = new System.Windows.Forms.TrackBar();
            this.trackBar12 = new System.Windows.Forms.TrackBar();
            this.trackBar11 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pColorPad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPalette)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).BeginInit();
            this.SuspendLayout();
            // 
            // cbVariants
            // 
            this.cbVariants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVariants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVariants.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbVariants.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbVariants.Items.AddRange(new object[] {
            "RGB ↔ LAB ↔ CMYK",
            "RGB ↔ CMYK ↔ HSL",
            "RGB ↔ XYZ ↔ LAB",
            "RGB ↔ HSV ↔ LAB",
            "CMYK ↔ LAB ↔ HSV",
            "CMYK ↔ RGB ↔ HSL",
            "CMYK ↔ RGB ↔ HSV",
            "RGB ↔ XYZ ↔ HSV",
            "HSV ↔ XYZ ↔ LAB",
            "CMYK ↔ LAB ↔ RGB",
            "XYZ ↔ LAB ↔ HSL",
            "RGB ↔ XYZ ↔ HSL",
            "RGB ↔ XYZ ↔ CMYK",
            "CMYK ↔ LAB ↔ XYZ",
            "RGB ↔ CMYK ↔ HSV",
            "CMYK ↔ HSL ↔ XYZ",
            "RGB ↔ HSL ↔ LAB",
            "CMYK ↔ XYZ ↔ RGB"});
            this.cbVariants.Location = new System.Drawing.Point(47, 280);
            this.cbVariants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVariants.Name = "cbVariants";
            this.cbVariants.Size = new System.Drawing.Size(170, 23);
            this.cbVariants.TabIndex = 21;
            this.cbVariants.SelectedIndexChanged += new System.EventHandler(this.cbVariants_SelectedIndexChanged);
            // 
            // pColorPad
            // 
            this.pColorPad.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pColorPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorPad.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pColorPad.Image = ((System.Drawing.Image)(resources.GetObject("pColorPad.Image")));
            this.pColorPad.Location = new System.Drawing.Point(10, 9);
            this.pColorPad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pColorPad.Name = "pColorPad";
            this.pColorPad.Size = new System.Drawing.Size(352, 235);
            this.pColorPad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pColorPad.TabIndex = 1;
            this.pColorPad.TabStop = false;
            this.pColorPad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pColorPad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pColorPad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pPalette
            // 
            this.pPalette.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pPalette.BackColor = System.Drawing.Color.White;
            this.pPalette.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pPalette.Location = new System.Drawing.Point(378, 9);
            this.pPalette.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPalette.Name = "pPalette";
            this.pPalette.Size = new System.Drawing.Size(170, 55);
            this.pPalette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pPalette.TabIndex = 13;
            this.pPalette.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "RGB";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "HSL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(9, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "XYZ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.tBox12);
            this.panel1.Controls.Add(this.tBox11);
            this.panel1.Controls.Add(this.tBox10);
            this.panel1.Controls.Add(this.tBox9);
            this.panel1.Controls.Add(this.tBox8);
            this.panel1.Controls.Add(this.tBox7);
            this.panel1.Controls.Add(this.tBox6);
            this.panel1.Controls.Add(this.tBox5);
            this.panel1.Controls.Add(this.tBox4);
            this.panel1.Controls.Add(this.tBox3);
            this.panel1.Controls.Add(this.tBox2);
            this.panel1.Controls.Add(this.tBox1);
            this.panel1.Controls.Add(this.trackBar34);
            this.panel1.Controls.Add(this.trackBar33);
            this.panel1.Controls.Add(this.trackBar32);
            this.panel1.Controls.Add(this.trackBar31);
            this.panel1.Controls.Add(this.trackBar24);
            this.panel1.Controls.Add(this.trackBar23);
            this.panel1.Controls.Add(this.trackBar22);
            this.panel1.Controls.Add(this.trackBar21);
            this.panel1.Controls.Add(this.trackBar14);
            this.panel1.Controls.Add(this.trackBar13);
            this.panel1.Controls.Add(this.trackBar12);
            this.panel1.Controls.Add(this.trackBar11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(47, 317);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 326);
            this.panel1.TabIndex = 31;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tBox12
            // 
            this.tBox12.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox12.Location = new System.Drawing.Point(66, 300);
            this.tBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox12.Name = "tBox12";
            this.tBox12.Size = new System.Drawing.Size(64, 21);
            this.tBox12.TabIndex = 54;
            this.tBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox12.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox3_KeyUp);
            // 
            // tBox11
            // 
            this.tBox11.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox11.Location = new System.Drawing.Point(66, 275);
            this.tBox11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox11.Name = "tBox11";
            this.tBox11.Size = new System.Drawing.Size(64, 21);
            this.tBox11.TabIndex = 53;
            this.tBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox11.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox3_KeyUp);
            // 
            // tBox10
            // 
            this.tBox10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox10.Location = new System.Drawing.Point(66, 250);
            this.tBox10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox10.Name = "tBox10";
            this.tBox10.Size = new System.Drawing.Size(64, 21);
            this.tBox10.TabIndex = 52;
            this.tBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox10.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox3_KeyUp);
            // 
            // tBox9
            // 
            this.tBox9.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox9.Location = new System.Drawing.Point(66, 226);
            this.tBox9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox9.Name = "tBox9";
            this.tBox9.Size = new System.Drawing.Size(64, 21);
            this.tBox9.TabIndex = 51;
            this.tBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox9.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox3_KeyUp);
            // 
            // tBox8
            // 
            this.tBox8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox8.Location = new System.Drawing.Point(66, 195);
            this.tBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox8.Name = "tBox8";
            this.tBox8.Size = new System.Drawing.Size(64, 21);
            this.tBox8.TabIndex = 50;
            this.tBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox8.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox2_KeyUp);
            // 
            // tBox7
            // 
            this.tBox7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox7.Location = new System.Drawing.Point(66, 170);
            this.tBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox7.Name = "tBox7";
            this.tBox7.Size = new System.Drawing.Size(64, 21);
            this.tBox7.TabIndex = 49;
            this.tBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox7.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox2_KeyUp);
            // 
            // tBox6
            // 
            this.tBox6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox6.Location = new System.Drawing.Point(66, 146);
            this.tBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox6.Name = "tBox6";
            this.tBox6.Size = new System.Drawing.Size(64, 21);
            this.tBox6.TabIndex = 48;
            this.tBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox6.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox2_KeyUp);
            // 
            // tBox5
            // 
            this.tBox5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox5.Location = new System.Drawing.Point(66, 121);
            this.tBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox5.Name = "tBox5";
            this.tBox5.Size = new System.Drawing.Size(64, 21);
            this.tBox5.TabIndex = 47;
            this.tBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox2_KeyUp);
            // 
            // tBox4
            // 
            this.tBox4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox4.Location = new System.Drawing.Point(66, 84);
            this.tBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox4.Name = "tBox4";
            this.tBox4.Size = new System.Drawing.Size(64, 21);
            this.tBox4.TabIndex = 46;
            this.tBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox1_KeyUp);
            // 
            // tBox3
            // 
            this.tBox3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox3.Location = new System.Drawing.Point(66, 59);
            this.tBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox3.Name = "tBox3";
            this.tBox3.Size = new System.Drawing.Size(64, 21);
            this.tBox3.TabIndex = 45;
            this.tBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox1_KeyUp);
            // 
            // tBox2
            // 
            this.tBox2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox2.Location = new System.Drawing.Point(66, 34);
            this.tBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(64, 21);
            this.tBox2.TabIndex = 44;
            this.tBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox1_KeyUp);
            // 
            // tBox1
            // 
            this.tBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox1.Location = new System.Drawing.Point(66, 10);
            this.tBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(64, 21);
            this.tBox1.TabIndex = 43;
            this.tBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.groupBox1_KeyUp);
            // 
            // trackBar34
            // 
            this.trackBar34.LargeChange = 1;
            this.trackBar34.Location = new System.Drawing.Point(134, 300);
            this.trackBar34.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar34.Maximum = 100;
            this.trackBar34.Name = "trackBar34";
            this.trackBar34.Size = new System.Drawing.Size(304, 45);
            this.trackBar34.SmallChange = 100;
            this.trackBar34.TabIndex = 42;
            this.trackBar34.TickFrequency = 100;
            this.trackBar34.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar34.Scroll += new System.EventHandler(this.groupBar3_Scroll);
            // 
            // trackBar33
            // 
            this.trackBar33.LargeChange = 1;
            this.trackBar33.Location = new System.Drawing.Point(134, 275);
            this.trackBar33.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar33.Maximum = 100;
            this.trackBar33.Name = "trackBar33";
            this.trackBar33.Size = new System.Drawing.Size(304, 45);
            this.trackBar33.SmallChange = 100;
            this.trackBar33.TabIndex = 41;
            this.trackBar33.TickFrequency = 100;
            this.trackBar33.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar33.Scroll += new System.EventHandler(this.groupBar3_Scroll);
            // 
            // trackBar32
            // 
            this.trackBar32.LargeChange = 1;
            this.trackBar32.Location = new System.Drawing.Point(134, 250);
            this.trackBar32.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar32.Maximum = 100;
            this.trackBar32.Name = "trackBar32";
            this.trackBar32.Size = new System.Drawing.Size(304, 45);
            this.trackBar32.SmallChange = 100;
            this.trackBar32.TabIndex = 40;
            this.trackBar32.TickFrequency = 100;
            this.trackBar32.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar32.Scroll += new System.EventHandler(this.groupBar3_Scroll);
            // 
            // trackBar31
            // 
            this.trackBar31.LargeChange = 1;
            this.trackBar31.Location = new System.Drawing.Point(134, 226);
            this.trackBar31.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar31.Maximum = 100;
            this.trackBar31.Name = "trackBar31";
            this.trackBar31.Size = new System.Drawing.Size(304, 45);
            this.trackBar31.SmallChange = 100;
            this.trackBar31.TabIndex = 39;
            this.trackBar31.TickFrequency = 100;
            this.trackBar31.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar31.Scroll += new System.EventHandler(this.groupBar3_Scroll);
            // 
            // trackBar24
            // 
            this.trackBar24.LargeChange = 1;
            this.trackBar24.Location = new System.Drawing.Point(134, 193);
            this.trackBar24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar24.Maximum = 100;
            this.trackBar24.Name = "trackBar24";
            this.trackBar24.Size = new System.Drawing.Size(304, 45);
            this.trackBar24.SmallChange = 100;
            this.trackBar24.TabIndex = 38;
            this.trackBar24.TickFrequency = 100;
            this.trackBar24.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar24.Scroll += new System.EventHandler(this.groupBar2_Scroll);
            // 
            // trackBar23
            // 
            this.trackBar23.LargeChange = 1;
            this.trackBar23.Location = new System.Drawing.Point(134, 168);
            this.trackBar23.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar23.Maximum = 100;
            this.trackBar23.Name = "trackBar23";
            this.trackBar23.Size = new System.Drawing.Size(304, 45);
            this.trackBar23.SmallChange = 100;
            this.trackBar23.TabIndex = 37;
            this.trackBar23.TickFrequency = 100;
            this.trackBar23.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar23.Scroll += new System.EventHandler(this.groupBar2_Scroll);
            // 
            // trackBar22
            // 
            this.trackBar22.LargeChange = 1;
            this.trackBar22.Location = new System.Drawing.Point(134, 143);
            this.trackBar22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar22.Maximum = 100;
            this.trackBar22.Name = "trackBar22";
            this.trackBar22.Size = new System.Drawing.Size(304, 45);
            this.trackBar22.SmallChange = 100;
            this.trackBar22.TabIndex = 36;
            this.trackBar22.TickFrequency = 100;
            this.trackBar22.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar22.Scroll += new System.EventHandler(this.groupBar2_Scroll);
            // 
            // trackBar21
            // 
            this.trackBar21.LargeChange = 1;
            this.trackBar21.Location = new System.Drawing.Point(134, 118);
            this.trackBar21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar21.Maximum = 100;
            this.trackBar21.Name = "trackBar21";
            this.trackBar21.Size = new System.Drawing.Size(304, 45);
            this.trackBar21.SmallChange = 100;
            this.trackBar21.TabIndex = 35;
            this.trackBar21.TickFrequency = 100;
            this.trackBar21.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar21.Scroll += new System.EventHandler(this.groupBar2_Scroll);
            // 
            // trackBar14
            // 
            this.trackBar14.LargeChange = 1;
            this.trackBar14.Location = new System.Drawing.Point(134, 84);
            this.trackBar14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar14.Maximum = 100;
            this.trackBar14.Name = "trackBar14";
            this.trackBar14.Size = new System.Drawing.Size(304, 45);
            this.trackBar14.SmallChange = 100;
            this.trackBar14.TabIndex = 34;
            this.trackBar14.TickFrequency = 100;
            this.trackBar14.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar14.Scroll += new System.EventHandler(this.groupBar1_Scroll);
            // 
            // trackBar13
            // 
            this.trackBar13.LargeChange = 1;
            this.trackBar13.Location = new System.Drawing.Point(134, 59);
            this.trackBar13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar13.Maximum = 100;
            this.trackBar13.Name = "trackBar13";
            this.trackBar13.Size = new System.Drawing.Size(304, 45);
            this.trackBar13.SmallChange = 100;
            this.trackBar13.TabIndex = 33;
            this.trackBar13.TickFrequency = 100;
            this.trackBar13.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar13.Scroll += new System.EventHandler(this.groupBar1_Scroll);
            // 
            // trackBar12
            // 
            this.trackBar12.LargeChange = 1;
            this.trackBar12.Location = new System.Drawing.Point(134, 34);
            this.trackBar12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar12.Maximum = 100;
            this.trackBar12.Name = "trackBar12";
            this.trackBar12.Size = new System.Drawing.Size(304, 45);
            this.trackBar12.SmallChange = 100;
            this.trackBar12.TabIndex = 32;
            this.trackBar12.TickFrequency = 100;
            this.trackBar12.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar12.Scroll += new System.EventHandler(this.groupBar1_Scroll);
            // 
            // trackBar11
            // 
            this.trackBar11.LargeChange = 1;
            this.trackBar11.Location = new System.Drawing.Point(134, 10);
            this.trackBar11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trackBar11.Maximum = 100;
            this.trackBar11.Name = "trackBar11";
            this.trackBar11.Size = new System.Drawing.Size(304, 45);
            this.trackBar11.SmallChange = 100;
            this.trackBar11.TabIndex = 31;
            this.trackBar11.TickFrequency = 100;
            this.trackBar11.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar11.Scroll += new System.EventHandler(this.groupBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 654);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pPalette);
            this.Controls.Add(this.cbVariants);
            this.Controls.Add(this.pColorPad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(3502, 3010);
            this.MinimumSize = new System.Drawing.Size(508, 583);
            this.Name = "Form1";
            this.Text = "Color Converter";
            ((System.ComponentModel.ISupportInitialize)(this.pColorPad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPalette)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pColorPad;
        private System.Windows.Forms.PictureBox pPalette;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbVariants;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar34;
        private System.Windows.Forms.TrackBar trackBar33;
        private System.Windows.Forms.TrackBar trackBar32;
        private System.Windows.Forms.TrackBar trackBar31;
        private System.Windows.Forms.TrackBar trackBar24;
        private System.Windows.Forms.TrackBar trackBar23;
        private System.Windows.Forms.TrackBar trackBar22;
        private System.Windows.Forms.TrackBar trackBar21;
        private System.Windows.Forms.TrackBar trackBar14;
        private System.Windows.Forms.TrackBar trackBar13;
        private System.Windows.Forms.TrackBar trackBar12;
        private System.Windows.Forms.TrackBar trackBar11;
        private System.Windows.Forms.TextBox tBox4;
        private System.Windows.Forms.TextBox tBox3;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox8;
        private System.Windows.Forms.TextBox tBox7;
        private System.Windows.Forms.TextBox tBox6;
        private System.Windows.Forms.TextBox tBox5;
        private System.Windows.Forms.TextBox tBox12;
        private System.Windows.Forms.TextBox tBox11;
        private System.Windows.Forms.TextBox tBox10;
        private System.Windows.Forms.TextBox tBox9;
    }
}

