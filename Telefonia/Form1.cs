using System;
using System.Drawing;
using System.Windows.Forms;
using DatosTelefono;

namespace Telefonia
{
    public partial class Form1 : Form
    {
        //Tiempo en segundos
        private int ts;
        private int n=0,s=0;
        private Boolean llamada_en_curso = false;
        public Form1()
        {            
            InitializeComponent();
        }

        

        private void txtbLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtbTelefono.Text != "" && txtbLugar.Text != "" && !llamada_en_curso)
                {

                    TelefonoDatos telefonoDatos = new TelefonoDatos(txtbTelefono.Text, txtbLugar.Text);
                    //Se inserta un elemento al DataGridView
                    dgvTelefonia.Rows.Add(telefonoDatos.telefono, telefonoDatos.lugar, ts);
                    tiempollamadaEvento.Start();
                    txtbLugar.Clear();
                    txtbTelefono.Clear();
                    llamada_en_curso = true;
                }
                else
                {
                    MessageBox.Show("No se han ingresado datos");
                }
            }

        }

        private void tiempollamadaEvento_Tick(object sender, EventArgs e)
        {

            if (ts > 59)
            {
                dgvTelefonia.Rows[n].Cells[2].Value = s++ + ":" + ts++;
                ts = 0;
            }
            else {
                dgvTelefonia.Rows[n].Cells[2].Value =s +":"+ ts++;
            }
            

        }

        private void btnColgar_Click(object sender, EventArgs e)
        {
            
            tiempollamadaEvento.Stop();
            ts = 0;
            s = 0;
            n++;
            llamada_en_curso = false;
        }
    }
}
