using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Eventos;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
using ClaseData.Clases.Tareas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRREventos : Form
    {
        [DllImport("user32.dll")]
        static extern bool AnimateWindow(IntPtr hWnd, int time, AnimateWindowFlags flags);

        [Flags]
        enum AnimateWindowFlags
        {
            AW_HOR_POSITIVE = 0x00000001,
            AW_HOR_NEGATIVE = 0x00000002,
            AW_VER_POSITIVE = 0x00000004,
            AW_VER_NEGATIVE = 0x00000008,
            AW_CENTER = 0x00000010,
            AW_HIDE = 0x00010000,
            AW_ACTIVATE = 0x00020000,
            AW_SLIDE = 0x00040000,
            AW_BLEND = 0x00080000
        }




        int     ifolio;
        int     idSol;
        int     Usuario;
        int     DiasTerInterno;
        string  sNCliente;

        int iIdMateria;
        int iIdSolicitudTipo;

        EventosData         evento;
        TareasData          tarea;
        List<EventosData>   LEventos;
        List<TareasData>    LTareas;
        EIOSFolioEvento     Id;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_files";

        public FRREventos()
        {
            InitializeComponent();
        }

        /*Funciones que se inicializan cuando el formulario es llamado*/
        //public FRREventos(int idMateria, int idConsultor, int idSolicitud, string sNumCliente, int IdCaso, int IdSolicitudTipo)
        //{
        //    InitializeComponent();
        //    Usuario     = idConsultor;
        //    idSol       = idSolicitud;
        //    sNCliente   = sNumCliente;
        //    ifolio      = IdCaso;
        //    iIdMateria  = idMateria;
        //    iIdSolicitudTipo = IdSolicitudTipo;


        //    ///*Carga de tareas en el combobox*/
        //    //DatosTareas ATarea              = new DatosTareas();
        //    //LTareas                         = ATarea.ListaTareas(idMateria);
        //    //this.cmbTarea.DataSource        = LTareas;
        //    //this.cmbTarea.ValueMember       = "sIdTarea";
        //    //this.cmbTarea.DisplayMember     = "sTarea";
        //    //this.cmbTarea.SelectedIndex     = -1;

        //    CObtenerFolio idPro = new CObtenerFolio();
        //    Id = idPro.obtenerIDEvento();
        //}

        protected override void OnLoad(EventArgs e)
        {
            AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_BLEND);
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AnimateWindow(this.Handle, 300, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        static FRREventos _Eventos;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int idMateria, int idConsultor, int idSolicitud, string sNumCliente, int IdCaso, int IdSolicitudTipo)
        {
            _Eventos = new FRREventos();
            FRDetalleServicio _Detalle = Application.OpenForms["FRDetalleServicio"] as FRDetalleServicio;
            _Eventos.FormClosed += new FormClosedEventHandler(_Detalle.ActualizarDetalles_FormClosed);

            _Eventos.Usuario            = idConsultor;
            _Eventos.idSol              = idSolicitud;
            _Eventos.sNCliente          = sNumCliente;
            _Eventos.ifolio             = IdCaso;
            _Eventos.iIdMateria         = idMateria;
            _Eventos.iIdSolicitudTipo   = IdSolicitudTipo;

            /*Carga de eventos en el combobox*/
            DatosEventos AEvento = new DatosEventos();
            _Eventos.LEventos = AEvento.ListaEventos(_Eventos.iIdMateria, _Eventos.iIdSolicitudTipo);
            _Eventos.cmbEvento.DataSource       = _Eventos.LEventos;
            _Eventos.cmbEvento.ValueMember      = "sIdEvento";
            _Eventos.cmbEvento.DisplayMember    = "sEvento";
            _Eventos.cmbEvento.SelectedIndex    = -1;

            if (_Eventos.iEventoR != 0)
                _Eventos.cmbEvento.SelectedValue = _Eventos.iEventoR.ToString();

            if (IdSolicitudTipo != 4)
            {
                _Eventos.dtpTeminoLegal.Visible     = false;
                _Eventos.dtpTerminoInterno.Visible  = false;
                _Eventos.materialLabel8.Visible     = false;
                _Eventos.materialLabel9.Visible     = false;
                _Eventos.dtpTerminoInterno.Value    = new TerminoInterno().GetDate(IdSolicitudTipo, _Eventos.dtpTeminoLegal.Value);
            }

            ///*Carga de tareas en el combobox*/
            //DatosTareas ATarea              = new DatosTareas();
            //LTareas                         = ATarea.ListaTareas(idMateria);
            //this.cmbTarea.DataSource        = LTareas;
            //this.cmbTarea.ValueMember       = "sIdTarea";
            //this.cmbTarea.DisplayMember     = "sTarea";
            //this.cmbTarea.SelectedIndex     = -1;

            CObtenerFolio idPro = new CObtenerFolio();
            _Eventos.Id = idPro.obtenerIDEvento();

            _DialogResult = DialogResult.No;

            _Eventos.Activate();
            _Eventos.ShowDialog();
            return _DialogResult;
        }


        private void FRREventos_Load(object sender, EventArgs e)
        {
            ///*Carga de eventos en el combobox*/
            //DatosEventos AEvento = new DatosEventos();
            //LEventos = AEvento.ListaEventos(iIdMateria, iIdSolicitudTipo);
            //this.cmbEvento.DataSource = LEventos;
            //this.cmbEvento.ValueMember = "sIdEvento";
            //this.cmbEvento.DisplayMember = "sEvento";
            //this.cmbEvento.SelectedIndex = -1;

            //if(iEventoR != 0)
            //{
            //    this.cmbEvento.SelectedValue = iEventoR.ToString();
            //}
        }

        int idEvento;
        private void cmbEvento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idEvento = 0;
            cmbTarea.Enabled = false;
            btnAddTarea.Enabled = false;

            cmbTarea.DataSource = null;
            cmbTarea.Items.Clear();

            if(cmbEvento.SelectedItem != null)
            {
                EventosData sIdEvento = (EventosData)cmbEvento.SelectedItem;
                idEvento = int.Parse(sIdEvento.sIdEvento.ToString());

                if (idEvento > 0)
                {
                    /*Carga de tareas en el combobox*/
                    DatosTareas ATarea = new DatosTareas();
                    LTareas = ATarea.ListaTareas(iIdMateria, idEvento);

                    btnAddTarea.Enabled = true;
                    if (LTareas.Count > 0)
                    {
                        this.cmbTarea.DataSource = LTareas;
                        this.cmbTarea.ValueMember = "sIdTarea";
                        this.cmbTarea.DisplayMember = "sTarea";
                        this.cmbTarea.SelectedIndex = -1;
                        cmbTarea.Enabled = true;

                        if (iTareaR != 0)
                        {
                            this.cmbTarea.SelectedValue = iTareaR.ToString();
                        }
                    }
                }
                else
                {
                    cmbTarea.Enabled = false;
                    btnAddTarea.Enabled = false;
                }
            }
        }

        ///*Evento ValueChanged de control DatePicker que consume función para cargar la fecha de termino interno*/
        //private void dtpTeminoLegal_ValueChanged(object sender, EventArgs e)
        //{
        //    FechaTerminoInterno();
        //}

        ///*Evento SelectionChangeCommitted de combobox para obtener los dias de la tarea seleccionada*/
        //private void cmbTarea_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    tarea = (TareasData)cmbTarea.SelectedItem;

        //    foreach (TareasData ABuscar in LTareas)
        //    {
        //        if (tarea.sIdTarea == ABuscar.sIdTarea)
        //        {
        //            DiasTerInterno = int.Parse( ABuscar.sDiasTermInterno.ToString());
        //            FechaTerminoInterno();
        //            break;
        //        }
        //    }
        //}

        ///*Función para obtener la fecha de termino interno de acuerdo a la tarea seleccionada*/
        //private void FechaTerminoInterno()
        //{
        //    DateTime FTLegal = dtpTeminoLegal.Value;
        //    dtpTerminoInterno.Value = FTLegal.AddDays(-DiasTerInterno);
        //}

        /*Evento click boton registrar para dar de alta un nuevo evento*/
        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            int         iOficialia = 0; /*Eliminar la igualdad en caso de reactivar el envio de solicitud a oficialia*/
            int         idEvento;
            int         idtarea = 1;
            //string      sExpOrigen;
            string      sNumExpediente;
            string      sJuzgado;
            string      sContraparte;
            string      sTipoJuicio;
            string      sDescripcion;
            string      sDescripcionActo;
            DateTime    TerLegal;
            DateTime    TerInterno;
            DateTime    FActual = DateTime.Now;
            
            //if (txtExpOrigen.Text == string.Empty)
            //{
            //    sExpOrigen = " ";
            //}
            //else
            //{
            //    sExpOrigen = txtExpOrigen.Text;
            //}

            if (txtNumExp.Text == string.Empty)
            {
                sNumExpediente = " ";
            }
            else
            {
                sNumExpediente = txtNumExp.Text;
            }

            if (txtJuzgado.Text == string.Empty)
            {
                sJuzgado = " ";
            }
            else
            {
                sJuzgado = txtJuzgado.Text;
            }

            if (txtContraparte.Text == string.Empty)
            {
                sContraparte = " ";
            }
            else
            {
                sContraparte = txtContraparte.Text;
            }

            if (txtTJuicio.Text == string.Empty)
            {
                sTipoJuicio = " ";
            }
            else
            {
                sTipoJuicio = txtTJuicio.Text;
            }

            //if (txtDescripActo.Text == string.Empty)
            //{
            //    sDescripcionActo = " ";
            //}
            //else
            //{
            //    sDescripcionActo = txtDescripActo.Text;
            //}

            /*En caso de reactivar el envio de solicitud de oficilia de partes reactivar estas lineas de codigo y generar el control en el diseño con el nombre de chbOficialia*/
            //if (chbOficialia.Checked == true)
            //{
            //    iOficialia = 1;
            //}
            //else
            //{
            //    iOficialia = 0;
            //}

            if (cmbEvento.Text != string.Empty)
            {
                evento = (EventosData)cmbEvento.SelectedItem;
                idEvento = int.Parse(evento.sIdEvento.ToString());

                if (cmbTarea.Text != string.Empty)
                {
                    tarea = (TareasData)cmbTarea.SelectedItem;
                    idtarea = int.Parse(tarea.sIdTarea);
                }


                    //if (dtpTerminoInterno.Text != string.Empty)
                    //{
                        TerLegal    = dtpTeminoLegal.Value;
                        TerInterno  = dtpTerminoInterno.Value;

                        if (TerInterno >= FActual)
                        {
                            if (txtDescripcion.Text != string.Empty)
                            {
                                sDescripcion = txtDescripcion.Text;

                                //if (chbOficialia.Checked == true)
                                //{
                                /*En caso de reactivar el envio de solicitud de oficilia de partes sustituir esta linea por la comentada enteriormente*/
                                if (cbhActivarCampos.Checked == true)
                                {
                            //if (txtExpOrigen.Text == string.Empty && txtNumExp.Text == string.Empty && txtJuzgado.Text == string.Empty && txtContraparte.Text == string.Empty && txtTJuicio.Text == string.Empty)
                            //if (txtNumExp.Text == string.Empty && txtJuzgado.Text == string.Empty && txtContraparte.Text == string.Empty && txtTJuicio.Text == string.Empty && txtDescripActo.Text == string.Empty)
                            if (txtNumExp.Text == string.Empty && txtJuzgado.Text == string.Empty && txtContraparte.Text == string.Empty && txtTJuicio.Text == string.Empty)
                            {
                                        MessageBox.Show("Es necesario ingresar información en alguno de los siguientes campos: " + Environment.NewLine + 
                                                        "- Expediente de Origen" + Environment.NewLine + 
                                                        "- No. Expediente" + Environment.NewLine + 
                                                        "- Juzgado" + Environment.NewLine + 
                                                        "- Contraparte" + Environment.NewLine +
                                                        "- Tipo Juicio" + Environment.NewLine +
                                                        "- Descripción del Acto", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        try
                                        {
                                            //new DSDetalleServicio().RegistrarEvento(idSol, Usuario, idEvento, idtarea, sExpOrigen, sNumExpediente, sJuzgado, sContraparte, sTipoJuicio, sDescripcion, TerInterno, TerLegal, iOficialia);
                                        new DSDetalleServicio().RegistrarEvento(idSol, Usuario, idEvento, idtarea, " ", sNumExpediente, sJuzgado, sContraparte, sTipoJuicio, sDescripcion, TerInterno, TerLegal, iOficialia, string.Empty);

                                        if (txtRutaArchivo.Text != string.Empty)
                                            {
                                                cargaArchivo();
                                            }
                                            DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            if (rs == DialogResult.OK)
                                            {
                                                Close();
                                            }
                                        }
                                        catch (Exception)
                                        {
                                        }
                                    }
                                }
                                else
                                {
                                    try
                                    {

                                    //new DSDetalleServicio().RegistrarEvento(idSol, Usuario, idEvento, idtarea, sExpOrigen, sNumExpediente, sJuzgado, sContraparte, sTipoJuicio, sDescripcion, TerInterno, TerLegal, iOficialia);
                                    new DSDetalleServicio().RegistrarEvento(idSol, Usuario, idEvento, idtarea, " ", sNumExpediente, sJuzgado, sContraparte, sTipoJuicio, sDescripcion, TerInterno, TerLegal, iOficialia, string.Empty);
                                    if (txtRutaArchivo.Text != string.Empty)
                                        {
                                            cargaArchivo();
                                        }
                                        DialogResult rs = MessageBox.Show("Se ha realizado el registro correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        if (rs == DialogResult.OK)
                                        {
                                            Close();
                                        }
                                    }
                                    catch (Exception)
                                    {
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Es necesario ingresar la descripción del evento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        else
                        {
                            MessageBox.Show("La fecha de término interno no puede ser menor a la fecha actual", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Es necesario registrar la fecha de termino legal");
                    //}
                //}
                //else
                //{
                //    MessageBox.Show("Es necesario seleccionar la tarea", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //}
            }
            else
            {
                MessageBox.Show("Es necesario seleccionar el evento", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /*Evento KeyPress evita la escritura de texto en el control*/
        private void cmbEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Evento CheckedChanged de control checBox para habilitar o deshabiltar controles para alimentar el evento registrado*/
        private void cbhActivarCampos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhActivarCampos.Checked == true)
            {
                //txtExpOrigen.Enabled    = true;
                txtNumExp.Enabled       = true;
                txtJuzgado.Enabled      = true;
                txtContraparte.Enabled  = true;
                txtTJuicio.Enabled      = true;
                //txtDescripActo.Enabled = true;
                //chbOficialia.Visible = true;
            }
            else 
            {
                //txtExpOrigen.Enabled    = false;
                txtNumExp.Enabled       = false;
                txtJuzgado.Enabled      = false;
                txtContraparte.Enabled  = false;
                txtTJuicio.Enabled      = false;
                //txtDescripActo.Enabled = false;           
                //chbOficialia.Visible = false;
            }
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _Eventos.Close();
        }

        /*Evento click del boton CargarArchivo el cual consume control openFileDialog para permitir seleccionar el archivo que sera cargado*/
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            //ASIGNA NOMBRE Y FILTROS DEL CONTROL OPENFILEDIALOG
            openFileDialogDocumento.Title       = "Subir Archivos";
            //openFileDialogDocumento.Filter = "Pdf Files|*.pdf |JPG|*.jpg;*.jpeg |Excel Files|*.xls;*.xlsx;*.xlsm |txt files (*.txt)|*.txt|Zip Files|*.zip;*.rar";
            openFileDialogDocumento.FileName    = "";
            openFileDialogDocumento.ShowDialog();
            txtRutaArchivo.Text                 = openFileDialogDocumento.FileName;
        }

        /*Funcion para cargar archivo */
        public void cargaArchivo()
        {
            try
            {
                //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
                //{
                    if (!Directory.Exists(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento))
                    {
                        Directory.CreateDirectory(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento);
                    }

                    //CUENTA CUANTOS ARCHIVOS EXISTEN EN EL DIRECTORIO
                    var fileCount = (from file in Directory.EnumerateFiles(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento) select file).Count();
                    int i = fileCount - 1;

                    foreach (string fileName in openFileDialogDocumento.FileNames)
                    {
                        //COPIA Y CAMBIO DE NOMBRE DEL ARCHIVO
                        i++;
                        File.Copy(fileName, rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento + "\\" + Path.GetFileName(fileName));

                        File.Move(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento + "\\" + Path.GetFileName(fileName),
                                  rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));


                        EscribirLog("Se copió el archivo " + rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName)));

                        string ruta = rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + "EventoOficialia" + "\\" + Id.sIdEvento + "\\" + i + "-" + Path.GetFileName(RemoveDiacritics(fileName));

                        ////GUARDA UN REGISTRO DE LA RUTA DONDE SE GUARDO EL ARCHIVO
                        new Adjunto().RegistrarRutaAdjunto(int.Parse(Id.sIdEvento), ifolio, 1, Usuario, ruta);
                    }
                    txtRutaArchivo.Text = string.Empty;
                    openFileDialogDocumento.FileName = "";
                //}
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// Método Público para escribir un log de los cambios de los archivos del expediente en linea
        /// </summary>
        /// <param name="strMessage">Mensaje que se guardara en el log.</param>
        public void EscribirLog(string strMessage)
        {
            //VALIDACIÓN SI EL ARCHIVO EXISTE
            if (!File.Exists(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + @"EventoOficialia\Log.txt"))
            {
                var myFile = File.Create(rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + @"EventoOficialia\Log.txt");
                myFile.Close();
            }

            //RUTA DE ACCESO DEL ARCHIVO LOG
            string logFile = rutaAdjuntarArchivo.Path + sNCliente + "\\" + "SolicitudesJuridicas" + "\\" + ifolio + "\\" + @"EventoOficialia\Log.txt";

            //APLICA FORMATO AL LOG Y ESCRIBE EL MENSAJE QUE SE PASA EN EL PARAMETRO STRMENSAJE.
            string line = DateTime.Now.ToString() + " | ";
            line += strMessage;
            FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write, FileShare.None);
            StreamWriter swFromFileStream = new StreamWriter(fs);
            swFromFileStream.WriteLine(line);
            swFromFileStream.Flush();
            swFromFileStream.Close();
        }

        /*Función para remover acentos al nombre del archivo cargado*/
        static string RemoveDiacritics(string text)
        {
            var normalizedString    = text.Normalize(NormalizationForm.FormD);
            var stringBuilder       = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }

        int tipo = 0;
        private void btnAddEvento_Click(object sender, EventArgs e)
        {
            cmbEvento.DataSource = null;
            cmbEvento.Items.Clear();

            cmbTarea.DataSource = null;
            cmbTarea.Items.Clear();

            pnlAdd.Visible = true;
            lblNombre.Text = "Nombre del evento:";
            pnlAdd.Location = new Point(178, 206);//178, 250
            tipo = 0;
            EstadoControles(false);
        }

        public void EstadoControles(bool Status)
        {
            groupBox1.Enabled = Status;
            btnCancelar.Enabled = Status;
            btnRegistrarE.Enabled = Status;
        }

        private void btnAddCanc_Click(object sender, EventArgs e)
        {
            // Oculta el panel para crear una nueva carpeta
            pnlAdd.Visible = false;
            lblNombre.Text = string.Empty;
            txtAdd.Clear();
            EstadoControles(true);
            if (tipo == 0)
            {
                //FRREventos_Load(sender, e);
                /*Carga de eventos en el combobox*/
                DatosEventos AEvento = new DatosEventos();
                LEventos = AEvento.ListaEventos(iIdMateria, iIdSolicitudTipo);
                this.cmbEvento.DataSource = LEventos;
                this.cmbEvento.ValueMember = "sIdEvento";
                this.cmbEvento.DisplayMember = "sEvento";
                this.cmbEvento.SelectedIndex = -1;

                if (iEventoR != 0)
                {
                    this.cmbEvento.SelectedValue = iEventoR.ToString();
                }
            }
            else if (tipo == 1)
            {
                cmbEvento_SelectionChangeCommitted(sender, e);
            }
        }

        DExisteEvento idEventoExis;
        DExisteTarea idTareaExis;
        int iEventoR;
        int iTareaR;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tipo == 0)
            {
                DSDetalleServicio addEvento = new DSDetalleServicio();

                iEventoR = 0;

                idEventoExis = addEvento.existeEvento(iIdMateria, iIdSolicitudTipo, txtAdd.Text.ToUpper());

                if (idEventoExis == null)
                {
                    DialogResult reg = MessageBox.Show(string.Format("{0} {1} {2}", "¿Estás seguro agregar el evento ", txtAdd.Text.ToUpper(), "?"), "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reg == DialogResult.Yes)
                    {

                        try
                        {
                            iEventoR = addEvento.agregarEvento(iIdMateria, iIdSolicitudTipo, txtAdd.Text.ToUpper());

                            pnlAdd.Visible = false;
                            lblNombre.Text = string.Empty;
                            txtAdd.Clear();
                            EstadoControles(true);
                            //FRREventos_Load(sender, e);
                            /*Carga de eventos en el combobox*/
                            DatosEventos AEvento = new DatosEventos();
                            LEventos = AEvento.ListaEventos(iIdMateria, iIdSolicitudTipo);
                            this.cmbEvento.DataSource = LEventos;
                            this.cmbEvento.ValueMember = "sIdEvento";
                            this.cmbEvento.DisplayMember = "sEvento";
                            this.cmbEvento.SelectedIndex = -1;

                            if (iEventoR != 0)
                            {
                                this.cmbEvento.SelectedValue = iEventoR.ToString();
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("{0} {1} {2}", "El evento: ", txtAdd.Text.ToUpper(), " ya se encuentra registrado"), "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if(tipo == 1)
            {
                DSDetalleServicio addTarea = new DSDetalleServicio();

                iTareaR = 0;

                idTareaExis = addTarea.existeTarea(iIdMateria, idEvento, txtAdd.Text.ToUpper());

                if(idTareaExis == null)
                {
                    DialogResult reg = MessageBox.Show(string.Format("{0} {1} {2} {3} {4}", "¿Estás seguro agregar la tarea ", txtAdd.Text.ToUpper()," al evento: ", cmbEvento.Text, "?"), "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reg == DialogResult.Yes)
                    {
                        try
                        {
                            iTareaR = addTarea.agregarTarea(iIdMateria, idEvento, txtAdd.Text.ToUpper());

                            pnlAdd.Visible = false;
                            lblNombre.Text = string.Empty;
                            txtAdd.Clear();
                            EstadoControles(true);
                            cmbEvento_SelectionChangeCommitted(sender, e);
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(string.Format("{0} {1} {2}", "La tarea: ", txtAdd.Text.ToUpper(), " ya se encuentra registrada"), "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnAddTarea_Click(object sender, EventArgs e)
        {
            cmbTarea.DataSource = null;
            cmbTarea.Items.Clear();

            pnlAdd.Visible = true;
            lblNombre.Text = "Nombre de la Tarea:";
            pnlAdd.Location = new Point(178, 206);//178, 290

            tipo = 1;
            EstadoControles(false);
        }

        private void dtpTeminoLegal_ValueChanged(object sender, EventArgs e)
        {
            dtpTerminoInterno.Value = new TerminoInterno().GetDate(_Eventos.iIdSolicitudTipo, dtpTeminoLegal.Value);
        }
    }
}
