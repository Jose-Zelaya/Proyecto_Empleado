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
    public partial class Tickets : Form
    {
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        public Tickets()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from t_Cliente", conexion);
            SqlDataAdapter xy = new SqlDataAdapter();
            xy.SelectCommand = comando;
            DataTable tabla = new DataTable();
            xy.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("delete From t_Cliente where IdCliente='" + txtnombre.Text + "'", conexion);

            try
            {
                comando.ExecuteNonQuery();
                label2.Text = "Boleto Canjeado";
                txtnombre.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
            conexion.Close();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private void Tickets_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
