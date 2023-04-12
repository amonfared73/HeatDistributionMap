namespace WindowsFormsApp1
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
            this.button_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_platewidth = new System.Windows.Forms.Label();
            this.label_PlaneHeight = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_height = new System.Windows.Forms.TextBox();
            this.textBox_width = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Gridpoints = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_leftT = new System.Windows.Forms.TextBox();
            this.textBox_bottomT = new System.Windows.Forms.TextBox();
            this.textBox_rightT = new System.Windows.Forms.TextBox();
            this.textBox_topT = new System.Windows.Forms.TextBox();
            this.textBox_initialT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_compute = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_mini = new System.Windows.Forms.Button();
            this.label_min = new System.Windows.Forms.Label();
            this.label_max = new System.Windows.Forms.Label();
            this.loops = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_close
            // 
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.Image = ((System.Drawing.Image)(resources.GetObject("button_close.Image")));
            this.button_close.Location = new System.Drawing.Point(797, 5);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(30, 30);
            this.button_close.TabIndex = 0;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.Button_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("3ds", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "2D Steady State Heat Transfer";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "twitter ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(753, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "@amonfared73";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(414, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 280);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label_platewidth
            // 
            this.label_platewidth.AutoSize = true;
            this.label_platewidth.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_platewidth.Location = new System.Drawing.Point(17, 37);
            this.label_platewidth.Name = "label_platewidth";
            this.label_platewidth.Size = new System.Drawing.Size(100, 16);
            this.label_platewidth.TabIndex = 5;
            this.label_platewidth.Text = "Plate Width[m]:";
            // 
            // label_PlaneHeight
            // 
            this.label_PlaneHeight.AutoSize = true;
            this.label_PlaneHeight.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_PlaneHeight.Location = new System.Drawing.Point(190, 37);
            this.label_PlaneHeight.Name = "label_PlaneHeight";
            this.label_PlaneHeight.Size = new System.Drawing.Size(107, 16);
            this.label_PlaneHeight.TabIndex = 6;
            this.label_PlaneHeight.Text = "Plane Height[m]:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_height);
            this.groupBox1.Controls.Add(this.textBox_width);
            this.groupBox1.Controls.Add(this.label_PlaneHeight);
            this.groupBox1.Controls.Add(this.label_platewidth);
            this.groupBox1.Location = new System.Drawing.Point(18, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 83);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plane Properties";
            // 
            // textBox_height
            // 
            this.textBox_height.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_height.Location = new System.Drawing.Point(301, 33);
            this.textBox_height.Multiline = true;
            this.textBox_height.Name = "textBox_height";
            this.textBox_height.Size = new System.Drawing.Size(59, 25);
            this.textBox_height.TabIndex = 8;
            this.textBox_height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_width
            // 
            this.textBox_width.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_width.Location = new System.Drawing.Point(118, 33);
            this.textBox_width.Multiline = true;
            this.textBox_width.Name = "textBox_width";
            this.textBox_width.Size = new System.Drawing.Size(59, 25);
            this.textBox_width.TabIndex = 7;
            this.textBox_width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Gridpoints);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(18, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 85);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gridpoints";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Adobe Heiti Std R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(238, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 53);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of gridpoints represent the program accuracy!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Gridpoints
            // 
            this.textBox_Gridpoints.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_Gridpoints.Location = new System.Drawing.Point(164, 33);
            this.textBox_Gridpoints.Multiline = true;
            this.textBox_Gridpoints.Name = "textBox_Gridpoints";
            this.textBox_Gridpoints.Size = new System.Drawing.Size(59, 25);
            this.textBox_Gridpoints.TabIndex = 1;
            this.textBox_Gridpoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Number of Gridpoints:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_leftT);
            this.groupBox3.Controls.Add(this.textBox_bottomT);
            this.groupBox3.Controls.Add(this.textBox_rightT);
            this.groupBox3.Controls.Add(this.textBox_topT);
            this.groupBox3.Controls.Add(this.textBox_initialT);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(18, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 249);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Boundary Conditions";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Adobe Heiti Std R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(238, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 191);
            this.label11.TabIndex = 2;
            this.label11.Text = "Set the constant temperatures applied on the boundaries of the plate! This is the" +
    " most effective parameter in the temperature distribution!";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(17, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Left Temperatue[C]:";
            // 
            // textBox_leftT
            // 
            this.textBox_leftT.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_leftT.Location = new System.Drawing.Point(164, 204);
            this.textBox_leftT.Multiline = true;
            this.textBox_leftT.Name = "textBox_leftT";
            this.textBox_leftT.Size = new System.Drawing.Size(59, 25);
            this.textBox_leftT.TabIndex = 1;
            this.textBox_leftT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_bottomT
            // 
            this.textBox_bottomT.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_bottomT.Location = new System.Drawing.Point(164, 160);
            this.textBox_bottomT.Multiline = true;
            this.textBox_bottomT.Name = "textBox_bottomT";
            this.textBox_bottomT.Size = new System.Drawing.Size(59, 25);
            this.textBox_bottomT.TabIndex = 1;
            this.textBox_bottomT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_rightT
            // 
            this.textBox_rightT.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_rightT.Location = new System.Drawing.Point(164, 116);
            this.textBox_rightT.Multiline = true;
            this.textBox_rightT.Name = "textBox_rightT";
            this.textBox_rightT.Size = new System.Drawing.Size(59, 25);
            this.textBox_rightT.TabIndex = 1;
            this.textBox_rightT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_topT
            // 
            this.textBox_topT.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_topT.Location = new System.Drawing.Point(164, 72);
            this.textBox_topT.Multiline = true;
            this.textBox_topT.Name = "textBox_topT";
            this.textBox_topT.Size = new System.Drawing.Size(59, 25);
            this.textBox_topT.TabIndex = 1;
            this.textBox_topT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_initialT
            // 
            this.textBox_initialT.Font = new System.Drawing.Font("Adobe Heiti Std R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_initialT.Location = new System.Drawing.Point(164, 28);
            this.textBox_initialT.Multiline = true;
            this.textBox_initialT.Name = "textBox_initialT";
            this.textBox_initialT.Size = new System.Drawing.Size(59, 25);
            this.textBox_initialT.TabIndex = 1;
            this.textBox_initialT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(17, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Bottom Temperatue[C]:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(17, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Right Temperatue[C]:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(17, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Top Temperatue[C]:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Adobe Heiti Std R", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(17, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Initial Temperatue[C]:";
            // 
            // button_compute
            // 
            this.button_compute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_compute.Location = new System.Drawing.Point(413, 356);
            this.button_compute.Name = "button_compute";
            this.button_compute.Size = new System.Drawing.Size(104, 30);
            this.button_compute.TabIndex = 10;
            this.button_compute.Text = "Compute";
            this.button_compute.UseVisualStyleBackColor = true;
            this.button_compute.Click += new System.EventHandler(this.Button_compute_Click);
            // 
            // button_clear
            // 
            this.button_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_clear.Location = new System.Drawing.Point(527, 356);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(73, 30);
            this.button_clear.TabIndex = 10;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // button_excel
            // 
            this.button_excel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_excel.Location = new System.Drawing.Point(696, 355);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(120, 30);
            this.button_excel.TabIndex = 10;
            this.button_excel.Text = "Send Data to Excel";
            this.button_excel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Location = new System.Drawing.Point(607, 355);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(83, 30);
            this.button_Save.TabIndex = 10;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_mini
            // 
            this.button_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_mini.Image = ((System.Drawing.Image)(resources.GetObject("button_mini.Image")));
            this.button_mini.Location = new System.Drawing.Point(761, 5);
            this.button_mini.Name = "button_mini";
            this.button_mini.Size = new System.Drawing.Size(30, 30);
            this.button_mini.TabIndex = 11;
            this.button_mini.UseVisualStyleBackColor = true;
            this.button_mini.Click += new System.EventHandler(this.Button_mini_Click);
            // 
            // label_min
            // 
            this.label_min.AutoSize = true;
            this.label_min.Location = new System.Drawing.Point(411, 406);
            this.label_min.Name = "label_min";
            this.label_min.Size = new System.Drawing.Size(0, 13);
            this.label_min.TabIndex = 12;
            // 
            // label_max
            // 
            this.label_max.AutoSize = true;
            this.label_max.Location = new System.Drawing.Point(411, 428);
            this.label_max.Name = "label_max";
            this.label_max.Size = new System.Drawing.Size(0, 13);
            this.label_max.TabIndex = 12;
            // 
            // loops
            // 
            this.loops.AutoSize = true;
            this.loops.Location = new System.Drawing.Point(411, 450);
            this.loops.Name = "loops";
            this.loops.Size = new System.Drawing.Size(0, 13);
            this.loops.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(833, 501);
            this.Controls.Add(this.loops);
            this.Controls.Add(this.label_max);
            this.Controls.Add(this.label_min);
            this.Controls.Add(this.button_mini);
            this.Controls.Add(this.button_excel);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_compute);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Steady State Heat Transfer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_platewidth;
        private System.Windows.Forms.Label label_PlaneHeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_width;
        private System.Windows.Forms.TextBox textBox_height;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Gridpoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_initialT;
        private System.Windows.Forms.TextBox textBox_topT;
        private System.Windows.Forms.TextBox textBox_leftT;
        private System.Windows.Forms.TextBox textBox_bottomT;
        private System.Windows.Forms.TextBox textBox_rightT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_compute;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_mini;
        private System.Windows.Forms.Label label_min;
        private System.Windows.Forms.Label label_max;
        private System.Windows.Forms.Label loops;
    }
}

