namespace Menu
{
    partial class Asientos_Disponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asientos_Disponibles));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AMinimizar = new System.Windows.Forms.PictureBox();
            this.btn_ACerrar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_AVolver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ACerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btn_AMinimizar);
            this.panel1.Controls.Add(this.btn_ACerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1617, 136);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_AMinimizar
            // 
            this.btn_AMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_AMinimizar.Image")));
            this.btn_AMinimizar.Location = new System.Drawing.Point(1458, 36);
            this.btn_AMinimizar.Name = "btn_AMinimizar";
            this.btn_AMinimizar.Size = new System.Drawing.Size(56, 61);
            this.btn_AMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_AMinimizar.TabIndex = 2;
            this.btn_AMinimizar.TabStop = false;
            this.btn_AMinimizar.Click += new System.EventHandler(this.btn_AMinimizar_Click);
            // 
            // btn_ACerrar
            // 
            this.btn_ACerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ACerrar.Image")));
            this.btn_ACerrar.Location = new System.Drawing.Point(1538, 36);
            this.btn_ACerrar.Name = "btn_ACerrar";
            this.btn_ACerrar.Size = new System.Drawing.Size(54, 61);
            this.btn_ACerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_ACerrar.TabIndex = 1;
            this.btn_ACerrar.TabStop = false;
            this.btn_ACerrar.Click += new System.EventHandler(this.btn_ACerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(988, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asientos Disponibles";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 177);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(421, 794);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1702, 21);
            this.panel2.TabIndex = 13;
            // 
            // btn_AVolver
            // 
            this.btn_AVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_AVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AVolver.ForeColor = System.Drawing.Color.LightGray;
            this.btn_AVolver.Location = new System.Drawing.Point(1284, 901);
            this.btn_AVolver.Name = "btn_AVolver";
            this.btn_AVolver.Size = new System.Drawing.Size(299, 111);
            this.btn_AVolver.TabIndex = 7;
            this.btn_AVolver.Text = "VOLVER";
            this.btn_AVolver.UseVisualStyleBackColor = false;
            this.btn_AVolver.Click += new System.EventHandler(this.btn_TVolver_Click);
            this.btn_AVolver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_AVolver_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Asientos_Disponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1617, 1039);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_AVolver);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asientos_Disponibles";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asientos_Disponibles";
            this.Load += new System.EventHandler(this.Asientos_Disponibles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ACerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_AMinimizar;
        private System.Windows.Forms.PictureBox btn_ACerrar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_AVolver;
        private System.Windows.Forms.Label label2;
    }
}