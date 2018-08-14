using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOContaLogica;
using LogicaCC;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmObligacionesCliente : Form
    {
        //CREA DOS LISTA PARA OBLIGACIONES
        public List<DetalleObligacion> obligaciones;
        public List<DetalleObligacion> obligacionesAsignadas;
        Cliente Cliente;
        LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
		static DetalleObligacion _DetalleObligacion = new DetalleObligacion();

		int    iIdCliente    = 0;
        string sFechaInicio  = null;
        string sFechaTermino = null;

        public frmObligacionesCliente(int iIdCliente, string sFechaInicio, string sFechaTermino)
        {
            InitializeComponent();
            this.iIdCliente    = iIdCliente;
            this.sFechaInicio  = sFechaInicio;
            this.sFechaTermino = sFechaTermino;
            cargarInformacion();
        }

        /// <summary>
        /// Carga la información del cliente y muestra tambien el listado de obligaciones fiscales pendientes
        /// </summary>
        public void cargarInformacion()
        {
            if (AUsuarioData.sTipoUsuario.Equals("5"))
                lnkContadorAsignado.Visible = true;
            //INFORMACIÓN DEL CLIENTE        
            Cliente                     = new Cliente().InformacionCliente(iIdCliente); // iIdCliente
            lblNoCliente.Text           = Cliente.sCliente;
            lblNombre.Text              = string.Format("{0} {1} {2}", Cliente.sNombre, Cliente.sAPaterno, Cliente.sAMaterno);
            lblRfc.Text                 = Cliente.sRfc;
            lblTelefono.Text            = Cliente.sTelefono;
            lblCelular.Text             = Cliente.sNumeroMovil;
            lblExtension.Text           = Cliente.sExtension;
            lblCorreoElectronico.Text   = Cliente.sCorreoElectronico;
            lblDomicilio.Text           = string.Format("{0}, {1}", Cliente.sDireccion, Cliente.sMunicipio);
            lnkContadorAsignado.Tag     = Cliente.iIdContador;
            lnkContadorAsignado.Text    = "     " + Cliente.sContador;
            if (Cliente.iIdRegimen == 2)
                ovalPictureBox1.Image = Properties.Resources.skyscrapers_96px;
            else
                ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;

            //CARGAMOS LISTA DE OBLIGACIONES FISCALES
            cargarListaObligaciones(1);
        }


        /// <summary>
        /// Metodo Publico para realizar una busqueda
        /// de obligaciones fiscales filtrando por estado
        /// de realización.
        /// </summary>
        /// <param name="estado">Estado de obligación, 0 para realizadas y 1 para no realizadas</param>
        public void cargarListaObligaciones(int estado)
        {
            //CREA UNA LISTA DINAMICA DE OBLIGACIONES FISCALES
            DetalleObligacion obligacion = new DetalleObligacion();
            obligaciones = obligacion.listaObligacionesCliente(iIdCliente, sFechaInicio, sFechaTermino, estado);
            for (int i = 0; i < obligaciones.Count; i++)
            {
                Button btnObligacion                      = new Button();
                btnObligacion.Location                    = new Point(12, 24 * i + 0);
                btnObligacion.Text                        = obligaciones[i].sDetalleObligacion;
                btnObligacion.Font                        = new Font("Segoe UI", 9);
                btnObligacion.Width                       = 244;
                btnObligacion.Height                      = 24;
                btnObligacion.FlatStyle                   = FlatStyle.Flat;
                btnObligacion.FlatAppearance.BorderSize   = 0;
                btnObligacion.Cursor                      = Cursors.Hand;

                Panel ptbEstado     = new Panel();
                ptbEstado.Location  = new Point(7, 24 * i + 0);
                ptbEstado.Width     = 5;
                ptbEstado.Height    = 24;

                DateTime fecha1 = Convert.ToDateTime(obligaciones[i].sfechaVerde);
                DateTime fecha2 = Convert.ToDateTime(obligaciones[i].sfechaAmarillo);
                DateTime fecha3 = Convert.ToDateTime(obligaciones[i].sfechaRojo);
                DateTime fecha  = DateTime.Now;

                if(estado == 1 )
                { 
                     //CONDICIONA PARA ASIGNAR EL ESTADO DE FECHA DE UNA OBLIGACIÓN
                     if ((fecha >= fecha1) && (fecha <= fecha2))
                     {
                        ptbEstado.BackColor                             = Color.FromArgb(3, 166, 0);
                        btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(3, 166, 0);
                     }
                     else if ((fecha >= fecha2) && (fecha <= fecha3))
                     {
                        ptbEstado.BackColor                             = Color.FromArgb(255, 153, 0);
                        btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 153, 0);
                     }
                     else if (fecha >= fecha3)
                     {
                        ptbEstado.BackColor                             = Color.FromArgb(171, 30, 30);
                        btnObligacion.FlatAppearance.MouseOverBackColor = Color.FromArgb(171, 30, 30);
                     }
                }

				DetalleObligacion _Detail = new DetalleObligacion();
				int? iNull = null;
                _Detail.iIdRegistroObligacion = obligaciones[i].iIdRegistroObligacion;
				_Detail.sDetalleObligacion	  = obligaciones[i].sDetalleObligacion;
				_Detail.sFormaPresentacion	  = obligaciones[i].sFormaPresentacion;
				_Detail.sfechaVerde			  = obligaciones[i].sfechaVerde;
				_Detail.sfechaAmarillo		  = obligaciones[i].sfechaAmarillo;
				_Detail.sfechaRojo			  = obligaciones[i].sfechaRojo;
				_Detail.sFechaEntrega		  = obligaciones[i].sFechaEntrega;
                _Detail.sObligacion           = obligaciones[i].sObligacion;

                //_Detail.iR01				= obligaciones[i].iR01 == null ? iNull: obligaciones[i].iR01;
                //_Detail.iR02				= obligaciones[i].iR02 == null ? iNull : obligaciones[i].iR02;
                //_Detail.iR03				= obligaciones[i].iR03 == null ? iNull : obligaciones[i].iR03;

                //_Detail.iR04				= obligaciones[i].iR04 == null ? iNull : obligaciones[i].iR04;
                //_Detail.iR05				= obligaciones[i].iR05 == null ? iNull : obligaciones[i].iR05;
                //_Detail.iR06				= obligaciones[i].iR06 == null ? iNull : obligaciones[i].iR06;
                //_Detail.iR07				= obligaciones[i].iR07 == null ? iNull : obligaciones[i].iR07;
                //_Detail.iR08				= obligaciones[i].iR08 == null ? iNull : obligaciones[i].iR08;
                //_Detail.iR09				= obligaciones[i].iR09 == null ? iNull : obligaciones[i].iR09;
                //_Detail.iR10				= obligaciones[i].iR10 == null ? iNull : obligaciones[i].iR10;

                btnObligacion.ImageAlign         = ContentAlignment.TopLeft;
                btnObligacion.TextAlign          = ContentAlignment.MiddleLeft;
                btnObligacion.TextImageRelation  = TextImageRelation.ImageBeforeText;
                btnObligacion.AutoEllipsis       = true;
				//CREAMOS EL EVENTO CLICK DEL BOTON
				btnObligacion.Click += delegate (object sender, EventArgs e) { BtnObligacion_Click(sender, e, _Detail); };
				pnlObligaciones.Controls.Add(ptbEstado);
                pnlObligaciones.Controls.Add(btnObligacion);
            }
        }

        public static int iIdRegistroObligacionSeleccionada;
        public static int iIdObligacionDetalle;
        private void BtnObligacion_Click(object sender, EventArgs e, DetalleObligacion _Detalle)
        {
            Button button = sender as Button;

			_DetalleObligacion = _Detalle;

			pnlInformacionObligacion.Visible = true;
            pnlSemaforo.Visible              = true;
            
            //INFORMACIÓN DE LAS OBLIGACIONES FISCALES
            btnSubirArchivo.Text                = "Seleccionar Archivo";
			btnSubirArchivo.Image				= Properties.Resources.forward_50px;
			btnSubirArchivo.ThumbnailColor		= "#607d8b";
			btnSubirArchivo.FontColor			= "#3f51b5";

            openFileDialogDocumento.FileName    = "";

            lblDetalleObligacion.Text = button.Text;
            txtFormaPago.Text         = _Detalle.sFormaPresentacion;
            lblRegimen.Text           = _Detalle.sObligacion;
            lblFechaVerde.Text        = String.Format("{0:d}", DateTime.Parse(_Detalle.sfechaVerde));
            lblFechaAmarillo.Text     = String.Format("{0:d}", DateTime.Parse(_Detalle.sfechaAmarillo));
            lblFechaRojo.Text         = String.Format("{0:d}", DateTime.Parse(_Detalle.sfechaRojo));

			//btnHonorarios.Visible			= _Detalle.iR01 == null ? false : true;
			//btnArrendamiento.Visible		= _Detalle.iR02 == null ? false : true;
			//btnAsimilados.Visible			= _Detalle.iR03 == null ? false : true;

			//btnEnajenacionBienes.Visible	= _Detalle.iR04 == null ? false : true;
			//btnEnajenacionBolsa.Visible		= _Detalle.iR05 == null ? false : true;
			//btnAdquisicionBienes.Visible	= _Detalle.iR06 == null ? false : true;
			//btnIngresosInt.Visible			= _Detalle.iR07 == null ? false : true;
			//btnObtencionPremios.Visible		= _Detalle.iR08 == null ? false : true;
			//btnIngDividendos.Visible		= _Detalle.iR09 == null ? false : true;
			//btnOtrosIngresos.Visible		= _Detalle.iR10 == null ? false : true;

			if (button.FlatAppearance.MouseOverBackColor == Color.FromArgb(3, 166, 0))
            {
                lblFechaVerde.ForeColor    = Color.FromArgb(3, 166, 0);
                lblFechaAmarillo.ForeColor = Color.Black;
                lblFechaRojo.ForeColor     = Color.Black;
				stateIndicatorComponent1.StateIndex = 3;

			}
            else if (button.FlatAppearance.MouseOverBackColor == Color.FromArgb(255, 153, 0))
            {
                lblFechaVerde.ForeColor    = Color.Black;
                lblFechaAmarillo.ForeColor = Color.FromArgb(255, 153, 0);
                lblFechaRojo.ForeColor     = Color.Black;
				stateIndicatorComponent1.StateIndex = 2;
			}
            else if (button.FlatAppearance.MouseOverBackColor == Color.FromArgb(171, 30, 30))
            {
                lblFechaVerde.ForeColor    = Color.Black;
                lblFechaAmarillo.ForeColor = Color.Black;
                lblFechaRojo.ForeColor     = Color.FromArgb(171, 30, 30);
				stateIndicatorComponent1.StateIndex = 1;
			}

            //string fechaCumplimiento = _Detalle.sFechaEntrega;
            //if(!string.IsNullOrEmpty(fechaCumplimiento))
            //{
            //    lblFechaCumplimiento.Text = String.Format("{0:d}", DateTime.Parse(fechaCumplimiento));

            //    DateTime fechaV = Convert.ToDateTime(lblFechaVerde.Text);
            //    DateTime fechaA = Convert.ToDateTime(lblFechaAmarillo.Text);
            //    DateTime fechaR = Convert.ToDateTime(lblFechaRojo.Text);
            //    DateTime fechaC = Convert.ToDateTime(fechaCumplimiento);

            //    if ((fechaC >= fechaV) && (fechaC <= fechaA))
            //    {
            //        //CUMPLIMIENTO EN VERDE
            //        pctFechaCumplimiento.Image = Properties.Resources.CircledGreen;
            //    }
            //    else if ((fechaC >= fechaA) && (fechaC <= fechaR))
            //    {
            //        //CUMPLIMIENTO EN AMARILLO
            //        pctFechaCumplimiento.Image = Properties.Resources.CircledYellow;
            //    }
            //    else if (fechaC >= fechaR)
            //    {
            //        //CUMPLIMIENTO EN ROJO
            //        pctFechaCumplimiento.Image = Properties.Resources.CircledRed;
            //    }

            //    pctFechaCumplimiento.Visible = true;
            //    lblEtiquetaFC.Visible        = true;
            //    lblFechaCumplimiento.Visible = true;
            //}
            //else
            //{
            //    pctFechaCumplimiento.Visible = false;
            //    lblEtiquetaFC.Visible        = false;
            //    lblFechaCumplimiento.Visible = false;
            //}      

            // Valida si el usuario es un contador para permitir cambiar el estado de la obligación
            if(AUsuarioData.sTipoUsuario == "5")
            {
                btnObligacionCumplida.Visible	= false;
                btnSubirArchivo.Visible			= false;
            }
            cambiarColor(button.Text);
        }

        /// <summary>
        /// Cambia el color de la obligación seleccionada en el listado de estas
        /// </summary>
        /// <param name="IdObligacion">Id de la obligación seleccionada</param>
        public void cambiarColor(string sObligacion)
        {
            foreach (Control x in pnlObligaciones.Controls)
            {
                if (x is Button)
                {
                    if (x.Text == sObligacion.ToString())
                        x.BackColor = Color.FromArgb(0xB3, 0xB3, 0xB3);
                    else
                        x.BackColor = Color.White;
                }
            }
        }
        
        private void btnObligacionCumplida_Click(object sender, EventArgs e)
        {
            //CONDICIÓN SI EXISTE UNA RUTA DE ARCHIVO
            if (openFileDialogDocumento.FileName.ToString() != string.Empty)
            {
                if (FlatMessageBox.Show(string.Format("¿Está seguro de marcar como{0}cumplida esta obligación fiscal?", Environment.NewLine), "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
                {
					//SE ACTUALIZA EL ESTADO DE CUMPLIMIENTO DE LA OBLIGACIÓN SELECCIONADA
					btnObligacionCumplida.Visible = false;
                    pnlObligaciones.Enabled       = false;
                    btnSubirArchivo.Enabled       = false;
                    pgbCarga.Visible              = true;
                    bgwObligacion.RunWorkerAsync();
                }
            }
            else
            {
                FlatMessageBox.Show("No se ha seleccionado un archivo", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }

        public void SaveObligacion()
        {
            if (_DetalleObligacion.iIdRegistroObligacion > 0)
            {
                new RegistroObligacion().cumplirRegistroObligacion(new RegistroObligacion()
                {
                    iIdRegistroObligacion = _DetalleObligacion.iIdRegistroObligacion,
                    iIdUsuarioModifica    = int.Parse(AUsuarioData.sIdusuario)
                });
            }
            cargarArchivos();
        }

        private void btnSubirArchivo_Click(object sender, EventArgs e)
        {
			if (openFileDialogDocumento.ShowDialog() == DialogResult.OK)
			{
				btnSubirArchivo.Text = Path.GetFileName(openFileDialogDocumento.FileName);
				AsignarDocumento(btnSubirArchivo, openFileDialogDocumento.FileName);
			}
        }

		void AsignarDocumento(LollipopSmallCard Card, string sDocumento)
		{
			if (Path.GetExtension(sDocumento) == ".docx" || Path.GetExtension(sDocumento) == ".doc" || Path.GetExtension(sDocumento) == ".DOCX" || Path.GetExtension(sDocumento) == ".DOC")
			{
				Card.Image          = Properties.Resources.ms_word_48px;
				Card.ThumbnailColor = "#295598";
				Card.FontColor      = "#295598";
			}
			else if (Path.GetExtension(sDocumento) == ".xlsx" || Path.GetExtension(sDocumento) == ".xls" || Path.GetExtension(sDocumento) == ".XLSX" || Path.GetExtension(sDocumento) == ".XLS")
			{
				Card.Image			= Properties.Resources.ms_excel_48px1;
				Card.ThumbnailColor = "#1F7246";
				Card.FontColor		= "#1F7246";
			}
			else if (Path.GetExtension(sDocumento) == ".pdf" || Path.GetExtension(sDocumento) == ".PDF")
			{
				Card.Image			= Properties.Resources.pdf_2_48px;
				Card.ThumbnailColor = "#8C1A26";
				Card.FontColor		= "#8C1A26";
			}
			else if (Path.GetExtension(sDocumento) == ".png"
					|| Path.GetExtension(sDocumento) == ".JPG"
					|| Path.GetExtension(sDocumento) == ".JPEG"
					|| Path.GetExtension(sDocumento) == ".jpg"
					|| Path.GetExtension(sDocumento) == ".ico")
			{
				Card.Image			= Properties.Resources.picture_48px;
				Card.ThumbnailColor = "#0078D7";
				Card.FontColor		= "#0078D7";
			}
			else
			{
				Card.Image			= Properties.Resources.file_48px;
				Card.ThumbnailColor = "#aed581";
				Card.FontColor		= "#558b2f";
			}
			metroToolTip1.SetToolTip(Card, sDocumento);
			Card.Text = Path.GetFileName(sDocumento);
		}

        /// <summary>
        /// Método Público para copiar archivos al servidor
        /// </summary>
        public void cargarArchivos()
        {
            try
            {
                string sNoFolder = Cliente.iIdRegimen == 1 ? "26" : "25";
                // VALIDA SI LOS DIRECTORIO EXISTEN, SI NO, SE CREAN LAS CARPETAS
                FTPServer.CreateDirectory(FTPCredentials.Path, FTPCredentials.User, FTPCredentials.Password, string.Format(@"{0}/{3}. Otros/Obligaciones Fiscales/{1}/{2}/", Cliente.sCliente, lblDetalleObligacion.Text, DateTime.Now.ToString("dd-MM-yyyy"), sNoFolder));

                //RECORRE LOS ARCHIVOS SELCCIONADOS DEL CONTROL OPENFILEDIALOG Y COPIA AL SERVIDOR
                int i = 0;
                foreach (string fileName in openFileDialogDocumento.FileNames)
                {
                    i++;
                    string FullPath = string.Format("{0}/{1}/{2}/{5}. Otros/Obligaciones Fiscales/{3}/{4}", FTPCredentials.Path, ConnectionString.FolderConnection, Cliente.sCliente, lblDetalleObligacion.Text, DateTime.Now.ToString("dd-MM-yyyy"), sNoFolder);
                    FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), fileName);
                    FTPServer.RenameFile(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(fileName), i.ToString() + DateTime.Now.ToString("ddMMyyyy") + Path.GetExtension(fileName));
                }

                
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }          
        }

		/// <summary>
		/// Crea un directorio a partir de una ruta, si este existe, se omitira la creación
		/// </summary>
		/// <param name="sDirectorio">Ruta a crear</param>
		public void CreateDirectory(string sDirectorio)
		{
			if (!Directory.Exists(sDirectorio))
				Directory.CreateDirectory(sDirectorio);
		}

		/// <summary>
		/// Crea un directorio en base a un ruta, creando dos carpetas por ejercicios
		/// y dentro de estas, los meses correspondientes.
		/// </summary>
		/// <param name="sDirectorio">Ruta base</param>
		public void CreateDirectoryByDate(string sDirectorio)
		{
			string[] sMeses = System.Globalization.DateTimeFormatInfo.CurrentInfo.MonthNames;
			int i = 0;

			// Creamos el ejercicio anterior al que esta en curso
			if (!Directory.Exists(sDirectorio + @"\" + (DateTime.Now.Year - 1)))
				Directory.CreateDirectory(sDirectorio + @"\" + (DateTime.Now.Year - 1));

			//Creamos los meses correspodientes al ejercicio anterior
			foreach (string mes in sMeses.Where(m => m.Length > 0))
			{
				i++;
				CreateDirectory(sDirectorio + @"\" + (DateTime.Now.Year - 1) + @"\" + string.Format("{0} {1}", i.ToString("00"), char.ToUpper(mes[0]) + mes.Substring(1)));
			}

			i = 0;
			// Creamos el ejercicio en curso
			if (!Directory.Exists(sDirectorio + @"\" + (DateTime.Now.Year)))
				Directory.CreateDirectory(sDirectorio + @"\" + (DateTime.Now.Year));

			//Creamos los meses correspodientes al ejercicio en curso
			foreach (string mes in sMeses.Where(m => m.Length > 0))
			{
				i++;
				CreateDirectory(sDirectorio + @"\" + (DateTime.Now.Year) + @"\" + string.Format("{0} {1}", i.ToString("00"), char.ToUpper(mes[0]) + mes.Substring(1)));
			}
		}

		private void openFileDialogDocumento_FileOk(object sender, CancelEventArgs e)
        {
            //VALIDA EL TAMAÑO DE ARCHIVO SELECCIONADO
            int iTamanio = 0;
            foreach (string fileName in openFileDialogDocumento.FileNames)
            {
                FileInfo info   = new FileInfo(fileName);
                iTamanio        = iTamanio + int.Parse(info.Length.ToString());                
            }

            if (iTamanio > 31457280)
            {
                e.Cancel = true;
                FlatMessageBox.Show(string.Format("Limite de tamaño de archivos superados{0}El tamaño maximo es de 30Mb.", Environment.NewLine), "ACEPTAR", string.Empty, FlatMessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
			//VALIDACIÓN SI EL ARCHIVO EXISTE
			if (!File.Exists(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + Cliente.sCliente + "\\" + @"Expediente en Linea\Log.txt"))
			{
			    var myFile = File.Create(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Clientes\\" + Cliente.sCliente + "\\" + @"Expediente en Linea\Log.txt");
			    myFile.Close();
			}

			//RUTA DE ACCESO DEL ARCHIVO LOG
			string logFile = @"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Documentos\Clientes\" + Cliente.sCliente + @"\Expediente en Linea\Log.txt";

			//APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
			string line = string.Format("{0} | {1} | ", DateTime.Now, AUsuarioData.sIdusuario);
			line += strMessage;
			FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
			StreamWriter swFromFileStream = new StreamWriter(fs);
			swFromFileStream.WriteLine(line);
			swFromFileStream.Flush();
			swFromFileStream.Close();
        }

        private void bgwObligacion_DoWork(object sender, DoWorkEventArgs e)
        {
            SaveObligacion();
        }

        private void bgwObligacion_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //SE ACTUALIZA LA LISTA DE OBLIGACIONES Y SE REALIZA UNA COPIA DE ARCHIVOS AL SERVER
            pnlInformacionObligacion.Visible = false;
            pnlObligaciones.Controls.Clear();
            btnObligacionCumplida.Visible = true;
            pnlObligaciones.Enabled       = true;
            btnSubirArchivo.Enabled       = true;
            pgbCarga.Visible              = false;
            //REINICIA EL ESTADO DE LOS CONTROLES USADOS PARA GUARDAR ARCHIVOS EN EL SERVIDOR
            btnSubirArchivo.Text           = "Seleccionar Archivo";
			btnSubirArchivo.Image		   = Properties.Resources.forward_50px;
			btnSubirArchivo.ThumbnailColor = "#607d8b";
			btnSubirArchivo.FontColor	   = "#3f51b5";

			openFileDialogDocumento.FileName	= "";

            cargarInformacion();
        }
    }
}
