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
using LogicaCC.LexaSIOOperLogica;

namespace LxCallcenter.LexaSIOOperacionesDispersiones
{
    public partial class frmAltaVendedor : Form
    {
        public frmAltaVendedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            Vendedor vendedor   = new Vendedor();
            vendedor            = new Vendedor().busquedaVendedor(tbBVendedor.Text);
            if(!(vendedor == null))
            {
                cargarControles();
                lblMensajeError.Visible = false;

                //CARGAMOS LA INFORMACIÓN A LOS CONTROLES
                txbNVendedor.Text               = vendedor.sVendedor;
                txbRfc.Text                     = vendedor.sRfc;
                txbNombre.Text                  = vendedor.sNombre;
                if(!(vendedor.iActivo == 0))
                    ckbActivo.Checked           = true;
                txbAPaterno.Text                = vendedor.sAPaterno;
                txbAMaterno.Text                = vendedor.sAMaterno;
                txbDireccion.Text               = vendedor.sDireccion;
                txbMunicipio.Text               = vendedor.sMunicipio;
                cbEstados.SelectedValue         = vendedor.sEstado;
                txbCP.Text                      = vendedor.sCodigoPostal;
                txbTelefono.Text                = vendedor.sTelefono;
                txbExtension.Text               = vendedor.sExtension;
                txbMovil.Text                   = vendedor.sMovil;
                txbCorreoCliente.Text           = vendedor.sCorreoElectronico;
                cbNivel.SelectedValue           = vendedor.iIdNivel;
                cbComisionista.SelectedValue    = vendedor.iIdComisionista;
                txbCurp.Text                    = vendedor.sCurp;
                txbNoExpediente.Text            = vendedor.sNoExpediente;

                btnEditar.Enabled = true;
            }
            else
            {
                lblMensajeError.Visible = true;
            }
        }

        private void cargarControles()
        {
            DataSet ds;
            LogicaCC.Logica.Estados AEstados = new LogicaCC.Logica.Estados();

            //CARGAMOS LOS ESTADOS
            ds = AEstados.ListaEstados();
            cbEstados.DataSource    = ds.Tables["Estados"];
            cbEstados.DisplayMember = "estado";
            cbEstados.ValueMember   = "id";

            //CARGAMOS LOS NIVELES
            cbNivel.DataSource      = new Nivel().listaNiveles();
            cbNivel.DisplayMember   = "sNivel";
            cbNivel.ValueMember     = "iIdNivel";            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gbVendedor.Enabled = true;
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //VALIDA SI SE ENCUENTRAN TODA LA INFORMACIÓN REQUERIDA
            if (ValidarInformacion() == 0)
            {
                //int activo          = 0;
                int comisionista    = 0;

                LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;

                //if (ckbActivo.Checked)
                //    activo = 1;

                try
                {
                    if (!(cbComisionista.SelectedValue.ToString() == "0"))
                        comisionista = int.Parse(cbComisionista.SelectedValue.ToString());
                }
                catch
                {
                    comisionista = 0;
                }

                //GUARDO EL REGISTRO  CON LA INFORMACIÓN DEL VENDEDOR
                if (new VendedorLXCC().registroVendedor(new VendedorLXCC()
                {
                    sCliente                = txbNVendedor.Text,
                    iIdEstado               = int.Parse(cbEstados.SelectedValue.ToString()),
                    iIdUsuario              = int.Parse(AUsuarioData.sIdusuario),
                    sNombre                 = txbNombre.Text,
                    sAPaterno               = txbAPaterno.Text,
                    sAMaterno               = txbAMaterno.Text,
                    sRFC                    = txbRfc.Text,
                    sDireccion              = txbDireccion.Text,
                    sMunicipio              = txbMunicipio.Text,
                    sCP                     = txbCP.Text,
                    sTelefonoL              = txbTelefono.Text,
                    sExtension              = txbExtension.Text,
                    sTelefonoM              = txbMovil.Text,
                    sCorreoE                = txbCorreoCliente.Text,
                    iIdServEstatus          = 1,
                    iIdServicioTipo         = 1,
                    sFechaContr             = DateTime.Now.ToString(),
                    sFechaVenci             = DateTime.Now.ToString(),
                    iIdContadorAsignado     = 1,
                    sNombreC1               = " ",
                    sAPaternoC1             = " ",
                    sAMaternoC1             = " ",
                    sTelefonoLC1            = " ",
                    sExtensionC1            = " ",
                    sTelefonoMC1            = " ",
                    sCorreoEC1              = " ",
                    sNombreC2               = " ",
                    sAPaternoC2             = " ",
                    sAMaternoC2             = " ",
                    sTelefonoLC2            = " ",
                    sExtensionC2            = " ",
                    sTelefonoMC2            = " ",
                    sCorreoEC2              = " ",
                    sServicioConta          = "false",
                    sServicioOD             = "true",
                    iIdComisionista         = comisionista,
                    iIdNivel                = int.Parse(cbNivel.SelectedValue.ToString()),
                    sCURP                   = txbCurp.Text,
                    sNoExpediente           = txbNoExpediente.Text
                }) == true)
                {
                    btnEditar.Enabled  = false;
                    btnGuardar.Enabled = false;
                    MessageBox.Show("Información Guardado con Exito");
                    LimpiarControles();
                }
                else
                {
                    btnEditar.Enabled  = false;
                    btnGuardar.Enabled = false;
                    MessageBox.Show("Información Guardado con Exito");
                    LimpiarControles();
                }
            }
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //CARGAMOS LOS COMISIONISTAS
                cbComisionista.DataSource       = new Vendedor().listaComisionistas(int.Parse(cbNivel.SelectedValue.ToString()));
                cbComisionista.DisplayMember    = "sNombre";
                cbComisionista.ValueMember      = "iIdComisionista";
            }
            catch
            {

            }
        }

        /// <summary>
        /// Método Público para validar si se encuentra la información
        /// requerida para guardar el vendedor.
        /// </summary>
        /// <returns></returns>
        public int ValidarInformacion()
        {
            int iResultado = 0;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txbRfc.Text))
            {
                this.errorProvider1.SetError(txbRfc, "RFC del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbNombre.Text))
            {
                this.errorProvider1.SetError(txbNombre, "Nombre del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbAPaterno.Text))
            {
                this.errorProvider1.SetError(txbAPaterno, "Apellido paterno del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbAMaterno.Text))
            {
                this.errorProvider1.SetError(txbAMaterno, "Apellido materno del vendedor.");
                iResultado = 1;
            }

            if(string.IsNullOrEmpty(txbCurp.Text))
            {
                this.errorProvider1.SetError(txbCurp, "CURP del vendedor");
                iResultado = 1;
            }

            if(string.IsNullOrEmpty(txbNoExpediente.Text))
            {
                this.errorProvider1.SetError(txbNoExpediente, "Número de expediente del vendedor");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbDireccion.Text))
            {
                this.errorProvider1.SetError(txbDireccion, "Dirección del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbMunicipio.Text))
            {
                this.errorProvider1.SetError(txbMunicipio, "Municipio.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbCP.Text))
            {
                this.errorProvider1.SetError(txbCP, "Codigo Postal.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbTelefono.Text))
            {
                this.errorProvider1.SetError(txbTelefono, "Teléfono local del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbMovil.Text))
            {
                this.errorProvider1.SetError(txbMovil, "Teléfono movil del vendedor.");
                iResultado = 1;
            }

            if (string.IsNullOrEmpty(txbCorreoCliente.Text))
            {
                this.errorProvider1.SetError(txbCorreoCliente, "Correo electronico del vendedor");
                iResultado = 1;
            }

            if (ckbActivo.Checked == false)
            {
                this.errorProvider1.SetError(ckbActivo, "El vendedor debe estar activo.");
                iResultado = 1;
            }

            if (cbEstados.SelectedValue.Equals("33"))
            {
                this.errorProvider1.SetError(cbEstados, "Debe seleccionar un estado de la republica.");
                iResultado = 1;
            }

            return iResultado;
        }

        /// <summary>
        /// Método Público para limpiar los controles TextBox.
        /// </summary>
        private void LimpiarControles()
        {
            //LIMPIA POR GROUPBOX
            //INFORMACIÓN VENDEDOR
            foreach (Control x in gbVendedor.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = "";
                }
            }

            ckbActivo.Checked       = false;
            //PONE COMBOBOX EN ESTADO INICIAL.
            cbEstados.SelectedValue = 33;
            cbNivel.SelectedValue   = 0;
        }
    }
}
