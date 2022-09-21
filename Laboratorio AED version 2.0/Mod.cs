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
    public partial class Mod : Form
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
        public Mod()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Mod_Load(object sender, EventArgs e)
        {


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Ejer1NEGOCIO.isEditing = true;
            if (Ejer1NEGOCIO.isDeleting)
            {
                Ejer1NEGOCIO.eliminarDeudor(txtName.Text);
                this.Hide();
            }
            else
            {
                AddandModNegocio form = new AddandModNegocio();
                int IdtoSearch = int.Parse(txtName.Text);
                if(IdtoSearch > 0)
                {
                    Ejer1NEGOCIO.searchById(IdtoSearch);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Ingrese un id valido");
                }

            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
