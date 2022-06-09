namespace Sliding_Puzzle
{
    partial class SplashScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileName = new System.Windows.Forms.TextBox();
            this.Preview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(76, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.name.Location = new System.Drawing.Point(99, 69);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(126, 20);
            this.name.TabIndex = 4;
            this.name.Text = "Enter your name";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(71, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sliding Puzzle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(99, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose a picture";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Upload picture";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(76, 192);
            this.fileName.Name = "fileName";
            this.fileName.ReadOnly = true;
            this.fileName.Size = new System.Drawing.Size(165, 20);
            this.fileName.TabIndex = 8;
            // 
            // Preview
            // 
            this.Preview.Location = new System.Drawing.Point(12, 218);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(313, 234);
            this.Preview.TabIndex = 9;
            this.Preview.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 526);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SplashScreen";
            this.ShowInTaskbar = false;
            this.Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.Preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.PictureBox Preview;
    }
}