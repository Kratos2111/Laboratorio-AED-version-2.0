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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        private void updateData()
        {
            DatagridEjercicio1.Rows.Clear();
            for(int i = 0; i < Ejer1NEGOCIO.Tam; i++) {
                DatagridEjercicio1.Rows.Add(Ejer1NEGOCIO.id[i], Ejer1NEGOCIO.name[i], Ejer1NEGOCIO.deuda[i],
                Ejer1NEGOCIO.direccion[i], Ejer1NEGOCIO.telefono[i],
                Ejer1NEGOCIO.getEstado(i));
            }
            DatagridEjercicio1.Sort(DatagridEjercicio1.Columns["Deuda"], ListSortDirection.Ascending);
        }
        private void filter1()
        {
            DatagridEjercicio1.Rows.Clear();
            for(int i = 0; i < Ejer1NEGOCIO.Tam; i++)
            {
                if (Ejer1NEGOCIO.estado[i])
                {
                    DatagridEjercicio1.Rows.Add(Ejer1NEGOCIO.id[i], Ejer1NEGOCIO.name[i], Ejer1NEGOCIO.deuda[i],
                    Ejer1NEGOCIO.direccion[i], Ejer1NEGOCIO.telefono[i],
                    Ejer1NEGOCIO.getEstado(i));
                }
            }
        }
        private void filter2()
        {
            DatagridEjercicio1.Rows.Clear();
            for (int i = 0; i < Ejer1NEGOCIO.Tam; i++)
            {
                if (!Ejer1NEGOCIO.estado[i])
                {
                    DatagridEjercicio1.Rows.Add(Ejer1NEGOCIO.id[i], Ejer1NEGOCIO.name[i], Ejer1NEGOCIO.deuda[i],
                    Ejer1NEGOCIO.direccion[i], Ejer1NEGOCIO.telefono[i],
                    Ejer1NEGOCIO.getEstado(i));
                }
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AddandModNegocio form = new AddandModNegocio();
            form.Show();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void DatagridEjercicio1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatagridEjercicio1_Enter(object sender, EventArgs e)
        {
            updateData();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Mod formMod = new Mod();
            formMod.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Ejer1NEGOCIO.isDeleting = true;
            Mod formMod = new Mod();
            formMod.Show();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            updateData();
        }

        private void rbPendientes_CheckedChanged(object sender, EventArgs e)
        {
            filter1();
        }

        private void rbSaldados_CheckedChanged(object sender, EventArgs e)
        {
            filter2();
        }

        private void DatagridEjercicio1_Leave(object sender, EventArgs e)
        {
            updateData();
        }

        private void DatagridEjercicio1_MouseHover(object sender, EventArgs e)
        {
            updateData();
        }

        private void Ejercicio1_Enter(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
