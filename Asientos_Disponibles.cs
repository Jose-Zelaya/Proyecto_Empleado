using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Menu
{
    public partial class Asientos_Disponibles : Form
    {
        public Asientos_Disponibles()
        {
            InitializeComponent();
        }

        //MOVIMIENTO DEL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_AVolver_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //BOTONES DE MINIMIZAR Y CERRAR
        private void btn_AMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ACerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTONES PRINCIPALES
        private void btn_TVolver_Click(object sender, EventArgs e)
        {
            Form frm_vmenu = new Menu();
            frm_vmenu.Show();
            this.Hide();
        }

        private void Asientos_Disponibles_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
