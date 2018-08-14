using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmProspectos : Form
    {
        FPrincipal _FPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        Prospeccion AProspeccionData = Prospeccion.Instancia;
        List<Prospecto> ListProspectos;
        List<Prospecto> ListScheduleCalls;
        List<Prospecto> Horarios;
        List<Prospecto> HorariosTemp;
        public int iIdProspSel = 0;
        public int iIdLlamada;
        public int iIdLlamadaAgendada;
        public int iIdEtapa;

        public frmProspectos()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region Funciones
        public void InitializeControls()
        {
            this.Invoke((MethodInvoker)delegate { LoadProspectos(); LoadScheduleCalls(); LoadCountCitas(); });
        }

        /// <summary>
        /// Carga el listado de prospectos
        /// </summary>
        public void LoadProspectos()
        {
            ListProspectos = new Prospecto().GetList(int.Parse(AUsuarioData.sIdusuario));
            grdProspectos.DataSource = ListProspectos;
            if (gridView1.RowCount > 0)
                lblNoRegitros.Text = string.Format("No. de Registros: {0}", gridView1.RowCount);
            else
                lblNoRegitros.Text = "No. de Registros: --";
        }

        /// <summary>
        /// Carga un listado de llamadas agendadas
        /// </summary>
        public void LoadScheduleCalls()
        {
            ListScheduleCalls = new Prospecto().GetListScheduleCalls(int.Parse(AUsuarioData.sIdusuario));
            grdLlamadasAgendadas.DataSource = ListScheduleCalls;
        }

        /// <summary>
        /// Cuenta el número de citas meta de los agentes de call center
        /// </summary>
        public void LoadCountCitas()
        {
            Cita Total = new Cita().GetNoCitas(int.Parse(AUsuarioData.sIdusuario));
            lblNoCitas.Text = string.Format("{0}/{1}", Total.iContando == 0 ? "--" : Total.iContando.ToString(), Total.iTotal);
        }

        /// <summary>
        /// Envía un prospecto a la cola de prospectos.
        /// </summary>
        public void SendQueue()
        {
            bool bResultado = new Prospecto().SendQueue(int.Parse(AUsuarioData.sIdusuario), iIdProspSel, iIdLlamada, txtComentarioLlamada.Text, iIdEtapa == 7 ? (int?)null : iIdLlamadaAgendada);

            if (bResultado)
            {
                this.Invoke((MethodInvoker)delegate { LoadProspectos(); LoadScheduleCalls(); LoadCountCitas(); });
                tmrHorarios.Stop();
                pnlProspectos.Enabled  = true;
                pnlSeguimiento.Visible = false;
                RestartControllers();
                FlatMessageBox.Show("Prospecto actualizado", "Ok", string.Empty, FlatMessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Reinicia los controles a su estado inicial
        /// </summary>
        public void RestartControllers()
        {
            txtComoAgendada.Text            = "";
            txtComentarioLlamada.Text       = "";
            rdbAgendarCita.Checked          = false;
            rdbAgendarLlamada.Checked       = false;
            txtComentarioCita.Text          = "";
            txtComentarioAgendaLlamada.Text = "";
            txtTelefonoOpcional.Text        = "";
            txtDireccion.Text               = "";
            txtNombreAtiende.Text           = "";
            txtPuesto.Text                  = "";
            txtTelefono.Text                = "";

            pnlFormularioCita.Visible       = false;
            pnlFormularioLlamada.Visible    = false;

            btnCancelarProspecto.Visible    = false;
            btnPonerCola.Visible            = false;
            btnAgendarLlamada.Visible       = false;
            btnGuardarCita.Visible          = false;
        }

        /// <summary>
        /// Cancela un prospecto y lo quita del listado de prospectos activos
        /// </summary>
        public void CancelProsp(string sMotivoCancelacion)
        {
            bool bResultado = new Prospecto().CancelProsp(int.Parse(AUsuarioData.sIdusuario), iIdProspSel, iIdLlamada, txtComentarioLlamada.Text, iIdEtapa == 7 ? (int?)null : iIdLlamadaAgendada, sMotivoCancelacion);
            if (bResultado)
            {
                this.Invoke((MethodInvoker)delegate { LoadProspectos(); LoadScheduleCalls(); LoadCountCitas(); });
                tmrHorarios.Stop();
                pnlProspectos.Enabled   = true;
                pnlSeguimiento.Visible  = false;
                RestartControllers();
                FlatMessageBox.Show("Prospecto cancelado", "Ok", string.Empty, FlatMessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Valida que existan comentarios en el campo
        /// comentarios de la llamada
        /// </summary>
        /// <returns></returns>
        public bool ValidateCallComment()
        {
            errorProvider1.Clear();
            bool bResutaldo = true;
            if (string.IsNullOrEmpty(txtComentarioLlamada.Text))
            {
                bResutaldo = false;
                errorProvider1.SetError(txtComentarioLlamada, "Comentarios requeridos");
            }

            

            return bResutaldo;
        }

        /// <summary>
        /// Valida que la información del formulario para agendar una llamada, este completa.
        /// </summary>
        /// <returns></returns>
        public bool ValidateScheduleComment()
        {
            bool bResultado = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(dtFechaAgendaLlamada.DateTime.ToString()))
            {
                bResultado = false;
                errorProvider1.SetError(dtFechaAgendaLlamada, "Fecha requerida para agendar una llamada");
            }
            if (string.IsNullOrEmpty(txtComentarioAgendaLlamada.Text))
            {
                bResultado = false;
                errorProvider1.SetError(txtComentarioAgendaLlamada, "Comentarios requeridos");
            }
            return bResultado;
        }

        /// <summary>
        /// Agenda una nueva llamada
        /// </summary>
        public void ScheduleCall()
        {
            int iResultado = new Prospecto().ScheduleCall(int.Parse(AUsuarioData.sIdusuario), iIdProspSel
                                                        , iIdLlamada, txtComentarioLlamada.Text
                                                        , txtComentarioAgendaLlamada.Text, dtFechaAgendaLlamada.DateTime
                                                        , dtHoraAgendaLlamada.Time, txtTelefonoOpcional.Text, iIdEtapa == 7 ? (int?)null : iIdLlamadaAgendada);
            if (iResultado > 0)
            {
                this.Invoke((MethodInvoker)delegate { LoadProspectos(); LoadScheduleCalls(); LoadCountCitas(); });
                tmrHorarios.Stop();
                pnlProspectos.Enabled  = true;
                pnlSeguimiento.Visible = false;
                RestartControllers();  
                FlatMessageBox.Show("Llamada agendada exitosamente", "Ok", string.Empty, FlatMessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Realiza una llamada si la ventana de telefono se encuentra abierta
        /// </summary>
        /// <param name="sTelefono">Número de teléfono al que se desea llamar</param>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MakeCall(string sTelefono, object sender, EventArgs e)
        {
            frmTelefono _Telefono = Application.OpenForms["frmTelefono"] as frmTelefono;
            if (_Telefono != null)
            {
                iIdLlamada = new Llamada().NewLlamada(iIdProspSel, int.Parse(AUsuarioData.sIdusuario));
                if (iIdLlamada > 0)
                {
                    _FPrincipal.ShowPhone();
                    pnlProspectos.Enabled       = false;
                    _Telefono.txtDisplay.Text   = sTelefono;
                    _Telefono.lnkPickUp_Click(sender, e);

                    btnCancelarProspecto.Visible    = true;
                    btnPonerCola.Visible            = true;
                    txtComentarioLlamada.Visible    = true;
                    rdbAgendarCita.Visible          = true;
                    rdbAgendarLlamada.Visible       = true;
                    materialLabel7.Visible          = true;

                    //if (ALlamadaData.bCurso)
                    //{
                        AProspeccionData.bCurso     = true;
                        AProspeccionData.iIdLlamada = iIdLlamada;
                    //}
                    
                }
            }
        }
        LlamadaProspeccion ALlamadaData = LlamadaProspeccion.Instancia;

        /// <summary>
        /// Valida que los campos requeridos para agendar una cita
        /// esten completos
        /// </summary>
        /// <returns></returns>
        public bool ValidateAppointmentComment()
        {
            bool bResultado = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(dtFechaCita.DateTime.ToString()))
            {
                bResultado = false;
                errorProvider1.SetError(dtFechaCita, "Fecha requerida para agendar una cita");
            }
            if (tmHoraCita.SelectedItems.Count == 0)
            {
                bResultado = false;
                errorProvider1.SetError(tmHoraCita, "Hora requerida para agendar una cita");
            }
            if (string.IsNullOrEmpty(txtComentarioCita.Text))
            {
                bResultado = false;
                errorProvider1.SetError(txtComentarioCita, "Comentarios requeridos");
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                bResultado = false;
                errorProvider1.SetError(txtDireccion, "Dirección requerida");
            }

            if (string.IsNullOrEmpty(txtNombreAtiende.Text))
            {
                bResultado = false;
                errorProvider1.SetError(txtNombreAtiende, "Nombre requerido");
            }

            if (string.IsNullOrEmpty(txtPuesto.Text))
            {
                bResultado = false;
                errorProvider1.SetError(txtPuesto, "Puesto requerido");
            }

            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                bResultado = false;
                errorProvider1.SetError(txtTelefono, "Teléfono requerido");
            }
            return bResultado;
        }

        /// <summary>
        /// Agenda una nueva cita para el prospecto, se considera como etapa final para el
        /// call center
        /// </summary>
        public void ScheduleAppointment()
        {
            int iResultado = new Prospecto().ScheduleAppointment(int.Parse(AUsuarioData.sIdusuario), iIdProspSel
                                                                , iIdLlamada, txtComentarioLlamada.Text
                                                                , txtComentarioCita.Text, dtFechaCita.DateTime
                                                                , DateTime.Parse(tmHoraCita.SelectedItems[0].Text), iIdEtapa == 7 ? (int?)null : iIdLlamadaAgendada
                                                                , txtDireccion.Text, txtNombreAtiende.Text
                                                                , txtPuesto.Text, txtTelefono.Text);
            if (iResultado > 0)
            {
                this.Invoke((MethodInvoker)delegate { LoadProspectos(); LoadScheduleCalls(); LoadCountCitas(); });
                tmrHorarios.Stop();
                pnlProspectos.Enabled  = true;
                pnlSeguimiento.Visible = false;
                RestartControllers();
                FlatMessageBox.Show("Cita agendada correctamente", "Ok", string.Empty, FlatMessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Carga los horarios una ves seleccionada la fecha deseada
        /// </summary>
        public void LoadSchedules()
        {
            tmrHorarios.Stop();
            tmHoraCita.Items.Clear();
            Horarios = new Prospecto().GetSchedules(int.Parse(AUsuarioData.sIdusuario), dtFechaCita.DateTime);
            for (int i = 0; i < Horarios.Count; i++)
            {
                var Item = new ListViewItem(Horarios[i].tsHora.ToString());
                tmHoraCita.Items.Add(Item);
            }
        }

        /// <summary>
        /// Actualiza los horarios de acuerdo a la fecha seleccionada
        /// </summary>
        public void CheckSchedules()
        {
            HorariosTemp = new Prospecto().GetSchedules(int.Parse(AUsuarioData.sIdusuario), dtFechaCita.DateTime);
            if (HorariosTemp.Count != Horarios.Count)
            {
                Horarios = HorariosTemp;

                string seleccion = "";
                if (tmHoraCita.SelectedItems.Count == 1)
                    seleccion = tmHoraCita.SelectedItems[0].Text;

                tmHoraCita.Items.Clear();
                for (int i = 0; i < Horarios.Count; i++)
                {
                    var Item = new ListViewItem(Horarios[i].tsHora.ToString());
                    tmHoraCita.Items.Add(Item);

                    if (Horarios[i].tsHora.ToString() == seleccion)
                    {
                        Item.Focused  = true;
                        Item.Selected = true;
                    }
                }
                HorariosTemp = null;
            }
        }     
        #endregion

        #region Eventos
        private void rdbAgendar(object sender, EventArgs e)
        {
            if (rdbAgendarCita.Checked)
            {
                pnlFormularioLlamada.Visible = false;
                btnAgendarLlamada.Visible    = false;
                pnlFormularioCita.Visible    = true;
                btnGuardarCita.Visible       = true;
            }
            else
            {
                pnlFormularioCita.Visible    = false;
                btnGuardarCita.Visible       = false;
                pnlFormularioLlamada.Visible = true;
                btnAgendarLlamada.Visible    = true;
            }
        }

        private void lnkLlamar_Click(object sender, EventArgs e)
        {
            if (iIdEtapa == 7)
            {
                MakeCall(lblTelefono.Text.Replace(" ", string.Empty), sender, e);
            }
            else if (iIdEtapa == 8)
            {
                if (!string.IsNullOrEmpty(gridView2.GetFocusedRowCellValue("sTelOpcional").ToString().Replace(" ", string.Empty)))
                {
                    MetroFramework.Controls.MetroLink lnkMenu = (MetroFramework.Controls.MetroLink)sender;
                    Point ptLowerLeft = new Point(0, 0);
                    ptLowerLeft = lnkMenu.PointToScreen(ptLowerLeft);

                    btnTel1.Text = gridView2.GetFocusedRowCellValue("sTelefono").ToString();
                    btnTel2.Text = gridView2.GetFocusedRowCellValue("sTelOpcional").ToString();
                    mnstpMas.Show(ptLowerLeft);
                }
                else
                    MakeCall(lblTelefono.Text.Replace(" ", string.Empty), sender, e);
            }
        }

        MRUEdit edit;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            FindControl find = null;
            foreach (Control ctrl in grdProspectos.Controls)
                if (ctrl.GetType() == typeof(FindControl))
                    find = ctrl as FindControl;
            if (find != null)
            {
                LayoutControl layout = find.Controls[0] as LayoutControl;
                edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            edit.Text = txtBuscar.Text.ToString();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
            {
                Prospecto _ProspectoData = Prospecto.Instancia;
                _ProspectoData.iIdProspecto = int.Parse(gridView1.GetFocusedRowCellValue("iIdProspecto").ToString());

                iIdProspSel      = int.Parse(gridView1.GetFocusedRowCellValue("iIdProspecto").ToString());
                iIdEtapa         = int.Parse(gridView1.GetFocusedRowCellValue("iIdEtapa").ToString());
                lblTelefono.Text = gridView1.GetFocusedRowCellValue("sTelefono").ToString();

                btnCancelarProspecto.Visible = false;
                btnPonerCola.Visible         = false;
                txtComentarioLlamada.Visible = false;
                rdbAgendarCita.Visible       = false;
                rdbAgendarLlamada.Visible    = false;
                materialLabel7.Visible       = false;
                txtComoAgendada.Visible      = false;
                materialLabel2.Text          = gridView1.GetFocusedRowCellValue("sNombre").ToString();
                lblDireccion.Text            = gridView1.GetFocusedRowCellValue("sDireccion").ToString();

                pnlSeguimiento.Visible = true;
            }
        }

        private void btnPonerCola_Click(object sender, EventArgs e)
        {
            if (ValidateCallComment())
                SendQueue();
        }

        private void btnCancelarProspecto_Click(object sender, EventArgs e)
        {
            if (ValidateCallComment())
            {
                frmCancelProsp _Cancel = new frmCancelProsp();
                _Cancel.ShowDialog();
            }
            //CancelProsp();
        }

        private void btnAgendarLlamada_Click(object sender, EventArgs e)
        {
            if (ValidateCallComment())
            {
                if (ValidateScheduleComment())
                    ScheduleCall();
            }
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (ValidateCallComment())
            {
                if (ValidateAppointmentComment())
                    ScheduleAppointment();
            }
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView2.RowCount > 0)
            {
                Prospecto _ProspectoData = Prospecto.Instancia;
                _ProspectoData.iIdProspecto = int.Parse(gridView2.GetFocusedRowCellValue("iIdProspecto").ToString());

                iIdProspSel        = int.Parse(gridView2.GetFocusedRowCellValue("iIdProspecto").ToString());
                iIdEtapa           = int.Parse(gridView2.GetFocusedRowCellValue("iIdEtapa").ToString());
                iIdLlamadaAgendada = int.Parse(gridView2.GetFocusedRowCellValue("iIdLlamada").ToString());

                if (!string.IsNullOrEmpty(gridView2.GetFocusedRowCellValue("sTelOpcional").ToString().Replace(" ", string.Empty)))
                    lblTelefono.Text = "Dos números disponibles.";
                else
                    lblTelefono.Text = gridView2.GetFocusedRowCellValue("sTelefono").ToString();

                btnCancelarProspecto.Visible = false;
                btnPonerCola.Visible         = false;
                txtComentarioLlamada.Visible = false;
                rdbAgendarCita.Visible       = false;
                rdbAgendarLlamada.Visible    = false;
                materialLabel7.Visible       = false;
                txtComoAgendada.Visible      = true;
                materialLabel2.Text          = gridView2.GetFocusedRowCellValue("sNombre").ToString();
                txtComoAgendada.Text         = gridView2.GetFocusedRowCellValue("sObservaciones").ToString();
                lblDireccion.Text            = gridView1.GetFocusedRowCellValue("sDireccion").ToString();

                pnlSeguimiento.Visible = true;
            }
        }

        private void btnTel1_Click(object sender, EventArgs e)
        {
            MakeCall(gridView2.GetFocusedRowCellValue("sTelefono").ToString().Replace(" ", string.Empty), sender, e);
        }

        private void btnTel2_Click(object sender, EventArgs e)
        {
            MakeCall(gridView2.GetFocusedRowCellValue("sTelOpcional").ToString().Replace(" ", string.Empty), sender, e);
        }

        private void dtFechaCita_DateTimeChanged(object sender, EventArgs e)
        {
            LoadSchedules();
            tmrHorarios.Start();
        }

        private void tmrHorarios_Tick(object sender, EventArgs e)
        {
            CheckSchedules();
        }
        #endregion

        private void lblNoCitas_Click(object sender, EventArgs e)
        {
            frmCitasAgendasHoy _Citas = new frmCitasAgendasHoy();
            _Citas.ShowDialog();
        }
    }
}
