using System;
using System.Drawing;
using System.Windows.Forms;
using DatosTelefono;

namespace Telefonia
{
    public partial class Form1 : Form
    {
        public Form1()
        {            

            InitializeComponent();
        }

        

        private void txtbLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == 13)
            {

                TelefonoDatos telefonoDatos = new TelefonoDatos(txtbTelefono.Text, txtbLugar.Text);
                //Se inserta un elemento al DataGridView
                dgvTelefonia.Rows.Add(telefonoDatos.telefono, telefonoDatos.lugar);
            }
            

        }
    }
}
