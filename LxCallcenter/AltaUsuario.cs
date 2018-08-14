using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicaCC.LexaSIOContaLogica;
using DevExpress.XtraEditors.DXErrorProvider;
using System.IO;
using System.Net;

namespace LxCallcenter
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
            cargarControles();
        }
        
        public void cargarControles()
        {
            // cmbxEstado.DataSource
            LogicaCC.Logica.Estados AEstados = new LogicaCC.Logica.Estados();
            DataSet ds;
            ds = AEstados.ListaEstados();
            cmbxEstado.DisplayMember = "estado";
            cmbxEstado.ValueMember   = "id";
            cmbxEstado.DataSource    = ds.Tables["Estados"];


            //CARGA LOS NIVELES DE USUARIOS DISPONIBLES PARA EL ALTA DE USUARIOS
            cmbxNivelUsuario.DataSource    = new Usuario().listaNivelUsuario();
            cmbxNivelUsuario.DisplayMember = "sUsuarioNivel";
            cmbxNivelUsuario.ValueMember   = "iIdUsuarioNivel";
			cmbxNivelUsuario.SelectedIndex = -1;

			//CARGA LA LISTA DE PUESTOS
			cmbxPMSGerencia.DataSource      = new Usuario().lListaGerencia();
            cmbxPMSGerencia.DisplayMember   = "sGerencia";
            cmbxPMSGerencia.ValueMember     = "iIdGerencia";
            cmbxPMSGerencia.SelectedIndex   = -1;

            //CARGA TIPO DE USUARIO
            cmbxPMSTipo.DataSource      = new Usuario().lListaTipo();
            cmbxPMSTipo.DisplayMember   = "sTipo";
            cmbxPMSTipo.ValueMember     = "iIdTipo";
            cmbxPMSTipo.SelectedIndex   = -1;

			// CARGA GERENCIAS
			cmbxGerencia.DataSource		= new Usuario().GetListGerencias();
			cmbxGerencia.DisplayMember	= "sGerencia";
			cmbxGerencia.ValueMember	= "iIdGerencia";
			cmbxGerencia.SelectedIndex	= -1;
			cmbxGerencia.DropDownWidth = DropDownWidth(cmbxGerencia);
		}

        private void cmbxNivelUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
			cmbxTipoUsuario.DataSource		= null;
			cmbxGerentes.Visible			= false;
			cmbxGerentes.DataSource			= null;
			cmbxSupervisores.Visible		= false;
			cmbxSupervisores.DataSource		= null;
			materialLabel17.Visible			= false;
			materialLabel18.Visible			= false;
			pnlFotoPerfilContador1.Visible	= false;

            cmbxTipoUsuario.DataSource     = new Usuario().listaTipoUsuario(int.Parse(cmbxGerencia.SelectedValue.ToString()), int.Parse(cmbxNivelUsuario.SelectedValue.ToString()));
            cmbxTipoUsuario.DisplayMember  = "sUsuarioTipo";
            cmbxTipoUsuario.ValueMember    = "iIdUsuarioTipo";
			cmbxTipoUsuario.DropDownWidth = DropDownWidth(cmbxTipoUsuario);
		}

        int ID;
        public void AgregarUsuario(object sender, EventArgs e)
        {
             MensajeError.Clear();
            if (Validar() == 0)
            {
                byte iActivo = 0;
                if (chbxActivo.Checked)
                    iActivo = 1;

				//GUARDA EL NUEVO REGISTRO DEL USUARIO
				int? iNull = null;
                ID = new Usuario().InsertarUsuario(new Usuario()
                     {
                         iIdUsuarioTipo      = int.Parse(cmbxTipoUsuario.SelectedValue.ToString()),
                         sNombre             = txtNombre.Text,
                         sAPaterno           = txtAPaterno.Text,
                         sAMaterno           = txtAMaterno.Text,
                         sUsuario            = txtUsuario.Text,
                         sContrasena         = txtContrasena.Text,
                         bActivo             = iActivo,
                         sCorreoElectronico  = txtCorreoElectronico.Text,
                         sTelefonoLocal      = txtTelLocal.Text,
                         sExtension          = txtExt.Text,
                         sTelefonoMovil      = txtTelMovil.Text,
                         sCedula             = txtCedulaProfesional.Text,
                         iIdEstado           = int.Parse(cmbxEstado.SelectedValue.ToString()),
                         sNoCuentaBancaria   = txtNoCuentaBancaria.Text,
						 iIdSucursal		 = int.Parse(cmbxSucursal.SelectedValue.ToString()),
						 iIdEquipoContable	 = cmbxEquipoContable.Enabled ? int.Parse(cmbxEquipoContable.SelectedValue.ToString()) : iNull,
						 iIdGerente			 = cmbxGerentes.Visible ? int.Parse(cmbxGerentes.SelectedValue.ToString()) : iNull,
						 iIdSupervisor		 = cmbxSupervisores.Visible ? int.Parse(cmbxSupervisores.SelectedValue.ToString()) : iNull
                     });

                if (ID != 0)
                {
					// Si el usuario es un contador, guardamos la foto.
					if (cmbxTipoUsuario.SelectedValue.ToString() == "6")
					{		
						try
						{
							if (!Directory.Exists(string.Format(@"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Fotos\Contadores\{0}", ID)))
							    Directory.CreateDirectory(string.Format(@"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Fotos\Contadores\{0}", ID));

							File.Copy(ofdFotoPerfil.FileName, string.Format(@"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Fotos\Contadores\{0}\{1}", ID, Path.GetFileName(ofdFotoPerfil.FileName)));

							File.Move(@"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Fotos\Contadores\" + ID + "\\" + Path.GetFileName(ofdFotoPerfil.FileName),
                                      @"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Fotos\Contadores\" + ID + "\\" + ID + Path.GetExtension(ofdFotoPerfil.FileName));

							pctFotoPerfil.Image                 = null;
							ofdFotoPerfil.FileName              = null;
							lnkSeleccionarFotoPerfil.BackColor  = Color.FromArgb(240, 240, 240);
						}
						catch (Exception ex)
						{
						    FlatMessageBox.Show(string.Format("No se pudo asignar foto de perfil.{0}Error: {1}", Environment.NewLine, ex.Message), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
						}
					}

					if (new Usuario().iAltaUsuarioPMS(new Usuario()
					{
					    iIdUsuario          = ID,
					    sNombre             = txtNombre.Text,
					    sAPaterno           = txtAPaterno.Text,
					    sAMaterno           = txtAMaterno.Text,
					    iIdPuesto           = int.Parse(cmbxPMSPuesto.SelectedValue.ToString()),
					    iIdTipo             = int.Parse(cmbxPMSTipo.SelectedValue.ToString()),
					    sUsuario            = txtUsuario.Text,
					    sContrasena         = txtContrasena.Text,
					    sCorreoElectronico  = txtCorreoElectronico.Text
					}) != 0)
					{
					    FlatMessageBox.Show("Usuario Guardado", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
					    limpiarControles();
					    cargarControles();
					    pnlFormulario.Enabled = true;

					    cmbxPMSGerencia.SelectedIndex = -1;
					    cmbxPMSPuesto.SelectedIndex   = -1;
					    cmbxPMSTipo.SelectedIndex     = -1;

					    btnCancelar_Click(sender, e);
					}
					else
					{
					    FlatMessageBox.Show("Error al guardar el Usuario en el PMS", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
					}  
                }
                else
                {
                    FlatMessageBox.Show("No se pudo guardar el usuario", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// Métod Público para valida que se encuentra toda la información requerida
        /// para dar de alta un usuario.
        /// </summary>
        /// <returns></returns>
        private int Validar()
        {
            int iResultado = 0;

            if (txtNombre.Text.Equals(""))
            {
                MensajeError.SetError(txtNombre, "Debe insertar un nombre.");
                iResultado = 1;
            }

            if (txtAPaterno.Text.Equals(""))
            {
                MensajeError.SetError(txtAPaterno, "Debe insertar un nombre.");
                iResultado = 1;
            }

            if (txtAMaterno.Text.Equals(""))
            {
                MensajeError.SetError(txtAMaterno, "Debe insertar un nombre.");
                iResultado = 1;
            }

            if (txtUsuario.Text.Equals(""))
            {
                MensajeError.SetError(txtUsuario, "Debe insertar un nombre.");
                iResultado = 1;
            }

            if (txtContrasena.Text.Equals(""))
            {
                MensajeError.SetError(txtContrasena, "Debe insertar un nombre.");
                iResultado = 1;
            }

            if (cmbxEstado.SelectedValue.Equals("33"))
            {
                MensajeError.SetError(cmbxEstado, "Debe seleccionar un estado.");
                iResultado = 1;
            }
            if (cmbxNivelUsuario.SelectedIndex == -1)
            {
                MensajeError.SetError(cmbxNivelUsuario, "Debe seleccionar un nivel de usuario.");
                iResultado = 1;
            }

			if (cmbxSucursal.SelectedIndex == -1)
			{
				MensajeError.SetError(cmbxSucursal, "Sebe seleccionar una sucursal");
				iResultado = 1;
			}

			if (cmbxGerencia.SelectedIndex == -1)
			{
				MensajeError.SetError(cmbxGerencia, "Sebe seleccionar una gerencia");
				iResultado = 1;
			}

			if (cmbxTipoUsuario.SelectedIndex == -1)
			{
				MensajeError.SetError(cmbxTipoUsuario, "Sebe seleccionar un puesto");
				iResultado = 1;
			}

			if (!string.IsNullOrEmpty(cmbxTipoUsuario.Text) && cmbxTipoUsuario.SelectedValue.ToString() == "6")
			{
				if (string.IsNullOrEmpty(ofdFotoPerfil.FileName))
				{
					MensajeError.SetError(label18, "Debe adjuntar una fotografía del contador");
				}
			}

            return iResultado;
        }

        /// <summary>
        /// Método Público para limpiar los controles
        /// </summary>
        public void limpiarControles()
        {
            //cmbxTipoUsuario.SelectedIndex  = 4;
            txtNombre.Text                 = string.Empty;
            txtAPaterno.Text               = string.Empty;
            txtAMaterno.Text               = string.Empty;
            txtUsuario.Text                = string.Empty;
            txtContrasena.Text             = string.Empty;
            txtCorreoElectronico.Text      = string.Empty;
            txtTelLocal.Text               = string.Empty;
            txtExt.Text                    = string.Empty;
            txtTelMovil.Text               = string.Empty;
            txtCedulaProfesional.Text      = string.Empty;
			txtNoCuentaBancaria.Text	   = string.Empty;
            chbxActivo.Checked             = false;
        }


        private void lnkSeleccionarFotoPerfil_Click(object sender, EventArgs e)
        {
            if (ofdFotoPerfil.ShowDialog() == DialogResult.OK)
            {
                pctFotoPerfil.Image                = new Bitmap(ofdFotoPerfil.FileName);
                lnkSeleccionarFotoPerfil.Location  = new Point(pctFotoPerfil.Location.X  + 112, pctFotoPerfil.Location.Y - 23);
                lnkSeleccionarFotoPerfil.BackColor = Color.White;
                lnkSeleccionarFotoPerfil.SendToBack();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblFecha.Enabled        = true;
            label4.Enabled          = true;
            limpiarControles();
        }       

        private void cmbxPMSGerencia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbxPMSPuesto.DataSource    = new Usuario().lListaPuesto(int.Parse(cmbxPMSGerencia.SelectedValue.ToString()));
            cmbxPMSPuesto.DisplayMember = "sPuesto";
            cmbxPMSPuesto.ValueMember   = "iIdPuesto";
        }

        private void btnGuardarPMS_Click(object sender, EventArgs e)
        {
			AgregarUsuario(sender, e);
        }

		private void cmbxEstado_SelectedValueChanged(Object sender, EventArgs e)
		{
			cmbxSucursal.DataSource		= new LogicaCC.Logica.Sucursal().GetList(int.Parse(cmbxEstado.SelectedValue.ToString()));
			cmbxSucursal.ValueMember	= "iIdSucursal";
			cmbxSucursal.DisplayMember	= "sSucursal";

			if (cmbxEquipoContable.Enabled)
				cmbxEquipoContable.DataSource = null;

			cmbxGerencia.SelectedIndex		= -1;
			cmbxNivelUsuario.SelectedIndex	= -1;
			cmbxGerencia.SelectedIndex		= -1;
			cmbxNivelUsuario.SelectedIndex	= -1;
			cmbxTipoUsuario.DataSource		= null;
			cmbxGerentes.Visible			= false;
			cmbxGerentes.DataSource			= null;
			cmbxSupervisores.Visible		= false;
			cmbxSupervisores.DataSource		= null;
			materialLabel17.Visible			= false;
			materialLabel18.Visible			= false;
			pnlFotoPerfilContador1.Visible	= false;
		}

		private void cmbxTipoUsuario_SelectionChangeCommitted(Object sender, EventArgs e)
		{
			materialLabel18.Location = materialLabel17.Location;
			cmbxSupervisores.Location = cmbxGerentes.Location;
			if (int.Parse(cmbxTipoUsuario.SelectedValue.ToString()) == 6)
			{
				cmbxEquipoContable.DataSource		= new LogicaCC.Logica.EquipoContable().GetListEquipoContable(int.Parse(cmbxSucursal.SelectedValue.ToString()));
				cmbxEquipoContable.ValueMember		= "iIdEquipoContable";
				cmbxEquipoContable.DisplayMember	= "sEquipoContable";
				cmbxEquipoContable.Enabled			= true;
				pnlFotoPerfilContador1.Visible		= true;
			}
			else
			{
				cmbxEquipoContable.DataSource	= null;
				pnlFotoPerfilContador1.Visible	= false;
				cmbxEquipoContable.Enabled		= false;
			}

			
			if (cmbxNivelUsuario.SelectedValue.ToString() == "2") // Si el usuario es Supervisor/Coordinador
			{
				cmbxGerentes.DataSource		= new LogicaCC.Logica.Supervisor().lSupervisores(int.Parse(cmbxNivelUsuario.SelectedValue.ToString()),int.Parse(cmbxGerencia.SelectedValue.ToString()) , int.Parse(cmbxSucursal.SelectedValue.ToString()));
				cmbxGerentes.DisplayMember	= "sNombreSupervisor";
				cmbxGerentes.ValueMember	= "iIdSupervisor";
				materialLabel17.Visible		= true;
				materialLabel18.Visible		= false;
				cmbxGerentes.Visible		= true;
				cmbxSupervisores.Visible	= false;
			}
			else if (cmbxNivelUsuario.SelectedValue.ToString() == "3") // Si el usuario es Colaborador
			{
				cmbxSupervisores.DataSource		= new LogicaCC.Logica.Supervisor().lSupervisores(int.Parse(cmbxNivelUsuario.SelectedValue.ToString()),int.Parse(cmbxGerencia.SelectedValue.ToString()) , int.Parse(cmbxSucursal.SelectedValue.ToString()));
				cmbxSupervisores.DisplayMember	= "sNombreSupervisor";
				cmbxSupervisores.ValueMember	= "iIdSupervisor";
				materialLabel17.Visible			= false;
				materialLabel18.Visible			= true;
				cmbxGerentes.Visible			= false;
				cmbxSupervisores.Visible		= true;
			}
			else // Si el usuario es Gerente
			{
				materialLabel17.Visible	 = false;
				materialLabel18.Visible	 = false;
				cmbxGerentes.Visible	 = false;
				cmbxSupervisores.Visible = false;
			}
		}

		private void cmbxSucursal_SelectionChangeCommitted(Object sender, EventArgs e)
		{
			//if (cmbxEquipoContable.Enabled)
			//{
				cmbxEquipoContable.DataSource		= new LogicaCC.Logica.EquipoContable().GetListEquipoContable(int.Parse(cmbxSucursal.SelectedValue.ToString()));
				cmbxEquipoContable.ValueMember		= "iIdEquipoContable";
				cmbxEquipoContable.DisplayMember	= "sEquipoContable";

				cmbxGerencia.SelectedIndex		= -1;
				cmbxGerencia.SelectedIndex		= -1;
				cmbxNivelUsuario.SelectedIndex	= -1;
				cmbxNivelUsuario.SelectedIndex	= -1;
				cmbxTipoUsuario.DataSource		= null;
				cmbxGerentes.Visible			= false;
				cmbxGerentes.DataSource			= null;
				cmbxSupervisores.Visible		= false;
				cmbxSupervisores.DataSource		= null;
				materialLabel17.Visible			= false;
				materialLabel18.Visible			= false;
				pnlFotoPerfilContador1.Visible	= false;
			//}
		}

		private void cmbxGerencia_SelectionChangeCommitted(Object sender, EventArgs e)
		{
			cmbxNivelUsuario.SelectedIndex	= -1;
			cmbxNivelUsuario.SelectedIndex	= -1;
			cmbxTipoUsuario.DataSource		= null;
			cmbxGerentes.Visible			= false;
			cmbxGerentes.DataSource			= null;
			cmbxSupervisores.Visible		= false;
			cmbxSupervisores.DataSource		= null;
			materialLabel17.Visible			= false;
			materialLabel18.Visible			= false;
			pnlFotoPerfilContador1.Visible	= false;
		}

		/// <summary>
		/// Obtiene el tamaño maximo que tendra un combobox de acuerdo al tamaño de sus items
		/// </summary>
		/// <param name="myCombo">ComboBox del cual se obtendran los items para establecer el tamaño</param>
		/// <returns></returns>
		int DropDownWidth(MaterialSkin.Controls.MaterialComboBox myCombo)
		{
			int widestStringInPixels = 0;
			foreach (Object o in myCombo.Items)
			{
				string toCheck;
				System.Reflection.PropertyInfo pinfo;
				Type objectType = o.GetType();
				if (myCombo.DisplayMember.CompareTo("") == 0)
				{
					toCheck = o.ToString();
				}
				else
				{
					pinfo = objectType.GetProperty(myCombo.DisplayMember);
					toCheck = pinfo.GetValue(o, null).ToString();
				}
				if (TextRenderer.MeasureText(toCheck, SkinManager.ROBOTO_REGULAR_11).Width > widestStringInPixels)
					widestStringInPixels = TextRenderer.MeasureText(toCheck, SkinManager.ROBOTO_REGULAR_11).Width;
			}
			return widestStringInPixels + 45;

		}
		public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }
	}
}
