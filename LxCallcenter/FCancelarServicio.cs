using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class FCancelarServicio : Form
    {
        FPrincipal _frmPrincipal;
        public FCancelarServicio()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCliente.Text))
            {
                lblCampoRequerido.Visible = false;
                buscarServicio(txtCliente.Text);
            }
            else
            {
                lblCampoRequerido.Text    = "*Campo Requerido";
                lblCampoRequerido.Visible = true;
            }
        }

        Servicio sServicio = null;
        public void buscarServicio(string sNoCliente)
        {
            sServicio = new Servicio().BuscarServicio(sNoCliente);
            if (sServicio != null)
            {
                lblCampoRequerido.Visible   = false;
                lblNoCliente.Text           = sServicio.sNoCliente;
                lblRfc.Text                 = sServicio.sRfc;
                lblCurp.Text                = sServicio.sCurp;
                lblNombreCliente.Text       = sServicio.sNombre;
                lblContadorA.Text           = sServicio.sContadorA;
                lblServicioContratado.Text  = sServicio.sServicio;
                lblEstadoServicio.Text      = sServicio.sEstadoServicio;
                lblFContratacion.Text       = sServicio.dtFechaContratacion.ToShortDateString();
                lblFVencimiento.Text        = sServicio.dtFechaVencimiento.ToShortDateString();
                chbxActivo.Checked          = bool.Parse(sServicio.sActivo);
                btnCancelarServicio.Enabled = true;

                // Busca el formulario principal abierto para poder obtener sus propiedades
                _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
                if (_frmPrincipal != null)
                    _frmPrincipal.btnCConfirmarCancelarServicio.Enabled = true;
            }
            else
            {
                lblCampoRequerido.Text      = "*No existe el cliente";
                lblCampoRequerido.Visible   = true;
            }
        }

        private void btnCancelarServicio_Click(object sender, EventArgs e)
        {
            cancelarServicio();        
        }

        public void cancelarServicio()
        {
            if ((FlatMessageBox.Show("¿Está seguro de cancelar el servicio del cliente?", "SI", "NO", FlatMessageBoxIcon.Warning)) == DialogResult.Yes)
            {
                UsuarioData AUsuarioData = UsuarioData.Instancia;

                if ((new Servicio().bCancelarServicio(new Servicio()
                {
                    iIdServicio = sServicio.iIdServicio,
                    iIdUsuario  = int.Parse(AUsuarioData.sIdusuario)
                })) == true)
                {
                    txtCliente.Clear();
                    lblNoCliente.Text           = "--";
                    lblRfc.Text                 = "--";
                    lblCurp.Text                = "--";
                    lblNombreCliente.Text       = "--";
                    lblContadorA.Text           = "--";
                    lblServicioContratado.Text  = "--";
                    lblEstadoServicio.Text      = "--";
                    lblFContratacion.Text       = "--";
                    lblFVencimiento.Text        = "--";
                    chbxActivo.Checked          = false;
                    btnCancelarServicio.Enabled = false;
                    _frmPrincipal.btnCConfirmarCancelarServicio.Enabled = false;
                    FlatMessageBox.Show("Servicio Cancelado.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                }
                else
                {
                    FlatMessageBox.Show("No se pudo cancelar, reintentar en un momento.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }
            }
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
                btnBuscar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        public void cancelar()
        {
            txtCliente.Clear();
            lblNoCliente.Text           = "--";
            lblRfc.Text                 = "--";
            lblCurp.Text                = "--";
            lblNombreCliente.Text       = "--";
            lblContadorA.Text           = "--";
            lblServicioContratado.Text  = "--";
            lblEstadoServicio.Text      = "--";
            lblFContratacion.Text       = "--";
            lblFVencimiento.Text        = "--";
            chbxActivo.Checked          = false;
            btnCancelarServicio.Enabled = false;
            _frmPrincipal.btnCConfirmarCancelarServicio.Enabled = false;
        }
    }
}
