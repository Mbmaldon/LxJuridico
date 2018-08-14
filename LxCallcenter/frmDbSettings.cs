using MetroFramework;
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
    public partial class frmDbSettings : Form
    {
        //Constants
		const int AW_HIDE           = 0X10000;
        const int AW_SLIDE          = 0X40000;
        const int AW_HOR_POSITIVE   = 0X1;
        const int AW_HOR_NEGATIVE   = 0X2;
        const int AW_BLEND          = 0X80000;
        const int AW_VER_POSITIVE   = 0x00000004;
        const int AW_VER_NEGATIVE   = 0x00000008;
        

        [System.Runtime.InteropServices.DllImport("user32")]
        static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);

        private bool _UseSlideAnimation;
        public frmDbSettings() : this(false) { }

        public frmDbSettings(bool useSlideAnimation)
        {
            InitializeComponent();
            _UseSlideAnimation = useSlideAnimation;
		}

        static frmDbSettings _Settings;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show()
        {
            _Settings = new frmDbSettings();
            Form frmSet = Application.OpenForms["Login"];

            int x = Math.Max(frmSet.Location.X, frmSet.Location.X + (frmSet.Width - _Settings.Width) / 2);
            int y = frmSet.Location.Y + 1;
            _Settings.Location = new Point(x, y);

            _Settings.InitializeControls();

            _DialogResult = DialogResult.No;
            _Settings.Activate();
            _Settings.ShowDialog();
            return _DialogResult;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);
            AnimateWindow(this.Handle, 100, AW_SLIDE | AW_VER_POSITIVE);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (e.Cancel == false)
                AnimateWindow(this.Handle, 200, AW_HIDE | AW_SLIDE | AW_VER_NEGATIVE);
        }

        #region Funciones
        /// <summary>
        /// Inicializa los controles y carga la información
        /// para acceso a las base de datos
        /// </summary>
        public void InitializeControls()
        {
            if (LogicaCC.Properties.Settings.Default.DefaultConnection)
                chkbProduction.Checked = true;
            else
                chkbDeveloper.Checked = true;
            //if (!string.IsNullOrEmpty(LogicaCC.Properties.Settings.Default.DbUser))
            //{
            //    // Carga de los datos para la conexión al servidor
            //    txtDbServer.Text            = LogicaCC.Properties.Settings.Default.DbServer;
            //    txtDbUser.Text              = LogicaCC.Properties.Settings.Default.DbUser;
            //    txtDbPassword.Text          = LogicaCC.Properties.Settings.Default.DbPassword;
            //    // Carga de los nombres de las bases de datos
            //    txtDbMedic.Text             = LogicaCC.Properties.Settings.Default.DbMedic;
            //    txtDbMedicAlimentos.Text    = LogicaCC.Properties.Settings.Default.DbMedicAlimentos;
            //    txtDbMedicConta.Text        = LogicaCC.Properties.Settings.Default.DbMedicConta;
            //    txtDbMedicOpera.Text        = LogicaCC.Properties.Settings.Default.DbMedicOpera;
            //    txtDbMedicCsjdb.Text        = LogicaCC.Properties.Settings.Default.DbMedicCSJDB;
            //}       
        }

        /// <summary>
        /// Guarda los cambios de las configuraciones para la conexión al servidor
        /// y bases de datos
        /// </summary>
        public void SaveSettings()
        {
            // Guardamos las configuraciones de la conexión al servidor
            if (chkbProduction.Checked)
                LogicaCC.Properties.Settings.Default.DefaultConnection = true;
            else
                LogicaCC.Properties.Settings.Default.DefaultConnection = false;

            LogicaCC.Properties.Settings.Default.Save();
        }

        ///// <summary>
        ///// Valida que los campos requeridos tengan información
        ///// </summary>
        ///// <returns></returns>
        //public bool FieldsValidation()
        //{
        //    errorProvider1.Clear();
        //    bool bResultado = true;
        //    if (string.IsNullOrEmpty(_Settings.txtDbUser.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbUser, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(_Settings.txtDbUser.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbUser, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(txtDbPassword.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbPassword, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(txtDbMedic.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbMedic, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(txtDbMedicAlimentos.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbMedicAlimentos, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(txtDbMedicConta.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbMedicConta, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(txtDbMedicOpera.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbMedicOpera, "Campo requerido");
        //    }

        //    if (string.IsNullOrEmpty(txtDbMedicCsjdb.Text))
        //    {
        //        bResultado = false;
        //        errorProvider1.SetError(txtDbMedicCsjdb, "Campo requerido");
        //    }
        //    return bResultado;
        //}
        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _Settings.SaveSettings();
            _DialogResult = DialogResult.Yes;
            _Settings.Close();

            MessageBox.Show("La aplicación se cerrara para surtir cambios.", "Configuraciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _Settings.Close();
        }
        #endregion

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            //if (FieldsValidation())
            //{
            //    if (LogicaCC.ConnectionString.Connect(txtDbServer.Text, txtDbUser.Text, txtDbPassword.Text, txtDbMedic.Text))
            //    {
            //        if (LogicaCC.ConnectionString.Connect(txtDbServer.Text, txtDbUser.Text, txtDbPassword.Text, txtDbMedicAlimentos.Text))
            //        {
            //            if (LogicaCC.ConnectionString.Connect(txtDbServer.Text, txtDbUser.Text, txtDbPassword.Text, txtDbMedicConta.Text))
            //            {
            //                if (LogicaCC.ConnectionString.Connect(txtDbServer.Text, txtDbUser.Text, txtDbPassword.Text, txtDbMedicOpera.Text))
            //                {
            //                    if (LogicaCC.ConnectionString.Connect(txtDbServer.Text, txtDbUser.Text, txtDbPassword.Text, txtDbMedicCsjdb.Text))
            //                    {
            //                        MetroMessageBox.Show(this, "Las pruebas de conexión al servidor han sido exitosas", "Conexión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information, 200);
            //                    }
            //                    else
            //                    {
            //                        MetroMessageBox.Show(this, LogicaCC.ConnectionString.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            //                    }
            //                }
            //                else
            //                {
            //                    MetroMessageBox.Show(this, LogicaCC.ConnectionString.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            //                }
            //            }
            //            else
            //            {
            //                MetroMessageBox.Show(this, LogicaCC.ConnectionString.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            //            }
            //        }
            //        else
            //        {
            //            MetroMessageBox.Show(this, LogicaCC.ConnectionString.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            //        }
            //    }
            //    else
            //    {
            //        MetroMessageBox.Show(this, LogicaCC.ConnectionString.GetError(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, 200);
            //    }
            //}
        }
    }
}
