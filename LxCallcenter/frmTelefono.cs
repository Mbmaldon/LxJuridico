using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Librerías para llamadas
using Ozeki.Media;
using Ozeki.VoIP;
using System.Net;
using System.Media;
using LogicaCC.Logica;
using System.IO;
using LogicaCC;
using System.Runtime.InteropServices;

namespace LxCallcenter
{
    public partial class frmTelefono : Form
    {
        #region Clases Requeridas Para Llamada
        ISoftPhone        _softPhone;
        IPhoneLine        _phoneLine;
        RegState          _phoneLineState;
        public IPhoneCall _call;
        public IPhoneCall _call2;
        Microphone             _microphone;
        Speaker                _speaker;
        MediaConnector         _connector;
        PhoneCallAudioSender   _mediaSender;
        PhoneCallAudioReceiver _mediaReceiver;

        bool _incomingCall;
        static string caller;
        static string filename = "";
        static WaveStreamRecorder recorder;

        FPrincipal _MainForm = Application.OpenForms["FPrincipal"] as FPrincipal;
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        Prospeccion AProspeccionData = Prospeccion.Instancia;
        LlamadaProspeccion ALlamadaData = LlamadaProspeccion.Instancia;

        int    iIdFolio;
        string sRecordName = "";
        public int iIdFolioSeguimiento = 0;
        public int iIdHistorialFolio   = 0;
        public bool bSeguimiento = false;
        public bool bEstadoPanel = true;
        DateTime sFechaInicio = DateTime.Now;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        #endregion

        #region ANIMACIONES
        public enum Effect { Roll, Slide, Center, Blend }

        //ANIMACIÓN 1*****************************************************************************/
        public static void Animate(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else
            {
                if (ctl.TopLevelControl == ctl) flags |= 0x20000;
                else if (effect == Effect.Blend) throw new ArgumentException();
            }
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed");
            ctl.Visible = !ctl.Visible;
        }

        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);
        /***************************************************************************************/

        //ANIMACIÓN 2*****************************************************************************/
        public static void Animate2(Control control, Effect efecto, int milisegundos, int angulo)
        {
            int flags = effemap[(int)efecto];
            if (control.Visible) { flags |= 0x10000; angulo += 360; }
            else
            {
                if (control.TopLevelControl == control) flags |= 0x20000;
                else if (efecto == Effect.Blend) throw new ArgumentException();
            }
            flags |= diremap[(angulo % 360) / 45];
            bool ok = AnimateWindow(control.Handle, milisegundos, flags);
            if (!ok) throw new Exception("Animation failed");
            control.Visible = !control.Visible;
        }

        private static int[] diremap = { 1, 5, 4, 6, 2, 10, 8, 9 };
        private static int[] effemap = { 0, 0x40000, 0x10, 0x80000 };

        /***************************************************************************************/
        #endregion

        public frmTelefono()
        {
            InitializeComponent();
            pnlLlamada.Location = new Point(pnlKeyPad.Location.X, pnlKeyPad.Location.Y);
        }

        private void frmTelefono_Load(object sender, EventArgs e)
        { 
            //Inicializa los componentes para las llamadas
            _microphone    = Microphone.GetDefaultDevice();
            _speaker       = Speaker.GetDefaultDevice();
            _connector     = new MediaConnector();
            _mediaSender   = new PhoneCallAudioSender();
            _mediaReceiver = new PhoneCallAudioReceiver();
            InitializeSoftphone();
        }

        #region EVENTOS
        private void frmTelefono_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
        }

        private void lnkExpCol_Click(object sender, EventArgs e)
        {
            while (this.Width > 10)
            {
                this.Width -= 20;
                this.Left += 20;
                Application.DoEvents(); //allow the Form to display its new size before the next iteration
            }
            bEstadoPanel = false;
        }

        private void pnlKeyPad_Click(object sender, EventArgs e)
        {
            txtDisplay.Focus();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (lnkHangUp.Location.X > 100)
                lnkHangUp.Left -= 5;
            else
                timer3.Enabled = false;
        }

        private void btnEnviarTransf_Click(object sender, EventArgs e)
        {
            _call.ToggleHold();
            _call.AttendedTransfer(_call2);
            InvokeGUIThread(() => { btnEnviarTransf.Visible = false; btnTransfer.Visible = true; });
        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                lnkPickUp_Click(sender, e);

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        void _phoneLine_RegistrationStateChanged(object sender, RegistrationStateChangedArgs e)
        {
            _phoneLineState = e.State;

            if (_phoneLineState == RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { lblExtension.Text = _phoneLine.SIPAccount.UserName; });
                InvokeGUIThread(() => { lblIpAddress.Text = _phoneLine.SIPAccount.DomainServerHost; });
            }
        }

        void _softPhone_IncomingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            if (_call == null)
            {
			    wplayer.URL = @"\\192.168.1.34\Documentos\" + LogicaCC.ConnectionString.FolderConnection + @"\skype_call.mp3";

			    var userName = e.Item.DialInfo.SIPCallerID.DisplayName;
                caller       = e.Item.DialInfo.SIPCallerID.DisplayName;
                InvokeGUIThread(() =>
                {
			    	if (_MainForm.WindowState == FormWindowState.Minimized)
                        _MainForm.WindowState = FormWindowState.Maximized;

			    	wplayer.settings.setMode("loop", true);
                    wplayer.controls.play();
                    txtDisplay.Text     = userName;
                    lblExtEntrante.Text = userName;

                    InvokeGUIThread(() =>
                    {
                        ShowPhone();
                    });

                    if (pnlLlamada.Visible == true)
                    {
                        frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                        frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                        frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                    }
                    else
                    {
                        frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                        frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                    }

                    lnkConfigurar.Enabled = false;

                    _MainForm.Activate();
                });

                _call = e.Item;
                WireUpCallEvents();
                _incomingCall = true;
            }
        }

        void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lbl_CallState.Text = e.State.ToString(); lblEstatusLlamada.Text = e.State.ToString(); });

            if (e.State == CallState.Answered)
            {                
                InvokeGUIThread(() => {
                    wplayer.controls.stop();
                    crearFolio();
                    ALlamadaData.bCurso = true;

                    string sRuta = string.Format(@"{0}\mpy\records\nws", Path.GetTempPath());
                    if (!Directory.Exists(sRuta))
                        Directory.CreateDirectory(sRuta);
                });

                StartDevices();
                SendDTMFSingnal();

                sFechaInicio = DateTime.Now;
                sRecordName  = AProspeccionData.bCurso ? string.Format("pcll-{1}.wav", Path.GetTempPath(), AProspeccionData.iIdLlamada) : string.Format("Folio-{0}-{1}{2}{3}{4}{5}{6}.wav", iIdFolio, sFechaInicio.Day, sFechaInicio.Month, sFechaInicio.Year, sFechaInicio.Hour, sFechaInicio.Minute, sFechaInicio.Second);
                filename     = string.Format(@"{0}\mpy\records\nws\{1}", Path.GetTempPath(), sRecordName);

				recorder = new WaveStreamRecorder(filename);  // new recorder object
                _connector.Connect(_microphone, recorder);    // connects the outgoing voice to the recorder
                _connector.Connect(_mediaReceiver, recorder); // connects the incoming voice to the recorder

                _mediaSender.AttachToCall(_call);
                _mediaReceiver.AttachToCall(_call);
                recorder.Start();  // starts the recording
                
                InvokeGUIThread(() => {
                    timer1.Start();
                    txtDisplay.Text     = "" + ((IPhoneCall)sender).DialInfo.SIPCallerID.DisplayName;
                    lblExtEntrante.Text = "" + ((IPhoneCall)sender).DialInfo.SIPCallerID.DisplayName;

                    if (!AProspeccionData.bCurso)
                    {
                        // Valida despues de mostrar la modal para registrar la llamada
                        if (RegistrarLlamadaModal.Show(iIdFolio, filename) == DialogResult.Yes)
                        {
                            Cliente ACliente = new Cliente();
                            Caso NoCliente;
                            if (bSeguimiento)
                                NoCliente = new Caso().ClienteCaso(iIdFolioSeguimiento);
                            else
                                NoCliente = new Caso().ClienteCaso(iIdFolio);
                        }
                    }
                });
            }
            else if (e.State == CallState.InCall)
            {
                StartDevices();
            }

            if (e.State == CallState.LocalHeld || e.State == CallState.InactiveHeld)
            {
                StopDevices();
                InvokeGUIThread(() => {
                    lnkHold.Text         = "Unhold";
                    lnkHold.Image        = Properties.Resources.resume_button_48px;
                    lnkHold.NoFocusImage = Properties.Resources.resume_button_48px;
                });
            }
            else
            {
                InvokeGUIThread(() => {
                    lnkHold.Text         = "Hold";
                    lnkHold.Image        = Properties.Resources.pause_48px;
                    lnkHold.NoFocusImage = Properties.Resources.pause_48px;
                });
            }

            if (e.State.IsCallEnded())
            {
                StopDevices();

                _mediaSender.Detach();
                _mediaReceiver.Detach();

                WireDownCallEvents();

                if (recorder != null)
                {
                    recorder.Dispose();
                    recorder = null;
                }

                _call = null;

                timer1.Stop();

                InvokeGUIThread(() => {
                    wplayer.controls.stop();
                    txtDisplay.Text               = String.Empty;
                    lblExtEntrante.Text           = string.Empty;
                    lblTiempo.Text                = string.Empty;

                    if (pnlLlamada.Visible == true)
                    {
                        frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 360);
                        frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                    }

                    lnkPickUpInCall.Visible       = true;
                    lnkVolverLLamada.Visible      = false;
                    pnlTransferirLlamada.Visible  = false;
                    txtNoTransferir.Text          = string.Empty;
                    lnkConfigurar.Enabled         = true;
                    lnkHangUp.Location            = new Point(150, 94);
                    AProspeccionData.bCurso       = false;

                    string sFilePath = "";
                    if (bSeguimiento && iIdFolioSeguimiento != 0)
                    {
                        sFilePath = string.Format(@"{0}\mpy\records\nws\Folio-{1}-{2}{3}{4}{5}{6}{7}.wav", Path.GetTempPath(), iIdFolioSeguimiento, sFechaInicio.Day, sFechaInicio.Month, sFechaInicio.Year, sFechaInicio.Hour, sFechaInicio.Minute, sFechaInicio.Second);
                        File.Move(filename, sFilePath);
                        CasoHistorial _UpdRecord = new CasoHistorial();
                        _UpdRecord.UpdateHistorialRecord(iIdHistorialFolio, sFilePath);
                    }
 
                    if (ALlamadaData.bCurso)
                    {
                        if (sFilePath == "")
                        {
                            string FullPath = string.Format("{0}/{1}/Records/", FTPCredentials.Path, ConnectionString.FolderConnection);
                            FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(filename), filename);
                            File.Delete(filename);
                        }
                        else
                        {
                            string FullPath = string.Format("{0}/{1}/Records/", FTPCredentials.Path, ConnectionString.FolderConnection);
                            FTPServer.Upload(FullPath, FTPCredentials.User, FTPCredentials.Password, Path.GetFileName(sFilePath), sFilePath);
                            File.Delete(sFilePath);
                        }
                        ALlamadaData.bCurso = false;
                    }
                });
            }
        }

        void buttonKeyPadButton_Click(object sender, EventArgs e)
        {
            var btn = sender as MetroFramework.Controls.MetroLink;

            if (_call != null)
                return;

            if (btn == null)
                return;

            txtDisplay.Text += btn.Text.Trim();
        }

        private void buttonKeyPadButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (_call != null && _call.CallState == CallState.InCall)
            {
                var btn = sender as MetroFramework.Controls.MetroLink;
                int id;
                
                if (btn.Tag != null && int.TryParse(btn.Tag.ToString(), out id))
                    _call.StartDTMFSignal((DtmfNamedEvents)id, DtmfSignalingMode.RFC2833);
                else
                {
                    if (btn.Tag.ToString() == "#")
                        _call.StartDTMFSignal(DtmfNamedEvents.DtmfHashMark, DtmfSignalingMode.RFC2833);
                    else if (btn.Tag.ToString() == "*")
                        _call.StartDTMFSignal(DtmfNamedEvents.DtmfStar, DtmfSignalingMode.RFC2833);
                }
            }
        }

        private void buttonKeyPad_MouseUp(object sender, MouseEventArgs e)
        {
            if (_call != null && _call.CallState == CallState.InCall)
            {
                var btn = sender as MetroFramework.Controls.MetroLink;
                int id;

                if (btn.Tag != null && int.TryParse(btn.Tag.ToString(), out id))
                    _call.StopDTMFSignal((DtmfNamedEvents)id);
                else
                {
                    if (btn.Tag.ToString() == "#")
                        _call.StopDTMFSignal(DtmfNamedEvents.DtmfHashMark);
                    else if (btn.Tag.ToString() == "*")
                        _call.StopDTMFSignal(DtmfNamedEvents.DtmfStar);
                }
            }
        }

        public void lnkPickUp_Click(object sender, EventArgs e)
        {            
            if (_incomingCall)
            {
                lnkPickUpInCall.Visible = false;
                timer3.Enabled = true;

                _incomingCall = false;
                _call.Answer();

                return;
            }

            if (_call != null)
                return;

            if (_phoneLineState != RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { txtDisplay.Text = "OFFLINE! Please register."; });
                return;
            }

            if (!String.IsNullOrEmpty(txtDisplay.Text))
            {
                var userName = txtDisplay.Text;
                lnkConfigurar.Enabled = false;

                if (pnlLlamada.Visible == true)
                {
                    frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                    frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                    frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                }
                else
                {
                    frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                    frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                }

                lnkPickUpInCall.Visible = false;
                timer3.Enabled          = true;

                _call = _softPhone.CreateCallObject(_phoneLine, userName);
                WireUpCallEvents();
                _call.Start();
            }
        }

        private void lnkHangUp_Click(object sender, EventArgs e)
        {
            if (_call != null)
            {
                if (_incomingCall && _call.CallState == CallState.Ringing)
                    _call.Reject();
                else
                    _call.HangUp();
                _incomingCall = false;
                _call = null;
            }
            txtDisplay.Text = string.Empty;
        }

        private void lnkTransfer_Click(object sender, EventArgs e)
        {
            if (_call.CallState == CallState.InCall)
            {
                pnlTransferirLlamada.Location = new Point(pnlLlamada.Location.X + 10, 226);//Y=180
                pnlTransferirLlamada.Visible  = true;
                txtNoTransferir.Focus();
            }
        }

        private void lnkHold_Click(object sender, EventArgs e)
        {
            if (_call != null)
                _call.ToggleHold();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan spTiempo = DateTime.Now - sFechaInicio;
            lblTiempo.Text    = spTiempo.ToString(@"hh\:mm\:ss", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void lnkTeclado_Click(object sender, EventArgs e)
        {
            lnkVolverLLamada.Visible = true;

            frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 360);
            frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
        }

        private void lnkVolverLLamada_Click(object sender, EventArgs e)
        {
            lnkVolverLLamada.Visible = false;
            if (pnlLlamada.Visible == true)
            {
                frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
                frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
            }
            else
            {
                frmTelefono.Animate(pnlKeyPad, frmTelefono.Effect.Slide, 150, 360);
                frmTelefono.Animate2(pnlLlamada, frmTelefono.Effect.Slide, 150, 180);
            }
        }

        private void lnkConfigurar_Click(object sender, EventArgs e)
        {
            //this.Close();
            //frmTelefonoConfigurar _frmTelefonoConfigurar = new frmTelefonoConfigurar();
            //MostrarForm(_frmTelefonoConfigurar);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string transferTo = txtNoTransferir.Text;
            _call.ToggleHold();

            _call2 = _softPhone.CreateCallObject(_phoneLine, transferTo);
            _call2.CallStateChanged += call2_CallStateChanged;
            _call2.Start();
        }

        private void call2_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            if (e.State == CallState.Answered)
            {
                _mediaSender.AttachToCall(_call2);
                _mediaReceiver.AttachToCall(_call2);

                StartDevices();
                InvokeGUIThread(() => { btnTransfer.Visible = false; btnEnviarTransf.Visible = true; });
            }
            else if (e.State == CallState.InCall)
                StartDevices();

            if (e.State.IsCallEnded())
            {
                _call2 = null;
                _mediaSender.Detach();
                _mediaReceiver.Detach();

                _mediaSender.AttachToCall(_call);
                _mediaReceiver.AttachToCall(_call);

                StartDevices();
                InvokeGUIThread(() => { btnTransfer.Visible = true; });
            }
        }

        private void btnCancelarTransferirLlamada_Click(object sender, EventArgs e)
        {
            if (_call2 != null)
            {
                _call2.HangUp();
                _call2 = null;
                _mediaSender.AttachToCall(_call);
                _mediaReceiver.AttachToCall(_call);
                _call.ToggleHold();
                InvokeGUIThread(() => { btnEnviarTransf.Visible = false; btnTransfer.Visible = true; });
            }
            pnlTransferirLlamada.Visible = false;
            txtNoTransferir.Text = string.Empty;
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Inicializa la información de los controles que se usarán para el teléfono
        /// </summary>
        void InitializeSoftphone()
        {
            try
            {
                UsuarioLinea ln = new UsuarioLinea().ObtenerLinea(int.Parse(AUsuarioData.sIdusuario));

                _softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750);
                SIPAccount sa = new SIPAccount(true, ln.sDisplayName, ln.sUserName, ln.sRegisterName, ln.sRegisterPassword, ln.sDomainHost, ln.iDomainPort);

                _phoneLine = _softPhone.CreatePhoneLine(sa);
                _phoneLine.RegistrationStateChanged += _phoneLine_RegistrationStateChanged;

                _softPhone.IncomingCall += _softPhone_IncomingCall;
                _softPhone.RegisterPhoneLine(_phoneLine);

                _incomingCall = false;

                ConnectMedia();
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => {
					txtDisplay.Text = ex.Message;
				});
            }            
        }

        /// <summary>
        /// Crea un nuevo folio para una nueva llamada
        /// </summary>
        public void crearFolio()
        {
            CasoNuevo ACaso = new CasoNuevo();
            iIdFolio = ACaso.CrearCaso(AUsuarioData.sIdusuario);
        }

        /// <summary>
        /// Muestra el teléfono en pantalla si este esta oculto por el usuario
        /// </summary>
        public void ShowPhone()
        {
            if (!bEstadoPanel)
            {
                Point p = _MainForm.PointToScreen(new Point(_MainForm.ClientRectangle.X + _MainForm.Width - this.Width, _MainForm.ClientRectangle.Y));
                this.Location = p;
                this.Owner    = _MainForm;
                this.Height   = _MainForm.Height;
                this.Show();
                while (this.Width < 301)
                {
                    this.Width += 20;
                    this.Left -= 20;
                    Application.DoEvents(); //allow the Form to display its new size before the next iteration
                }
            }
        }

        /// <summary>
        /// Envía tonos DTMS cuando se recibe una llamada
        /// </summary>
        private void SendDTMFSingnal()
        {
            System.Threading.Thread.Sleep(1000);
            _call.StartDTMFSignal(DtmfNamedEvents.Dtmf0);
            System.Threading.Thread.Sleep(500);
            _call.StopDTMFSignal(DtmfNamedEvents.Dtmf0);
        }

        /// <summary>
        /// Inicializa los dispositivos que se usarán (microfono y bocina)
        /// </summary>
        void StartDevices()
        {
            if (_microphone != null)
                _microphone.Start();

            if (_speaker != null)
                _speaker.Start();
        }

        /// <summary>
        /// Detiene los servicios que se usan (microfono y bocina)
        /// </summary>
        void StopDevices()
        {
            if (_microphone != null)
                _microphone.Stop();

            if (_speaker != null)
                _speaker.Stop();
        }

        /// <summary>
        /// Conecta los servicios que se usarán (microfono y bocina)
        /// </summary>
        void ConnectMedia()
        {
            if (_microphone != null)
                _connector.Connect(_microphone, _mediaSender);

            if (_speaker != null)
                _connector.Connect(_mediaReceiver, _speaker);
        }

        /// <summary>
        /// Asignamos evento a la llamada cuando es respondida
        /// </summary>
        void WireUpCallEvents()
        {
            _call.CallStateChanged += (call_CallStateChanged);
        }

        /// <summary>
        /// Quitamos evento a la llamada cuando es terminada
        /// </summary>
        void WireDownCallEvents()
        {
            _call.CallStateChanged -= (call_CallStateChanged);
        }

        /// <summary>
        /// Realiza una tarea en segundo plano
        /// </summary>
        /// <param name="action">Acción que se realizará</param>
        void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }
        #endregion      
        
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

        protected override void WndProc(ref System.Windows.Forms.Message m)
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
