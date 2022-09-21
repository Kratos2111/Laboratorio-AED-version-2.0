using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_AED_version_2._0
{
    internal class Ejerc2NEGOCIO
    {
        //debtor's property
        static public string[] carnet;
        static public string[] name;
        static public string[] proyecto;
        static public DateTime[] Fentrega;
        static public DateTime[] flimite;
        static public int Tam;
        static public bool isEditing;
        static public int indexEditing;
        static public bool isDeleting;


        //generate a number from 1 to 100
        public static void searchById(string a)
        {
            int x = Array.IndexOf(carnet, a);
            if (x >= 0)
            {
                indexEditing = x;
            }
            else
            {
                MessageBox.Show("No se encontro al proyecto");
            }

        }
        public static void agregarCliente(string nmCarnet, string nmProyecto, string nmNombre, DateTime d, DateTime numero)
        {
            try
            {
                Tam++;
                Array.Resize(ref carnet, Tam);
                Array.Resize(ref proyecto, Tam);
                Array.Resize(ref name, Tam);
                Array.Resize(ref Fentrega, Tam);
                Array.Resize(ref flimite, Tam);

                carnet[Tam - 1] = nmCarnet;
                proyecto[Tam - 1] = nmProyecto;
                name[Tam - 1] = nmNombre;
                Fentrega[Tam - 1] = d;
                flimite[Tam - 1] = numero;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo agregar el proyecto", e.Message);
            }

        }
        public static void eliminarDeudor(string a)
        {
            int index;
            try
            {
                index = Array.IndexOf(carnet, a);
                if (index < 0) { MessageBox.Show("Proyecto no encontrado"); return; }
                for (int i = index; i < Tam - 1; i++)
                {
                    carnet[i] = carnet[i + 1];
                    name[i] = name[i + 1];
                    proyecto[i] = proyecto[i + 1];
                    Fentrega[i] = Fentrega[i + 1];
                    flimite[i] = flimite[i + 1];
                }
                Tam--;
                Array.Resize(ref carnet, Tam);
                Array.Resize(ref name, Tam);
                Array.Resize(ref proyecto, Tam);
                Array.Resize(ref Fentrega, Tam);
                Array.Resize(ref flimite, Tam);
                MessageBox.Show("Proyecto eliminado con exito", "Success");

            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro el proyecto", e.Message);
            }

        }
    }
}
