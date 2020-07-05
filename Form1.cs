using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tickets nuevo = new Tickets();
            nuevo.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
            this.Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Peliculas nuevo = new Peliculas();
            nuevo.Show();
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sala nuevo = new Sala();
            nuevo.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Comida nuevo = new Comida();
            nuevo.Show();
            this.Visible = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
