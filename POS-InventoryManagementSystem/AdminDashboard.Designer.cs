﻿namespace POS_InventoryManagementSystem
{
    partial class AdminDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dashboard_totalIncome = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dashboard_TI = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dashboard_AC = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dashboard_AU = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(11, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 581);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel5.Controls.Add(this.dashboard_totalIncome);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(427, 318);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 173);
            this.panel5.TabIndex = 2;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dashboard_totalIncome
            // 
            this.dashboard_totalIncome.AutoSize = true;
            this.dashboard_totalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_totalIncome.ForeColor = System.Drawing.Color.White;
            this.dashboard_totalIncome.Location = new System.Drawing.Point(89, 33);
            this.dashboard_totalIncome.Name = "dashboard_totalIncome";
            this.dashboard_totalIncome.Size = new System.Drawing.Size(44, 18);
            this.dashboard_totalIncome.TabIndex = 8;
            this.dashboard_totalIncome.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(89, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Total Income";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::POS_InventoryManagementSystem.Properties.Resources.money_bag__1_1;
            this.pictureBox4.Location = new System.Drawing.Point(3, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.dashboard_TI);
            this.panel4.Location = new System.Drawing.Point(104, 318);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 173);
            this.panel4.TabIndex = 1;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(87, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Today\'s Income";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS_InventoryManagementSystem.Properties.Resources.cash;
            this.pictureBox3.Location = new System.Drawing.Point(3, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // dashboard_TI
            // 
            this.dashboard_TI.AutoSize = true;
            this.dashboard_TI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_TI.ForeColor = System.Drawing.Color.White;
            this.dashboard_TI.Location = new System.Drawing.Point(87, 33);
            this.dashboard_TI.Name = "dashboard_TI";
            this.dashboard_TI.Size = new System.Drawing.Size(44, 18);
            this.dashboard_TI.TabIndex = 7;
            this.dashboard_TI.Text = "$0.00";
            this.dashboard_TI.Click += new System.EventHandler(this.dashboard_TI_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.dashboard_AC);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(430, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 173);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(89, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "All Customers";
            // 
            // dashboard_AC
            // 
            this.dashboard_AC.AutoSize = true;
            this.dashboard_AC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_AC.ForeColor = System.Drawing.Color.White;
            this.dashboard_AC.Location = new System.Drawing.Point(89, 33);
            this.dashboard_AC.Name = "dashboard_AC";
            this.dashboard_AC.Size = new System.Drawing.Size(16, 18);
            this.dashboard_AC.TabIndex = 4;
            this.dashboard_AC.Text = "0";
            this.dashboard_AC.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::POS_InventoryManagementSystem.Properties.Resources.rating;
            this.pictureBox2.Location = new System.Drawing.Point(3, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(113)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dashboard_AU);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(104, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 173);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(89, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "All Users";
            // 
            // dashboard_AU
            // 
            this.dashboard_AU.AutoSize = true;
            this.dashboard_AU.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_AU.ForeColor = System.Drawing.Color.White;
            this.dashboard_AU.Location = new System.Drawing.Point(89, 33);
            this.dashboard_AU.Name = "dashboard_AU";
            this.dashboard_AU.Size = new System.Drawing.Size(16, 18);
            this.dashboard_AU.TabIndex = 1;
            this.dashboard_AU.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POS_InventoryManagementSystem.Properties.Resources.people;
            this.pictureBox1.Location = new System.Drawing.Point(3, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboard";
            this.Size = new System.Drawing.Size(869, 797);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dashboard_AC;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dashboard_AU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label dashboard_TI;
        private System.Windows.Forms.Label dashboard_totalIncome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}
