using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using DataAccess;

namespace Menu
{
    public partial class Ticket : Form
    {
        ClsProductos objProducto = new ClsProductos();

        public Ticket()
        {
            InitializeComponent();
        }
        //MOVIMIENTO DEL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Ticket_MouseDown(object sender, MouseEventArgs e)
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

        //BOTONES DE MINIMIZAR, CERRAR
        private void btn_TMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_TCerrar_Click(object sender, EventArgs e)
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

        private void btn_TComprar_Click(object sender, EventArgs e)
        {
            objProducto.InsertarProductos(Convert.ToInt32(cmb_TSala.SelectedValue),tb_TNombre.Text,tb_Apellido.Text,Convert.ToDateTime(cmb_THora.SelectedValue),Convert.ToInt32(cmb_TFila.SelectedValue),Convert.ToInt32(cmb_TAsiento.SelectedValue),Convert.ToFloat(cmb_TPrecio.SelectedValue));
            MessageBox.Show("Insertado Correctamente");
        }
    }
}
