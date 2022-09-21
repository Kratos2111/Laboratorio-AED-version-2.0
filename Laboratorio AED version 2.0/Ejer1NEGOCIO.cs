using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace Laboratorio_AED_version_2._0
{
    static internal class Ejer1NEGOCIO
    {

        //debtor's property
        static public int[] id;
        static public string[] name;
        static public float[] deuda;
        static public string[] direccion;
        static public int[] telefono;
        static public bool[] estado;
        static public int Tam;
        static public bool isEditing;
        static public int indexEditing;
        static public bool isDeleting;


        //generate a number from 1 to 100
        private static int GenerarId()
        {
            Random rnd = new Random();
            return rnd.Next(1, 101);
        }
        public static void searchById(int a)
        {
            int x = Array.IndexOf(id, a);
            if(x >= 0)
            {
                indexEditing = x;
            }
            else
            {
                MessageBox.Show("No se encontro al deudor");
            }

        }
        public static void agregarCliente(float b, string c, string d, int numero, bool state)
        {
            try
            {
                Tam++;
                Array.Resize(ref id, Tam);
                Array.Resize(ref deuda, Tam);
                Array.Resize(ref name, Tam);
                Array.Resize(ref direccion, Tam);
                Array.Resize(ref telefono, Tam);
                Array.Resize(ref estado, Tam);

                id[Tam - 1] = GenerarId();
                deuda[Tam - 1] = b;
                name[Tam - 1] = c;
                direccion[Tam - 1] = d;
                telefono[Tam - 1] = numero;
                estado[Tam - 1] = state;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo agregar el Deudor", e.Message);
            }

        }
        //translaste the value of "estado" to string;
        public static string getEstado(int a)
        {
            if (!estado[a])
            {
                return "Pagada";
            }
            else { return "No pagada"; }
        }
        public static void eliminarDeudor(string a)
        {
            int index;
            try
            {
                index = Array.IndexOf(id, int.Parse(a));
                if (index < 0) { MessageBox.Show("Deudor no encontrado"); return; }
                for (int i = index; i < Tam - 1; i++)
                {
                    id[i] = id[i + 1];
                    name[i] = name[i + 1];
                    deuda[i] = deuda[i + 1];
                    direccion[i] = direccion[i + 1];
                    telefono[i] = telefono[i + 1];
                    estado[i] = estado[i + 1];
                }
                Tam--;
                Array.Resize(ref id, Tam);
                Array.Resize(ref name, Tam);
                Array.Resize(ref deuda, Tam);
                Array.Resize(ref direccion, Tam);
                Array.Resize(ref telefono, Tam);
                Array.Resize(ref estado, Tam);
                MessageBox.Show("Deudor eliminado con exito", "Success");

            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontro el deudor", e.Message);
            }

        }

    }
}
