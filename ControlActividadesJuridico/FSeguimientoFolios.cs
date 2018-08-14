using AxWMPLib;
using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Llamadas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlActividadesJuridico
{
    public partial class FSeguimientoFolios : Form
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
            AW_CENTER       = 0x00000010,
            AW_HIDE         = 0x00010000,
            AW_ACTIVATE     = 0x00020000,
            AW_SLIDE        = 0x00040000,
            AW_BLEND        = 0x00080000
        }

        public FSeguimientoFolios()
        {
            InitializeComponent();
            //_UseSlideAnimation = useSlideAnimation;
        }

        protected override void OnLoad(EventArgs e)
        {
            AnimateWindow(this.Handle, 200, AnimateWindowFlags.AW_BLEND);
        }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            AnimateWindow(this.Handle, 300, AnimateWindowFlags.AW_BLEND | AnimateWindowFlags.AW_HIDE);
        }

        static FSeguimientoFolios _Seguimiento;
        static DialogResult _DialogResult = DialogResult.No;

        public static DialogResult Show(int iFolio)
        {
            _Seguimiento = new FSeguimientoFolios();
            _Seguimiento.informacion(iFolio);

            _DialogResult = DialogResult.No;

            _Seguimiento.Activate();
            _Seguimiento.ShowDialog();
            return _DialogResult;
        }

        /*Metodo para pasar las credenciales y tener acceso a la carpeta MiPyme_Files*/
        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        //public FSeguimientoFolios(int iFolio)
        //{
        //    InitializeComponent();
        //    informacion(iFolio);
        //}

        /*Función para consultar si existen grabaciones del folio*/
        public void informacion(int ifolio)
        {
            scFoliosAbiertos.Controls.Clear();
            Llamada caso = new Llamada().InformacionCaso(ifolio);

            //LABEL QUE MUESTRA EL FOLIO QUE SE ESTA MOSTRANDO DETALLADAMENTE
            Label lblTitulo                 = new Label();
            lblTitulo.Text                  = "Detalles Folio " + caso.iIdFolio;
            lblTitulo.Location              = new Point(14, 18);//29, 8
            lblTitulo.Font                  = new Font("Calibri Light", 14);//122,23
            lblTitulo.Anchor                = AnchorStyles.Left | AnchorStyles.Top;
            lblTitulo.TextAlign             = ContentAlignment.TopLeft;
            lblTitulo.Width                 = 150;

            //LABEL QUE MUESTRA EL MOTIVO DE LA LLAMADA
            Label lblMotivo                 = new Label();
            lblMotivo.Text                  = string.Format("Tipo de Llamada{0}{1}", Environment.NewLine, caso.sMotivo);
            lblMotivo.Location              = new Point(30, 55);//480, 8
            lblMotivo.Font                  = new Font("Calibri Light", 13);//122,23
            lblMotivo.Anchor                = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left;
            lblMotivo.TextAlign             = ContentAlignment.TopLeft;
            lblMotivo.Width                 = 150;
            lblMotivo.Height                = 45;

            //LABEL QUE MUESTRA LA FECHA DE SOLICITUD DEL FOLIO
            Label lblFechaCreacion          = new Label();
            lblFechaCreacion.Text           = string.Format("Fecha de Solicitud{0}{1}", Environment.NewLine, caso.dtFechaCreacion);
            lblFechaCreacion.Location       = new Point(657, 55);//657, 8
            lblFechaCreacion.Font           = new Font("Calibri Light", 13);//122,23
            lblFechaCreacion.Anchor         = AnchorStyles.Left | AnchorStyles.Top;
            lblFechaCreacion.TextAlign      = ContentAlignment.TopLeft;
            lblFechaCreacion.Width          = 220;
            lblFechaCreacion.Height         = 45;

            //LABEL QUE MUESTRA LA FECHA DE CIERRE DEL FOLIO
            Label lblFechaCierre            = new Label();
            lblFechaCierre.Text             = string.Format("Fecha de Cierre{0}{1}", Environment.NewLine, caso.sFechaCierre);
            lblFechaCierre.Location         = new Point(657, 120);//657, 8
            lblFechaCierre.Font             = new Font("Calibri Light", 13);//122,23
            lblFechaCierre.Anchor           = AnchorStyles.Left | AnchorStyles.Top;
            lblFechaCierre.TextAlign        = ContentAlignment.TopLeft;
            lblFechaCierre.Width            = 220;
            lblFechaCierre.Height           = 45;

            //LABEL QUE MUESTRA EL NÚMERO DE CLIENTE
            Label lblCliente                = new Label();
            lblCliente.Text                 = string.Format("No. cliente{0}{1}", Environment.NewLine, caso.sCliente);
            lblCliente.Location             = new Point(30, 120);
            lblCliente.Font                 = new Font("Calibri Light", 13);//122,23
            lblCliente.Width                = 150;
            lblCliente.Height               = 45;

            //LABEL QUE MUESTRA EL NOMBRE DEL CLIENTE
            Label lblClienteNombre          = new Label();
            lblClienteNombre.Text           = string.Format("Cliente{0}{1} {2}  {3}", Environment.NewLine, caso.sNombre, caso.sAPaterno, caso.sAMaterno);
            lblClienteNombre.Location       = new Point(260, 120);
            lblClienteNombre.Font           = new Font("Calibri Light", 13);//122,23
            lblClienteNombre.Width          = 320;
            lblClienteNombre.Height         = 45;

            //LABEL QUE MUESTRA EL NOMBRE DEL CONTADOR ASIGNADO
            Label lblContador               = new Label();
            lblContador.Text                = string.Format("Contador{0}{1} {2} {3}", Environment.NewLine, caso.sContadorNombre, caso.sContadorAPaterno, caso.sContadorAMaterno);
            lblContador.Location            = new Point(260, 55);//29, 8
            lblContador.Font                = new Font("Calibri Light", 13);//122,23
            lblContador.Anchor              = AnchorStyles.Left | AnchorStyles.Top;
            lblContador.TextAlign           = ContentAlignment.TopLeft;
            lblContador.Width               = 320;
            lblContador.Height              = 45;

            //CONTROL RICHTEXTBOX DONDE SE MUESTRA LA DESCRIPCIÓN DEL FOLIO
            RichTextBox txtComentario       = new RichTextBox();
            txtComentario.Text              = string.Format("Comentario{0}{1}", Environment.NewLine, caso.sDescripcion);
            txtComentario.Location          = new Point(30, 194);//29, 8
            txtComentario.Font              = new Font("Calibri Light", 13);//122,23
            txtComentario.Width             = 845;//845
            txtComentario.Height            = 65;
            txtComentario.Anchor            = AnchorStyles.Left | AnchorStyles.Right;
            txtComentario.BorderStyle       = BorderStyle.None;
            txtComentario.ReadOnly          = true;
            txtComentario.BackColor         = Color.White;
            txtComentario.Enabled           = false;

            Label lblHistorial              = new Label();
            lblHistorial.Location           = new Point(30, 260);
            lblHistorial.Text               = "Llamadas";
            lblHistorial.Font               = new Font("Calibri Light", 14);
            lblHistorial.ForeColor          = Color.FromArgb(105, 105, 105);

            Panel pnlLinea                  = new Panel();
            pnlLinea.Location               = new Point(30, 285);
            pnlLinea.BackColor              = Color.FromArgb(236, 240, 241);
            pnlLinea.Width                  = 900;//620
            pnlLinea.Height                 = 1;
            pnlLinea.BorderStyle            = BorderStyle.None;


            //CONTROL SPLITCONTAINER DONDE SE MOSTRARAN LAS GRABACIONES
            SplitContainer sCGrabaciones    = new SplitContainer();
            sCGrabaciones.Name              = "sCGrabaciones";
            sCGrabaciones.Location          = new Point(30, 295);
            sCGrabaciones.Width             = 410;//620//845
            sCGrabaciones.Height            = 180;
            sCGrabaciones.Anchor            = AnchorStyles.Left | AnchorStyles.Right;
            sCGrabaciones.BackColor         = Color.FromArgb(236, 240, 241);
            sCGrabaciones.BackColor         = Color.FromArgb(236, 240, 241);
            sCGrabaciones.BackColor         = Color.White;
            sCGrabaciones.SplitterWidth     = 2;
            sCGrabaciones.SplitterDistance  = 180;


            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                //OBTIENE UNA LISTA DE ARCHIVOS CON EXTENCIÓN DESDE UN DIRECTORIO Y SE AGREGAN A UNA LISTA

                DirectoryInfo _DirectoryInfo    = new DirectoryInfo(@"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\Documentos\Grabaciones");
                IEnumerable<FileInfo> fileList  = _DirectoryInfo.GetFiles("*.WAV", SearchOption.AllDirectories);

                sCGrabaciones.Panel1.Controls.Clear();
                // StopPlayer();
                int g = 0;
                foreach (FileInfo fi in fileList.Where(fi => fi.Name.Contains("Folio-" + caso.iIdFolio + "-")).OrderByDescending(fi => fi.Name))
                {
                    // StopPlayer();
                    g++;
                    //BOTON QUE SE GENERA POR CADA ARCHIVO ENCONTRADO DE LA LISTA DE DOCUMENTPS FILTRADOS
                    Button btnGrabacion                     = new Button();
                    btnGrabacion.Location                   = new Point(0, 24 * g + -23);//(0, 24 * g + 0);
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
                    btnGrabacion.Image                      = Properties.Resources.microphone_16px;
                    btnGrabacion.ImageAlign                 = ContentAlignment.TopLeft;
                    btnGrabacion.TextImageRelation          = TextImageRelation.ImageBeforeText;
                    btnGrabacion.AutoEllipsis               = true;

                    //EVENTO CLICK DEL BOTON GRABACIÓN
                    btnGrabacion.Click += (s, ev) =>
                    {
                        StopPlayer();
                        sCGrabaciones.Panel2.Controls.Clear();
                    //TITULO DE LA GRABACIÓN
                    Label lblGrabacion                  = new Label();
                        lblGrabacion.Location           = new Point(100, 30);
                        lblGrabacion.Text               = "Grabación";
                        lblGrabacion.Font               = new Font("Calibri Light", 10);
                        lblGrabacion.ForeColor          = Color.FromArgb(105, 105, 105);

                    //NOMBRE DE LA GRABACIÓN
                    Label lblNombreGrabacion            = new Label();
                        lblNombreGrabacion.Location     = new Point(45, 4);
                        lblNombreGrabacion.Text         = fi.Name;
                        lblNombreGrabacion.Font         = new Font("Calibri Light", 10);
                        lblNombreGrabacion.ForeColor    = Color.FromArgb(105, 105, 105);
                        lblNombreGrabacion.Width        = 220;
                        lblNombreGrabacion.Height       = 20;

                    //CONTROL LINK PARA REPRODUCIR LAS GRABACIONES
                    Bitmap play_25px                                = Properties.Resources.play_25px;
                        Bitmap stop_25px                            = Properties.Resources.stop_25px;
                        MetroFramework.Controls.MetroLink lnkPlayer = new MetroFramework.Controls.MetroLink();
                        lnkPlayer.Image                             = play_25px;
                        lnkPlayer.Location                          = new Point(120, 50);
                        lnkPlayer.ImageSize                         = 25;
                        lnkPlayer.Width                             = 25;
                        lnkPlayer.Height                            = 25;
                        lnkPlayer.Cursor                            = Cursors.Hand;

                    //CONTROL PARA REPRODUCIR AUDIO
                    AxWindowsMediaPlayer axWindowsMediaPlayer1      = new AxWindowsMediaPlayer();
                        axWindowsMediaPlayer1.Location              = new Point(30, 85);//(485, 85);
                        axWindowsMediaPlayer1.Width                 = 190;
                        axWindowsMediaPlayer1.Height                = 50;

                    //ACTUALIZAR EL ICONO AL TERMINAR LA REPRODUCCION
                    axWindowsMediaPlayer1.PlayStateChange += (object senderr, _WMPOCXEvents_PlayStateChangeEvent es) =>
                        {
                            if (es.newState == 8)
                            {
                                lnkPlayer.Image = play_25px;
                                lnkPlayer.Refresh();
                            }
                        };

                        Panel pnl1      = new Panel();
                        pnl1.BackColor  = Color.White;
                        pnl1.Location   = new Point(30, 83);
                        pnl1.Width      = 170;
                        pnl1.Height     = 10;

                        Panel pnl2      = new Panel();
                        pnl2.BackColor  = Color.White;
                        pnl2.Location   = new Point(30, 103);
                        pnl2.Width      = 170;
                        pnl2.Height     = 34;

                        Panel pnl3      = new Panel();
                        pnl3.BackColor  = Color.White;
                        pnl3.Location   = new Point(30, 83);
                        pnl3.Width      = 28;
                        pnl3.Height     = 50;

                        Panel pnl4      = new Panel();
                        pnl4.BackColor  = Color.White;
                        pnl4.Location   = new Point(195, 83);//420, 37
                        pnl4.Width      = 28;
                        pnl4.Height     = 50;

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
            //AGREGAMOS LOS CONTROLES AL PANEL 2
            scFoliosAbiertos.Controls.Add(lblTitulo);
            scFoliosAbiertos.Controls.Add(lblMotivo);
            scFoliosAbiertos.Controls.Add(lblFechaCreacion);
            scFoliosAbiertos.Controls.Add(lblFechaCierre);
            scFoliosAbiertos.Controls.Add(lblCliente);
            scFoliosAbiertos.Controls.Add(lblClienteNombre);
            scFoliosAbiertos.Controls.Add(lblContador);
            scFoliosAbiertos.Controls.Add(txtComentario);
            scFoliosAbiertos.Controls.Add(lblHistorial);
            scFoliosAbiertos.Controls.Add(pnlLinea);
            //scFoliosAbiertos.Panel2.Controls.Add(sCHistorial);
            scFoliosAbiertos.Controls.Add(sCGrabaciones);
        }

        /*Evento para parar la reprdocción de la grabació*/
        private void StopPlayer()
        {
            foreach (Control x in scFoliosAbiertos.Controls)
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

        /*Evento click del boton Cerrar, cierra formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //Close();
            _DialogResult = DialogResult.No;
            _Seguimiento.Close();
        }

        /*Evento FormClosing que consume evento StopPlayer que para la reproducción*/
        private void FSeguimientoFolios_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopPlayer();
        }
    }
}
