using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.Logica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmOperacionesDispersionesInicio : Form
    {
        public frmOperacionesDispersionesInicio()
        {
            InitializeComponent();
        }

        private void frmOperacionesDispersionesInicio_Load(object sender, EventArgs e)
        {
            PermisosUsuario(sender, e);
        }

        #region FUNCIONES USADAS POR CONTROLES

        // RECIBE EL FORMULARIO A MOSTRAR, LO EDITA Y LO MUESTRA
        private void MostrarForm(Form Formulario)
        {
            CerrarFormularios();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Formulario);
            this.panelContenedor.Tag = Formulario;
            Formulario.Show();
        }

        // PERMISOS USUARIOS
        private void PermisosUsuario(object sender, EventArgs e)
        {
            UsuarioData AUsuarioData = UsuarioData.Instancia;

            if (AUsuarioData.sTipoUsuario.Equals("20015"))
            {
                controlDeOperacionesToolStripMenuItem.Visible   = false;
                comisionesToolStripMenuItem.Visible             = false;
                concentradoDeAlimentosToolStripMenuItem.Visible = false;
            }
            //else if (!AUsuarioData.sTipoUsuario.Equals("3"))
            //{
            //    altaClienteToolStripMenuItem.Text           = "Registrar o Editar cliente";
            //    declaracionesToolStripMenuItem.Visible      = false;
            //    enviarSMSToolStripMenuItem.Visible          = false;
            //    expedienteEnLineaToolStripMenuItem.Visible  = false;
            //}
            //else if (AUsuarioData.sTipoUsuario.Equals("2"))
            //{
            //    menuStrip1.Visible = false;
            //}
            //else if (AUsuarioData.sTipoUsuario.Equals("1"))
            //{
            //    menuStrip1.Visible = false;
            //}
            //else if (AUsuarioData.sTipoUsuario.Equals("4"))
            //{
            //    menuStrip1.Visible = false;
            //}
            //else if (AUsuarioData.sTipoUsuario.Equals("5"))
            //{
            //    menuStrip1.Visible = false;
            //}
            //if (AUsuarioData.sTipoUsuario.Equals("6"))
            //{
            //    altaClienteToolStripMenuItem.Visible = false;
            //    obligacionesFiscalesToolStripMenuItem_Click(sender, e);
            //}
            //else if (AUsuarioData.sTipoUsuario.Equals("5"))
            //{
            //    altaClienteToolStripMenuItem.Text = "Registrar o Editar cliente";
            //    declaracionesToolStripMenuItem.Visible = false;
            //    enviarSMSToolStripMenuItem.Visible = false;
            //    expedienteEnLineaToolStripMenuItem.Visible = false;
            //    obligacionesFiscalesToolStripMenuItem.Visible = false;
            //    callCenterToolStripMenuItem.Visible = false;
            //}
            //else if (AUsuarioData.sTipoUsuario.Equals("1"))
            //{
            //    usuariosToolStripMenuItem.Visible = true;
            //}
            //else
            //{
            //    menuStrip1.Visible = false;
            //}
            lblNombreUsuario.Text = string.Format("{0} {1}", AUsuarioData.sNombre, AUsuarioData.sAPaterno);
        }

        // CIERRA LOS FORMULARIOS ABIERTOS Y PUESTOS EN EL FORM.
        private void CerrarFormularios()
        {
            Form[] sAforms = new Form[10];
            int iContador = 0;
            // Se genera el listado de los formularios abiertos
            foreach (Form x in Application.OpenForms)
            {
                string sForm = x.Name.ToString();

                if (!sForm.Equals("Login") && !sForm.Equals("frmOperacionesDispersionesInicio"))
                {
                    panelContenedor.Controls.Remove(x);
                    sAforms[iContador] = x;
                    iContador++;
                }
            }
            // Cierra los formularios
            for (int i = 0; i < 10; i++)
            {
                if (sAforms[i] != null)
                {
                    sAforms[i].Close();
                }
            }
        }
        #endregion FUNCIONES USADAS POR CONTROLES

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void operacionesAgentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA ISNTANCIA DEL FORM FRMOPERACIONESAGENTES
            frmOperacionesAgentes _frmOperacionesAgentes = new frmOperacionesAgentes();
            frmOperacionesAgentes OperacionesAgentes     = _frmOperacionesAgentes ?? new frmOperacionesAgentes();
            MostrarForm(OperacionesAgentes);
        }

        private void altaVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMALTAVENDEDOR
            frmAltaVendedor _frmAltaVendedor = new frmAltaVendedor();
            frmAltaVendedor AltaVendedor     = _frmAltaVendedor ?? new frmAltaVendedor();
            MostrarForm(AltaVendedor);
        }

        private void controlDeOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMCONTROLOPERACIONES
            frmControlOperaciones _frmControlOperaciones  = new frmControlOperaciones();
            frmControlOperaciones ControlOperaciones      = _frmControlOperaciones ?? new frmControlOperaciones();
            MostrarForm(ControlOperaciones);
        }

        private void comisionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMCOMISIONES
            frmComisiones _frmComisiones  = new frmComisiones();
            frmComisiones Comisiones      = _frmComisiones ?? new frmComisiones();
            MostrarForm(Comisiones);
        }

        private void concentradoDeAlimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMCONCENTRADOALIMENTOS
            //frmConcentradoAlimentos _frmConcentradoAlimentos  = new frmConcentradoAlimentos();
            //frmConcentradoAlimentos ConcentradoAlimentos      = _frmConcentradoAlimentos ?? new frmConcentradoAlimentos();
            //MostrarForm(ConcentradoAlimentos);
            frmReportes _frmReportes = new frmReportes();
            frmReportes Reportes     = _frmReportes ?? new frmReportes();
            MostrarForm(Reportes);
        }

        private void catToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMCATALOGOVENDEDORES
            frmCatalogoVendedores _frmCatalogoVendedores = new frmCatalogoVendedores();
            frmCatalogoVendedores CatalogoVendedores     = _frmCatalogoVendedores ?? new frmCatalogoVendedores();
            MostrarForm(CatalogoVendedores);
        }

        private void catálogoDeSCIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMCATALOGOSCI
            frmCatalogoSci _frmCatalogoSci = new frmCatalogoSci();
            frmCatalogoSci CatalogoSci     = _frmCatalogoSci ?? new frmCatalogoSci();
            MostrarForm(CatalogoSci);
        }

        private void frmOperacionesDispersionesInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //VALIDACIÓN PARA CERRAR LA APLICACIÓN
            DialogResult AResultado = MessageBox.Show("¿Esta seguro que desea salir?",
                                          "Salir",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (AResultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void comisionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //NUEVA INSTANCIA DEL FORM FRMCOMISIONESPAGO
            frmComisionesPago _frmComisionesPago = new frmComisionesPago();
            frmComisionesPago ComisionesPago = _frmComisionesPago ?? new frmComisionesPago();
            MostrarForm(ComisionesPago);
        }

        
    }
}
