using CapaDiseno.Consultas;
using CapaDiseno.Mantenimientos;
using CapaDiseno.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseno
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {

        }
        bool Mant_Uno = false;
        MantVendedores mant_uno = new MantVendedores();
        private void unoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantVendedores);
            if (Mant_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_uno = new MantVendedores();
                }

                mant_uno.MdiParent = this;
                mant_uno.Show();
                Application.DoEvents();
                Mant_Uno = true;
            }
            else
            {
                mant_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        /*
        bool Proceso_Uno = false;
        Proceso proceso_uno = new Proceso();
        private void unoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Proceso);
            if (Proceso_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                    proceso_uno = new Proceso();
                }

                proceso_uno.MdiParent = this;
                proceso_uno.Show();
                Application.DoEvents();
                Proceso_Uno = true;
            }
            else
            {
                proceso_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        */
        bool Consult_Uno = false;
        ConsultVendedores consult_uno = new ConsultVendedores();
        private void unoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultVendedores);
            if (Consult_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                   consult_uno = new ConsultVendedores();
                }

                consult_uno.MdiParent = this;
                consult_uno.Show();
                Application.DoEvents();
                Consult_Uno = true;
            }
            else
            {
                consult_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        bool Mant_Dos = false;
        MantMarcas mant_dos = new MantMarcas();
        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantMarcas);
            if (Mant_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_dos = new MantMarcas();
                }

                mant_dos.MdiParent = this;
                mant_dos.Show();
                Application.DoEvents();
                Mant_Dos = true;
            }
            else
            {
                mant_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_Dos = false;
        ConsultMarcas consult_dos = new ConsultMarcas();
        private void aulaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultMarcas);
            if (Consult_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_dos = new ConsultMarcas();
                }

                consult_dos.MdiParent = this;
                consult_dos.Show();
                Application.DoEvents();
                Consult_Dos = true;
            }
            else
            {
                consult_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Mant_Tres = false;
        MantBodegas mant_tres = new MantBodegas();
        private void facultadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantBodegas);
            if (Mant_Tres == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_tres = new MantBodegas();
                }

                mant_tres.MdiParent = this;
                mant_tres.Show();
                Application.DoEvents();
                Mant_Tres = true;
            }
            else
            {
                mant_tres.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        private void seccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
       
        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
       
        private void jornadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        bool Mant_7 = false;
        MantLineas mant_7 = new MantLineas();
        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantLineas);
            if (Mant_7 == false || frmC == null)
            {
                if (frmC == null)
                {
                    mant_7 = new MantLineas();
                }

                mant_7.MdiParent = this;
                mant_7.Show();
                Application.DoEvents();
                Mant_7 = true;
            }
            else
            {
                mant_7.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        /*bool Proceso_Dos = false;
        AsignacionCursoCatedratico proceso_dos = new AsignacionCursoCatedratico();
        private void dosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is AsignacionCursoCatedratico);
            if (Proceso_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    proceso_dos = new AsignacionCursoCatedratico();
                }

                proceso_dos.MdiParent = this;
                proceso_dos.Show();
                Application.DoEvents();
                Proceso_Dos = true;
            }
            else
            {
                proceso_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        */
        bool Consult_3 = false;
        ConsultBodega consult_3 = new ConsultBodega();
        private void facultadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultBodega);
            if (Consult_3 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_3 = new ConsultBodega();
                }

                consult_3.MdiParent = this;
                consult_3.Show();
                Application.DoEvents();
                Consult_3 = true;
            }
            else
            {
                consult_3.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        private void seccionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }
        
        private void sedesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void jornadasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
        }
        bool Consult_7 = false;
        ConsultLineas consult_7 = new ConsultLineas();
        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultLineas);
            if (Consult_7 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_7 = new ConsultLineas();
                }

                consult_7.MdiParent = this;
                consult_7.Show();
                Application.DoEvents();
                Consult_7 = true;
            }
            else
            {
                consult_7.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        
        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }
        
        private void asignacionCursoCatedráticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        bool Consult_9 = false;
        MantClientes consult_9 = new MantClientes();
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantClientes);
            if (Consult_9 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_9 = new MantClientes();
                }

                consult_9.MdiParent = this;
                consult_9.Show();
                Application.DoEvents();
                Consult_9 = true;
            }
            else
            {
                consult_9.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_8 = false;
        MantProveedores consult_8 = new MantProveedores();
        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantProveedores);
            if (Consult_8 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_8 = new MantProveedores();
                }

                consult_8.MdiParent = this;
                consult_8.Show();
                Application.DoEvents();
                Consult_8 = true;
            }
            else
            {
                consult_8.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_6 = false;
        ConsultProveedor consult_6 = new ConsultProveedor();
        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultProveedor);
            if (Consult_6 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_6 = new ConsultProveedor();
                }

                consult_6.MdiParent = this;
                consult_6.Show();
                Application.DoEvents();
                Consult_6 = true;
            }
            else
            {
                consult_6.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_5 = false;
        ConsultClientes consult_5 = new ConsultClientes();
        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is ConsultClientes);
            if (Consult_5 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_5 = new ConsultClientes();
                }

                consult_5.MdiParent = this;
                consult_5.Show();
                Application.DoEvents();
                Consult_5 = true;
            }
            else
            {
                consult_5.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_11 = false;
        MantProducto consult_11 = new MantProducto();
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is MantProducto);
            if (Consult_11 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_11 = new MantProducto();
                }

                consult_11.MdiParent = this;
                consult_11.Show();
                Application.DoEvents();
                Consult_11 = true;
            }
            else
            {
                consult_11.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Consult_12 = false;
        Consult_Producto consult_12 = new Consult_Producto();
        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consult_Producto);
            if (Consult_12 == false || frmC == null)
            {
                if (frmC == null)
                {
                    consult_12 = new Consult_Producto();
                }

                consult_12.MdiParent = this;
                consult_12.Show();
                Application.DoEvents();
                Consult_12 = true;
            }
            else
            {
                consult_12.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Proceso_Dos = false;
        VentasEncabezado proceso_dos = new VentasEncabezado();
        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is VentasEncabezado);
            if (Proceso_Dos == false || frmC == null)
            {
                if (frmC == null)
                {
                    proceso_dos = new VentasEncabezado();
                }

                proceso_dos.MdiParent = this;
                proceso_dos.Show();
                Application.DoEvents();
                Proceso_Dos = true;
            }
            else
            {
                proceso_dos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool Proceso_Uno = false;
        Existencias proceso_uno = new Existencias();
        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Existencias);
            if (Proceso_Uno == false || frmC == null)
            {
                if (frmC == null)
                {
                    proceso_uno = new Existencias();
                }

                proceso_uno.MdiParent = this;
                proceso_uno.Show();
                Application.DoEvents();
                Proceso_Uno = true;
            }
            else
            {
                proceso_uno.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
