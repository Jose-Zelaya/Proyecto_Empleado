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
    public partial class Peliculas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Peliculas()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("Select * from t_Pelicula", conexion);
            SqlDataAdapter xy = new SqlDataAdapter();
            xy.SelectCommand = comando;
            DataTable tabla = new DataTable();
            xy.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Peliculas_Load(object sender, EventArgs e)
        {

        }

        private void Peliculas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
