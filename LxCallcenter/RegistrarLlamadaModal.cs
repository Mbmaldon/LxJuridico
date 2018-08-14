using AxWMPLib;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseData;
using System.Runtime.InteropServices;

namespace LxCallcenter
{
    public partial class RegistrarLlamadaModal : Form
    {

		UsuarioData AUsuarioData = UsuarioData.Instancia;
        ClienteData AClienteData;
        DataSet ds;
        CasoMotivo ACasoM = new CasoMotivo();
        public int iFolio;
        public string sRutaGrabacion;
        List<Caso> LCaso;
        List<CasoHistorial> LCasoHistorial;


        public RegistrarLlamadaModal()
        {
            InitializeComponent();
        }

        static RegistrarLlamadaModal _RegistrarLlamadaModal;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iFolio, string sRutaGrabacion)
        {
            _RegistrarLlamadaModal = new RegistrarLlamadaModal();
            _RegistrarLlamadaModal.StartPosition = FormStartPosition.CenterScreen;

            _RegistrarLlamadaModal.iFolio           = iFolio;
            _RegistrarLlamadaModal.sRutaGrabacion   = sRutaGrabacion;

            _DialogResult = DialogResult.No;

			_RegistrarLlamadaModal.Activate();
			_RegistrarLlamadaModal.ShowDialog();

			return _DialogResult;
        }

        protected override void OnLoad(EventArgs e)
        {
            //Animate form
            base.OnLoad(e);

            _RegistrarLlamadaModal.btnCliente.Visible         = true;
            _RegistrarLlamadaModal.btnPersonalInterno.Visible = true;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

        private void lnkBuscarCliente_Click(object sender, EventArgs e)
        {
            if (AClienteData != null)
            {
                if (AClienteData.sCliente != txtBuscarCliente.Text || AClienteData.sRfc != txtBuscarCliente.Text)
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

        /// <summary>
        /// Método que realiza la carga de folios una vez realizada una busqueda, si encuentra folios
        /// abiertos, se muestra una lista de estos.
        /// </summary>
        void CargarFolios()
        {
            Caso caso = new Caso();
            LCaso = caso.LAbiertos(int.Parse(AClienteData.sIdCliente));
            cargarControles();
            // Condición si la lista de casos es diferente de 0
            if (LCaso.Count != 0)
            {
                StopPlayer();
                flpFolios.Controls.Clear();
                //scFoliosAbiertos.Panel1.AutoScroll = true;

                Panel pnlTitulo = new Panel();
                pnlTitulo.Name      = "pnlTitulo";
                pnlTitulo.Height    = 2;
                pnlTitulo.Dock      = DockStyle.Top;
                pnlTitulo.BackColor = Color.FromArgb(174, 213, 129);

                Label lblTitulo      = new Label();
                lblTitulo.Text       = "Folios Abiertos";
                lblTitulo.Location   = new Point(scFoliosAbiertos.Panel1.Width / 2 - lblTitulo.Width / 2, 1);//29, 8
                lblTitulo.Font       = new Font("Calibri Light", 12);//122,23
                lblTitulo.Anchor     = AnchorStyles.Top;
                lblTitulo.TextAlign  = ContentAlignment.TopLeft;
                lblTitulo.Width      = 122;

                

                MaterialSkin.Controls.MaterialLabel lblBuscar = new MaterialSkin.Controls.MaterialLabel();
                lblBuscar.Text       = "Buscar";
                lblBuscar.Location   = new Point(1, 30);

                MaterialSkin.Controls.MaterialSingleLineTextField txtBusqueda = new MaterialSkin.Controls.MaterialSingleLineTextField();
                txtBusqueda.Name     = "txtBusqueda";
                txtBusqueda.Width    = 125;
                txtBusqueda.Location = new Point(5, 50);
                txtBusqueda.Hint     = "Tipo de LLamada";
                txtBusqueda.TextChanged += TxtBusqueda_TextChanged;

                if (scFoliosAbiertos.Panel1.Controls.Count <= 1)
                {

                    scFoliosAbiertos.Panel1.Controls.Add(pnlTitulo);
                    scFoliosAbiertos.Panel1.Controls.Add(lblTitulo);
                    scFoliosAbiertos.Panel1.BackColor = Color.FromArgb(236, 240, 241);
                    scFoliosAbiertos.Panel1.Controls.Add(lblBuscar);
                    scFoliosAbiertos.Panel1.Controls.Add(txtBusqueda);
                }

                for (int i = 0; i < LCaso.Count; i++)
                {
                    Button btnFolio = new Button();
                    btnFolio.Name                       = LCaso[i].iIdCaso.ToString();
                    btnFolio.Text                       = "   Folio: " + LCaso[i].iIdCaso.ToString();
                    btnFolio.AccessibleName             = LCaso[i].sMotivo;
                    btnFolio.AccessibleDescription      = LCaso[i].sDescripcion;
                    btnFolio.Font                       = new Font("Segoe UI", 9);
                    btnFolio.ForeColor                  = Color.FromArgb(105, 105, 105);
                    btnFolio.Width                      = scFoliosAbiertos.Panel1.Width - 8;//160//156
                    btnFolio.Height                     = 24;
                    btnFolio.FlatStyle                  = FlatStyle.Flat;
                    btnFolio.FlatAppearance.BorderSize  = 0;
                    btnFolio.TextAlign                  = ContentAlignment.MiddleLeft;
                    btnFolio.Cursor                     = Cursors.Hand;
                    btnFolio.Image                      = Properties.Resources.phone_16px1;
                    btnFolio.ImageAlign                 = ContentAlignment.MiddleLeft;
                    btnFolio.TextImageRelation          = TextImageRelation.ImageBeforeText;

                    btnFolio.Click += BtnFolio_Click;

                    flpFolios.Controls.Add(btnFolio);                
                }
                scFoliosAbiertos.Location = new Point(0, 270);
                scFoliosAbiertos.Visible = true;
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBC = sender as TextBox;
            foreach (Control uc in flpFolios.Controls)
            {
                if (uc is Button)
                {
                    if (CaseContains(uc.Text, txtBC.Text) || CaseContains(uc.AccessibleName, txtBC.Text) || CaseContains(uc.AccessibleDescription, txtBC.Text))
                        uc.Visible = true;
                    else
                        uc.Visible = false;
                }
            }
        }

        public bool CaseContains(string baseString, string textToSearch)
        {
            return (baseString.IndexOf(textToSearch, StringComparison.CurrentCultureIgnoreCase) != -1);
        }

        private void BtnFolio_Click(object sender, EventArgs e)
        {
            Button btnFolio = sender as Button;
            StopPlayer();
            scFoliosAbiertos.Panel2.Controls.Clear();

            Caso caso = new Caso().InformacionCaso(int.Parse(btnFolio.Name));

            Panel pnlTitulo     = new Panel();
            pnlTitulo.Height    = 2;
            pnlTitulo.Dock      = DockStyle.Top;
            pnlTitulo.BackColor = Color.FromArgb(174, 213, 129);

            PictureBox pctInfo = new PictureBox();
            pctInfo.BackgroundImage       = Properties.Resources.info_25px;
            pctInfo.Location              = new Point(30, 17);
            pctInfo.BackgroundImageLayout = ImageLayout.None;
            pctInfo.Height                = 26;
            pctInfo.Width                 = 26;

            Label lblTitulo = new Label();
            lblTitulo.Text      = "Detalles Folio " + caso.iIdCaso;
            lblTitulo.Location  = new Point(53, 18);//29, 8
            lblTitulo.Font      = new Font("Calibri Light", 14);//122,23
            lblTitulo.Anchor    = AnchorStyles.Left | AnchorStyles.Top;
            lblTitulo.TextAlign = ContentAlignment.TopLeft;
            lblTitulo.Width     = 220;
            lblTitulo.ForeColor = Color.FromArgb(7, 22, 127);

            Label lblMotivo = new Label();
            lblMotivo.Text      = string.Format("Tipo de Llamada{0}{1}", Environment.NewLine, caso.sMotivo);
            lblMotivo.Location  = new Point(30, 55);//480, 8
            lblMotivo.Font      = new Font("Calibri Light", 13);//122,23
            lblMotivo.Anchor    = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            lblMotivo.TextAlign = ContentAlignment.TopLeft;
            lblMotivo.Width     = 150;
            lblMotivo.Height    = 45;

            Label lblFechaCreacion = new Label();
            lblFechaCreacion.Text       = string.Format("Fecha Solicitud{0}{1}", Environment.NewLine, caso.dtFechaCreacion);
            lblFechaCreacion.Location   = new Point(570, 55);//30, 44 657, 55
            lblFechaCreacion.Font       = new Font("Calibri Light", 12);//122,23
            lblFechaCreacion.Anchor     = AnchorStyles.Left | AnchorStyles.Top;
            lblFechaCreacion.TextAlign  = ContentAlignment.TopLeft;
            lblFechaCreacion.Width      = 220;
            lblFechaCreacion.Height     = 45;

            Label lblContador = new Label();
            lblContador.Text        = string.Format("Contador{0}{1} {2} {3}", Environment.NewLine, caso.sContadorNombre, caso.sContadorAPaterno, caso.sContadorAMaterno);
            lblContador.Location    = new Point(260, 55);//29, 8
            lblContador.Font        = new Font("Calibri Light", 13);//122,23
            lblContador.Anchor      = AnchorStyles.Left | AnchorStyles.Top;
            lblContador.TextAlign   = ContentAlignment.TopLeft;
            lblContador.Width       = 320;
            lblContador.Height      = 45;

            LollipopTextBox txtComentario = new LollipopTextBox();
            txtComentario.Multiline     = true;
            txtComentario.Text          = string.Format("Comentario{0}{1}", Environment.NewLine, caso.sDescripcion);
            txtComentario.Location      = new Point(33, 120);//29, 8
            txtComentario.Font          = new Font("Calibri Light", 13);//122,23
            txtComentario.Width         = 750;//845
            txtComentario.Height        = 65;
            txtComentario.Anchor        = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            txtComentario.FocusedColor  = "#FFA300";
            txtComentario.ReadOnly      = true;


            SplitContainer sCHistorial = new SplitContainer();
            sCHistorial.Location            = new Point(30, 200);//162
            sCHistorial.Width               = 385;//450
            sCHistorial.Height              = 120;//120
            sCHistorial.Anchor              = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            sCHistorial.BackColor           = Color.FromArgb(227, 227, 227);
            sCHistorial.Panel1.BackColor    = Color.FromArgb(236, 240, 241);// Color.White;
            sCHistorial.Panel2.BackColor    = Color.White;
            sCHistorial.SplitterWidth       = 1;
            sCHistorial.SplitterDistance    = 180;


            //CONTROL SPLITCONTAINER DONDE SE MOSTRARAN LAS GRABACIONES
            SplitContainer sCGrabaciones = new SplitContainer();
            sCGrabaciones.Name              = "sCGrabaciones";
            sCGrabaciones.Location          = new Point(430, 200);//490, 200
            sCGrabaciones.Width             = 385;//385
            sCGrabaciones.Height            = 120;//94
            sCGrabaciones.Anchor            = AnchorStyles.Right | AnchorStyles.Bottom;
            sCGrabaciones.BackColor         = Color.FromArgb(236, 240, 241);
            sCGrabaciones.Panel1.BackColor  = Color.FromArgb(236, 240, 241);
            sCGrabaciones.Panel2.BackColor  = Color.White;
            sCGrabaciones.SplitterWidth     = 2;
            sCGrabaciones.SplitterDistance  = 180;//170



            CasoHistorial casoHistorial = new CasoHistorial();
            LCasoHistorial = casoHistorial.GetListCasoHistorial(caso.iIdCaso);
            for (int i = 0; i < LCasoHistorial.Count; i++)
            {
                Button btnHistorial = new Button();
                btnHistorial.Location                   = new Point(0, 24 * i + 0);//new Point(12, 24 * i + 0);
                btnHistorial.Name                       = LCasoHistorial[i].iIdCasoHistorial.ToString();
                btnHistorial.Text                       = "  " + LCasoHistorial[i].dtFechaCreacion.ToString();
                btnHistorial.Font                       = new Font("Segoe UI", 9);
                btnHistorial.ForeColor                  = Color.FromArgb(105, 105, 105);
                btnHistorial.Width                      = 180;//225//160
                btnHistorial.Height                     = 24;
                btnHistorial.FlatStyle                  = FlatStyle.Flat;
                btnHistorial.FlatAppearance.BorderSize  = 0;
                btnHistorial.Anchor                     = AnchorStyles.Left | AnchorStyles.Right;
                btnHistorial.TextAlign                  = ContentAlignment.MiddleLeft;
                btnHistorial.Cursor                     = Cursors.Hand;
                btnHistorial.Image                      = Properties.Resources.clock_16px1;
                btnHistorial.ImageAlign                 = ContentAlignment.TopLeft;
                btnHistorial.TextImageRelation          = TextImageRelation.ImageBeforeText;

                btnHistorial.Click += (s, ev) =>
                {
                    sCHistorial.Panel2.Controls.Clear();
                    CasoHistorial casoH = new CasoHistorial().GetInfoCasoHistorial(int.Parse(btnHistorial.Name));
                    Label lblFechaCreacionH = new Label();
                    lblFechaCreacionH.Width     = 200;
                    lblFechaCreacionH.Height    = 45;
                    lblFechaCreacionH.Location  = new Point(10, 5);
                    lblFechaCreacionH.Text      = string.Format("Por: {0}{1}Fecha {2}", casoH.sUsuario, Environment.NewLine, casoH.dtFechaCreacion);

                    RichTextBox txtComentarioH = new RichTextBox();
                    txtComentarioH.Text         = string.Format("Comentario{0}{1}", Environment.NewLine, casoH.sComentario);
                    txtComentarioH.Location     = new Point(10, 65);//29, 8//10, 35
                    txtComentarioH.Font         = new Font("Calibri Light", 11);//122,23
                    txtComentarioH.Width        = 180;//270
                    txtComentarioH.Height       = 58;
                    txtComentarioH.Anchor       = AnchorStyles.Left | AnchorStyles.Right;
                    txtComentarioH.BorderStyle  = BorderStyle.None;
                    txtComentarioH.ReadOnly     = true;
                    txtComentarioH.BackColor    = Color.White;

                    sCHistorial.Panel2.Controls.Add(txtComentarioH);
                    sCHistorial.Panel2.Controls.Add(lblFechaCreacionH);
                };

                sCHistorial.Panel1.Controls.Add(btnHistorial);
            }

            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //OBTIENE UNA LISTA DE ARCHIVOS CON EXTENCIÓN DESDE UN DIRECTORIO Y SE AGREGAN A UNA LISTA
                //DirectoryInfo _DirectoryInfo   = new DirectoryInfo(@"\\192.169.143.34\\MiPyme_Files\\Documentos\\Grabaciones\\");
				DirectoryInfo _DirectoryInfo   = new DirectoryInfo(@"\\192.168.1.34\\Documentos\\" + LogicaCC.ConnectionString.FolderConnection + "\\Documentos\\Grabaciones\\");
                IEnumerable<FileInfo> fileList = _DirectoryInfo.GetFiles("*.WAV", SearchOption.AllDirectories);
                sCGrabaciones.Panel1.Controls.Clear();
                int g = 0;
                foreach (FileInfo fi in fileList.Where(fi => fi.Name.Contains("Folio-" + caso.iIdCaso + "-")).OrderByDescending(fi => fi.Name))
                {
                    g++;
                    //BOTON QUE SE GENERA POR CADA ARCHIVO ENCONTRADO DE LA LISTA DE DOCUMENTPS FILTRADOS
                    Button btnGrabacion = new Button();
                    btnGrabacion.Location                   = new Point(0, 24 * g + -23);//(0, 24 * g + 0);//0, 24 * g + -23
                    btnGrabacion.Name                       = fi.FullName;
                    btnGrabacion.Text                       = " " + fi.Name;
                    btnGrabacion.Font                       = new Font("Segoe UI", 9);
                    btnGrabacion.ForeColor                  = Color.FromArgb(105, 105, 105);
                    btnGrabacion.Width                      = 180;//225
                    btnGrabacion.Height                     = 24;
                    btnGrabacion.TextAlign                  = ContentAlignment.MiddleLeft;
                    btnGrabacion.Cursor                     = Cursors.Hand;
                    btnGrabacion.FlatStyle                  = FlatStyle.Flat;
                    btnGrabacion.FlatAppearance.BorderSize  = 0;
                    btnGrabacion.Image                      = Properties.Resources.microphone_16px1;
                    btnGrabacion.ImageAlign                 = ContentAlignment.TopLeft;
                    btnGrabacion.TextImageRelation          = TextImageRelation.ImageBeforeText;
                    btnGrabacion.AutoEllipsis               = true;

                    //EVENTO CLICK DEL BOTON GRANACIÓN
                    btnGrabacion.Click += (s, ev) =>
                    {
                        StopPlayer();
                        sCGrabaciones.Panel2.Controls.Clear();
                        //TITULO DE LA GRABACIÓN
                        Label lblGrabacion = new Label();
                        lblGrabacion.Location   = new Point(65, 30);
                        lblGrabacion.Text       = "Grabación";
                        lblGrabacion.Font       = new Font("Calibri Light", 10);
                        lblGrabacion.ForeColor  = Color.FromArgb(105, 105, 105);

                        //NOMBRE DE LA GRABACIÓN
                        Label lblNombreGrabacion = new Label();
                        lblNombreGrabacion.Location     = new Point(5, 4);
                        lblNombreGrabacion.Text         = fi.Name;
                        lblNombreGrabacion.Font         = new Font("Calibri Light", 10);
                        lblNombreGrabacion.ForeColor    = Color.FromArgb(105, 105, 105);
                        lblNombreGrabacion.Width        = 180;
                        lblNombreGrabacion.Height       = 20;

                        //CONTROL LINK PARA REPRODUCIR LAS GRABACIONES
                        Bitmap play_25px = Properties.Resources.play_25px1;
                        Bitmap stop_25px = Properties.Resources.stop_25px1;
                        MetroFramework.Controls.MetroLink lnkPlayer = new MetroFramework.Controls.MetroLink();
                        lnkPlayer.Image     = play_25px;
                        lnkPlayer.Location  = new Point(85, 50);
                        lnkPlayer.ImageSize = 25;
                        lnkPlayer.Width     = 25;
                        lnkPlayer.Height    = 25;
                        lnkPlayer.Cursor    = Cursors.Hand;

                        //CONTROL PARA REPRODUCIR AUDIO
                        AxWindowsMediaPlayer axWindowsMediaPlayer1 = new AxWindowsMediaPlayer();
                        axWindowsMediaPlayer1.Location = new Point(30, 85);//(30, 85);
                        axWindowsMediaPlayer1.Width    = 140;
                        axWindowsMediaPlayer1.Height   = 50;

                        axWindowsMediaPlayer1.PlayStateChange += (object senderr, _WMPOCXEvents_PlayStateChangeEvent es) =>
                        {
                            if (es.newState == 8)
                            {
                                lnkPlayer.Image = play_25px;
                                lnkPlayer.Refresh();
                            }
                        };

                        Panel pnl1 = new Panel();
                        pnl1.BackColor = Color.White;
                        pnl1.Location  = new Point(30, 83);
                        pnl1.Width     = 140;
                        pnl1.Height    = 10;

                        Panel pnl2 = new Panel();
                        pnl2.BackColor = Color.White;
                        pnl2.Location  = new Point(30, 103);
                        pnl2.Width     = 140;
                        pnl2.Height    = 34;

                        Panel pnl3 = new Panel();
                        pnl3.BackColor = Color.White;
                        pnl3.Location  = new Point(30, 83);
                        pnl3.Width     = 28;
                        pnl3.Height    = 50;

                        Panel pnl4 = new Panel();
                        pnl4.BackColor = Color.White;
                        pnl4.Location  = new Point(142, 83);
                        pnl4.Width     = 28;
                        pnl4.Height    = 50;

                        //EVENTO CLICK DEL CONTROL METROLINK
                        lnkPlayer.Click += (se, eva) =>
                        {
                            string path = btnGrabacion.Name;

                            axWindowsMediaPlayer1.URL = path;

                            if (lnkPlayer.Image == play_25px)
                            {
                                lnkPlayer.Image = stop_25px;
                                axWindowsMediaPlayer1.Ctlcontrols.play();
                            }
                            else
                            {
                                lnkPlayer.Image = play_25px;
                                axWindowsMediaPlayer1.Ctlcontrols.stop();
                            }
                        };
                        sCGrabaciones.Panel2.Controls.Add(lnkPlayer);
                        sCGrabaciones.Panel2.Controls.Add(lblNombreGrabacion);
                        sCGrabaciones.Panel2.Controls.Add(lblGrabacion);
                        sCGrabaciones.Panel2.Controls.Add(pnl1);
                        sCGrabaciones.Panel2.Controls.Add(pnl2);
                        sCGrabaciones.Panel2.Controls.Add(pnl3);
                        sCGrabaciones.Panel2.Controls.Add(pnl4);
                        sCGrabaciones.Panel2.Controls.Add(axWindowsMediaPlayer1);
                    };
                    sCGrabaciones.Panel1.Controls.Add(btnGrabacion);
                }
            //}

            LollipopButton btnSeguimiento = new LollipopButton();
            btnSeguimiento.Location  = new Point(620, 18);
            btnSeguimiento.Name      = caso.iIdCaso.ToString();
            btnSeguimiento.Text      = "Dar Seguimiento";
            btnSeguimiento.Width     = 126;
            btnSeguimiento.Height    = 24;
            btnSeguimiento.Anchor    = AnchorStyles.Right | AnchorStyles.Top;
            btnSeguimiento.Cursor    = Cursors.Hand;
            btnSeguimiento.Tag       = caso.sMotivo;
            btnSeguimiento.BGColor   = "#2196F3";
            btnSeguimiento.Click += BtnSeguimiento_Click;

            //AGREGAMOS LOS CONTROLES AL PANEL 2
            scFoliosAbiertos.Panel2.Controls.Add(pnlTitulo); 
            scFoliosAbiertos.Panel2.Controls.Add(pctInfo);
            scFoliosAbiertos.Panel2.Controls.Add(lblTitulo);
            scFoliosAbiertos.Panel2.Controls.Add(lblMotivo);
            scFoliosAbiertos.Panel2.Controls.Add(lblFechaCreacion);
            scFoliosAbiertos.Panel2.Controls.Add(lblContador);
            scFoliosAbiertos.Panel2.Controls.Add(txtComentario);
            scFoliosAbiertos.Panel2.Controls.Add(sCHistorial);
            scFoliosAbiertos.Panel2.Controls.Add(sCGrabaciones);
            scFoliosAbiertos.Panel2.Controls.Add(btnSeguimiento);
        }

        private void BtnSeguimiento_Click(object sender, EventArgs e)
        {
            LollipopButton btnSeguimiento = sender as LollipopButton;
            StopPlayer();

            lblFolio.Text                = btnSeguimiento.Name;
            cbTipoLlamada.SelectedIndex  = cbTipoLlamada.FindStringExact(btnSeguimiento.Tag.ToString());
            cbTipoLlamada.Enabled        = false;
            btnNuevoTipoLlamada.Enabled  = false;
            lnkGuardarLlamada.Visible    = false;
            btnGuardaHistorial.Location  = new Point(lnkGuardarLlamada.Location.X, lnkGuardarLlamada.Location.Y);
            btnGuardaHistorial.Visible   = true;

            scFoliosAbiertos.Visible = false;
            btnAsignarFolio.Visible  = false;

            pnlComentarioFolio.Visible = true;
        }

        /// <summary>
        /// Método para detener la reproducción de una grabación
        /// </summary>
        private void StopPlayer()
        {
            foreach (Control x in scFoliosAbiertos.Panel2.Controls)
            {
                if (x is SplitContainer)
                {
                    if (x.Name == "sCGrabaciones")
                    {
                        SplitContainer panel = x as SplitContainer;
                        foreach (Control y in panel.Panel2.Controls)
                        {
                            if (y is AxWindowsMediaPlayer)
                            {
                                AxWindowsMediaPlayer player = y as AxWindowsMediaPlayer;
                                player.Ctlcontrols.stop();
                            }
                        }
                    }
                }
            }
        }

        private int BuscarCliente()
        {
            //StopPlayer();
            int iResultado    = 0;
            AClienteData      = null;
            lblResultado.Text = "";
            Cliente ACliente  = new Cliente();

            LimpiarControles();

            AClienteData = ACliente.ClienteInfo(txtBuscarCliente.Text);

            if (AClienteData != null)
            {
                ClienteInfo(AClienteData);
                pnlInformacionCliente.Location = new Point(-1, 77);
                pnlInformacionCliente.Visible  = true;
            }
            else
            {
                lblResultado.Text             = "* Cliente no encontrado.";
                iResultado                    = 1;
                pnlInformacionCliente.Visible = false;
            }

            return iResultado;
        }

        private void Mayusculas(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
                lnkBuscarCliente_Click(sender, e);
        }

        private void LimpiarControles()
		{
            lblCorreoElectronico.Text   = "";
            lblTelMovil.Text            = "";
            lblNombreCliente.Text		= "";
            lblNoCliente.Text           = "";
            asignarFotografia(-1);
        }

        private void ClienteInfo(ClienteData ACliente)
		{
            LimpiarControles();
            lblNoCliente.Text           = txtBuscarCliente.Text;
            lblNombreCliente.Text		= string.Format("{0} {1} {2}", ACliente.sNombre, ACliente.sAMaterno, ACliente.sAMaterno);
			lblCorreoElectronico.Text	= ACliente.sCorreoElectronico;
            lblTelMovil.Text            = ACliente.sTelefonoCelular;
            asignarFotografia(int.Parse(ACliente.sIdCliente));


            if (ACliente.sActivo.Equals("True"))
                ckbActivo.Checked = true;
        }

        /// <summary>
        /// Obtiene y asigna la foto de perfil de un cliente, si este no tiene, se le asigna una por default
        /// </summary>
        /// <param name="iIdCliente">Id del Cliente</param>
        void asignarFotografia(int iIdCliente)
        {
			ovalPictureBox1.Image = Properties.Resources.circled_user_male_skin_type_1_2_96px;
		}

        private void btnAsignarFolio_Click(object sender, EventArgs e)
        {
            cargarControles();
            pnlComentarioFolio.Location = new Point(-1, 263);
            pnlComentarioFolio.Visible  = true;
            scFoliosAbiertos.Visible    = false;
        }
        
        public void cargarControles()
        {
            ds = ACasoM.ListadoMotivos();
            cbTipoLlamada.DisplayMember = "Motivo";
            cbTipoLlamada.ValueMember   = "IdCasoMotivo";
            cbTipoLlamada.DataSource    = ds.Tables["Motivos"];
        }

        ClaseData.Clases.ListCoordinadores.CoordinadorData slc;

        private void lnkGuardarLlamada_Click(object sender, EventArgs e)
        {
            MensajeError.Clear();
            if (ValidarCampos() == 0)
            {
                CasoActualizar AActualizar = new CasoActualizar();


                int iCoordinador = 0;
                int iMateria = 0;

                if (cbTipoLlamada.SelectedValue.ToString() == "8")
                {
                    slc = (ClaseData.Clases.ListCoordinadores.CoordinadorData)cmbCoordinador.SelectedItem;
                    iCoordinador = int.Parse(slc.sIdUsuario.ToString());
                    iMateria = int.Parse(slc.sIdMateria.ToString());
                }

                string sArea = cbTipoLlamada.SelectedValue.ToString() == "8" ? cmbCoordinador.SelectedValue.ToString() : "";

                if (AActualizar.ActualizarCaso(cbTipoLlamada.SelectedValue.ToString(),
                                           AClienteData.sIdCliente,
                                           AUsuarioData.sIdusuario,
                                           txbDescripcion.Text,
                                           lblFolio.Text, iMateria.ToString(), iCoordinador, _RegistrarLlamadaModal.sRutaGrabacion) == 0)
                {
                    LimpiarControles();
                    txtBuscarCliente.Text = "";
                    _DialogResult = DialogResult.Yes;
                    _RegistrarLlamadaModal.Close();
                }
                else
                {
                    // si hubo error al actualizar
                }


            }
        }

        private int ValidarCampos()
        {
            int iResultado = 0;

            if (string.IsNullOrEmpty(txbDescripcion.Text))
            {
                this.MensajeError.SetError(txbDescripcion, "Debe anotar una descripción.");
                iResultado = 1;
            }

            if (cbTipoLlamada.SelectedIndex == 0)
            {
                this.MensajeError.SetError(cbTipoLlamada, "Debe seleccionar un tipo de llamada.");
                iResultado = 1;
            }
            return iResultado;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            lblFolio.Text               = iFolio.ToString();
            lollipopCard1.Visible       = false;
            lollipopCard2.Visible       = false;
            btnCliente.Visible          = false;
            btnPersonalInterno.Visible  = false;
            pnlBusquedaCliente.Location = new Point(-1, 12);
            pnlBusquedaCliente.Visible  = true;
        }

        private void btnPersonalInterno_Click(object sender, EventArgs e)
        {
            _DialogResult = DialogResult.No;
            _RegistrarLlamadaModal.Close();
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
                    iIdUsuario = 1,
                    sTipoLlamada = txtNuevoTipoLlamada.Text
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
            if (!string.IsNullOrEmpty(txbDescripcion.Text))
            {
                MensajeError.Clear();

                int iResultado = new CasoHistorial().AddHistorial(new CasoHistorial()
                {
                    iIdCaso            = int.Parse(lblFolio.Text),
                    iIdUsuarioRegistra = int.Parse(AUsuarioData.sIdusuario),
                    sComentario        = txbDescripcion.Text
                });

                if (iResultado > 0)
                {
                    frmTelefono _frmTelefono = Application.OpenForms["frmTelefono"] as frmTelefono;

                    _frmTelefono.bSeguimiento        = true;
                    _frmTelefono.iIdFolioSeguimiento = int.Parse(lblFolio.Text);
                    _frmTelefono.iIdHistorialFolio   = iResultado;

                    _DialogResult = DialogResult.Yes;
                    _RegistrarLlamadaModal.Close();
                }
                else
                    FlatMessageBox.Show("No se pudo agregar el comentario", "ACEPTAR", string.Empty, FlatMessageBoxIcon.Error);
            }
            else
                this.MensajeError.SetError(txbDescripcion, "Debe anotar una descripción.");
        }

        private void lnkDirectorio_Click(object sender, EventArgs e)
        {
            // Muestra el directorio de clientes
            frmDirectorio.Show(_RegistrarLlamadaModal);
        }

        private void cbTipoLlamada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbTipoLlamada.SelectedValue.ToString() == "8")
            {
                /*Consumo de funcion para la carga de coordinadores en el combobox*/
                ClaseData.Clases.ListCoordinadores.DatosCoordinadores ACoordinador = new ClaseData.Clases.ListCoordinadores.DatosCoordinadores();
                List<ClaseData.Clases.ListCoordinadores.CoordinadorData> LCoordinadores = ACoordinador.listaCoordinadores();

                cmbCoordinador.DataSource = LCoordinadores;
                cmbCoordinador.ValueMember = "sIdUsuario";
                cmbCoordinador.DisplayMember = "sMateria";
                cmbCoordinador.SelectedIndex = -1;

                materialLabel2.Visible = true;
                cmbCoordinador.Visible = true;
            }
            else
            {
                materialLabel2.Visible    = false;
                cmbCoordinador.Visible    = false;
                cmbCoordinador.DataSource = null;
            }
        }

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

            //if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
            //    m.Result = (IntPtr)HTCAPTION;

        }
        #endregion
    }
}
