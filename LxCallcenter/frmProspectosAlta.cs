using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmProspectosAlta : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        public frmProspectosAlta()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region FUNCIONES
        /// <summary>
        /// Inicializa la información que se cargara desde
        /// un principio en el formulario
        /// </summary>
        public void InitializeControls()
        {
            LoadRegimen();
            LoadGeneros();
            LoadEstados();
            LoadGrupos();

            pnlFormMoral.Location = new Point(84, 105);
        }

        /// <summary>
        /// Carga un listado de generos
        /// </summary>
        public void LoadGeneros()
        {
            cmbxGenero.DataSource    = new Genero().GetList();
            cmbxGenero.ValueMember   = "iIdGenero";
            cmbxGenero.DisplayMember = "sGenero";
            cmbxGenero.SelectedIndex = -1;
        }

        /// <summary>
        /// Carga un listado de Estados
        /// </summary>
        public void LoadEstados()
        {
            DataSet ds;
            Estados AEstados = new Estados();
            ds = AEstados.ListaEstados();

            cmbxEstado.DataSource       = ds.Tables["Estados"];
            cmbxEstado.DisplayMember    = "estado";
            cmbxEstado.ValueMember      = "id";
            cmbxEstado.SelectedValue    = 33;

            cmbxEstadoMoral.DataSource       = ds.Tables["Estados"];
            cmbxEstadoMoral.DisplayMember    = "estado";
            cmbxEstadoMoral.ValueMember      = "id";
            cmbxEstadoMoral.SelectedValue    = 33;
        }

        /// <summary>
        /// Carga un listado de regimenes
        /// </summary>
        public void LoadRegimen()
        {
            cmbxRegimen.DataSource    = new Regimen().GetList();
            cmbxRegimen.ValueMember   = "iIdRegimen";
            cmbxRegimen.DisplayMember = "sRegimen";
            cmbxRegimen.SelectedIndex = -1;
        }

        /// <summary>
        /// Carga un listado de grupos
        /// </summary>
        public void LoadGrupos()
        {
            cmbxGrupoFisica.DataSource      = new Grupo().GetList(1);
            cmbxGrupoFisica.ValueMember     = "iIdGrupo";
            cmbxGrupoFisica.DisplayMember   = "sGrupo";
            cmbxGrupoFisica.SelectedIndex   = -1;

            cmbxGrupoMoral.DataSource       = new Grupo().GetList(1);
            cmbxGrupoMoral.ValueMember      = "iIdGrupo";
            cmbxGrupoMoral.DisplayMember    = "sGrupo";
            cmbxGrupoMoral.SelectedIndex    = -1;
        }

        /// <summary>
        /// Valida que los campos requerido tengan información.
        /// </summary>
        /// <returns></returns>
        public bool ValidateForm()
        {
            errorProvider1.Clear();
            bool bResultado = true;

            if (cmbxRegimen.SelectedValue.ToString() == "1")
            {
                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtNombre, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtAPaterno.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtAPaterno, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtAMaterno.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtAMaterno, "Campo Requerido");
                }
                if (string.IsNullOrEmpty(txtEdad.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtEdad, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtCorreoE.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtCorreoE, "Campo rquerido");
                }
                if (string.IsNullOrEmpty(txtTelefono.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtTelefono, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxGenero.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxGenero, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtCodigoPostal.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtCodigoPostal, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxEstado.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxEstado, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtDomicilio.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtDomicilio, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxGrupoFisica.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxGrupoFisica, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxAgenteFisica.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxAgenteFisica, "Campo requerido");
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtRazonSocial.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtRazonSocial, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtRFC.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtRFC, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxEstadoMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxEstadoMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtCodigoPostalMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtCodigoPostalMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtDomicilioMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtDomicilioMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtNombreMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtNombreMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtAPaternoMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtAPaternoMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtAMaternoMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtAMaternoMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtPuesto.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtPuesto, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtCorreoMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtCorreoMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(txtTelefonoMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(txtTelefonoMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxGrupoMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxGrupoMoral, "Campo requerido");
                }
                if (string.IsNullOrEmpty(cmbxAgenteMoral.Text))
                {
                    bResultado = false;
                    errorProvider1.SetError(cmbxAgenteMoral, "Campo requerido");
                }
            }

            return bResultado;
        }

        /// <summary>
        /// Realiza el alta de un nuevo prospecto
        /// </summary>
        public void SaveProspecto()
        {
            int iResultado = 0;

            // Valida que regimen esta seleccionado
            if (cmbxRegimen.SelectedValue.ToString() == "1")
            {
                iResultado = new Prospecto().NewItem(int.Parse(AUsuarioData.sIdusuario), txtNombre.Text
                                                   , txtAPaterno.Text, txtAMaterno.Text
                                                   , int.Parse(txtEdad.Text), txtCorreoE.Text
                                                   , txtTelefono.Text, int.Parse(cmbxGenero.SelectedValue.ToString())
                                                   , txtCodigoPostal.Text, int.Parse(cmbxEstado.SelectedValue.ToString())
                                                   , txtDomicilio.Text, int.Parse(cmbxAgenteFisica.SelectedValue.ToString()));
            }
            else
            {
                iResultado = new Prospecto().NewItem(int.Parse(AUsuarioData.sIdusuario), txtRazonSocial.Text
                                                   , txtRFC.Text, int.Parse(cmbxEstadoMoral.SelectedValue.ToString())
                                                   , txtCodigoPostalMoral.Text, txtDomicilioMoral.Text
                                                   , txtNombreMoral.Text, txtAPaternoMoral.Text
                                                   , txtAMaternoMoral.Text, txtPuesto.Text
                                                   , txtCorreoMoral.Text, txtTelefonoMoral.Text
                                                   , int.Parse(cmbxAgenteMoral.SelectedValue.ToString()));
            }

            if (iResultado > 0)
            {
                this.Invoke((MethodInvoker)delegate { UpdateList(); });
                ClearForm();
                FlatMessageBox.Show("Prospecto Guardado Exitosamente", "Ok", string.Empty, FlatMessageBoxIcon.Information);                
            }
            else if (iResultado == -2)
            {
                FlatMessageBox.Show("Error al guardar en la base de datos", "Ok", string.Empty, FlatMessageBoxIcon.Error);
            }
            else if (iResultado == -1)
            {
                FlatMessageBox.Show("Error al guardar, revise que la información sea correcta", "Ok", string.Empty, FlatMessageBoxIcon.Warning);
            }
            else if (iResultado == 0)
            {
                FlatMessageBox.Show("Error en la validación de la información en la consulta", "Ok", string.Empty, FlatMessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Limpia el contenido de los formularios
        /// </summary>
        public void ClearForm()
        {
            // Formulario: Persona Física
            txtNombre.Text       = "";
            txtAPaterno.Text     = "";
            txtAMaterno.Text     = "";
            txtEdad.Text         = "";
            txtCorreoE.Text      = "";
            txtTelefono.Text     = "";
            txtCodigoPostal.Text = "";
            txtDomicilio.Text    = "";
            cmbxGenero.SelectedIndex = -1;
            cmbxEstado.SelectedValue = 31;
            cmbxGrupoFisica.SelectedIndex = -1;
            cmbxAgenteFisica.DataSource = null;

            // Formulario: Persona Moral
            txtRazonSocial.Text         = "";
            txtRFC.Text                 = "";
            txtCodigoPostalMoral.Text   = "";
            txtDomicilioMoral.Text      = "";
            txtNombreMoral.Text         = "";
            txtAPaternoMoral.Text       = "";
            txtAMaternoMoral.Text       = "";
            txtPuesto.Text              = "";
            txtCorreoMoral.Text         = "";
            txtTelefonoMoral.Text       = "";
            cmbxEstadoMoral.SelectedValue = 31;
            cmbxGrupoMoral.SelectedIndex = -1;
            cmbxAgenteMoral.DataSource = null;
        }

        /// <summary>
        /// Actualiza el contenido del listado de prospectos del formulario frmProspectos
        /// que es donde se muestran todos
        /// </summary>
        public void UpdateList()
        {
            frmProspectos _Prospectos = Application.OpenForms["frmProspectos"] as frmProspectos;
            if (_Prospectos != null)
                _Prospectos.LoadProspectos();
        }
        #endregion

        #region EVENTOS
        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
                SaveProspecto();
        }

        private void cmbxRegimen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnGuardar.Visible = true;
            if (cmbxRegimen.SelectedValue.ToString() == "1")
            {
                pnlFormMoral.Visible = false;
                pnlFormFisica.Visible = true;
            }
            else
            {
                pnlFormFisica.Visible = false;
                pnlFormMoral.Visible = true;
            }
        }

        private void JustNumbers(Object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void cmbxGrupoFisica_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbxAgenteFisica.DataSource = new LogicaCC.LexaSIOContaLogica.Usuario().GetListCallCenter(int.Parse(cmbxGrupoFisica.SelectedValue.ToString()));
            cmbxAgenteFisica.DisplayMember = "sNombre";
            cmbxAgenteFisica.ValueMember = "iIdUsuario";
        }

        private void cmbxGrupoMoral_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbxAgenteMoral.DataSource = new LogicaCC.LexaSIOContaLogica.Usuario().GetListCallCenter(int.Parse(cmbxGrupoMoral.SelectedValue.ToString()));
            cmbxAgenteMoral.DisplayMember = "sNombre";
            cmbxAgenteMoral.ValueMember = "iIdUsuario";
        }
        #endregion

        #region Code for border shadow
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }

        #endregion
    }
}