namespace Menu
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TCerrar = new System.Windows.Forms.PictureBox();
            this.btn_TMinimizar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_TAsiento = new System.Windows.Forms.ComboBox();
            this.cmb_TFila = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_THora = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TNombre = new System.Windows.Forms.TextBox();
            this.tb_Apellido = new System.Windows.Forms.TextBox();
            this.cmb_TPrecio = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_TComprar = new System.Windows.Forms.Button();
            this.btn_TVolver = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_TSala = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.btn_TCerrar);
            this.panel1.Controls.Add(this.btn_TMinimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1693, 129);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_TCerrar
            // 
            this.btn_TCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_TCerrar.Image")));
            this.btn_TCerrar.Location = new System.Drawing.Point(1610, 33);
            this.btn_TCerrar.Name = "btn_TCerrar";
            this.btn_TCerrar.Size = new System.Drawing.Size(53, 52);
            this.btn_TCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TCerrar.TabIndex = 2;
            this.btn_TCerrar.TabStop = false;
            this.btn_TCerrar.Click += new System.EventHandler(this.btn_TCerrar_Click);
            // 
            // btn_TMinimizar
            // 
            this.btn_TMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_TMinimizar.Image")));
            this.btn_TMinimizar.Location = new System.Drawing.Point(1530, 33);
            this.btn_TMinimizar.Name = "btn_TMinimizar";
            this.btn_TMinimizar.Size = new System.Drawing.Size(64, 53);
            this.btn_TMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_TMinimizar.TabIndex = 1;
            this.btn_TMinimizar.TabStop = false;
            this.btn_TMinimizar.Click += new System.EventHandler(this.btn_TMinimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(644, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // cmb_TAsiento
            // 
            this.cmb_TAsiento.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmb_TAsiento.ForeColor = System.Drawing.Color.Black;
            this.cmb_TAsiento.FormattingEnabled = true;
            this.cmb_TAsiento.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmb_TAsiento.Location = new System.Drawing.Point(1209, 313);
            this.cmb_TAsiento.Name = "cmb_TAsiento";
            this.cmb_TAsiento.Size = new System.Drawing.Size(321, 38);
            this.cmb_TAsiento.TabIndex = 1;
            this.cmb_TAsiento.Text = "Sleccione:";
            // 
            // cmb_TFila
            // 
            this.cmb_TFila.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmb_TFila.ForeColor = System.Drawing.Color.Black;
            this.cmb_TFila.FormattingEnabled = true;
            this.cmb_TFila.Items.AddRange(new object[] {
            "A.",
            "B.",
            "C.",
            "D."});
            this.cmb_TFila.Location = new System.Drawing.Point(1209, 545);
            this.cmb_TFila.Name = "cmb_TFila";
            this.cmb_TFila.Size = new System.Drawing.Size(321, 38);
            this.cmb_TFila.TabIndex = 1;
            this.cmb_TFila.Text = "Sleccione:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1209, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fila";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1209, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Asiento";
            // 
            // cmb_THora
            // 
            this.cmb_THora.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmb_THora.ForeColor = System.Drawing.Color.Black;
            this.cmb_THora.FormattingEnabled = true;
            this.cmb_THora.Items.AddRange(new object[] {
            "09:30:00",
            "10:00:00",
            "14:00:00",
            "17:00:00",
            "19:00:00"});
            this.cmb_THora.Location = new System.Drawing.Point(82, 549);
            this.cmb_THora.Name = "cmb_THora";
            this.cmb_THora.Size = new System.Drawing.Size(371, 38);
            this.cmb_THora.TabIndex = 1;
            this.cmb_THora.Text = "Sleccione:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(81, 486);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(82, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 40);
            this.label6.TabIndex = 2;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(657, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 40);
            this.label7.TabIndex = 2;
            this.label7.Text = "Apellido";
            // 
            // tb_TNombre
            // 
            this.tb_TNombre.Location = new System.Drawing.Point(82, 316);
            this.tb_TNombre.Name = "tb_TNombre";
            this.tb_TNombre.Size = new System.Drawing.Size(371, 35);
            this.tb_TNombre.TabIndex = 3;
            // 
            // tb_Apellido
            // 
            this.tb_Apellido.Location = new System.Drawing.Point(657, 316);
            this.tb_Apellido.Name = "tb_Apellido";
            this.tb_Apellido.Size = new System.Drawing.Size(392, 35);
            this.tb_Apellido.TabIndex = 4;
            // 
            // cmb_TPrecio
            // 
            this.cmb_TPrecio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmb_TPrecio.ForeColor = System.Drawing.Color.Black;
            this.cmb_TPrecio.FormattingEnabled = true;
            this.cmb_TPrecio.Items.AddRange(new object[] {
            "80.00",
            "130.00",
            "200.00  "});
            this.cmb_TPrecio.Location = new System.Drawing.Point(662, 546);
            this.cmb_TPrecio.Name = "cmb_TPrecio";
            this.cmb_TPrecio.Size = new System.Drawing.Size(384, 38);
            this.cmb_TPrecio.TabIndex = 1;
            this.cmb_TPrecio.Text = "Sleccione:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(655, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 40);
            this.label8.TabIndex = 2;
            this.label8.Text = "Precio";
            // 
            // btn_TComprar
            // 
            this.btn_TComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_TComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TComprar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_TComprar.Location = new System.Drawing.Point(1382, 907);
            this.btn_TComprar.Name = "btn_TComprar";
            this.btn_TComprar.Size = new System.Drawing.Size(299, 111);
            this.btn_TComprar.TabIndex = 7;
            this.btn_TComprar.Text = "COMPRAR";
            this.btn_TComprar.UseVisualStyleBackColor = false;
            this.btn_TComprar.Click += new System.EventHandler(this.btn_TComprar_Click);
            // 
            // btn_TVolver
            // 
            this.btn_TVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btn_TVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TVolver.ForeColor = System.Drawing.Color.LightGray;
            this.btn_TVolver.Location = new System.Drawing.Point(1070, 907);
            this.btn_TVolver.Name = "btn_TVolver";
            this.btn_TVolver.Size = new System.Drawing.Size(299, 111);
            this.btn_TVolver.TabIndex = 7;
            this.btn_TVolver.Text = "VOLVER";
            this.btn_TVolver.UseVisualStyleBackColor = false;
            this.btn_TVolver.Click += new System.EventHandler(this.btn_TVolver_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 741);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(524, 367);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1702, 21);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gold;
            this.panel3.Location = new System.Drawing.Point(2, 734);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(522, 17);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(524, 735);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 360);
            this.panel4.TabIndex = 13;
            // 
            // cmb_TSala
            // 
            this.cmb_TSala.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cmb_TSala.ForeColor = System.Drawing.Color.Black;
            this.cmb_TSala.FormattingEnabled = true;
            this.cmb_TSala.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_TSala.Location = new System.Drawing.Point(662, 713);
            this.cmb_TSala.Name = "cmb_TSala";
            this.cmb_TSala.Size = new System.Drawing.Size(384, 38);
            this.cmb_TSala.TabIndex = 1;
            this.cmb_TSala.Text = "Sleccione:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(657, 647);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sala";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1693, 1095);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_TSala);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_TVolver);
            this.Controls.Add(this.btn_TComprar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_TPrecio);
            this.Controls.Add(this.tb_Apellido);
            this.Controls.Add(this.tb_TNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_THora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_TFila);
            this.Controls.Add(this.cmb_TAsiento);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ticket_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_TMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_TCerrar;
        private System.Windows.Forms.PictureBox btn_TMinimizar;
        private System.Windows.Forms.ComboBox cb_TAsiento;
        private System.Windows.Forms.ComboBox cmb_TFila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_THora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_TNombre;
        private System.Windows.Forms.TextBox tb_Apellido;
        private System.Windows.Forms.ComboBox cmb_TPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_TComprar;
        private System.Windows.Forms.Button btn_TVolver;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmb_TAsiento;
        private System.Windows.Forms.ComboBox cmb_TSala;
        private System.Windows.Forms.Label label2;
    }
}