using DevExpress.Export;
using LogicaCC.LexaSIOContaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class ConcentradoUsuarios : Form
    {
        LogicaCC.Logica.UsuarioData AUsuario;
        Usuario InformacionUsuario;
        public ConcentradoUsuarios()
        {
            InitializeComponent();
            AUsuario = LogicaCC.Logica.UsuarioData.Instancia;
        }

        private void ConcentradoUsuarios_Load(object sender, EventArgs e)
        {
            //ASIGNA FORMATO AL DOCUMENTO EXPORTADO DESDE EL GRIDVIEW DE DEVEXPRESS
            ExportSettings.DefaultExportType                    = ExportType.WYSIWYG;
            gridView1.AppearancePrint.HeaderPanel.BackColor     = Color.FromArgb(7, 22, 127);
            gridView1.AppearancePrint.HeaderPanel.ForeColor     = Color.White;
            gridView1.AppearancePrint.HeaderPanel.BorderColor   = Color.FromArgb(7, 22, 127);
            gridView1.AppearancePrint.FooterPanel.BackColor     = Color.White;
            gridView1.AppearancePrint.FooterPanel.BorderColor   = Color.White;
            gridView1.AppearancePrint.Row.BorderColor           = Color.FromArgb(216, 216, 216);
            gridView1.OptionsPrint.AutoWidth                    = false;
            gridView1.OptionsPrint.UsePrintStyles               = true;


            grdUsuarios.DataSource = new Usuario().listaUsuarios();
            gridView1.BestFitColumns();
            gridView1.Appearance.FooterPanel.Options.UseBackColor   = true;
            gridView1.Appearance.FooterPanel.Options.UseBorderColor = true;
            gridView1.Appearance.FooterPanel.BackColor              = Color.White;
            gridView1.Appearance.FooterPanel.BackColor2             = Color.White;
            gridView1.Appearance.FooterPanel.BorderColor            = Color.White;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator(new DevExpress.Data.Filtering.OperandProperty("sNombre"), new DevExpress.Data.Filtering.OperandValue("%" + txtBuscar.Text + "%"), DevExpress.Data.Filtering.BinaryOperatorType.Like);
            gridView1.ExpandAllGroups();
        }


        private void EstadoControles(bool estado)
        {
            label1.Enabled      = estado;
            label2.Enabled      = estado;
            label3.Enabled      = estado;
            txtBuscar.Enabled   = estado;
            grdUsuarios.Enabled = estado;
            lnkDetalles.Enabled = estado;
            lnkExportar.Enabled = estado;

            if (estado ==false)
            {
                lnkDetalles.BackColor = Color.FromArgb(219, 219, 219);
                lnkExportar.BackColor = Color.FromArgb(219, 219, 219);
            }
            else
            {
                lnkDetalles.BackColor = Color.FromArgb(244, 244, 244);
                lnkExportar.BackColor = Color.FromArgb(244, 244, 244);
            }
        }
        
        public void obtenerInformacionUsuario()
        {
            var rowHandle = gridView1.FocusedRowHandle;
            int id        = int.Parse(gridView1.GetRowCellValue(rowHandle, "iIdUsuario").ToString());
            InformacionUsuario = new Usuario().InformacionUsuario(id);
            if(InformacionUsuario != null)
            {
                lblId.Text                      = InformacionUsuario.iIdUsuario.ToString();
                lblNombreUsuario.Text           = string.Format("{0} {1} {2}", InformacionUsuario.sNombre, InformacionUsuario.sAPaterno, InformacionUsuario.sAMaterno);
                lblUsuario.Text                 = InformacionUsuario.sUsuario;
                lblContrasenia.Text             = InformacionUsuario.sContrasena;
                lblCedulaProfesional.Text       = InformacionUsuario.sCedula;
                lblCorreoElectronico.Text       = InformacionUsuario.sCorreoElectronico;
                lblTelLocal.Text                = InformacionUsuario.sTelefonoLocal;
                lblExt.Text                     = InformacionUsuario.sExtension;
                lblTelMovil.Text                = InformacionUsuario.sTelefonoMovil;
                lblTipoUsuario.Text             = InformacionUsuario.sUsuarioTipo;
                chbxActivo.Checked              = InformacionUsuario.sActivo == "True" ? true : false;
                lblFechaCreacion.Text           = DateTime.Parse(InformacionUsuario.sFechaCreacion).ToShortDateString();
                txtNoCuenta.Text                = InformacionUsuario.sNoCuentaBancaria;

                EstadoControles(false);
                pnlDetalles.Visible = true;
            }
        }

        private void lnkDetalles_Click(object sender, EventArgs e)
        {
            obtenerInformacionUsuario();
        }

        private void lnkCerrar_Click(object sender, EventArgs e)
        {
            pnlDetalles.Visible = false;
            EstadoControles(true);            
        }

        private Point MouseDownLocation;
        private void pnlDetalles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                MouseDownLocation = e.Location;
        }

        private void pnlDetalles_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pnlDetalles.Left = e.X + pnlDetalles.Left - MouseDownLocation.X;
                pnlDetalles.Top = e.Y + pnlDetalles.Top - MouseDownLocation.Y;
            }
        }

        private void lblCorreoElectronico_Click(object sender, EventArgs e)
        {
            Process.Start("mailto:"+lblCorreoElectronico.Text);
        }

        private void lnkExportar_Click(object sender, EventArgs e)
        {
            exportar();
        }

        public void exportar()
        {
            if (gridView1.RowCount != 0)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    grdUsuarios.ExportToXlsx(saveFileDialog1.FileName);
                    Process.Start(saveFileDialog1.FileName);
                }
            }
        }

        private void lnkEditarCuenta_Click(object sender, EventArgs e)
        {
            txtNoCuenta.Enabled        = true;
            lnkEditarCuenta.Enabled    = false;
            lnkGuardarNoCuenta.Enabled = true;
        }

        private void lnkGuardarNoCuenta_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNoCuenta.Text) && txtNoCuenta.Text != InformacionUsuario.sNoCuentaBancaria)
            {
                if (new Usuario().iActualizaCuentaBancaria(int.Parse(AUsuario.sIdusuario), InformacionUsuario.iIdUsuario, txtNoCuenta.Text) > 0)
                {
                    txtNoCuenta.Enabled        = false;
                    lnkEditarCuenta.Enabled    = true;
                    lnkGuardarNoCuenta.Enabled = false;
                    FlatMessageBox.Show("No. de Cuenta Actualizado Correctamente", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                }
            }
        }
    }
}
