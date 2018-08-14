using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.DB;
using LogicaCC.Logica;
//using LogicaCC.LexaSIOContaLogica;

namespace LxCallcenter
{
	public partial class AltaCliente : Form
	{
        FPrincipal frmPrincipal;
		// CONSTRUCTOR
		public AltaCliente(FPrincipal _frmPrincipal)
		{
            // this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            InitializeComponent();
			EstadoControles(false);
			InicializarControles();
            this.frmPrincipal = _frmPrincipal;
            gbGiro.Visible    = false;
		}   
        
        #region EVENTOS CONTROLES

        public void Guardar()
        {
            UsuarioData AUsuarioData = UsuarioData.Instancia;
            int iResultado      = 0;

            int comisionista    = 0;
            try
            {
                if (!(cbComisionista.SelectedValue.ToString() == "0"))
                    comisionista = int.Parse(cbComisionista.SelectedValue.ToString());
            }
            catch
            {
                comisionista = 0;
            }

            int nivel = 0;
            try
            {
                if (!(cbNivel.SelectedValue.ToString() == "0"))
                    nivel = int.Parse(cbNivel.SelectedValue.ToString());
            }
            catch
            {

            }


            if (ValidarInformacion() == 0)
			{
				ClienteActInfo AInfo = new ClienteActInfo();

				AInfo.ActualizarInfo(txbNCliente.Text,
									 cbEstados.SelectedValue.ToString(),
									 AUsuarioData.sIdusuario,
									 txbNombre.Text,
									 txbAPaterno.Text,
									 txbAMaterno.Text,
									 txbRfc.Text,
									 txbDireccion.Text,
									 txbMunicipio.Text,
									 txbCP.Text,
									 txbTelefono.Text,
									 txbExtension.Text,
									 txbMovil.Text,
									 txbCorreoCliente.Text,
									 cbServicioEstado.SelectedValue.ToString(),
									 cbServicio.SelectedValue.ToString(),
									 dpContratacion.Text,
									 dpFechaVencimiento.Text,
									 cbContaAsig.SelectedValue.ToString(),
									 txbNombreC1.Text,
									 txbAPaternoC1.Text,
									 txbAMaternoC1.Text,
									 txbTelefonoC1.Text,
									 txbExtensionC1.Text,
									 txbMovilC1.Text,
									 txbCorreoC1.Text,
									 txbNombreC2.Text,
									 txbAPaternoC2.Text,
									 txbAMaternoC2.Text,
									 txbTelefonoC2.Text,
									 txbExtensionC2.Text,
									 txbMovilC2.Text,
									 txbCorreoC2.Text,
                                     true,
                                     ckbServicioOD.Checked,
                                     comisionista.ToString(),
                                     nivel.ToString(),
                                     txbCurp.Text,
                                     txbNoExpediente.Text);

                //AGREGAMOS GIRO DEL CLIENTE
                //new LogicaCC.LexaSIOContaLogica.Categoria().iAsignarCategoria(txbNCliente.Text, int.Parse(cbSubcategoria.SelectedValue.ToString()));

                //AGREGAMOS CLIENTE A LA BD BD DBLEXACONTA
                new LogicaCC.LexaSIOContaLogica.Cliente().bInsertarCliente(new LogicaCC.LexaSIOContaLogica.Cliente()
                {
                    iIdCliente            = iIdCliente,
                    iIdUsuarioCreacion    = int.Parse(cbContaAsig.SelectedValue.ToString()),
                    sCliente              = txbNCliente.Text,
                    sNombre               = txbNombre.Text,
                    sAPaterno             = txbAPaterno.Text,
                    sAMaterno             = txbAMaterno.Text,
                    sRfc                  = txbRfc.Text,
                    sCorreoElectronico    = txbCorreoCliente.Text,
                    sTelefono             = txbTelefono.Text,
                    sDireccion            = txbDireccion.Text,
                    sMunicipio            = txbMunicipio.Text,
                    sCodigoPostal         = txbCP.Text,
                    sExtension            = txbExtension.Text,
                    sNumeroMovil          = txbMovil.Text
                });

                if (iResultado == 0)
                {
                    InicializarControles();
                    EstadoControles(false);
                    FlatMessageBox.Show("Información guardada satisfactoriamente.", "OK", string.Empty, FlatMessageBoxIcon.Information);
                    frmPrincipal.btnCGuardarInfo.Enabled = false;
                }
                else 
                {
					errorProvider1.Clear();
					FlatMessageBox.Show("Error al tratar de guardar.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }
			}
        }

		// EVENTO GUARDA LA INFORMACION DEL CLIENTE
		private void btnGuardar_Click(object sender, EventArgs e)
		{
            Guardar();
		}

		// EVENTO BUSCA INFORMACION DEL CLIENTE
		private void btnBuscar_Click(object sender, EventArgs e)
		{
			if(BuscarCliente("") == 1)
				SystemSounds.Beep.Play();
		}

        public static int iIdCliente;
		// FUNCION QUE BUSCA UN CLIENTE
		private int BuscarCliente(string sCliente)
		{
			ClienteData         AClienteInf;
			Cliente             ACliente    = new Cliente();
			ContactoAut         AContactos  = null;
			List<ContactoData>  LContactos  = null;
			int                 iResultado  = 0;

			EstadoControles(false);
            btnCancelarEdicion.Enabled = false;
            errorProvider1.Clear();

			if(sCliente.Equals(""))
				AClienteInf = ACliente.ClienteInfo(tbBCliente.Text);
			else
				AClienteInf = ACliente.ClienteInfo(sCliente);

			LimpiarControles();

			if(AClienteInf != null)
			{
                frmPrincipal.btnCGuardarInfo.Enabled = false;
                frmPrincipal.btnCEditarCliente.Enabled = true;
                btnEditar.Enabled = true;
				
                txbCP.Text = AClienteInf.sCP;
				txbRfc.Text = AClienteInf.sRfc;
				txbMovil.Text = AClienteInf.sTelefonoCelular;
				txbNombre.Text = AClienteInf.sNombre;
				txbTelefono.Text = AClienteInf.sTelefonoLocal;
				txbNCliente.Text = AClienteInf.sCliente;
				txbAPaterno.Text = AClienteInf.sAPaterno;
				txbAMaterno.Text = AClienteInf.sAMaterno;
				txbDireccion.Text = AClienteInf.sDireccion;
				txbMunicipio.Text = AClienteInf.sMunicipio;
				txbExtension.Text = AClienteInf.sExtension;
				dpContratacion.Text = AClienteInf.sFechaContratado;
				txbCorreoCliente.Text = AClienteInf.sCorreoElectronico;
				dpFechaVencimiento.Text = AClienteInf.sFechaVencimiento;
				cbEstados.SelectedValue = AClienteInf.sIdEstado;
				cbServicio.SelectedValue = AClienteInf.sIdServicioTipo;
				cbContaAsig.SelectedValue = AClienteInf.sIdContAsignado;
				cbServicioEstado.SelectedValue = AClienteInf.sIdServicioStatus;
                txbCurp.Text = AClienteInf.sCurp;
                txbNoExpediente.Text = AClienteInf.sNoExpediente;

                iIdCliente = int.Parse(AClienteInf.sIdCliente);

                cbNivel.SelectedValue = int.Parse(AClienteInf.iIdNivel);
                cbComisionista.SelectedValue = AClienteInf.iIdComisionista;

                if (AClienteInf.iServicioOD.Equals("True"))
                    ckbServicioOD.Checked = true;

                if (AClienteInf.sActivo.Equals("True"))
					ckbActivo.Checked = true;
				
				AContactos = new ContactoAut();
				LContactos = AContactos.ListaContactos(AClienteInf.sIdCliente);

				if(LContactos.Count > 0)
				{
					for(int i = 0; i < LContactos.Count; i++)
					{
						switch(i)
						{
							case 0:
								txbMovilC1.Text = LContactos[i].sTelefonoMovil;
								txbNombreC1.Text = LContactos[i].sNombre;
								txbCorreoC1.Text = LContactos[i].sCorreoEletronico;
								txbAPaternoC1.Text = LContactos[i].sAPaterno;
								txbAMaternoC1.Text = LContactos[i].sMaterno;
								txbTelefonoC1.Text = LContactos[i].sTelefonolocal;
								txbExtensionC1.Text = LContactos[i].sExtension;
								break;
							case 1:
								txbMovilC2.Text = LContactos[i].sTelefonoMovil;
								txbNombreC2.Text = LContactos[i].sNombre;
								txbCorreoC2.Text = LContactos[i].sCorreoEletronico;
								txbAPaternoC2.Text = LContactos[i].sAPaterno;
								txbAMaternoC2.Text = LContactos[i].sMaterno;
								txbTelefonoC2.Text = LContactos[i].sTelefonolocal;
								txbExtensionC2.Text = LContactos[i].sExtension;
								break;
							default:
								break;
						}
					}
				}

                // CARGAMOS LOS DATOS DE CATEGORÍA
                LogicaCC.LexaSIOContaLogica.Categoria categoria = new LogicaCC.LexaSIOContaLogica.Categoria().CategoriaCliente(txbNCliente.Text);
                if (categoria != null)
                {
                    cbCategoria.SelectedValue = categoria.iIdCategoria;
                    // Subcategoría
                    cbSubcategoria.DataSource    = new LogicaCC.LexaSIOContaLogica.Categoria().lSubcategorias(categoria.iIdCategoria);
                    cbSubcategoria.DisplayMember = "sSubcategoria";
                    cbSubcategoria.ValueMember   = "iIdSubcategoria";
                    cbSubcategoria.SelectedValue = categoria.iIdSubcategoria;
                }

                if (AClienteInf.sIdServicioStatus == "5")
                {
                    FlatMessageBox.Show(string.Format("El cliente {0} actualmente se encuentra activo, pero su servicio se encuentra inactivo, por lo cual solo se podrá guardar información básica.", txbNCliente.Text), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
                    
                    btnGuardar.Visible      = false;
                    btnPreGuardar.Location  = new Point(btnGuardar.Location.X, btnGuardar.Location.Y);
                    btnPreGuardar.Visible   = true;
                }
                else
                {
                    // btnEditar.Visible       = true;
                    btnGuardar.Visible      = true;
                    btnPreGuardar.Visible   = false;
                }
            }
			else
			{
				iResultado = 1;
				lblMensajeBusqueda.Text = "* Cliente no encontrado.";
			}

            return iResultado;
		}

		// BOTON EDITAR
		private void btnEditar_Click(Object sender, EventArgs e)
		{
            EditarCliente();
		}

        // EVENTO AL PRESIONAR ENTER EN EL TEXBOX DE BUSQUEDA
        private void tbBCliente_KeyDown(Object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                if (BuscarCliente("") == 0)
                    e.Handled = e.SuppressKeyPress = true;
            }
        }
        
        // EVENTO AL SELECCIONAR TEXBOX DE BUSQUEDA SE SELECCIONA EL TEXTO AUTOMATICAMENTE
        private void tbBCliente_Click(Object sender, EventArgs e)
        {
            tbBCliente.SelectAll();
        }

        #endregion

        #region FUNCIONES CONTROLES --
        // CAMBIA ESTADO DE CONTROLES
        private void EstadoControles(bool bEstado)
        {
            txbCP.Enabled                = bEstado;
            txbRfc.Enabled               = bEstado;
            txbMovil.Enabled             = bEstado;
            txbNombre.Enabled            = bEstado;
            cbEstados.Enabled            = bEstado;
            ckbActivo.Enabled            = bEstado;
            ckbServicioOD.Enabled        = bEstado;
            btnEditar.Enabled            = bEstado;
            cbServicio.Enabled           = bEstado;
            txbMovilC1.Enabled           = bEstado;
            txbMovilC2.Enabled           = bEstado;
            btnGuardar.Enabled           = bEstado;
            //txbNCliente.Enabled        = bEstado;
            txbAPaterno.Enabled          = bEstado;
            txbAMaterno.Enabled          = bEstado;
            txbTelefono.Enabled          = bEstado;
            txbNombreC1.Enabled          = bEstado;
            txbCorreoC1.Enabled          = bEstado;
            txbNombreC2.Enabled          = bEstado;
            txbCorreoC2.Enabled          = bEstado;
            cbContaAsig.Enabled          = bEstado;
            txbDireccion.Enabled         = bEstado;
            txbMunicipio.Enabled         = bEstado;
            txbExtension.Enabled         = bEstado;
            txbAPaternoC1.Enabled        = bEstado;
            txbAMaternoC1.Enabled        = bEstado;
            txbAPaternoC2.Enabled        = bEstado;
            txbAMaternoC2.Enabled        = bEstado;
            txbTelefonoC2.Enabled        = bEstado;
            txbTelefonoC1.Enabled        = bEstado;
            txbExtensionC1.Enabled       = bEstado;
            //dpContratacion.Enabled       = bEstado;
            txbExtensionC2.Enabled       = bEstado;
            txbCorreoCliente.Enabled     = bEstado;
            cbServicioEstado.Enabled     = bEstado;
            //dpFechaVencimiento.Enabled = bEstado;
            txbCurp.Enabled              = bEstado;
            txbNoExpediente.Enabled      = bEstado;
            cbCategoria.Enabled          = bEstado;
            cbSubcategoria.Enabled       = bEstado;
            btnPreGuardar.Enabled        = bEstado;
        }

        // INICIALIZAR CONTROLES
        private void InicializarControles()
        {
            List<UsuarioInfo>   AListaUsuarios  = null;
            UsuarioLista        AUsuarios       = new UsuarioLista();
            ServicioT           AServiciosT     = new ServicioT();
            ServicioE           AServiciosE     = new ServicioE();
            Estados             AEstados        = new Estados();
            DataSet             ds;

            //Lista de contadores
            AListaUsuarios = AUsuarios.ObtenerLista("6");

            if (AListaUsuarios != null)
            {
                cbContaAsig.DataSource		= AListaUsuarios;
                cbContaAsig.DisplayMember	= "sNombre";
                cbContaAsig.ValueMember		= "sIdusuario";
            }

            // Estados de la republica
            ds = AEstados.ListaEstados();
            cbEstados.DisplayMember = "estado";
            cbEstados.ValueMember   = "id";
            cbEstados.DataSource    = ds.Tables["Estados"];

            // Tipos de servicio
            ds = AServiciosT.ListaServiciosTipo();
            cbServicio.DisplayMember = "ServicioTipo";
            cbServicio.ValueMember   = "Id";
            cbServicio.DataSource    = ds.Tables["ServicioTipo"];

            // Estado de servicio
            ds = AServiciosE.ListadoServicioEstado();
            cbServicioEstado.DisplayMember = "ServicioEstado";
            cbServicioEstado.ValueMember   = "Id";
            cbServicioEstado.DataSource    = ds.Tables["ServicioEstado"];


            // Niveles
            cbNivel.DataSource = new LogicaCC.LexaSIOOperLogica.Nivel().listaNiveles();
            cbNivel.DisplayMember = "sNivel";
            cbNivel.ValueMember   = "iIdNivel";
            cbNivel.SelectedValue = 0;

            // Categoría
            cbCategoria.DataSource    = new LogicaCC.LexaSIOContaLogica.Categoria().lCatergorias();
            cbCategoria.DisplayMember = "sCategoria";
            cbCategoria.ValueMember   = "iIdCategoria";
            cbCategoria.SelectedValue = -1;
        }




        // CONVIERTE EL TEXTO EN MAYUSCULAS
        private void Mayusculas(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        // LIMPIEZA DE CONTROLES
        private void LimpiarControles()
        {
            // Limpia por groupbox.
			// Informacion Cliente
            foreach (Control x in gbCliente.Controls)
            {
                if (x is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    x.Text = "";
                }
            }
			// Contacto 1
            foreach (Control x in gbContacto1.Controls)
            {
                if (x is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    x.Text = "";
                }
            }
			// Contacto 2
            foreach (Control x in gbContacto2.Controls)
            {
                if (x is MaterialSkin.Controls.MaterialSingleLineTextField)
                {
                    x.Text = "";
                }
            }

            txbDireccion.Text = string.Empty;


            ckbActivo.Checked = false;
			// Pone combobox en estado inicial.
			cbEstados.SelectedIndex			= 0;
            cbServicio.SelectedIndex		= 0;
            cbContaAsig.SelectedIndex		= 0;
            cbServicioEstado.SelectedIndex	= 0;
            // Limpia la leyenda abajo del texbox de busqueda.
            lblMensajeBusqueda.Text			= "";
            cbCategoria.SelectedIndex       = -1;
            cbSubcategoria.SelectedIndex    = -1;
        }

		// VALIDAR CONTROLES
        // HABILITA LOS MENSAJE DE ERROR PARA LOS CAMPOS
		public int ValidarInformacion()
		{
			int iResultado = 0;
			errorProvider1.Clear();

			if(string.IsNullOrEmpty(txbRfc.Text))
			{
				this.errorProvider1.SetError(txbRfc, "RFC del cliente.");
				iResultado = 1;
			}

			if(string.IsNullOrEmpty(txbNombre.Text))
			{
				this.errorProvider1.SetError(txbNombre, "Nombre del cliente.");
				iResultado = 1;
			}

			if(string.IsNullOrEmpty(txbAPaterno.Text))
			{
				this.errorProvider1.SetError(txbAPaterno, "Apellido paterno del cliente.");
				iResultado = 1;
			}

			if(string.IsNullOrEmpty(txbAMaterno.Text))
			{
				this.errorProvider1.SetError(txbAMaterno, "Apellido materno del cliente.");
				iResultado = 1;
			}

			if(string.IsNullOrEmpty(txbDireccion.Text))
			{
				this.errorProvider1.SetError(txbDireccion, "Dirección del cliente.");
				iResultado = 1;
			}


			if(string.IsNullOrEmpty(txbMunicipio.Text))
			{
				this.errorProvider1.SetError(txbMunicipio, "Municipio.");
				iResultado = 1;
			}


			if(string.IsNullOrEmpty(txbCP.Text))
			{
				this.errorProvider1.SetError(txbCP, "Codigo Postal.");
				iResultado = 1;
			}

			if(string.IsNullOrEmpty(txbMovil.Text))
			{
				this.errorProvider1.SetError(txbMovil, "");
				iResultado = 1;
			}

			if(string.IsNullOrEmpty(txbCorreoCliente.Text))
			{
				this.errorProvider1.SetError(txbCorreoCliente, "");
				iResultado = 1;
			}

			if(ckbActivo.Checked == false)
			{
				this.errorProvider1.SetError(ckbActivo, "El cliente debe estar activo.");
				iResultado = 1;
			}

			if(cbEstados.SelectedValue.Equals("33"))
			{
				this.errorProvider1.SetError(cbEstados, "Debe seleccionar un estado de la republica.");
				iResultado = 1;
			}

			if(cbServicio.SelectedValue.Equals("1"))
			{
				this.errorProvider1.SetError(cbServicio, "Debe seleccionar un servicio.");
				iResultado = 1;
			}

			if(cbServicioEstado.SelectedValue.Equals("1"))
			{
				this.errorProvider1.SetError(cbServicioEstado, "Debe seleccionar el estado del servicio.");
				iResultado = 1;
			}

			return iResultado;
		}

        // TIPO DE USUARIOS.
        public void EditarCliente()
        {
            UsuarioData AUsuarioData = UsuarioData.Instancia;

            EstadoControles(true);

            if(cbServicioEstado.SelectedValue.ToString() == "5")
            { 
                cbContaAsig.Enabled         = false;
                cbServicio.Enabled          = false;
                cbServicioEstado.Enabled    = false;
                dpContratacion.Enabled      = false;
                dpFechaVencimiento.Enabled  = false;
                ckbActivo.Enabled           = false;
            }

            btnEditar.Enabled = false;

			// Supervisor de ventas
			if(AUsuarioData.sTipoUsuario.Equals("3"))
			{
				ckbActivo.Enabled   = false;
				cbContaAsig.Enabled = false;
			}
            txbNombre.Focus();
        }

        #endregion

        private void ckbServicioOD_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbServicioOD.Checked)
                groupBoxOD.Enabled = true;
            else
                groupBoxOD.Enabled = true;
        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dpContratacion_ValueChanged(object sender, EventArgs e)
        {
            dpFechaVencimiento.Value = dpContratacion.Value.AddMonths(12);
        }

        public void PreGuardar()
        {
            UsuarioData AUsuarioData = UsuarioData.Instancia;
            int iResultado      = 0;

            int comisionista    = 0;
            try
            {
                if (!(cbComisionista.SelectedValue.ToString() == "0"))
                    comisionista = int.Parse(cbComisionista.SelectedValue.ToString());
            }
            catch
            {
                comisionista = 0;
            }

            int nivel = 0;
            try
            {
                if (!(cbNivel.SelectedValue.ToString() == "0"))
                    nivel = int.Parse(cbNivel.SelectedValue.ToString());
            }
            catch
            {

            }


            if (ValidarInformacion() == 0)
			{
				ClienteActInfo AInfo = new ClienteActInfo();

				AInfo.ActualizarInfo(txbNCliente.Text,
									 cbEstados.SelectedValue.ToString(),
									 AUsuarioData.sIdusuario,
									 txbNombre.Text,
									 txbAPaterno.Text,
									 txbAMaterno.Text,
									 txbRfc.Text,
									 txbDireccion.Text,
									 txbMunicipio.Text,
									 txbCP.Text,
									 txbTelefono.Text,
									 txbExtension.Text,
									 txbMovil.Text,
									 txbCorreoCliente.Text,
									 "5",
                                     cbServicio.SelectedValue.ToString(),
                                     "1-1-2000",
                                     "1-1-2000",
									 "1",
									 txbNombreC1.Text,
									 txbAPaternoC1.Text,
									 txbAMaternoC1.Text,
									 txbTelefonoC1.Text,
									 txbExtensionC1.Text,
									 txbMovilC1.Text,
									 txbCorreoC1.Text,
									 txbNombreC2.Text,
									 txbAPaternoC2.Text,
									 txbAMaternoC2.Text,
									 txbTelefonoC2.Text,
									 txbExtensionC2.Text,
									 txbMovilC2.Text,
									 txbCorreoC2.Text,
                                     false,
                                     ckbServicioOD.Checked,
                                     comisionista.ToString(),
                                     nivel.ToString(),
                                     txbCurp.Text,
                                     txbNoExpediente.Text);

                //AGREGAMOS GIRO DEL CLIENTE
                new LogicaCC.LexaSIOContaLogica.Categoria().iAsignarCategoria(txbNCliente.Text, int.Parse(cbSubcategoria.SelectedValue.ToString()));

                //AGREGAMOS CLIENTE A LA BD BD DBLEXACONTA
                new LogicaCC.LexaSIOContaLogica.Cliente().bInsertarCliente(new LogicaCC.LexaSIOContaLogica.Cliente()
                {
                    iIdCliente            = iIdCliente,
                    iIdUsuarioCreacion    = 1,
                    sCliente              = txbNCliente.Text,
                    sNombre               = txbNombre.Text,
                    sAPaterno             = txbAPaterno.Text,
                    sAMaterno             = txbAMaterno.Text,
                    sRfc                  = txbRfc.Text,
                    sCorreoElectronico    = txbCorreoCliente.Text,
                    sTelefono             = txbTelefono.Text,
                    sDireccion            = txbDireccion.Text,
                    sMunicipio            = txbMunicipio.Text,
                    sCodigoPostal         = txbCP.Text,
                    sExtension            = txbExtension.Text,
                    sNumeroMovil          = txbMovil.Text
                });

                if (iResultado == 0)
                {
                    FlatMessageBox.Show("Información guarda satisfactoriamente.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                    EstadoControles(false);
                    LimpiarControles();
                    //BuscarCliente(txbNCliente.Text);

                }
                else 
                {
					errorProvider1.Clear();
					FlatMessageBox.Show("Error al tratar de guardar.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }
			}
        }

        private void btnPreGuardar_Click(object sender, EventArgs e)
        {
            PreGuardar();
        }

        private void cbCategoria_SelectionChangeCommitted(object sender, EventArgs e)
        {        
            cbSubcategoria.DataSource    = new LogicaCC.LexaSIOContaLogica.Categoria().lSubcategorias(int.Parse(cbCategoria.SelectedValue.ToString()));
            cbSubcategoria.DisplayMember = "sSubcategoria";
            cbSubcategoria.ValueMember   = "iIdSubcategoria";
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
        }

        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            tbBCliente.Clear();
            EstadoControles(false);
            frmPrincipal.btnCGuardarInfo.Enabled = false;
        }

        private void tbBCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void Numeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
