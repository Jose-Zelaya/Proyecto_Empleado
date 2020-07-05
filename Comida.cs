using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class Comida : Form
    {
        public Comida()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Comida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet5.t_Comida' Puede moverla o quitarla según sea necesario.
            this.t_ComidaTableAdapter3.Fill(this.dataSet5.t_Comida);
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.t_Comida' Puede moverla o quitarla según sea necesario.
            this.t_ComidaTableAdapter2.Fill(this.dataSet4.t_Comida);
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.t_Comida' Puede moverla o quitarla según sea necesario.
            this.t_ComidaTableAdapter1.Fill(this.dataSet3.t_Comida);
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.t_Comida' Puede moverla o quitarla según sea necesario.
            this.t_ComidaTableAdapter.Fill(this.dataSet2.t_Comida);
            checkedListBox1.Items.Add("Normal",true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.Show();
            this.Visible = false;
        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            facturar();
            conexion.Open();

            SqlCommand comando = new SqlCommand("insert into t_ClientesComida values(@Principal,@Extra,@Dulces, @Bebidas,@TotalPagado)", conexion);
            comando.Parameters.AddWithValue("@Principal", comboBox1.Text);
            comando.Parameters.AddWithValue("@extra", comboBox2.Text);
            comando.Parameters.AddWithValue("@Dulces", comboBox3.Text);
            comando.Parameters.AddWithValue("@Bebidas", comboBox4.Text);
            comando.Parameters.AddWithValue("@TotalPagado", textBox1.Text);

            try
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("Gracias por su compra");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            conexion.Close();
        }
        private void facturar()
        {
           
            double Precioprincipal=0;
            double Precioextra=0;
            double Preciodulce=0;
            double PrecioBebida=0;
            double total;
            if (comboBox1.Text == "Palomitas")
            {
                Precioprincipal = 85.00;
            }
            else if (comboBox1.Text == "Nachos")
            {
                Precioprincipal = 65.00;
            }
            else if (comboBox1.Text == "Hotdogs")
            {
                Precioprincipal = 110.00;
            }

            if (comboBox2.Text == "Queso")
            {
                Precioextra = 25.00;
            }
            else if (comboBox2.Text == "Carne")
            {
                Precioextra = 55.00;
            }
            else if (comboBox2.Text == "Chili")
            {
                Precioextra = 30.00;
            }

            if (comboBox3.Text == "Mentas")
            {
                Preciodulce = 5.00;
            }
            else if (comboBox3.Text == "Frutas")
            {
                Preciodulce = 10.00;
            }
            else if (comboBox3.Text == "Paletas")
            {
                Preciodulce = 8.00;
            }

            if (comboBox4.Text == "Pepsi")
            {
                PrecioBebida = 20.00;
            }
            else if (comboBox4.Text == "CocaCola")
            {
                PrecioBebida = 25.00;
            }
            else if (comboBox4.Text == "7Up")
            {
                PrecioBebida = 20.00;
            }
            int label = 0;
            
            label = checkedListBox1.SelectedIndex;
            
                if (label != 1)
                {
                    MessageBox.Show("Seleccione Tipo de Combo");
                
                }
                else if (label == 1)
                {
                    total = Precioprincipal + Precioextra + Preciodulce + PrecioBebida;
                    textBox1.Text = Convert.ToString(total);
                     
            }
                else if (label == 2)
                {
                    total = Precioprincipal + Precioextra + Preciodulce + PrecioBebida + ((Precioprincipal + Precioextra + Preciodulce + PrecioBebida) * 0.10);
                    textBox1.Text = Convert.ToString(total);
                     
            }
                else if (label == 3)
                {
                    total = Precioprincipal + Precioextra + Preciodulce + PrecioBebida + ((Precioprincipal + Precioextra + Preciodulce + PrecioBebida) * 0.20);
                    textBox1.Text = Convert.ToString(total);
                     
            }
            
            
        }

        private void Comida_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
