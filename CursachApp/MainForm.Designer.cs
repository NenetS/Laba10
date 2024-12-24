namespace CursachApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnFinds = new CursachApp.CustomerButtons();
            this.btnExhibit = new CursachApp.CustomerButtons();
            this.btnStaff = new CursachApp.CustomerButtons();
            this.btnExcavations = new CursachApp.CustomerButtons();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExhibit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcavations)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExcavations);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnExhibit);
            this.panel1.Controls.Add(this.btnFinds);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 122);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "MUSEUM INVENTORY MANAGER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 571);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 27);
            this.panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 122);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4);
            this.panelMain.MaximumSize = new System.Drawing.Size(1086, 449);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1086, 449);
            this.panelMain.TabIndex = 2;
            // 
            // btnFinds
            // 
            this.btnFinds.Image = ((System.Drawing.Image)(resources.GetObject("btnFinds.Image")));
            this.btnFinds.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnFinds.ImageHover")));
            this.btnFinds.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnFinds.ImageNormal")));
            this.btnFinds.Location = new System.Drawing.Point(473, 18);
            this.btnFinds.Name = "btnFinds";
            this.btnFinds.Size = new System.Drawing.Size(49, 43);
            this.btnFinds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFinds.TabIndex = 0;
            this.btnFinds.TabStop = false;
            this.btnFinds.Click += new System.EventHandler(this.btnFinds_Click);
            // 
            // btnExhibit
            // 
            this.btnExhibit.Image = ((System.Drawing.Image)(resources.GetObject("btnExhibit.Image")));
            this.btnExhibit.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnExhibit.ImageHover")));
            this.btnExhibit.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnExhibit.ImageNormal")));
            this.btnExhibit.Location = new System.Drawing.Point(637, 18);
            this.btnExhibit.Name = "btnExhibit";
            this.btnExhibit.Size = new System.Drawing.Size(51, 43);
            this.btnExhibit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExhibit.TabIndex = 10;
            this.btnExhibit.TabStop = false;
            this.btnExhibit.Click += new System.EventHandler(this.btnExhibit_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnStaff.ImageHover")));
            this.btnStaff.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnStaff.ImageNormal")));
            this.btnStaff.Location = new System.Drawing.Point(806, 18);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(49, 43);
            this.btnStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnStaff.TabIndex = 12;
            this.btnStaff.TabStop = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnExcavations
            // 
            this.btnExcavations.Image = ((System.Drawing.Image)(resources.GetObject("btnExcavations.Image")));
            this.btnExcavations.ImageHover = ((System.Drawing.Image)(resources.GetObject("btnExcavations.ImageHover")));
            this.btnExcavations.ImageNormal = ((System.Drawing.Image)(resources.GetObject("btnExcavations.ImageNormal")));
            this.btnExcavations.Location = new System.Drawing.Point(977, 18);
            this.btnExcavations.Name = "btnExcavations";
            this.btnExcavations.Size = new System.Drawing.Size(49, 43);
            this.btnExcavations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExcavations.TabIndex = 13;
            this.btnExcavations.TabStop = false;
            this.btnExcavations.Click += new System.EventHandler(this.btnExcavations_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(454, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "НАХОДКИ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(601, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "ЭКСПОНАТЫ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(770, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "СОТРУДНИКИ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(955, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "РАСКОПКИ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(376, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "С ВОЗВРАЩЕНИЕМ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 598);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFinds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExhibit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExcavations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomerButtons btnFinds;
        private System.Windows.Forms.Label label1;
        private CustomerButtons btnExcavations;
        private CustomerButtons btnStaff;
        private CustomerButtons btnExhibit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}