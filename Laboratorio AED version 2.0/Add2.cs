using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_AED_version_2._0
{
    public partial class Add2 : Form
    {
        public Add2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Ejerc2NEGOCIO.isEditing)
            {
                int x = Ejerc2NEGOCIO.indexEditing;
                Ejerc2NEGOCIO.name[x] = txtName.Text;
                Ejerc2NEGOCIO.proyecto[x] = txtProyecto.Text;
                Ejerc2NEGOCIO.carnet[x] = txtCarnet.Text;
                Ejerc2NEGOCIO.flimite[x] = Limite.Value;
                Ejerc2NEGOCIO.Fentrega[x] = Entrega.Value;
            }
            else
            {
                Ejerc2NEGOCIO.agregarCliente(txtCarnet.Text, txtProyecto.Text, txtName.Text, Entrega.Value , Limite.Value);
            }
            this.Hide();
        }

        private void Add2_Load(object sender, EventArgs e)
        {
            if (Ejerc2NEGOCIO.isEditing)
            {
                int x = Ejerc2NEGOCIO.indexEditing;
                txtName.Text = Ejerc2NEGOCIO.name[x];
                txtProyecto.Text = Ejerc2NEGOCIO.proyecto[x];
                txtCarnet.Text = Ejerc2NEGOCIO.carnet[x];
                Limite.Value = Ejerc2NEGOCIO.flimite[x];
                Entrega.Value = Ejerc2NEGOCIO.Fentrega[x];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ejerc2NEGOCIO.isDeleting = false;
            this.Hide();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtProyecto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCarnet_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            
        }

        private void txtProyecto_Click(object sender, EventArgs e)
        {
           
        }

        private void txtCarnet_Click(object sender, EventArgs e)
        {
          
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtProyecto_Enter(object sender, EventArgs e)
        {
            txtProyecto.Text = "";
        }

        private void txtCarnet_Enter(object sender, EventArgs e)
        {
            txtCarnet.Text = "";
        }
    }
}
