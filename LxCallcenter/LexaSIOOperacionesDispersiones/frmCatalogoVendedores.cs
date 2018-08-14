using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmCatalogoVendedores : Form
    {
        public frmCatalogoVendedores()
        {
            InitializeComponent();
            //CARGA REGISTROS DE VENDEDORES EN EL GRIDVIEW GRDCATALOGOVENDEDORES
            grdCatalogoVendedores.DataSource      = new LogicaCC.LexaSIOOperLogica.CatalogoVendedores().listaCatalogoVendedores();
            gridView1.OptionsView.ColumnAutoWidth = false;
            gridView1.BestFitColumns();            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //OBTIENE EL REGISTRO QUE TIENE EL FOCUS Y TOMA LA CLAVE DEL VENDEDOR
            var rowHandle   = gridView1.FocusedRowHandle;
            var obj         = gridView1.GetRowCellValue(rowHandle, "sVendedor");
            string vendedor = obj.ToString();

            //OBTIENE LA INFORMACIÓN DE VENDEDOR REQUERIDO
            LogicaCC.LexaSIOOperLogica.InformacionVendedor _informacionVendedor = new LogicaCC.LexaSIOOperLogica.InformacionVendedor();
            _informacionVendedor = new LogicaCC.LexaSIOOperLogica.InformacionVendedor().detalleVendedor(vendedor);

            //ASIGNA LA INFORMACIÓN DEL VENDEDOR A LOS CONTROLES
            lblNuVendedor.Text      = _informacionVendedor.sNumVendedor;
            lblRfc.Text             = _informacionVendedor.sRfc;
            if (_informacionVendedor.sActivo == "1")
                ckbActivo.Checked   = true;
            else
                ckbActivo.Checked   = false;
            lblNombre.Text          = _informacionVendedor.sNombre;
            lblAPaterno.Text        = _informacionVendedor.sAPaterno;
            lblAMaterno.Text        = _informacionVendedor.sAMaterno;
            lblDireccion.Text       = _informacionVendedor.sDireccion;
            lblMunicipio.Text       = _informacionVendedor.sMunicipio;
            lblEstado.Text          = _informacionVendedor.sEstado;
            lblCodigoPostal.Text    = _informacionVendedor.sCodigoPostal;
            lblTelefono.Text        = _informacionVendedor.sTelefono;
            lblExtension.Text       = _informacionVendedor.sExtension;
            lblMovil.Text           = _informacionVendedor.sMovil;
            lblCorreo.Text          = _informacionVendedor.sCorreoElectronico;
            lblNivel.Text           = _informacionVendedor.sNivel;
            lblComisionista.Text    = _informacionVendedor.sComisionista;
            gbVendedor.Visible      = true;
        }

        private void lnkCancelarGenerarCostanciaAlimentos_Click(object sender, EventArgs e)
        {
            //OCULTA EL PANEL QUE CONTIENE LA INFORMACIÓN DEL VENDEDOR
            gbVendedor.Visible = false;
        }
    }
}
