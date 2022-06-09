namespace Sliding_Puzzle
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
            this.TimeCount = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.gName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pName = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeCount
            // 
            this.TimeCount.Enabled = true;
            this.TimeCount.Interval = 1000;
            this.TimeCount.Tick += new System.EventHandler(this.TimeCount_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 495);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mix the pic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gName
            // 
            this.gName.AutoSize = true;
            this.gName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gName.Location = new System.Drawing.Point(94, 9);
            this.gName.Name = "gName";
            this.gName.Size = new System.Drawing.Size(184, 31);
            this.gName.TabIndex = 2;
            this.gName.Text = "Sliding Puzzle";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox16, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox15, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox12, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox11, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 93);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(380, 396);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(287, 299);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(86, 90);
            this.pictureBox16.TabIndex = 15;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(193, 299);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(86, 90);
            this.pictureBox15.TabIndex = 14;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(99, 299);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(86, 90);
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(5, 299);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(86, 90);
            this.pictureBox13.TabIndex = 12;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(287, 201);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(86, 90);
            this.pictureBox12.TabIndex = 11;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(193, 201);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(86, 90);
            this.pictureBox11.TabIndex = 10;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(99, 201);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(86, 90);
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(5, 201);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(86, 90);
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(287, 103);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(86, 90);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(193, 103);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(86, 90);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(99, 103);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(86, 90);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(5, 103);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(86, 90);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(287, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 90);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(193, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(86, 90);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(99, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(86, 90);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 90);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pName
            // 
            this.pName.AutoSize = true;
            this.pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.pName.Location = new System.Drawing.Point(12, 53);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(0, 18);
            this.pName.TabIndex = 4;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Time.Location = new System.Drawing.Point(284, 53);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(0, 17);
            this.Time.TabIndex = 5;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(5, 495);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(118, 34);
            this.show.TabIndex = 6;
            this.show.Text = "Show picture (Reset)";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(129, 495);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Finish";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(378, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.show);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimeCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label gName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label pName;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

