namespace WindowsFormsApp2
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
            this.PictureBoxAsli = new System.Windows.Forms.PictureBox();
            this.textBoxBrigthness = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PictureBoxHasil = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxTreshold = new System.Windows.Forms.TextBox();
            this.pictureBoxHistogram = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.pembobotan = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.pictureBoxEqualization = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.kotakB = new System.Windows.Forms.TextBox();
            this.kotakG = new System.Windows.Forms.TextBox();
            this.kotakR = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.kotakB2 = new System.Windows.Forms.TextBox();
            this.kotakG2 = new System.Windows.Forms.TextBox();
            this.kotakR2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAsli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembobotan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqualization)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxAsli
            // 
            this.PictureBoxAsli.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxAsli.Image")));
            this.PictureBoxAsli.Location = new System.Drawing.Point(34, 93);
            this.PictureBoxAsli.Name = "PictureBoxAsli";
            this.PictureBoxAsli.Size = new System.Drawing.Size(339, 233);
            this.PictureBoxAsli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxAsli.TabIndex = 0;
            this.PictureBoxAsli.TabStop = false;
            this.PictureBoxAsli.Click += new System.EventHandler(this.PictureBoxAsli_Click);
            // 
            // textBoxBrigthness
            // 
            this.textBoxBrigthness.Location = new System.Drawing.Point(34, 376);
            this.textBoxBrigthness.Name = "textBoxBrigthness";
            this.textBoxBrigthness.Size = new System.Drawing.Size(42, 20);
            this.textBoxBrigthness.TabIndex = 1;
            this.textBoxBrigthness.TextChanged += new System.EventHandler(this.brigtness_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Brigthness";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Brigthness";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PictureBoxHasil
            // 
            this.PictureBoxHasil.Location = new System.Drawing.Point(386, 93);
            this.PictureBoxHasil.Name = "PictureBoxHasil";
            this.PictureBoxHasil.Size = new System.Drawing.Size(339, 233);
            this.PictureBoxHasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxHasil.TabIndex = 4;
            this.PictureBoxHasil.TabStop = false;
            this.PictureBoxHasil.Click += new System.EventHandler(this.PictureBoxHasil_Click);
            this.PictureBoxHasil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxHasil_MouseClick);
            this.PictureBoxHasil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBoxHasil_MouseMove);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 376);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Gray Scale";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(188, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "Invert";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "Tresholding";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxTreshold
            // 
            this.textBoxTreshold.Location = new System.Drawing.Point(269, 353);
            this.textBoxTreshold.Name = "textBoxTreshold";
            this.textBoxTreshold.Size = new System.Drawing.Size(36, 20);
            this.textBoxTreshold.TabIndex = 9;
            this.textBoxTreshold.TextChanged += new System.EventHandler(this.textBoxTreshold_TextChanged);
            // 
            // pictureBoxHistogram
            // 
            this.pictureBoxHistogram.Location = new System.Drawing.Point(596, 383);
            this.pictureBoxHistogram.Name = "pictureBoxHistogram";
            this.pictureBoxHistogram.Size = new System.Drawing.Size(339, 233);
            this.pictureBoxHistogram.TabIndex = 10;
            this.pictureBoxHistogram.TabStop = false;
            this.pictureBoxHistogram.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(602, 343);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 34);
            this.button5.TabIndex = 11;
            this.button5.Text = "Histogram";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(31, 334);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Ganti Gambar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(438, 351);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(34, 20);
            this.textBoxX.TabIndex = 13;
            this.textBoxX.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(482, 351);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(34, 20);
            this.textBoxY.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Koordinat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Intensitas";
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(484, 428);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(34, 20);
            this.textBoxG.TabIndex = 20;
            // 
            // textBoxR
            // 
            this.textBoxR.Location = new System.Drawing.Point(444, 428);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(34, 20);
            this.textBoxR.TabIndex = 19;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(524, 428);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(34, 20);
            this.textBoxB.TabIndex = 21;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(454, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "G";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(531, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "B";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(387, 386);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(196, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Process";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "GAMBAR ASLI";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "HASIL IMAGE PROCEESSING";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(599, 383);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "HISTOGRAM";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(107, 417);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 58);
            this.button8.TabIndex = 29;
            this.button8.Text = "Grayscale Pembobotan [Luma]";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pembobotan
            // 
            this.pembobotan.Location = new System.Drawing.Point(738, 50);
            this.pembobotan.Name = "pembobotan";
            this.pembobotan.Size = new System.Drawing.Size(339, 233);
            this.pembobotan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pembobotan.TabIndex = 30;
            this.pembobotan.TabStop = false;
            this.pembobotan.Click += new System.EventHandler(this.pembobotan_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(735, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "GRAYSCALE PEMBOBOTAN MENGGUNAKAN METODE LUMA";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(965, 342);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 34);
            this.button9.TabIndex = 32;
            this.button9.Text = "Equalization";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // pictureBoxEqualization
            // 
            this.pictureBoxEqualization.Location = new System.Drawing.Point(965, 383);
            this.pictureBoxEqualization.Name = "pictureBoxEqualization";
            this.pictureBoxEqualization.Size = new System.Drawing.Size(339, 233);
            this.pictureBoxEqualization.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEqualization.TabIndex = 33;
            this.pictureBoxEqualization.TabStop = false;
            this.pictureBoxEqualization.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(966, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "EQUALIZATION";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(460, 4);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(58, 20);
            this.textBoxX2.TabIndex = 35;
            this.textBoxX2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBoxX3
            // 
            this.textBoxX3.Location = new System.Drawing.Point(631, 4);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(58, 20);
            this.textBoxX3.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(543, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "B";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(508, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "G";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(466, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "R";
            // 
            // kotakB
            // 
            this.kotakB.Location = new System.Drawing.Point(536, 47);
            this.kotakB.Name = "kotakB";
            this.kotakB.Size = new System.Drawing.Size(34, 20);
            this.kotakB.TabIndex = 40;
            // 
            // kotakG
            // 
            this.kotakG.Location = new System.Drawing.Point(496, 47);
            this.kotakG.Name = "kotakG";
            this.kotakG.Size = new System.Drawing.Size(34, 20);
            this.kotakG.TabIndex = 39;
            // 
            // kotakR
            // 
            this.kotakR.Location = new System.Drawing.Point(456, 47);
            this.kotakR.Name = "kotakR";
            this.kotakR.Size = new System.Drawing.Size(34, 20);
            this.kotakR.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(392, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Intensitas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(686, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "B";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(651, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 13);
            this.label19.TabIndex = 48;
            this.label19.Text = "G";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(609, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "R";
            // 
            // kotakB2
            // 
            this.kotakB2.Location = new System.Drawing.Point(679, 47);
            this.kotakB2.Name = "kotakB2";
            this.kotakB2.Size = new System.Drawing.Size(34, 20);
            this.kotakB2.TabIndex = 46;
            // 
            // kotakG2
            // 
            this.kotakG2.Location = new System.Drawing.Point(639, 47);
            this.kotakG2.Name = "kotakG2";
            this.kotakG2.Size = new System.Drawing.Size(34, 20);
            this.kotakG2.TabIndex = 45;
            // 
            // kotakR2
            // 
            this.kotakR2.Location = new System.Drawing.Point(599, 47);
            this.kotakR2.Name = "kotakR2";
            this.kotakR2.Size = new System.Drawing.Size(34, 20);
            this.kotakR2.TabIndex = 44;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.kotakB2);
            this.Controls.Add(this.kotakG2);
            this.Controls.Add(this.kotakR2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.kotakB);
            this.Controls.Add(this.kotakG);
            this.Controls.Add(this.kotakR);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBoxEqualization);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pembobotan);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBoxHistogram);
            this.Controls.Add(this.textBoxTreshold);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PictureBoxHasil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBrigthness);
            this.Controls.Add(this.PictureBoxAsli);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxAsli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxHasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHistogram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pembobotan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqualization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxAsli;
        private System.Windows.Forms.TextBox textBoxBrigthness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox PictureBoxHasil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBoxTreshold;
        private System.Windows.Forms.PictureBox pictureBoxHistogram;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pembobotan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.PictureBox pictureBoxEqualization;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox kotakB;
        private System.Windows.Forms.TextBox kotakG;
        private System.Windows.Forms.TextBox kotakR;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox kotakB2;
        private System.Windows.Forms.TextBox kotakG2;
        private System.Windows.Forms.TextBox kotakR2;
    }
}

