using ClaseData.Clases;
using ClaseData.Clases.Exportar;
using ClaseData.Clases.Exportar.EExportar;
using ClaseData.Clases.ListConsultores;
using ClaseData.Clases.Solicitud.CSolPendientes;
using ClaseData.Clases.Solicitud.CSolRealizadas;
using ClaseData.Clases.Solicitud.CSolTerminadas;
using ControlActividadesJuridico.Representacion;
using ControlActividadesJuridico.Representacion.RegistroAvances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using LogicaCC.Logica;

namespace ControlActividadesJuridico
{
    public partial class FBandeja : Form
    {
        int iUsuario;
        int TipoUsuario;
        int BanderaExportar = 0;
        DataGridView dtRegistros;

        UsuarioData AUsuarioData = UsuarioData.Instancia;

        public FBandeja()
        {
            InitializeComponent();
        }

        /*Evento Load del formulario para cargar la informacion y mostrarla*/
        private void FBandeja_Load(object sender, EventArgs e)
        {
            btnExportar.Visible = false;
            limpiarDataGrid(sender, e);

            tcSolicitudes.DrawItem += new DrawItemEventHandler(tcSolicitudes_DrawItem);

            //DatosUsuario ADatosUsuario  = DatosUsuario.Instancia;
            //iUsuario                    = int.Parse(ADatosUsuario.sIdusuario);
            //lblUser.Text                = ADatosUsuario.sNombre + ' ' + 
            //                              ADatosUsuario.sAPaterno + ' ' + 
            //                              ADatosUsuario.sAMAterno;
            //TipoUsuario                 = int.Parse(ADatosUsuario.sTipoUsuario);

            //DatosUsuario ADatosUsuario  = DatosUsuario.Instancia;
            iUsuario = int.Parse(AUsuarioData.sIdusuario);
            //lblUser.Text                = AUsuarioData.sNombre + ' ' +
            //                              AUsuarioData.sAPaterno + ' ' +
            //                              AUsuarioData.sAMAterno;
            TipoUsuario = int.Parse(AUsuarioData.sTipoUsuario);

            DatosConsultores AUsuarios = new DatosConsultores();
            List<ConsultorData> LResponsables = AUsuarios.listaResponsables();
            this.cmbResponsable.DataSource = LResponsables;
            this.cmbResponsable.ValueMember = "sIdUsuario";
            this.cmbResponsable.DisplayMember = "sUsuario";
            this.cmbResponsable.SelectedIndex = -1;

            cargaSolicitudesPendientes();
            tcSolicitudes.TabPages.Remove(tabPage5);

            if (int.Parse(AUsuarioData.sTipoUsuario) == 1)
            {
                btnNewSolicitud.Visible = false;


                Button btnNewUser = new Button();
                btnNewUser.Size = new System.Drawing.Size(119, 31);
                btnNewUser.FlatAppearance.BorderSize = 0;
                btnNewUser.Cursor = Cursors.Hand;
                btnNewUser.FlatStyle = FlatStyle.Flat;
                btnNewUser.BackColor = Color.FromArgb(33, 150, 243);
                btnNewUser.ForeColor = Color.White;
                btnNewUser.Text = " Alta Usuario";
                btnNewUser.Image = Properties.Resources.Add_New;
                btnNewUser.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnNewUser.TextAlign = ContentAlignment.MiddleRight;
                btnNewUser.Location = new System.Drawing.Point(199, 59);
                btnNewUser.Click += BtnNewUser_Click;
                this.Controls.Add(btnNewUser);
            }

            //3   DIRECTIVO                 - 1
            //4   GERENTE                   - 20043
            //5   COORDINADOR               - ELIMINAR
            //6   CONSULTOR F y L           -  20082 - 20083
            //7   OFICIALIA                 - ELIMINAR
            //8   CONTADOR                  - 6
            //9   CALL CENTER               - 10009
            //10  SUPERVISOR CALL CENTER    - 10009
            //11  SUPERVISOR CONTABILIDAD   - 5
            //if (int.Parse(AUsuarioData.sTipoUsuario) > 5)
            //{
            //    tcSolicitudes.TabPages.Remove(tabPage4);

            //    if (int.Parse(AUsuarioData.sTipoUsuario) > 6)
            //    {
            //        tcSolicitudes.TabPages.Remove(tabPage2);
            //        cargarSolicitudesPendientesOficialia();
            //        btnNewSolicitud.Visible = false;
            //        txtBuscar.Visible       = true;
            //        btnBuscar.Visible       = true;
            //        if (int.Parse(AUsuarioData.sTipoUsuario) > 7)
            //        {
            //            btnNewSolicitud.Visible = false;
            //            txtBuscar.Visible   = false;
            //            btnBuscar.Visible   = false;

            //            if (int.Parse(AUsuarioData.sTipoUsuario) > 8)
            //            {
            //                cargaEvaluacionesPendientes();
            //                btnNewSolicitud.Visible = false;
            //                txtBuscar.Visible       = false;
            //                btnBuscar.Visible       = false;

            //                tcSolicitudes.TabPages.Remove(tabPage2);
            //                tcSolicitudes.TabPages.Remove(tabPage3);
            //                tcSolicitudes.TabPages.Remove(tabPage4);
            //                tcSolicitudes.TabPages.Add(tabPage5);

            //                if (int.Parse(AUsuarioData.sTipoUsuario) == 11)
            //                {
            //                    tcSolicitudes.TabPages.Add(tabPage3);
            //                    tcSolicitudes.TabPages.Remove(tabPage5);
            //                }
            //            }
            //        }
            //    }
            //}

            if (int.Parse(AUsuarioData.sTipoUsuario) == 20082 || int.Parse(AUsuarioData.sTipoUsuario) == 20083)
            {
                tcSolicitudes.TabPages.Remove(tabPage4);
            }
            if (int.Parse(AUsuarioData.sTipoUsuario) == 6)
            {
                tcSolicitudes.TabPages.Remove(tabPage4);

                tcSolicitudes.TabPages.Remove(tabPage2);
                cargarSolicitudesPendientesOficialia();
                btnNewSolicitud.Visible = false;
                txtBuscar.Visible = true;
                btnBuscar.Visible = true;

                btnNewSolicitud.Visible = false;
                txtBuscar.Visible = false;
                btnBuscar.Visible = false;
            }




            if (int.Parse(AUsuarioData.sTipoUsuario) == 1)
            {
                btnNewSolicitud.Visible = false;
                tcSolicitudes.TabPages.Remove(tabPage1);
                tcSolicitudes.TabPages.Remove(tabPage2);
                //cargaSolicitudesTerminadasDirectivo();
            }
            else if (int.Parse(AUsuarioData.sTipoUsuario) == 10009)//10
            {
                cargaEvaluacionesPendientesSup();
            }
            else if (int.Parse(AUsuarioData.sTipoUsuario) == 10009)//9
            {
                btnNewSolicitud.Visible = true;
            }
            seleccion();
        }

        /*Evento click del boton Nueva solicitud para mostrar modal y registrar una nueva solicitud*/
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            FAltaUsuario Formulario = new FAltaUsuario();
            Formulario.ShowDialog();
        }


        private void tcSolicitudes_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tcSolicitudes.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tcSolicitudes.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.White);
                //g.FillRectangle(new SolidBrush(Color.FromArgb(33, 150, 243)), e.Bounds);
                g.FillRectangle(new SolidBrush(Color.FromArgb(7, 22, 127)), e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }


            // Use our own font.
            //Font _tabFont = new Font("Arial", (float)12.0, System.Drawing.FontStyle.Regular, GraphicsUnit.Pixel);
            Font _tabFont = SkinManager.ROBOTO_MEDIUM_11;

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        public MaterialSkin.MaterialSkinManager SkinManager { get { return MaterialSkin.MaterialSkinManager.Instance; } }

        /*Funcion para mostrar modal de nueva solicitud*/
        public void btnNewSolicitud_Click(object sender, EventArgs e)
        {
            //FSolicitudJuridica NewSolicitud = new FSolicitudJuridica();
            //NewSolicitud.FormClosed         += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
            //NewSolicitud.ShowDialog();

            FSolicitudJuridica.Show();
        }

        #region Funciones para cargar los data grid dependiendo el tab seleccionado

        public void cargaSolicitudesPendientes()
        {
            List<ISolPendiente> LSolPendiente = new List<ISolPendiente>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LSolPendiente = ADatos.obtenerDatos(iUsuario);

            int iContador = 0;

            if (LSolPendiente.Any())
            {
                foreach (ISolPendiente vRow in LSolPendiente)
                {
                    dgvSolPendientes.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sSolicitante,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }

            List<ISolPendiente> LSolInformacion = new List<ISolPendiente>();
            CDSolPendientes ASInfo = new CDSolPendientes();

            LSolInformacion = ASInfo.obtenerDatosSolicitudInformacion(iUsuario);

            if (LSolInformacion.Any())
            {
                foreach (ISolPendiente vRow in LSolInformacion)
                {
                    dgvSolPendientes.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sSolicitante,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolPendientes, 8);
        }

        public void cargaSolicitudesRealizadas()
        {
            List<ISolRealizadas> LSolPendiente = new List<ISolRealizadas>();
            CDSolRealizadas ADatos = new CDSolRealizadas();

            LSolPendiente = ADatos.obtenerDatos(iUsuario);

            int iContador = 0;

            if (LSolPendiente.Any())
            {
                foreach (ISolRealizadas vRow in LSolPendiente)
                {
                    dgvSolRealizadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolRealizadas, 9);
        }

        public void cargaSolicitudesTerminadas()
        {
            List<ISolTerminadas> LSolPendiente = new List<ISolTerminadas>();
            CDSolTerminadas ADatos = new CDSolTerminadas();

            LSolPendiente = ADatos.obtenerDatos(iUsuario);

            int iContador = 0;

            if (LSolPendiente.Any())
            {
                foreach (ISolTerminadas vRow in LSolPendiente)
                {
                    dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }


            List<ISolTerminadas> LSolInformacionRealizadas = new List<ISolTerminadas>();
            CDSolTerminadas ASInfoRealizadas = new CDSolTerminadas();

            LSolInformacionRealizadas = ASInfoRealizadas.DatosSolicitudInformacionRealizadas(iUsuario);

            if (LSolInformacionRealizadas.Any())
            {
                foreach (ISolTerminadas vRow in LSolInformacionRealizadas)
                {
                    dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }

            List<ISolTerminadas> LSolOficiliaRealizadas = new List<ISolTerminadas>();
            CDSolTerminadas ASInfoOficialiRealizadas = new CDSolTerminadas();

            LSolOficiliaRealizadas = ASInfoOficialiRealizadas.datosSolicitudTerminadasOficialia(iUsuario);

            if (LSolOficiliaRealizadas.Any())
            {
                foreach (ISolTerminadas vRow in LSolOficiliaRealizadas)
                {
                    dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }

            if (TipoUsuario == 20043) //4
            {
                List<ISolTerminadas> LSolTerminadasGerente = new List<ISolTerminadas>();
                CDSolTerminadas ASolTerminadasGerente = new CDSolTerminadas();

                LSolTerminadasGerente = ASolTerminadasGerente.datosSolicitudesTerminadasGerente(iUsuario);

                if (LSolTerminadasGerente.Any())
                {
                    foreach (ISolTerminadas vRow in LSolTerminadasGerente)
                    {
                        dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                                  vRow.sIdCaso,
                                                  vRow.sFase,
                                                  vRow.sSolicitudTipo,
                                                  vRow.sNoCliente,
                                                  vRow.sConsultor,
                                                  vRow.sFSolicitud,
                                                  vRow.sFVencimiento,
                                                  vRow.sFechaResolucion,
                                                  vRow.sSemaforo,
                                                  "Detalles",
                                                  vRow.sIdFase);
                        iContador++;
                    }
                }
            }

            //else if (TipoUsuario == 5) //5
            //{
            //    List<ISolTerminadas> LSolTerminadasCoordinador  = new List<ISolTerminadas>();
            //    CDSolTerminadas ASolTerminadasCoordinador       = new CDSolTerminadas();

            //    LSolTerminadasCoordinador = ASolTerminadasCoordinador.datosSolicitudesTerminadasCoordinador(iUsuario);

            //    if (LSolTerminadasCoordinador.Any())
            //    {
            //        foreach (ISolTerminadas vRow in LSolTerminadasCoordinador)
            //        {
            //            dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
            //                                      vRow.sIdCaso,
            //                                      vRow.sFase,
            //                                      vRow.sSolicitudTipo,
            //                                      vRow.sNoCliente,
            //                                      vRow.sConsultor,
            //                                      vRow.sFSolicitud,
            //                                      vRow.sFVencimiento,
            //                                      vRow.sFechaResolucion,
            //                                      vRow.sSemaforo,
            //                                      "Detalles",
            //                                      vRow.sIdFase);
            //            iContador++;
            //        }
            //    }
            //}

            else if (TipoUsuario == 6) //8
            {
                List<ISolTerminadas> LSolTerminadasContador = new List<ISolTerminadas>();
                CDSolTerminadas ASolTermindasContador = new CDSolTerminadas();

                LSolTerminadasContador = ASolTermindasContador.solicitudesTerminadasContador(iUsuario);

                if (LSolTerminadasContador.Any())
                {
                    foreach (ISolTerminadas vRow in LSolTerminadasContador)
                    {
                        dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                                  vRow.sIdCaso,
                                                  vRow.sFase,
                                                  vRow.sSolicitudTipo,
                                                  vRow.sNoCliente,
                                                  vRow.sConsultor,
                                                  vRow.sFSolicitud,
                                                  vRow.sFVencimiento,
                                                  vRow.sFechaResolucion,
                                                  vRow.sSemaforo,
                                                  "Detalles",
                                                  vRow.sIdFase);
                        iContador++;
                    }
                }
            }

            else if (TipoUsuario == 5) //11
            {
                List<ISolTerminadas> LSolTerminadasSupervisorContable = new List<ISolTerminadas>();
                CDSolTerminadas ASolTermindasContador = new CDSolTerminadas();

                LSolTerminadasSupervisorContable = ASolTermindasContador.solicitudesTerminadasSupervisorContable(iUsuario);

                if (LSolTerminadasSupervisorContable.Any())
                {
                    foreach (ISolTerminadas vRow in LSolTerminadasSupervisorContable)
                    {
                        dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                                  vRow.sIdCaso,
                                                  vRow.sFase,
                                                  vRow.sSolicitudTipo,
                                                  vRow.sNoCliente,
                                                  vRow.sConsultor,
                                                  vRow.sFSolicitud,
                                                  vRow.sFVencimiento,
                                                  vRow.sFechaResolucion,
                                                  vRow.sSemaforo,
                                                  "Detalles",
                                                  vRow.sIdFase);
                        iContador++;
                    }
                }
            }

            Semaforo(dgvSolTerminadas, 9);
        }


        public void cargaSolicitudesTerminadasDirectivo()
        {
            List<ISolTerminadas> LSolPendiente = new List<ISolTerminadas>();
            CDSolTerminadas ADatos = new CDSolTerminadas();

            LSolPendiente = ADatos.SolicitudesTerminadasDirectivos();

            int iContador = 0;

            if (LSolPendiente.Any())
            {
                foreach (ISolTerminadas vRow in LSolPendiente)
                {
                    dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolTerminadas, 9);
        }

        public void cargarSolicitudesEnProceso()
        {
            //if (TipoUsuario <= 4)
            if (TipoUsuario == 20043 || TipoUsuario == 1)
            {
                List<ISolEnProceso> LSolPendiente = new List<ISolEnProceso>();
                CDSolTerminadas ADatos = new CDSolTerminadas();

                LSolPendiente = ADatos.obtenerSolicitudesProcesoGerente();

                int iContador = 0;

                if (LSolPendiente.Any())
                {
                    foreach (ISolEnProceso vRow in LSolPendiente)
                    {
                        dgvProceso.Rows.Add(vRow.sIdSolicitud,
                                                  vRow.sIdCaso,
                                                  vRow.sFase,
                                                  vRow.sSolicitudTipo,
                                                  vRow.sNoCliente,
                                                  vRow.sResponsable,
                                                  vRow.sFSolicitud,
                                                  vRow.sFVencimiento,
                                                  vRow.sSemaforo,
                                                  "Detalles",
                                                  vRow.sIdFase);
                        iContador++;
                    }
                }
                Semaforo(dgvProceso, 8);
            }
            //else if (TipoUsuario == 5) //5
            //{
            //    List<ISolEnProceso> LSolPendiente   = new List<ISolEnProceso>();
            //    CDSolTerminadas ADatos              = new CDSolTerminadas();

            //    LSolPendiente = ADatos.obtenerSolicitudesProcesoCoordinador(iUsuario);

            //    int iContador = 0;

            //    if (LSolPendiente.Any())
            //    {
            //        foreach (ISolEnProceso vRow in LSolPendiente)
            //        {
            //            dgvProceso.Rows.Add(vRow.sIdSolicitud,
            //                                      vRow.sIdCaso,
            //                                      vRow.sFase,
            //                                      vRow.sSolicitudTipo,
            //                                      vRow.sNoCliente,
            //                                      vRow.sResponsable,
            //                                      vRow.sFSolicitud,
            //                                      vRow.sFVencimiento,
            //                                      vRow.sSemaforo,
            //                                      "Detalles",
            //                                      vRow.sIdFase);
            //            iContador++;
            //        }
            //    }
            //    Semaforo(dgvProceso, 8);
            //}
        }

        public void cargarSolicitudesPendientesOficialia()
        {
            List<ISolPendiente> LSolPendiente = new List<ISolPendiente>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LSolPendiente = ADatos.obtenerDatosOficilia(iUsuario);

            int iContador = 0;

            if (LSolPendiente.Any())
            {
                foreach (ISolPendiente vRow in LSolPendiente)
                {
                    dgvSolPendientes.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sSolicitante,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolPendientes, 8);
        }

        public void cargaEvaluacionesPendientes()
        {
            List<ISolPendiente> LEvaPendiente = new List<ISolPendiente>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LEvaPendiente = ADatos.DatosSolicitudesEvaluacionCallCenter(iUsuario);

            int iContador = 0;

            if (LEvaPendiente.Any())
            {
                foreach (ISolPendiente vRow in LEvaPendiente)
                {
                    dgvSolPendientes.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sSolicitante,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolPendientes, 8);
        }

        public void cargaEvaluacionesPendientesSup()
        {
            List<ISolPendiente> LEvaPendienteSup = new List<ISolPendiente>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LEvaPendienteSup = ADatos.datosSolicitudesEvaluacionSupCallCenter(iUsuario);

            int iContador = 0;

            if (LEvaPendienteSup.Any())
            {
                foreach (ISolPendiente vRow in LEvaPendienteSup)
                {
                    dgvSolPendientes.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sSolicitante,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolPendientes, 8);
        }

        public void cargaEvaluacionesRealizadas()
        {
            List<ISolTerminadas> LEvaReali = new List<ISolTerminadas>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LEvaReali = ADatos.DatosEvaluacionesRealizadasCallCenter(iUsuario);

            int iContador = 0;

            if (LEvaReali.Any())
            {
                foreach (ISolTerminadas vRow in LEvaReali)
                {
                    dgvEvaluacionesRealizadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvEvaluacionesRealizadas, 9);
        }

        public void cargaEvaluacionesRealizadasSup()
        {
            List<ISolTerminadas> LEvaRealiSup = new List<ISolTerminadas>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LEvaRealiSup = ADatos.datosEvaluacionesRealizadasSupCallCenter();

            int iContador = 0;

            if (LEvaRealiSup.Any())
            {
                foreach (ISolTerminadas vRow in LEvaRealiSup)
                {
                    dgvEvaluacionesRealizadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvEvaluacionesRealizadas, 9);
        }

        #endregion

        /*Función para pintar semaforo de cada registro en el datagrid*/
        public void Semaforo(DataGridView DG, int cell)
        {
            for (int i = 0; i < DG.RowCount; i++)
            {
                if (DG.Rows[i].Cells[cell].FormattedValue.ToString() == "V")
                {
                    DG.Rows[i].Cells[cell].Style.BackColor = Color.FromArgb(76, 175, 80);
                    DG.Rows[i].Cells[cell].Style.ForeColor = Color.FromArgb(76, 175, 80);
                    DG.Rows[i].Cells[cell].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG.Rows[i].Cells[cell].Value = string.Empty;
                }
                else if (DG.Rows[i].Cells[cell].FormattedValue.ToString() == "A")
                {
                    DG.Rows[i].Cells[cell].Style.BackColor = Color.FromArgb(253, 216, 53);
                    DG.Rows[i].Cells[cell].Style.ForeColor = Color.FromArgb(253, 216, 53);
                    DG.Rows[i].Cells[cell].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG.Rows[i].Cells[cell].Value = string.Empty;
                }
                else if (DG.Rows[i].Cells[cell].FormattedValue.ToString() == "R")
                {
                    DG.Rows[i].Cells[cell].Style.BackColor = Color.FromArgb(244, 67, 54);
                    DG.Rows[i].Cells[cell].Style.ForeColor = Color.FromArgb(244, 67, 54);
                    DG.Rows[i].Cells[cell].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    DG.Rows[i].Cells[cell].Value = string.Empty;
                }
            }
        }

        /*Funcion para cargar información dependiento el tipo de usuario*/
        private void tcSolicitudes_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarDataGrid(sender, e);
            cmbResponsable.Visible = false;
            dtpDesde.Visible = false;
            dtpHasta.Visible = false;
            btnActualizar.Visible = false;
            btnExportar.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;

            if (tcSolicitudes.SelectedTab.Name == "tabPage1")
            {
                cargaSolicitudesPendientes();
                //if (TipoUsuario == 7) //7
                //{
                //    cargarSolicitudesPendientesOficialia();
                //}
                if (TipoUsuario == 10009) //9
                {
                    cargaEvaluacionesPendientes();
                }
                if (TipoUsuario == 10009) //10
                {
                    cargaEvaluacionesPendientesSup();
                }
                dgvSolPendientes.Visible = true;
            }

            else if (tcSolicitudes.SelectedTab.Name == "tabPage2")
            {
                cargaSolicitudesRealizadas();
                dgvSolRealizadas.Visible = true;
            }

            else if (tcSolicitudes.SelectedTab.Name == "tabPage3")
            {

                cargaSolicitudesTerminadas();
                if (TipoUsuario == 20043) //4
                {
                    btnActualizar.Visible = true;
                    //btnExportar.Visible = true;
                    cmbResponsable.Visible = true;
                    dtpDesde.Visible = true;
                    dtpHasta.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    if (dgvSolTerminadas.Rows.Count != 0)
                    {
                        btnExportar.Visible = true;
                    }
                }

                if (TipoUsuario == 1) //3
                {
                    cargaSolicitudesTerminadasDirectivo();
                }

                dgvSolTerminadas.Visible = true;

            }
            else if (tcSolicitudes.SelectedTab.Name == "tabPage4")
            {
                cargarSolicitudesEnProceso();
                dgvProceso.Visible = true;
            }
            else if (tcSolicitudes.SelectedTab.Name == "tabPage5")
            {
                cargaEvaluacionesRealizadas();
                if (TipoUsuario == 10009) //10
                {
                    cargaEvaluacionesRealizadasSup();
                    //btnExportar.Visible = true;
                    btnActualizar.Visible = true;
                    dtpDesde.Visible = true;
                    dtpHasta.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;

                    if (dgvEvaluacionesRealizadas.Rows.Count != 0)
                    {
                        btnExportar.Visible = true;
                    }
                }
                dgvEvaluacionesRealizadas.Visible = true;
            }
            seleccion();
        }

        /*Funcion para limpiar y ocultar los datagrid*/
        public void limpiarDataGrid(object sender, EventArgs e)
        {
            dgvSolPendientes.Rows.Clear();
            dgvSolRealizadas.Rows.Clear();
            dgvSolTerminadas.Rows.Clear();
            dgvProceso.Rows.Clear();
            dgvEvaluacionesRealizadas.Rows.Clear();

            dgvSolPendientes.Visible = dgvSolPendientes.Visible ? true : false;
            dgvSolRealizadas.Visible = dgvSolRealizadas.Visible ? true : false;
            dgvSolTerminadas.Visible = dgvSolTerminadas.Visible ? true : false;
            dgvProceso.Visible = dgvProceso.Visible ? true : false;
            dgvEvaluacionesRealizadas.Visible = dgvEvaluacionesRealizadas.Visible ? true : false;
        }

        /*Quitar autoseleccion a los registros en el datagrid*/
        public void seleccion()
        {
            dgvSolPendientes.ClearSelection();
            dgvSolRealizadas.ClearSelection();
            dgvSolTerminadas.ClearSelection();
            dgvProceso.ClearSelection();
            dgvEvaluacionesRealizadas.ClearSelection();
        }

        /*Funcion para mostrar modal dependiento en que fase se encuentre la solicitud pendiente*/
        private void dgvSolPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSolPendientes.Columns[e.ColumnIndex].Name.Equals("Detalles"))
                {
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("2"))
                    {
                        FAsignarConsultor.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("3"))
                    {
                        FRDetalleServicio.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }

                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("4"))
                    {
                        FRAprobar.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }

                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("5"))
                    {
                        FRDictamenFinal.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }

                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("6"))
                    {
                        FRResolucion.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("1007"))
                    {
                        FRDetalleOficilia aFomulario = new FRDetalleOficilia(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()));
                        aFomulario.ShowDialog();
                    }
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("1008"))
                    {
                        FRDetalleSInformacion.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()));
                    }
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("1009"))
                    {
                        if (TipoUsuario == 10009) //10
                        {
                            FDEvaluacionServicio.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()));
                        }
                        else
                        {
                            FEvaluarServicio aFormulario = new FEvaluarServicio(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()));
                            aFormulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                            aFormulario.ShowDialog();
                        }
                    }

                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("1013"))
                    {
                        FRCGenerarRespuesta.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("1014"))
                    {
                        FRCAprobar.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvSolPendientes.SelectedCells[10].FormattedValue.Equals("1015"))
                    {
                        FCResolucion.Show(int.Parse(dgvSolPendientes.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolPendientes.SelectedCells[1].FormattedValue.ToString()));
                    }
                    //if (this.dgvEvaluacionesRealizadas.SelectedCells[10].FormattedValue.Equals("1010"))
                    //{
                    //    FDEvaluacionServicio aFormulario = new FDEvaluacionServicio(int.Parse(dgvEvaluacionesRealizadas.SelectedCells[0].FormattedValue.ToString()));
                    //    aFormulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                    //    aFormulario.ShowDialog();
                    //}
                }
            }
            catch (Exception ex)
            {

            }
        }

        /*Funcion para mostrar modal dependiento en que fase se encuentre la solicitud realizada*/
        private void dgvSolRealizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSolRealizadas.Columns[e.ColumnIndex].Name.Equals("DetallesR"))
                {
                    if (this.dgvSolRealizadas.SelectedCells[11].FormattedValue.Equals("1016"))
                    {
                        //FCDetalleSolicitud aFomulario = new FCDetalleSolicitud(int.Parse(dgvSolRealizadas.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolRealizadas.SelectedCells[1].FormattedValue.ToString()));
                        //aFomulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                        //aFomulario.ShowDialog();
                        FCDetalleSolicitud.Show(int.Parse(dgvSolRealizadas.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolRealizadas.SelectedCells[1].FormattedValue.ToString()));
                    }
                    else
                    {
                        FDetalleSolicitud.Show(int.Parse(dgvSolRealizadas.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolRealizadas.SelectedCells[1].FormattedValue.ToString()));
                    }
                }
            }
            catch
            {
            }
        }

        /*Funcion para mostrar modal dependiento en que fase se encuentre la solicitud terminada*/
        private void dgvSolTerminadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvSolTerminadas.Columns[e.ColumnIndex].Name.Equals("DetallesT"))
                {
                    if (this.dgvSolTerminadas.SelectedCells[11].FormattedValue.Equals("7"))
                    {
                        FDetalleSolicitud.Show(int.Parse(dgvSolTerminadas.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolTerminadas.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvSolTerminadas.SelectedCells[11].FormattedValue.Equals("1011"))
                    {
                        FRRRSolicitudInformacion.Show(int.Parse(dgvSolTerminadas.SelectedCells[0].FormattedValue.ToString()));
                    }
                    if (this.dgvSolTerminadas.SelectedCells[11].FormattedValue.Equals("1012"))
                    {
                        FRDetalleOficiliaTerminada aFormulario = new FRDetalleOficiliaTerminada(int.Parse(dgvSolTerminadas.SelectedCells[0].FormattedValue.ToString()));
                        aFormulario.ShowDialog();
                    }

                    if (this.dgvSolTerminadas.SelectedCells[11].FormattedValue.Equals("1016"))
                    {
                        //FCDetalleSolicitud aFomulario = new FCDetalleSolicitud(int.Parse(dgvSolTerminadas.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolTerminadas.SelectedCells[1].FormattedValue.ToString()));
                        //aFomulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                        //aFomulario.ShowDialog();
                        FCDetalleSolicitud.Show(int.Parse(dgvSolTerminadas.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvSolTerminadas.SelectedCells[1].FormattedValue.ToString()));
                    }
                }
            }
            catch
            {
            }
        }

        /*Funcion para mostrar modal dependiento en que fase se encuentre la solicitud en proceso*/
        private void dgvProceso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvProceso.Columns[e.ColumnIndex].Name.Equals("detallesEP"))
                {
                    if (this.dgvProceso.SelectedCells[10].FormattedValue.Equals("1013"))
                    {
                        //FCDetalleSolicitud aFomulario = new FCDetalleSolicitud(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                        //aFomulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                        //aFomulario.ShowDialog();
                        FCDetalleSolicitud.Show(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvProceso.SelectedCells[10].FormattedValue.Equals("1014"))
                    {
                        //FCDetalleSolicitud aFomulario = new FCDetalleSolicitud(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                        //aFomulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                        //aFomulario.ShowDialog();
                        FCDetalleSolicitud.Show(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvProceso.SelectedCells[10].FormattedValue.Equals("1015"))
                    {
                        //FCDetalleSolicitud aFomulario = new FCDetalleSolicitud(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                        //aFomulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                        //aFomulario.ShowDialog();
                        FCDetalleSolicitud.Show(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                    }
                    if (this.dgvProceso.SelectedCells[10].FormattedValue.Equals("1016"))
                    {
                        //FCDetalleSolicitud aFomulario = new FCDetalleSolicitud(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                        //aFomulario.FormClosed += new FormClosedEventHandler(ActualizarSolPendientes_FormClosed);
                        //aFomulario.ShowDialog();
                        FCDetalleSolicitud.Show(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                    }
                    else
                    {
                        FDetalleSolicitud.Show(int.Parse(dgvProceso.SelectedCells[0].FormattedValue.ToString()), int.Parse(dgvProceso.SelectedCells[1].FormattedValue.ToString()));
                    }
                }
            }
            catch
            {
            }
        }

        /*Funcion para recargar la informacion y actulizar las solicitudes en los datagrid*/
        public void ActualizarSolPendientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            limpiarDataGrid(sender, e);

            cargaSolicitudesPendientes();
            cargaSolicitudesRealizadas();
            cargaSolicitudesTerminadas();
            cargarSolicitudesEnProceso();

            if (TipoUsuario == 1) //3
            {
                cargaSolicitudesTerminadasDirectivo();
            }
            if (TipoUsuario == 10009) //9
            {
                cargaEvaluacionesPendientes();
                cargaEvaluacionesRealizadas();
            }
            if (TipoUsuario == 10009) //10
            {
                cargaEvaluacionesPendientesSup();
                cargaEvaluacionesRealizadasSup();
            }
            //cargaEvaluacionesRealizadas();
            //cargaEvaluacionesRealizadasSup();
            seleccion();
        }

        /*Funcion para preguntar al usuario si esta seguro de salir del aplicativo*/
        private void FBandeja_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBoxResult rs1 = System.Windows.MessageBox.Show("¿Desea salir del aplicativo?", "Mensaje", MessageBoxButton.YesNo, MessageBoxImage.Question);
            //if (rs1 == MessageBoxResult.No)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    System.Windows.Forms.Application.Restart();
            //}
        }

        /*Funcion para buscar por solicitudes pendientes oficilia*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvSolPendientes.Rows.Clear();
            if (txtBuscar.Text != string.Empty)
            {
                List<ISolPendiente> LSolPendiente = new List<ISolPendiente>();
                CDSolPendientes ADatos = new CDSolPendientes();

                LSolPendiente = ADatos.buscarDatosSolicitudesOficilia(iUsuario, txtBuscar.Text);

                int iContador = 0;

                if (LSolPendiente.Any())
                {
                    foreach (ISolPendiente vRow in LSolPendiente)
                    {
                        dgvSolPendientes.Rows.Add(vRow.sIdSolicitud,
                                                  vRow.sIdCaso,
                                                  vRow.sFase,
                                                  vRow.sSolicitudTipo,
                                                  vRow.sNoCliente,
                                                  vRow.sSolicitante,
                                                  vRow.sFSolicitud,
                                                  vRow.sFVencimiento,
                                                  vRow.sSemaforo,
                                                  "Detalles",
                                                  vRow.sIdFase);
                        iContador++;
                    }
                    Semaforo(dgvSolPendientes, 8);
                }
            }
            else
            {
                cargarSolicitudesPendientesOficialia();
            }
        }

        #region Funciones para integrar imagen en los data grid

        private void dgvSolPendientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSolPendientes.Columns[e.ColumnIndex].Name == "Detalles" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvSolPendientes.Rows[e.RowIndex].Cells["Detalles"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.view_details_gray_22px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvSolTerminadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSolTerminadas.Columns[e.ColumnIndex].Name == "DetallesT" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvSolTerminadas.Rows[e.RowIndex].Cells["DetallesT"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.view_details_gray_22px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvSolRealizadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvSolRealizadas.Columns[e.ColumnIndex].Name == "DetallesR" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvSolRealizadas.Rows[e.RowIndex].Cells["DetallesR"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.view_details_gray_22px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvProceso_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvProceso.Columns[e.ColumnIndex].Name == "detallesEP" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvProceso.Rows[e.RowIndex].Cells["detallesEP"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.view_details_gray_22px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        private void dgvEvaluacionesRealizadas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.ColumnIndex >= 0 && this.dgvEvaluacionesRealizadas.Columns[e.ColumnIndex].Name == "detallesERe" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                DataGridViewButtonCell celBoton = this.dgvEvaluacionesRealizadas.Rows[e.RowIndex].Cells["detallesERe"] as DataGridViewButtonCell;

                e.Graphics.DrawImage(Properties.Resources.view_details_gray_22px, e.CellBounds.Left + 20, e.CellBounds.Top + 0);

                e.Handled = true;
            }
        }

        #endregion

        #region Funciones para cambiar punter al pasar mouse por la columna Detalles

        private void dgvSolPendientes_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSolPendientes.Columns[e.ColumnIndex].Name.ToString() == "Detalles")
            {
                dgvSolPendientes.Cursor = Cursors.Hand;
            }
            else
            {
                dgvSolPendientes.Cursor = Cursors.Default;
            }
        }

        private void dgvSolRealizadas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSolRealizadas.Columns[e.ColumnIndex].Name.ToString() == "DetallesR")
            {
                dgvSolRealizadas.Cursor = Cursors.Hand;
            }
            else
            {
                dgvSolRealizadas.Cursor = Cursors.Default;
            }
        }

        private void dgvSolTerminadas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvSolTerminadas.Columns[e.ColumnIndex].Name.ToString() == "DetallesT")
            {
                dgvSolTerminadas.Cursor = Cursors.Hand;
            }
            else
            {
                dgvSolTerminadas.Cursor = Cursors.Default;
            }
        }

        private void dgvProceso_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProceso.Columns[e.ColumnIndex].Name.ToString() == "detallesEP")
            {
                dgvProceso.Cursor = Cursors.Hand;
            }
            else
            {
                dgvProceso.Cursor = Cursors.Default;
            }
        }

        private void dgvEvaluacionesRealizadas_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEvaluacionesRealizadas.Columns[e.ColumnIndex].Name.ToString() == "detallesERe")
            {
                dgvEvaluacionesRealizadas.Cursor = Cursors.Hand;
            }
            else
            {
                dgvEvaluacionesRealizadas.Cursor = Cursors.Default;
            }
        }

        #endregion

        /*Muestra la modal correspondiente a la evaluacion realizada*/
        private void dgvEvaluacionesRealizadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvEvaluacionesRealizadas.Columns[e.ColumnIndex].Name.Equals("detallesERe"))
                {
                    FDEvaluacionServicio.Show(int.Parse(dgvEvaluacionesRealizadas.SelectedCells[0].FormattedValue.ToString()));
                }
            }
            catch
            {
            }
        }

        /*Función para cargar información en datagrid generado dinamicamente*/
        public void CargaInformacionExportar(int ibandera, DateTime Desde, DateTime Hasta)
        {
            dtRegistros = new DataGridView();
            dtRegistros.AutoGenerateColumns = true;

            dtRegistros.Columns.Add("Folio", "Folio");
            dtRegistros.Columns.Add("Fase", "Fase");
            dtRegistros.Columns.Add("TipoSolicitud", "Tipo");
            dtRegistros.Columns.Add("NumCliente", "Num. Cliente");
            dtRegistros.Columns.Add("Reponsable", "Responsable");
            dtRegistros.Columns.Add("FechaSolicitud", "FechaSolicitud");
            dtRegistros.Columns.Add("FechaVigencia,", "FechaVigencia");
            dtRegistros.Columns.Add("FechaEvalua", "FechaEvalua");
            dtRegistros.Columns.Add("Semaforo", "Semaforo");
            dtRegistros.Columns.Add("ClienteContactado", "ClienteContactado");
            dtRegistros.Columns.Add("P1", "P1");
            dtRegistros.Columns.Add("P2", "P2");
            dtRegistros.Columns.Add("P3", "P3");
            dtRegistros.Columns.Add("P4", "P4");
            dtRegistros.Columns.Add("P5", "P5");
            dtRegistros.Columns.Add("P6", "P6");
            dtRegistros.Columns.Add("Comentario", "Comentario");
            dtRegistros.Columns.Add("FechaEvaluacion", "FechaEvaluacion");

            List<EDEvaluaciones> LEvaluaciones = new List<EDEvaluaciones>();
            EDatosEvaluaciones ADatos = new EDatosEvaluaciones();

            LEvaluaciones = ADatos.obtenerEvaluacion(ibandera, Desde, Hasta);

            int iContador = 0;

            if (LEvaluaciones.Any())
            {
                foreach (EDEvaluaciones vRow in LEvaluaciones)
                {
                    dtRegistros.Rows.Add(vRow.sfolio,
                                         vRow.sFase,
                                         vRow.sTipoSolicitud,
                                         vRow.sNumCliente,
                                         vRow.sResponsable,
                                         vRow.sFechaSolicitud,
                                         vRow.sFechaVigencia,
                                         vRow.sFechaEvalua,
                                         vRow.sSemaforo,
                                         vRow.SClienteContactado,
                                         vRow.sP1,
                                         vRow.sP2,
                                         vRow.sP3,
                                         vRow.sP4,
                                         vRow.sP5,
                                         vRow.sP6,
                                         vRow.sComentario,
                                         vRow.sFechaEvaluacion);
                    iContador++;
                }
                pintaSemaforo(dtRegistros, 8);
            }
        }

        /*Función para cambiar el semaforo en la columna de estado de cada registro cargado en el datagrig dtRegistros */
        public void pintaSemaforo(DataGridView DG, int cell)
        {
            for (int i = 0; i < DG.RowCount; i++)
            {
                if (DG.Rows[i].Cells[cell].FormattedValue.ToString() == "V")
                {
                    DG.Rows[i].Cells[cell].Style.BackColor  = Color.FromArgb(76, 175, 80);
                    DG.Rows[i].Cells[cell].Style.ForeColor  = Color.FromArgb(76, 175, 80);
                    DG.Rows[i].Cells[cell].Style.Alignment  = DataGridViewContentAlignment.MiddleCenter;
                    DG.Rows[i].Cells[cell].Value            = string.Empty;
                }
                else if (DG.Rows[i].Cells[cell].FormattedValue.ToString() == "A")
                {
                    DG.Rows[i].Cells[cell].Style.BackColor  = Color.FromArgb(253, 216, 53);
                    DG.Rows[i].Cells[cell].Style.ForeColor  = Color.FromArgb(253, 216, 53);
                    DG.Rows[i].Cells[cell].Style.Alignment  = DataGridViewContentAlignment.MiddleCenter;
                    DG.Rows[i].Cells[cell].Value            = string.Empty;
                }
                else if (DG.Rows[i].Cells[cell].FormattedValue.ToString() == "R")
                {
                    DG.Rows[i].Cells[cell].Style.BackColor  = Color.FromArgb(244, 67, 54);
                    DG.Rows[i].Cells[cell].Style.ForeColor  = Color.FromArgb(244, 67, 54);
                    DG.Rows[i].Cells[cell].Style.Alignment  = DataGridViewContentAlignment.MiddleCenter;
                    DG.Rows[i].Cells[cell].Value            = string.Empty;
                }
            }
        }

        /*Evento click del boton exportar*/
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (TipoUsuario == 20043) //4
            {
                new ExportExcelJuridico().Expotar(dgvSolTerminadas);
            }
            else if (TipoUsuario == 10009) //10
            {
                CargaInformacionExportar(BanderaExportar, dtpDesde.Value, dtpHasta.Value);

                new ExportExcelCallCenter().Expotar(dtRegistros);
            }
        }

        /*Evento click del boton Buscar para actualizar el data grid de las solicides realizadas o terminadas*/
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int idResponsable = 1;

            btnExportar.Visible = false;

            dgvSolTerminadas.Rows.Clear();
            dgvEvaluacionesRealizadas.Rows.Clear();

            if (TipoUsuario == 20043) //4
            {
                if (cmbResponsable.Text != string.Empty)
                {
                    //ConsultorData slRespon  = (ConsultorData)cmbResponsable.SelectedItem;
                    //idResponsable           = int.Parse(slRespon.sIdUsuario.ToString());

                    idResponsable = int.Parse(cmbResponsable.SelectedValue.ToString());
                }
                //comboBox1.sel
                solicitudesTerminadasFiltros(idResponsable, dtpDesde.Value, dtpHasta.Value);
                dgvSolTerminadas.ClearSelection();
            }

            else if (TipoUsuario == 10009)//10
            {
                BanderaExportar = 1;
                cargaEvaluacionesRealizadasSupFilros(dtpDesde.Value, dtpHasta.Value);
                dgvEvaluacionesRealizadas.ClearSelection();

            }

            if (dgvSolTerminadas.Rows.Count != 0)
            {
                btnExportar.Visible = true;
            }
            else if (dgvEvaluacionesRealizadas.Rows.Count != 0)
            {
                btnExportar.Visible = true;
            }
        }

        /*Función para obtenera las solicitudes terminadas aplicando el filtro de fecha */
        public void solicitudesTerminadasFiltros(int idUsuario, DateTime FDesde, DateTime FHasta)
        {
            List<ISolTerminadas> LSolTerminadasFiltros = new List<ISolTerminadas>();
            CDSolTerminadas ASolTerminadasFiltros = new CDSolTerminadas();

            LSolTerminadasFiltros = ASolTerminadasFiltros.datosSolicitudesTerminadasFiltros(idUsuario, FDesde, FHasta);
            int iContador = 0;
            if (LSolTerminadasFiltros.Any())
            {
                foreach (ISolTerminadas vRow in LSolTerminadasFiltros)
                {
                    dgvSolTerminadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvSolTerminadas, 9);
        }

        /*Función para obtenera las solicitudes realizadas aplicando el filtro de fecha */
        public void cargaEvaluacionesRealizadasSupFilros(DateTime Desde, DateTime Hasta)
        {
            List<ISolTerminadas> LEvaRealiSupFil = new List<ISolTerminadas>();
            CDSolPendientes ADatos = new CDSolPendientes();

            LEvaRealiSupFil = ADatos.EvaluacionesRealizadasSupCallCenterFiltros(Desde, Hasta);

            int iContador = 0;

            if (LEvaRealiSupFil.Any())
            {
                foreach (ISolTerminadas vRow in LEvaRealiSupFil)
                {
                    dgvEvaluacionesRealizadas.Rows.Add(vRow.sIdSolicitud,
                                              vRow.sIdCaso,
                                              vRow.sFase,
                                              vRow.sSolicitudTipo,
                                              vRow.sNoCliente,
                                              vRow.sConsultor,
                                              vRow.sFSolicitud,
                                              vRow.sFVencimiento,
                                              vRow.sFechaResolucion,
                                              vRow.sSemaforo,
                                              "Detalles",
                                              vRow.sIdFase);
                    iContador++;
                }
            }
            Semaforo(dgvEvaluacionesRealizadas, 9);
        }
    }
}
