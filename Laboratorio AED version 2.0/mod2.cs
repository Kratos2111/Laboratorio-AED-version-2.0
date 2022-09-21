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
    public partial class mod2 : Form
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
        public mod2()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Add2 form = new Add2();
            if (Ejerc2NEGOCIO.isDeleting)
            {
                Ejerc2NEGOCIO.eliminarDeudor(txtName.Text);
            }
            else
            {
                Ejerc2NEGOCIO.searchById(txtName.Text);
                form.Show();

            }
            this.Hide();
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            txtName.Text = "";
        }
    }
}
