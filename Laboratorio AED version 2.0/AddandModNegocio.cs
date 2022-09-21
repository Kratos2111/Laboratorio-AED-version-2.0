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

namespace Laboratorio_AED_version_2._0
{
    public partial class AddandModNegocio : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );
        public AddandModNegocio()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void AddandModNegocio_Load(object sender, EventArgs e)
        {
            if (Ejer1NEGOCIO.isEditing == true)
            {
                int x = Ejer1NEGOCIO.indexEditing;
                txtName.Text = Ejer1NEGOCIO.name[x];
                txtdebt.Text = Convert.ToString(Ejer1NEGOCIO.deuda[x]);
                txtAddress.Text = Ejer1NEGOCIO.direccion[x];
                txtTelefono.Text = Convert.ToString(Ejer1NEGOCIO.telefono[x]);
                rbState.Checked = Ejer1NEGOCIO.estado[x];
            }

        }

        private void kryptonRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtdebt_Enter(object sender, EventArgs e)
        {
            txtdebt.Text = "";
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            txtTelefono.Text = "";
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            txtAddress.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(int.Parse(txtTelefono.Text) > 0 && float.Parse(txtdebt.Text) > 0)
            {
                if (Ejer1NEGOCIO.isEditing)
                {
                    int x = Ejer1NEGOCIO.indexEditing;
                    Ejer1NEGOCIO.name[x] = txtName.Text;
                    Ejer1NEGOCIO.deuda[x] = float.Parse( txtdebt.Text);
                    Ejer1NEGOCIO.direccion[x] = txtAddress.Text;
                    Ejer1NEGOCIO.telefono[x] = int.Parse(txtTelefono.Text);
                    Ejer1NEGOCIO.estado[x] = rbState.Checked;
                    this.Hide();
                }
                else
                {
                    Ejer1NEGOCIO.agregarCliente(float.Parse(txtdebt.Text), txtName.Text, txtAddress.Text, int.Parse(txtTelefono.Text), rbState.Checked);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese caracteres validos");
                txtdebt.Text = "Deuda";
                txtTelefono.Text = "Telefono";
                txtAddress.Text = "Direccion";
                txtName.Focus();
            }
        }
    }
}
