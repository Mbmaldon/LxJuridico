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
    public partial class frmTelefonoConfigurar : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        public frmTelefonoConfigurar()
        {
            InitializeComponent();
            IniciarControles();
        }

        public void IniciarControles()
        {
            UsuarioLinea linea = new UsuarioLinea().ObtenerLinea(int.Parse(AUsuarioData.sIdusuario));
            if (linea != null)
            {
                btnGuardar.Visible     = false;
                btnActualizar.Location = new Point(btnGuardar.Location.X, btnGuardar.Location.Y);
                btnActualizar.Visible  = true;

                string[] ip = linea.sDomainHost.Split('.');

                txtDisplayName.Text = linea.sDisplayName;
                txtUsuario.Text     = linea.sUserName;
                txtContrasenia.Text = linea.sRegisterPassword;
                txtIp1.Text         = ip[0];
                txtIp2.Text         = ip[1];
                txtIp3.Text         = ip[2];
                txtIp4.Text         = ip[3];
                txtPuerto.Text      = linea.iDomainPort.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == 0)
            {
                if ( iGuardarLinea() != 0)
                {
                    FlatMessageBox.Show("Configuración guardada correctamente.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                    //frmTelefono _frmTelefono = new frmTelefono();
                    //MostrarForm(_frmTelefono);
                }
            }
        }

        public int iGuardarLinea()
        {
            int iResultado = new UsuarioLinea().iNuevaLinea(new UsuarioLinea()
            {
                iIdUsuario        = int.Parse(AUsuarioData.sIdusuario),
                sDisplayName      = txtDisplayName.Text,
                sUserName         = txtUsuario.Text,
                sRegisterName     = txtUsuario.Text,
                sRegisterPassword = txtContrasenia.Text,
                sDomainHost       = string.Format("{0}.{1}.{2}.{3}", txtIp1.Text, txtIp2.Text, txtIp3.Text, txtIp4.Text),
                iDomainPort       = int.Parse(txtPuerto.Text)
            });
            return iResultado;
        }

        public int iActualizarLinea()
        {
            int iResultado = new UsuarioLinea().iActualizarLinea(new UsuarioLinea()
            {
                iIdUsuario        = int.Parse(AUsuarioData.sIdusuario),
                sDisplayName      = txtDisplayName.Text,
                sUserName         = txtUsuario.Text,
                sRegisterName     = txtUsuario.Text,
                sRegisterPassword = txtContrasenia.Text,
                sDomainHost       = string.Format("{0}.{1}.{2}.{3}", txtIp1.Text, txtIp2.Text, txtIp3.Text, txtIp4.Text),
                iDomainPort       = int.Parse(txtPuerto.Text)
            });
            return iResultado;
        }

        public void SoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        public int validarCampos()
        {
            int iResultado = 0;
            if (string.IsNullOrEmpty(txtDisplayName.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtDisplayName, "Debe ingresar el nombre a mostrar.");
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtUsuario, "Debe ingresar el usuario.");
            }

            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtUsuario, "Debe ingresar la contraseña del usuario.");
            }

            if (string.IsNullOrEmpty(txtIp1.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtIp4, "Debe ingresar una dirección valida.");
            }

            if (string.IsNullOrEmpty(txtIp2.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtIp4, "Debe ingresar una dirección valida.");
            }

            if (string.IsNullOrEmpty(txtIp3.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtIp4, "Debe ingresar una dirección valida.");
            }

            if (string.IsNullOrEmpty(txtIp4.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtIp4, "Debe ingresar una dirección valida.");
            }

            if (string.IsNullOrEmpty(txtPuerto.Text))
            {
                iResultado = 1;
                this.MensajeError.SetError(txtPuerto, "Debe ingresar el puerto.");
            }
            return iResultado;
        }

        //private void MostrarForm(Form Formulario)
        //{
        //    FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
        //    CerrarFormularios();
        //    Formulario.TopLevel         = false;
        //    Formulario.FormBorderStyle  = FormBorderStyle.None;
        //    Formulario.Dock             = DockStyle.Fill;
        //    _FPrincipal.pnlTelefono.Controls.Add(Formulario);
        //    _FPrincipal.pnlTelefono.Tag = Formulario;
        //    Formulario.Show();
        //}

        private void CerrarFormularios()
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarCampos() == 0)
            {
                if (iActualizarLinea() != 0)
                {
                    FlatMessageBox.Show(string.Format("Configuración actualizada correctamente.{0}La aplicación se reiniciará para surtir efectos.", Environment.NewLine), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                    //Start a new instance of the current program
                    System.Diagnostics.Process.Start(Application.ExecutablePath);

                    //close the current application process
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                }
            }
        }

        bool bEstadoPanel = true;
        private void lnkExpCol_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            if (bEstadoPanel)
            {
                metroToolTip1.SetToolTip(lnkExpCol, "Mostrar");
                lnkExpCol.Image = Properties.Resources.Arrowhead_Left;
            }
            else
            {
                metroToolTip1.SetToolTip(lnkExpCol, "Ocultar");
                lnkExpCol.Image = Properties.Resources.Arrowhead_Right;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //FPrincipal _FPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            //if (bEstadoPanel == true)
            //{
            //    if (_FPrincipal.pnlTelefono.Width <= 40)
            //    {
            //        timer2.Enabled = false;
            //        bEstadoPanel = false;
            //    }
            //    else
            //        _FPrincipal.pnlTelefono.Width -= 20;
            //}
            //else
            //{
            //    if (_FPrincipal.pnlTelefono.Width >= 255)
            //    {
            //        timer2.Enabled = false;
            //        bEstadoPanel = true;
            //    }
            //    else
            //        _FPrincipal.pnlTelefono.Width += 20;
            //}
        }
    }
}
