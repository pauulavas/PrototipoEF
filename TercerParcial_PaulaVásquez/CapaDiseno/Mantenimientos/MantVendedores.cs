﻿using CapaDiseno.Consultas;
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

namespace CapaDiseno.Mantenimientos
{
    public partial class MantVendedores : Form
    {
        Logica logic = new Logica();
        public MantVendedores()
        {
            InitializeComponent();
            //bloqueo de campos
            bloquear();
        }

        public void limpiar()
        {
            Txt_1.Clear();
            Txt_2.Clear();
            Txt_3.Clear();
            Txt_4.Clear();
            Txt_5.Clear();
            Cbo_estado.ResetText();
        }

        public void bloquear()
        {
            gpb_datos.Enabled = false;
        }

        public void desbloquear()
        {
            gpb_datos.Enabled = true;
        }


        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            desbloquear();
        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.modificar1(Txt_1.Text, Txt_2.Text, Txt_3.Text, Txt_4.Text, Txt_5.Text, Cbo_estado.Text);
            MessageBox.Show("Datos modificados correctamente.");
            limpiar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.guardar1(Txt_1.Text, Txt_2.Text, Txt_3.Text, Txt_4.Text, Txt_5.Text, Cbo_estado.Text);
            MessageBox.Show("Datos registrados.");
            limpiar();
        }

        private void Btn_borrar_Click(object sender, EventArgs e)
        {
            if (Cbo_estado.Text == "Activo")
            {
                Cbo_estado.Text = "1";
            }
            else
            {
                Cbo_estado.Text = "0";
            }
            OdbcDataReader cita = logic.eliminar1(Txt_1.Text);
            MessageBox.Show("Eliminado Correctamentee.");
            limpiar();
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            ConsultVendedores concep = new ConsultVendedores();
            concep.ShowDialog();

            if (concep.DialogResult == DialogResult.OK)
            {
                Txt_1.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[0].Value.ToString();
                Txt_2.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[1].Value.ToString();
                Txt_3.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[2].Value.ToString();
                Txt_4.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[3].Value.ToString();
                Txt_5.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[4].Value.ToString();
                Cbo_estado.Text = concep.Dgv_consulta1.Rows[concep.Dgv_consulta1.CurrentRow.Index].
                      Cells[5].Value.ToString();
            }
        }
    }
}
