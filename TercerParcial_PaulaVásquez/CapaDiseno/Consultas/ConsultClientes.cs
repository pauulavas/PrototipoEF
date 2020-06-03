using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno.Consultas
{
    public partial class ConsultClientes : Form
    {

        Logica logica = new Logica();

        public ConsultClientes()
        {
            InitializeComponent();
            Dgv_consulta1.Rows.Clear();
            MostrarTabla();
        }

        public void MostrarTabla()
        {
            OdbcDataReader mostrar = logica.consulta6("1");
            try
            {
                while (mostrar.Read())
                {
                    Dgv_consulta1.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2), mostrar.GetString(3), mostrar.GetString(4), mostrar.GetString(5), mostrar.GetString(6));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consulta1.Rows.Clear();
            MostrarTabla();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consulta1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void ConsultClientes_Load(object sender, EventArgs e)
        {
            Dgv_consulta1.Rows.Clear();
            MostrarTabla();
        }
    }
}
