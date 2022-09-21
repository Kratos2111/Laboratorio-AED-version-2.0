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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        private void updateData()
        {
            DatagridEjercicio1.Rows.Clear();
            for(int i = 0; i < Ejerc2NEGOCIO.Tam; i++) {
                DatagridEjercicio1.Rows.Add(Ejerc2NEGOCIO.carnet[i], Ejerc2NEGOCIO.name[i], Ejerc2NEGOCIO.proyecto[i], Convert.ToString(Ejerc2NEGOCIO.Fentrega[i].Date),Convert.ToString( Ejerc2NEGOCIO.flimite[i].Date));
            }
            DatagridEjercicio1.Sort(DatagridEjercicio1.Columns["Entrega"], ListSortDirection.Ascending);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Add2 form = new Add2();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ejerc2NEGOCIO.isDeleting = true;
            mod2 form = new mod2();
            form.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Ejerc2NEGOCIO.isEditing = true;
            mod2 form = new mod2();
            form.Show();
        }

        private void Ejercicio2_Enter(object sender, EventArgs e)
        {
            updateData();
        }

        private void DatagridEjercicio1_Enter(object sender, EventArgs e)
        {
            updateData();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DatagridEjercicio1.Rows.Clear();
            for (int i = 0; i < Ejerc2NEGOCIO.Tam; i++)
            {
                if (Ejerc2NEGOCIO.Fentrega[i] > Ejerc2NEGOCIO.flimite[i])
                {
                    DatagridEjercicio1.Rows.Add(Ejerc2NEGOCIO.carnet[i], Ejerc2NEGOCIO.name[i], Ejerc2NEGOCIO.proyecto[i], Convert.ToString(Ejerc2NEGOCIO.Fentrega[i].Date), Convert.ToString(Ejerc2NEGOCIO.flimite[i].Date));
                }
            }
            DatagridEjercicio1.Sort(DatagridEjercicio1.Columns["Entrega"], ListSortDirection.Ascending);
        }
    }
}
