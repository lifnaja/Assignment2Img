namespace Assignment2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.btn_CHMF = new System.Windows.Forms.Button();
            this.btn_Max = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_Midpoint = new System.Windows.Forms.Button();
            this.btn_Alpha = new System.Windows.Forms.Button();
            this.txt_Q = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(39, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(372, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(676, 44);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(153, 23);
            this.btn_OpenFile.TabIndex = 2;
            this.btn_OpenFile.Text = "Open file";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_CHMF
            // 
            this.btn_CHMF.Location = new System.Drawing.Point(733, 82);
            this.btn_CHMF.Name = "btn_CHMF";
            this.btn_CHMF.Size = new System.Drawing.Size(96, 42);
            this.btn_CHMF.TabIndex = 3;
            this.btn_CHMF.Text = "Contra Harmonic Mean Filter";
            this.btn_CHMF.UseVisualStyleBackColor = true;
            this.btn_CHMF.Click += new System.EventHandler(this.btn_CHMF_Click);
            // 
            // btn_Max
            // 
            this.btn_Max.Location = new System.Drawing.Point(676, 142);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(153, 23);
            this.btn_Max.TabIndex = 4;
            this.btn_Max.Text = "Max Filter";
            this.btn_Max.UseVisualStyleBackColor = true;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            // 
            // btn_min
            // 
            this.btn_min.Location = new System.Drawing.Point(676, 183);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(153, 23);
            this.btn_min.TabIndex = 5;
            this.btn_min.Text = "Min Filter";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_Midpoint
            // 
            this.btn_Midpoint.Location = new System.Drawing.Point(676, 222);
            this.btn_Midpoint.Name = "btn_Midpoint";
            this.btn_Midpoint.Size = new System.Drawing.Size(153, 23);
            this.btn_Midpoint.TabIndex = 6;
            this.btn_Midpoint.Text = "Midpoint Filter";
            this.btn_Midpoint.UseVisualStyleBackColor = true;
            this.btn_Midpoint.Click += new System.EventHandler(this.btn_Midpoint_Click);
            // 
            // btn_Alpha
            // 
            this.btn_Alpha.Location = new System.Drawing.Point(733, 264);
            this.btn_Alpha.Name = "btn_Alpha";
            this.btn_Alpha.Size = new System.Drawing.Size(96, 50);
            this.btn_Alpha.TabIndex = 7;
            this.btn_Alpha.Text = "Alpha-trimmed Mean-filter";
            this.btn_Alpha.UseVisualStyleBackColor = true;
            this.btn_Alpha.Click += new System.EventHandler(this.btn_Alpha_Click);
            // 
            // txt_Q
            // 
            this.txt_Q.Location = new System.Drawing.Point(676, 91);
            this.txt_Q.Name = "txt_Q";
            this.txt_Q.Size = new System.Drawing.Size(51, 20);
            this.txt_Q.TabIndex = 8;
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(676, 282);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(51, 20);
            this.txt_d.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 406);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_Q);
            this.Controls.Add(this.btn_Alpha);
            this.Controls.Add(this.btn_Midpoint);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_Max);
            this.Controls.Add(this.btn_CHMF);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.Button btn_CHMF;
        private System.Windows.Forms.Button btn_Max;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_Midpoint;
        private System.Windows.Forms.Button btn_Alpha;
        private System.Windows.Forms.TextBox txt_Q;
        private System.Windows.Forms.TextBox txt_d;
    }
}

