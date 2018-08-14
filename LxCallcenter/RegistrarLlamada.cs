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
using LogicaCC.Logica;
using System.Runtime.InteropServices;
using AxWMPLib;
using System.IO;
using System.Net;
using LogicaCC;
using System.Text.RegularExpressions;

namespace LxCallcenter
{
	public partial class RegistrarLlamada : Form
	{
		UsuarioData AUsuarioData = UsuarioData.Instancia;
        LogicaCC.LexaSIOContaLogica.Cliente Cliente;
        ClienteData AClienteData;

        List<Caso>          LCaso;
        List<CasoHistorial> LCasoHistorial;
        FPrincipal _frmPrincipal;

        Bitmap play_52px  = Properties.Resources.play_52px;
        Bitmap pause_52px = Properties.Resources.pause_52px;
        List<string> directories = new List<string>();
        private byte[] downloadedData;
        string sRutaActual = "";
        string FolderA     = "";
        string sPath       = "";
        bool bExiste       = false;

        // CONSTRUCTOR
        public RegistrarLlamada()
		{
			InitializeComponent();
			CargarControles();

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
            if (_frmPrincipal != null)
                _frmPrincipal.btnRegLlamada.Enabled = false;
        }

        #region Eventos Botones
        public void btnRegLlamada_Click(Object sender, EventArgs e)
		{
            if (FlatMessageBox.Show("¿Desea registrar una llamada del cliente?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (scFoliosAbiertos.Visible)
                    scFoliosAbiertos.Visible = false;

                CasoNuevo ACaso = new CasoNuevo();
				int iIdCaso = ACaso.CrearCaso(AUsuarioData.sIdusuario);

				if(iIdCaso != 0)
				{
					txbFolioLlamada.Text     = Convert.ToString(iIdCaso);
					txbBuscarCliente.Text    = "";
					txbBuscarCliente.Enabled = false;
					btnBuscarCliente.Enabled = false;
					gbLlamada.Visible        = true;
					btnRegLlamada.Visible    = false;
                    _frmPrincipal.btnRegLlamada.Enabled = false;
                    txbDescripcion.Focus();
				}
            }
		}

		private void btnBuscarCliente_Click(Object sender, EventArgs e)
		{
            if (!string.IsNullOrEmpty(txbBuscarCliente.Text))
            {
                if (AClienteData != null)
                {
                    if (AClienteData.sCliente != txbNCliente.Text || AClienteData.sRfc != txbNCliente.Text)
                    {
                        if (BuscarCliente() == 1)
                            SystemSounds.Beep.Play();
                        else
                            CargarFolios();
                    }
                }
                else
                {
                    if (BuscarCliente() == 1)
                        SystemSounds.Beep.Play();
                    else
                        CargarFolios();
                }
            }
        }

        private void BtnFolio_Click(object sender, EventArgs e)
        {
            Button btnFolio = sender as Button;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            RestartControlls(true);
            LlenarListView();

            Caso caso = new Caso().InformacionCaso(int.Parse(btnFolio.Name));
            lblTitulo.Text     = string.Format("Detalles Folio {0}", caso.iIdCaso);
            lblMotivo.Text     = string.Format("Tipo de Llamada{0}{1}", Environment.NewLine, caso.sMotivo);
            lblContador.Text   = string.Format("Contador{0}{1} {2} {3}", Environment.NewLine, caso.sContadorNombre, caso.sContadorAPaterno, caso.sContadorAMaterno);
            txtComentario.Text = string.Format("Comentario{0}{1}", Environment.NewLine, caso.sDescripcion);
            lblFechaCreacion.Text = string.Format("Fecha Solicitud{0}{1}", Environment.NewLine, caso.dtFechaCreacion);

            CasoHistorial casoHistorial = new CasoHistorial();
            LCasoHistorial = casoHistorial.GetListCasoHistorial(caso.iIdCaso);
            for (int i = 0; i < LCasoHistorial.Count; i++)
            {
                Button btnHistorial = new Button();
                btnHistorial.Location		   = new Point(0, 24 * i + 0);//new Point(12, 24 * i + 0);
                btnHistorial.Name			   = LCasoHistorial[i].iIdCasoHistorial.ToString();
                btnHistorial.Text			   = "  " + LCasoHistorial[i].dtFechaCreacion.ToString();
                btnHistorial.Font			   = new Font("Segoe UI", 9);
                btnHistorial.ForeColor		   = Color.FromArgb(105, 105, 105);
                btnHistorial.Width			   = 180;//225//160
                btnHistorial.Height			   = 24;
                btnHistorial.FlatStyle		   = FlatStyle.Flat;
                btnHistorial.Anchor			   = AnchorStyles.Left | AnchorStyles.Right;
                btnHistorial.TextAlign		   = ContentAlignment.MiddleLeft;
                btnHistorial.Cursor			   = Cursors.Hand;
                btnHistorial.Image			   = Properties.Resources.clock_16px1;
                btnHistorial.ImageAlign		   = ContentAlignment.TopLeft;
                btnHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnHistorial.FlatAppearance.BorderSize = 0;

                btnHistorial.Click += (s, ev) =>
                {
                    sCHistorial.Panel2.Controls.Clear();
                    CasoHistorial casoH = new CasoHistorial().GetInfoCasoHistorial(int.Parse(btnHistorial.Name));
                    Label lblFechaCreacionH = new Label();
                    lblFechaCreacionH.Width    = 200;
                    lblFechaCreacionH.Height   = 45;
                    lblFechaCreacionH.Location = new Point(10, 5);
                    lblFechaCreacionH.Text     = "Por: " + casoH.sUsuario + Environment.NewLine + "Fecha " + casoH.dtFechaCreacion;
                    lblFechaCreacionH.Font      = new Font("Calibri Light", 11);

                    RichTextBox txtComentarioH = new RichTextBox();
                    txtComentarioH.Text        = "Comentario" + Environment.NewLine + casoH.sComentario;
                    txtComentarioH.Location    = new Point(10, 65);//29, 8//10, 35
                    txtComentarioH.Font        = new Font("Calibri Light", 11);//122,23
                    txtComentarioH.Width       = 180;//270
                    txtComentarioH.Height      = 58;
                    txtComentarioH.Anchor      = AnchorStyles.Left | AnchorStyles.Right;
                    txtComentarioH.BorderStyle = BorderStyle.None;
                    txtComentarioH.ReadOnly    = true;
                    txtComentarioH.BackColor   = Color.White;

                    sCHistorial.Panel2.Controls.Add(txtComentarioH);
                    sCHistorial.Panel2.Controls.Add(lblFechaCreacionH);
                };

                sCHistorial.Panel1.Controls.Add(btnHistorial);
            }

            List<String> fileList = EndFTPRead();
            sCGrabaciones.Panel1.Controls.Clear();
            int g = 0;
            foreach (var fi in fileList.Where(fi => fi.Contains("Folio-" + caso.iIdCaso + "-")).OrderByDescending(fi => fi))
            {
                g++;
                //BOTON QUE SE GENERA POR CADA ARCHIVO ENCONTRADO DE LA LISTA DE DOCUMENTPS FILTRADOS
                Button btnGrabacion     = new Button();
                btnGrabacion.Location   = new Point(0, 24 * g + -23);//(0, 24 * g + 0);//0, 24 * g + -23
                btnGrabacion.Name       = fi;
                btnGrabacion.Text       = " " + fi;
                btnGrabacion.Font       = new Font("Segoe UI", 9);
                btnGrabacion.ForeColor  = Color.FromArgb(105, 105, 105);
                btnGrabacion.Width      = 180;//225
                btnGrabacion.Height     = 24;
                btnGrabacion.TextAlign  = ContentAlignment.MiddleLeft;
                btnGrabacion.Cursor     = Cursors.Hand;
                btnGrabacion.FlatStyle  = FlatStyle.Flat;
                btnGrabacion.FlatAppearance.BorderSize = 0;
                btnGrabacion.Image      = Properties.Resources.microphone_16px1;
                btnGrabacion.ImageAlign = ContentAlignment.TopLeft;
                btnGrabacion.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnGrabacion.AutoEllipsis = true;
                btnGrabacion.Click += BtnGrabacion_Click;

                sCGrabaciones.Panel1.Controls.Add(btnGrabacion);
            }

            LollipopButton btnSeguimiento = new LollipopButton();
            btnSeguimiento.Location = new Point(745, 18);
            btnSeguimiento.Name     = caso.iIdCaso.ToString();
            btnSeguimiento.Text     = "Dar Seguimiento";
            btnSeguimiento.Width    = 130;//160
            btnSeguimiento.Height   = 30;
            btnSeguimiento.Anchor   = AnchorStyles.Right | AnchorStyles.Top;
            btnSeguimiento.Cursor   = Cursors.Hand;
            btnSeguimiento.Tag      = caso.sMotivo;
            btnSeguimiento.BGColor  = "#001489";
            btnSeguimiento.Click += BtnSeguimiento_Click;
        }

        private void BtnGrabacion_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            Button btnRecord = sender as Button;
            sPath = btnRecord.Name;
            lblRecordName.Text = sPath;
            panel1.Visible = true;
        }

        private void BtnSeguimiento_Click(object sender, EventArgs e)
        {
            LollipopButton btnSeguimiento = sender as LollipopButton;
            axWindowsMediaPlayer1.Ctlcontrols.stop();

            txbFolioLlamada.Text          = btnSeguimiento.Name;
            cbTipoLlamada.SelectedIndex   = cbTipoLlamada.FindStringExact(btnSeguimiento.Tag.ToString());
            cbTipoLlamada.Enabled         = false;
            btnNuevoTipoLlamada.Enabled   = false;
            btnRegistrar.Visible          = false;
            btnGuardaHistorial.Location   = new Point(btnRegistrar.Location.X, btnRegistrar.Location.Y);//new Point(756, 264);
            btnGuardaHistorial.Visible    = true;

            scFoliosAbiertos.Visible	  = false;
            gbLlamada.Visible			  = true;
        }

        private void btnRegistrar_Click(Object sender, EventArgs e)
		{
			MensajeError.Clear();
			if(ValidarCampos() == 0)
			{
                if (FlatMessageBox.Show("¿Desea guardar?", "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CasoActualizar AActualizar = new CasoActualizar();
					// Se envia la informacion para actualizar la llamada
					if(AActualizar.Actualizar(cbTipoLlamada.SelectedValue.ToString(),
										   AClienteData.sIdCliente,
										   AUsuarioData.sIdusuario,
										   txbDescripcion.Text,
										   txbFolioLlamada.Text) == 0)
					{
						LimpiarControles();
						txbBuscarCliente.Text	 = "";
						gbLlamada.Visible		 = false;
						btnRegLlamada.Visible	 = true;
						btnRegLlamada.Enabled	 = false;
                        txbBuscarCliente.Enabled = true;
						btnBuscarCliente.Enabled = true;
                        _frmPrincipal.btnRegLlamada.Enabled = false;
                        txbBuscarCliente.Focus();
					}
					else
                        FlatMessageBox.Show("Error al registrar", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
                }
			}
		}

        private void btnNuevoTipoLlamada_Click(object sender, EventArgs e)
        {
            txtNuevoTipoLlamada.Text = string.Empty;
            if (pnlNuevoTipoLlamada.Visible)
            {
                pnlNuevoTipoLlamada.Visible = false;
            }
            else
            {
                pnlNuevoTipoLlamada.Visible = true;
                txtNuevoTipoLlamada.Focus();
            }
        }

        private void btnAgregarTipoLlamada_Click(object sender, EventArgs e)
        {
            if (!(txtNuevoTipoLlamada.Text == string.Empty))
            {
                new LogicaCC.LexaSIOContaLogica.TipoLlamada().InsertarTipoLlamada(new LogicaCC.LexaSIOContaLogica.TipoLlamada()
                {
                    iIdUsuario      = 1,
                    sTipoLlamada    = txtNuevoTipoLlamada.Text
                });
                FlatMessageBox.Show("Tipo de Llamada Agregada.", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Information);
                txtNuevoTipoLlamada.Text = string.Empty;

                // Motivo de llamada
                CasoMotivo ACasoM = new CasoMotivo();
                DataSet ds;
                ds = ACasoM.ListadoMotivos();
                cbTipoLlamada.DisplayMember = "Motivo";
                cbTipoLlamada.ValueMember   = "IdCasoMotivo";
                cbTipoLlamada.DataSource    = ds.Tables["Motivos"];
                cbTipoLlamada.SelectedIndex = cbTipoLlamada.Items.Count - 1;
            }
            else
                FlatMessageBox.Show("Campo vacio", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
        }

        private void btnGuardaHistorial_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txbDescripcion.Text))
            {
                MensajeError.Clear();
                int iResultado = new CasoHistorial().AddHistorial(new CasoHistorial()
                {
                    iIdCaso            = int.Parse(txbFolioLlamada.Text),
                    iIdUsuarioRegistra = int.Parse(AUsuarioData.sIdusuario),
                    sComentario        = txbDescripcion.Text
                });

                if (iResultado > 0)
                {
                    LimpiarControles();
			        txbBuscarCliente.Text	 = "";
			        gbLlamada.Visible		 = false;
			        btnRegLlamada.Visible	 = true;
			        btnRegLlamada.Enabled	 = false;
                    txbBuscarCliente.Enabled = true;
			        btnBuscarCliente.Enabled = true;
                    _frmPrincipal.btnRegLlamada.Enabled = false;
                    cbTipoLlamada.Enabled       = true;
                    btnNuevoTipoLlamada.Enabled = true;
                    btnRegistrar.Visible        = true;
                    btnGuardaHistorial.Location = new Point(756, 264);
                    btnGuardaHistorial.Visible  = false;
                    txbBuscarCliente.Focus();
                }
                else
                    FlatMessageBox.Show("No se pudo agregar el comentario", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            }
            else
                this.MensajeError.SetError(txbDescripcion, "Debe anotar una descripción.");
        }

        private void lnkPlay_Click(object sender, EventArgs e)
        {
            if (PathRecordExist())
            {
                if (RecordExists())
                {
                    if (string.IsNullOrEmpty(axWindowsMediaPlayer1.URL))
                        axWindowsMediaPlayer1.URL = sPath;

                    if (bExiste)
                    {
                        if (lnkPlay.Image == play_52px)
                        {
                            lnkPlay.Image = pause_52px;
                            lnkPlay.NoFocusImage = pause_52px;
                            axWindowsMediaPlayer1.Ctlcontrols.play();
                        }
                        else
                        {
                            lnkPlay.Image = play_52px;
                            lnkPlay.NoFocusImage = play_52px;
                            axWindowsMediaPlayer1.Ctlcontrols.pause();
                        }
                    }
                }
            }
        }

        private void tmrPlayer_Tick(object sender, EventArgs e)
        {
            TrackBar.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
            TrackBar.Value   = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            lblTiempo.Text   = string.Format("{0}/{1}", axWindowsMediaPlayer1.Ctlcontrols.currentPositionString, axWindowsMediaPlayer1.currentMedia.durationString);
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                lnkPlay.Image        = play_52px;
                lnkPlay.NoFocusImage = play_52px;
                lnkPlay.Refresh();
                tmrPlayer.Stop();
            }
            if (e.newState == 3)
            {
                tmrPlayer.Start();
                lnkPlay.Image        = pause_52px;
                lnkPlay.NoFocusImage = pause_52px;
                lnkPlay.Refresh();
            }
            if (e.newState == 1)
            {
                lnkPlay.Image        = play_52px;
                lnkPlay.NoFocusImage = play_52px;
                lblTiempo.Text = "--/--";
                tmrPlayer.Stop();
                TrackBar.Value = 0;
            }
        }
		#endregion

		#region Funciones
        /// <summary>
        /// Restablece el contenido de los controles a un estado original
        /// y cambia el estado de visibilidad de algunos controles
        /// </summary>
        /// <param name="bEstado">Estado de visibilidad que se asignarán a los controles</param>
        private void RestartControlls(bool bEstado)
        {
            lblTitulo.Text        = "";
            lblMotivo.Text        = "";
            lblContador.Text      = "";
            lblFechaCreacion.Text = "";
            txtComentario.Text    = "";
            sCHistorial.Panel1.Controls.Clear();
            sCHistorial.Panel2.Controls.Clear();
            sCGrabaciones.Panel1.Controls.Clear();
            lblTitulo.Visible        = bEstado;
            lblMotivo.Visible        = bEstado;
            lblContador.Visible      = bEstado;
            lblFechaCreacion.Visible = bEstado;
            txtComentario.Visible    = bEstado;
            panel1.Visible = false;
        }

        /// <summary>
        /// Función que busca el cliente dado
        /// </summary>
        /// <returns></returns>
		private int BuscarCliente()
		{
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            int iResultado	 = 0;
			AClienteData	 = null;
			lblBusqueda.Text = "";
			Cliente ACliente = new Cliente();

			LimpiarControles();

			btnRegLlamada.Visible    = true;
			btnRegLlamada.Enabled    = false;
            gbLlamada.Visible	     = false;
            scFoliosAbiertos.Visible = false;
            scFoliosAbiertos.Panel1.Controls.Clear();
            _frmPrincipal.btnRegLlamada.Enabled = false;

            AClienteData = ACliente.ClienteInfo(txbBuscarCliente.Text);

			if(AClienteData != null)
			{
				ClienteInfo(AClienteData);
			}
			else
			{
				lblBusqueda.Text = "* Cliente no encontrado.";
				iResultado = 1;
			}
			return iResultado;
		}

        /// <summary>
        /// Método que realiza la carga de folios una vez realizada una busqueda, si encuentra folios
        /// abiertos, se muestra una lista de estos.
        /// </summary>
        void CargarFolios()
        {
            RestartControlls(false);
            Caso caso = new Caso();
            LCaso = caso.LAbiertos(int.Parse(AClienteData.sIdCliente));
            // Condición si la lista de casos es diferente de 0
            if(LCaso.Count != 0)
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                scFoliosAbiertos.Panel1.Controls.Clear();
                scFoliosAbiertos.Panel1.AutoScroll = true;

                Label lblTitulo      = new Label();
                lblTitulo.Text       = "Folios Abiertos";
                lblTitulo.Location   = new Point(29, 8);//29, 8
                lblTitulo.Font       = new Font("Calibri Light", 14);//122,23
                lblTitulo.Anchor     = AnchorStyles.Top;
                lblTitulo.TextAlign  = ContentAlignment.TopLeft;
                lblTitulo.Width      = 122;
                scFoliosAbiertos.Panel1.Controls.Add(lblTitulo);
                scFoliosAbiertos.Panel1.BackColor = Color.FromArgb(236, 240, 241);

                for (int i = 0; i < LCaso.Count; i++)
                {
                    Button btnFolio = new Button();
                    btnFolio.Location                   = new Point(0, 24 * i + 50);//new Point(0, 24 * i + 50);
                    btnFolio.Name                       = LCaso[i].iIdCaso.ToString();
                    btnFolio.Text                       = "   Folio: " + LCaso[i].iIdCaso.ToString();
                    btnFolio.Font                       = new Font("Segoe UI", 9);
                    btnFolio.ForeColor                  = Color.FromArgb(105, 105, 105);
                    btnFolio.Width                      = scFoliosAbiertos.Panel1.Width - 5;//160//156
                    btnFolio.Height                     = 24;
                    btnFolio.FlatStyle                  = FlatStyle.Flat;
                    btnFolio.FlatAppearance.BorderSize  = 0;
                    btnFolio.TextAlign                  = ContentAlignment.MiddleLeft;
                    btnFolio.Cursor                     = Cursors.Hand;
                    btnFolio.Image                      = Properties.Resources.phone_16px1;
                    btnFolio.ImageAlign                 = ContentAlignment.MiddleLeft;
                    btnFolio.TextImageRelation          = TextImageRelation.ImageBeforeText;

                    btnFolio.Click += BtnFolio_Click;

                    scFoliosAbiertos.Panel1.Controls.Add(btnFolio);
                }
                scFoliosAbiertos.Visible = true;
            }
        }
      
        /// <summary>
        /// Muestra la información del cliente
        /// </summary>
        /// <param name="ACliente"></param>
        private void ClienteInfo(ClienteData ACliente)
		{
            Cliente = new LogicaCC.LexaSIOContaLogica.Cliente().InformacionCliente(int.Parse(ACliente.sIdCliente));
            txbNCliente.Text  = ACliente.sCliente;
            txtNombre.Text    = string.Format("{0} {1} {2}", Cliente.sNombre, Cliente.sAPaterno, Cliente.sAMaterno);
            txtRfc.Text       = Cliente.sRfc;
            txtTelefono.Text  = Cliente.sTelefono;
            txtCelular.Text   = Cliente.sNumeroMovil;
            txtExtension.Text = Cliente.sExtension;
            txtCorreoElectronico.Text = Cliente.sCorreoElectronico;

            if (Cliente.iIdRegimen == 2)
                ovalPictureBox1.Image = Properties.Resources.skyscrapers_96px;
            else
                ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;

            if (ACliente.sActivo.Equals("True"))
			{
				btnRegLlamada.Enabled				= true;                
                _frmPrincipal.btnRegLlamada.Enabled = true;
            }
		}

        /// <summary>
        /// Limpia y pone en un estado inicial a los controles
        /// </summary>
		private void LimpiarControles()
		{
			txtCorreoElectronico.Text   = "";
            txtCelular.Text             = "";
            txtNombre.Text		        = "";
			txbNCliente.Text	        = "";
			txbDescripcion.Text         = "";
			txbFolioLlamada.Text        = "";
			cbTipoLlamada.SelectedIndex = 0;
		}

        /// <summary>
        /// Cargado de listas en los combobox
        /// </summary>
		private void CargarControles()
		{
			UsuarioLista		AUsuarios		= new UsuarioLista();
			CasoMotivo			ACasoM			= new CasoMotivo();
			ServicioT			AServiciosT		= new ServicioT();
			ServicioE			AServiciosE		= new ServicioE();
			Estados				AEstados		= new Estados();
			DataSet				ds;

			// Motivo de llamada
			ds = ACasoM.ListadoMotivos();
			cbTipoLlamada.DisplayMember = "Motivo";
			cbTipoLlamada.ValueMember   = "IdCasoMotivo";
			cbTipoLlamada.DataSource    = ds.Tables["Motivos"];
		}

        /// <summary>
        /// Convierte el texto en mayusculas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
		private void Mayusculas(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
                btnBuscarCliente_Click(sender, e);
        }

        /// <summary>
        /// Valida que la información de los campos este completa
        /// </summary>
        /// <returns></returns>
		private int ValidarCampos()
		{
			int iResultado = 0;

			if(string.IsNullOrEmpty(txbDescripcion.Text))
			{
				this.MensajeError.SetError(txbDescripcion, "Debe anotar una descripción.");
				iResultado = 1;
			}

			if(cbTipoLlamada.SelectedIndex == 0)
			{
				this.MensajeError.SetError(cbTipoLlamada,"Debe seleccionar un tipo de llamada.");
				iResultado = 1;
			}

			return iResultado;
		}

        /// <summary>
        /// Realiza el llenado de grabaciones encontradas en un listview y muestra solo los pertenecientes al folio
        /// seleccionado.
        /// </summary>
        private void LlenarListView()
        {
            directories.Clear();
            var root = "";
            if (string.IsNullOrEmpty(materialLabel3.Text))
            {
                root = string.Format("ftp://{0}/{1}/Records/", FTPCredentials.Path, LogicaCC.ConnectionString.FolderConnection);
                sRutaActual = root;
            }
            else
            {
                root = GetDirection(sRutaActual, materialLabel3.Text);
                sRutaActual = root;
            }

            FtpWebRequest ftpRequest  = (FtpWebRequest)WebRequest.Create(root);
            ftpRequest.Credentials    = new NetworkCredential(FTPCredentials.User, FTPCredentials.Password);
            ftpRequest.Method         = WebRequestMethods.Ftp.ListDirectoryDetails;
            FtpWebResponse response   = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            var line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {
                var split        = new Regex(FTPServer.regex).Match(line);
                string dir       = split.Groups["dir"].ToString();
                string filename  = split.Groups["filename"].ToString();
                string size      = split.Groups["size"].ToString();
                string sFecha    = string.Format("{0} {1} {2}", split.Groups["day"], split.Groups["month"], split.Groups["timeyear"]);
                bool isDirectory = !string.IsNullOrWhiteSpace(dir) && dir.Equals("d", StringComparison.OrdinalIgnoreCase);

                string sLine = string.Format("{0}|{1}|{2}|{3}", (isDirectory ? "d" : "f"), filename, (isDirectory ? "" : BytesToMegabytes(int.Parse(size)).ToString("0.00") + "MB"), sFecha);
                directories.Add(sLine);
                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        /// <summary>
        /// Convierte bytes a megabytes
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        static double BytesToMegabytes(long bytes)
        {
            return (bytes / 1024f) / 1024f;
        }

        /// <summary>
        /// Returna la union de dos directorios
        /// </summary>
        /// <param name="directorio">Directorio 1</param>
        /// <param name="newDirec">Directorio 2</param>
        /// <returns></returns>
        public string GetDirection(string directorio, string newDirec)
        {
            return string.Format("{0}{1}/", directorio, newDirec);
        }

        /// <summary>
        /// Agrega items al listado de grabaciones
        /// </summary>
        /// <returns></returns>
        public List<string> EndFTPRead()
        {
            List<string> ListDirectories = new List<string>();
            string[] Separator = new string[] { "|" };
            directories = directories.OrderBy(s => s.Split(Separator, StringSplitOptions.None)[0]).ToList();
            for (int i = 0; i < directories.Count; i++)
            {
                string[] sDirectory = directories[i].Split('|');
                ListDirectories.Add(sDirectory[1]);
            }

            FolderA = materialLabel3.Text;
            return ListDirectories;
        }

        /// <summary>
        /// Verifica si existe un directorio
        /// </summary>
        /// <returns></returns>
        public bool PathRecordExist()
        {
            string sRuta = string.Format(@"{0}\mpy\records", Path.GetTempPath());
            if (!Directory.Exists(sRuta))
            {
                Directory.CreateDirectory(sRuta);
                return true;
            }
            else
                return true;
        }

        /// <summary>
        /// Verfica si existe la grabación requerida
        /// </summary>
        /// <returns></returns>
        public bool RecordExists()
        {
            bool bResultado = false;
            try
            {
                string FileName = Path.GetFileName(sPath);
                string FullPath = string.Format("{0}/{1}/Records/", FTPCredentials.Path, ConnectionString.FolderConnection);
                string LocalPath = string.Format(@"{0}\mpy\records\", Path.GetTempPath());

                if (!File.Exists(string.Format("{0}{1}", LocalPath, FileName)))
                {
                    pnlDescarga.Visible = true;
                    downloadFile(FullPath, FileName, FTPCredentials.User, FTPCredentials.Password);
                    pnlDescarga.Visible = false;
                }
                else
                    bExiste = true;

                bResultado = true;
            }
            catch (Exception)
            {
                bResultado = false;
            }

            return bResultado;
        }

        /// <summary>
        /// Conecta al servidor FTP y descarga archivos
        /// </summary>
        /// <param name="FTPAddress"></param>
        /// <param name="filename"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        private void downloadFile(string FTPAddress, string filename, string username, string password)
        {
            downloadedData = new byte[0];
            try
            {
                string FullPath = string.Format("{0}/{1}/Records/", FTPCredentials.Path, ConnectionString.FolderConnection);
                if (bExiste = FTPServer.CheckIfFileExistsOnServer(FullPath, FTPCredentials.User, FTPCredentials.Password, sPath))
                {
                    //Optional
                    //lblStatus.Text = "Conectando...";
                    Application.DoEvents();

                    //Create FTP request
                    //Note: format is ftp://server.com/file.ext
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", FTPAddress, filename));

                    //Optional
                    //lblStatus.Text = "Recibiendo Información...";
                    Application.DoEvents();

                    //Get the file size first (for progress bar)
                    request.Method = WebRequestMethods.Ftp.GetFileSize;
                    request.Credentials = new NetworkCredential(username, password);
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.KeepAlive = true; //don't close the connection

                    int dataLength = (int)request.GetResponse().ContentLength;

                    //Optional
                    //lblStatus.Text = "Descargando Archivo...";
                    Application.DoEvents();

                    //Now get the actual data
                    request = (FtpWebRequest)WebRequest.Create(string.Format("ftp://{0}/{1}", FTPAddress, filename));
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                    request.Credentials = new NetworkCredential(username, password);
                    request.UsePassive = true;
                    request.UseBinary = true;
                    request.KeepAlive = false; //close the connection when done

                    //Set up progress bar
                    pgbDescarga.Value = 0;
                    pgbDescarga.Maximum = dataLength;
                    lbProgress.Text = "0 MB/" + BytesToMegabytes(dataLength).ToString("0.00") + "MB";

                    //Streams
                    FtpWebResponse response = request.GetResponse() as FtpWebResponse;
                    Stream reader = response.GetResponseStream();

                    //Download to memory
                    //Note: adjust the streams here to download directly to the hard drive
                    MemoryStream memStream = new MemoryStream();
                    byte[] buffer = new byte[1024]; //downloads in chuncks
                    lbProgress.Visible = true;
                    while (true)
                    {
                        Application.DoEvents(); //prevent application from crashing

                        //Try to read the data
                        int bytesRead = reader.Read(buffer, 0, buffer.Length);

                        if (bytesRead == 0)
                        {
                            //Nothing was read, finished downloading
                            pgbDescarga.Value = pgbDescarga.Maximum;
                            lbProgress.Text = string.Format("{0} MB/{0} MB", BytesToMegabytes(dataLength).ToString("0.00"));

                            Application.DoEvents();
                            break;
                        }
                        else
                        {
                            //Write the downloaded data
                            memStream.Write(buffer, 0, bytesRead);

                            //Update the progress bar
                            if (pgbDescarga.Value + bytesRead <= pgbDescarga.Maximum)
                            {
                                pgbDescarga.Value += bytesRead;
                                lbProgress.Text = string.Format("{0} MB/{1} MB", BytesToMegabytes(pgbDescarga.Value).ToString("0.00"), BytesToMegabytes(dataLength).ToString("0.00"));

                                pgbDescarga.Refresh();
                                Application.DoEvents();
                            }
                        }
                    }
                    lbProgress.Visible = false;

                    //Convert the downloaded stream to a byte array
                    downloadedData = memStream.ToArray();

                    //Clean up
                    reader.Close();
                    memStream.Close();
                    response.Close();
                }
            }
            catch (Exception)
            {
                FlatMessageBox.Show("Error conectando al servidor FTP.", "OK", string.Empty, FlatMessageBoxIcon.Error);
            }

            //lblStatus.Text = "Descargando datos";
            username = string.Empty;
            password = string.Empty;

            if (bExiste)
                SaveDownload(filename);
        }

        /// <summary>
        /// Guarda el archivo descargado
        /// </summary>
        /// <param name="fileName"></param>
        public void SaveDownload(string fileName)
        {
            if (downloadedData != null && downloadedData.Length != 0)
            {
                //lblStatus.Text = "Guardando...";
                Application.DoEvents();

                //Write the bytes to a file
                string LocalPath = string.Format(@"{0}\mpy\records\{1}", Path.GetTempPath(), fileName);
                FileStream newFile = new FileStream(LocalPath, FileMode.Create);
                newFile.Write(downloadedData, 0, downloadedData.Length);
                newFile.Close();
                sPath = LocalPath;
            }
        }
        #endregion
    }
}
