using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LogicaCC;
using System.Globalization;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmInicioObligaciones : Form
    {
        LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        public int iIdUsuario;
        public List<LogicaCC.LexaSIOContaLogica.RegistroObligacion> clientes;

        //VARIABLES PUBLICAS PARA USAR EN OTROS FORMS
        public static int    iIdCliente;
        public static string sfechaInicio;
        public static string sfechaTermino;

        FPrincipal _frmPrincipal;


        public frmInicioObligaciones(int IdUsuario)
        {
			this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
			InitializeComponent();
            iIdUsuario = IdUsuario;
            cargarClientes();

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;

            if (gridView1.RowCount == 0)
            {
                _frmPrincipal.btnOFVerObligacionesFiscales.Enabled = false;
            }
            else
            {
                _frmPrincipal.btnOFVerObligacionesFiscales.Enabled = true;
            }

        }

        private void cargarClientes()
        {
            var vHoy = DateTime.Now;
            //PRIMER DÍA DE LA SEMANA
            var vPrimerDia = vHoy.AddDays(-((vHoy.DayOfWeek - System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.FirstDayOfWeek + 7) % 7)).Date;
            //ULTIMO DÍA DE LA SEMANA
            var vUltimoDia = vPrimerDia.AddDays(6);
            //PRIMER DÍA DEL MES
            var vPrimerDiaMes = new DateTime(vHoy.Year, vHoy.Month, 1);

            //INICIALIZAMOS LOS VALORES DE LOS CONTROLES DATETIME
            dttmDesde.Value = DateTime.Parse(vPrimerDiaMes.ToString());
            dttmHasta.Value = DateTime.Parse(vUltimoDia.ToString());

            //OBTENEMOS LA LISTA DE CLIENTES QUE TIENE OBLIGACIONES PENDIENTES LA SEMANA EN CURSO
            LogicaCC.LexaSIOContaLogica.RegistroObligacion cliente = new LogicaCC.LexaSIOContaLogica.RegistroObligacion();
            clientes = cliente.InformacionClienteSemanaObligacion(new LogicaCC.LexaSIOContaLogica.RegistroObligacion()
            {
                iIdUsuarioRegistra = iIdUsuario
            }, vPrimerDiaMes.ToString(), vUltimoDia.ToString(), string.Empty);

            grdClientes.DataSource = clientes;

			ContarRegistros();
		}

        private void btnBusquedaPerso_Click(object sender, EventArgs e)
        {
            //VALIDA SI SE MUESTRA O NO EL PANEL PARA REALIZAR BUSQUEDA
            if (pnlBusqueda.Visible == false)
                pnlBusqueda.Visible = true;
            else
                pnlBusqueda.Visible = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //LIMPIA EL PANEL DE CLIENTES Y GUARDA LAS FECHAS EN VARIABLES PARA USARLAS POSTERIORMENTE.
            var vPrimerDia = dttmDesde.Value;
            var vUltimoDia = dttmHasta.Value;

            //OBTIENE NUEVOS DATOS PASANDO LOS NUEVOS PARAMETROS DE BUSQUEDA
            LogicaCC.LexaSIOContaLogica.RegistroObligacion cliente = new LogicaCC.LexaSIOContaLogica.RegistroObligacion();
            clientes = cliente.InformacionClienteSemanaObligacion(new LogicaCC.LexaSIOContaLogica.RegistroObligacion()
            {
                iIdUsuarioRegistra = iIdUsuario
            }, vPrimerDia.ToString(), vUltimoDia.ToString(), txtBuscar.Text);

            //CREA UNA LISTA DINAMICA DE LOS CLIENTES QUE TIENEN OBLIGACIONES ENTRE LAS FECHAS FILTRADAS
            for (int i = 0; i < clientes.Count; i++)
            {
                Panel pnlCliente = new Panel();
                pnlCliente.BackColor    = Color.FromArgb(0xF2, 0xF1, 0xF1);
                pnlCliente.Width        = 180;
                pnlCliente.Height       = 110;//200
                pnlCliente.Location     = new Point(181 * i + 0, 0);

                Label label = new Label();
                label.Location  = new Point(2, 35);
                label.Font      = new Font("Segoe UI", 9);
                label.Width     = 240;
                label.Text      = string.Format("{0} {1} {2}", clientes[i].sNombre, clientes[i].sAPaterno, clientes[i].sAMaterno);
                pnlCliente.Controls.Add(label);

                Button btnCliente = new Button();
                btnCliente.Location                     = new Point(20, 60);//275
                btnCliente.Name                         = clientes[i].iIdCliente.ToString();
                btnCliente.Text                         = "Ver Obligaciones";
                btnCliente.Width                        = 140;
                btnCliente.Height                       = 23;
                btnCliente.FlatStyle                    = FlatStyle.Flat;
                btnCliente.FlatAppearance.BorderSize    = 0;
                btnCliente.BackColor                    = Color.FromArgb(7, 22, 127);
                btnCliente.ForeColor                    = Color.White;
                btnCliente.Cursor                       = Cursors.Hand;
                //CREAMOS EL EVENTO CLICK DEL BOTÓN
                btnCliente.Click += BtnCliente_Click;
                pnlCliente.Controls.Add(btnCliente);
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            //OBTIENE EL ID DEL CLIENTE SELECCIONADO Y LO GUARDA EN UNA VARIABLE PUBLICA
            Button button   = sender as Button;
            iIdCliente      = int.Parse(button.Name);
            sfechaInicio    = dttmDesde.Value.ToShortDateString();
            sfechaTermino   = dttmHasta.Value.ToShortDateString();
        }

        #region FUNCIONES USADAS POR CONTROLES

        // RECIBE EL FORMULARIO A MOSTRAR, LO EDITA Y LO MUESTRA
        private void MostrarForm(Form Formulario)
        {

            FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
            CerrarFormularios();
            Formulario.TopLevel = false;
            Formulario.FormBorderStyle = FormBorderStyle.None;
            Formulario.Dock = DockStyle.Fill;
            _FPrincipal.panelContenedor.Controls.Add(Formulario);
            _FPrincipal.panelContenedor.Tag = Formulario;
            Formulario.Show();
        }

        // CIERRA LOS FORMULARIOS ABIERTOS Y PUESTOS EN EL FORM.
        private void CerrarFormularios()
        {
            FPrincipal _FPrincipal = Application.OpenForms.OfType<FPrincipal>().Where(pre => pre.Name == "FPrincipal").SingleOrDefault<FPrincipal>();
            Form[] sAforms = new Form[10];
            int iContador = 0;
            // Se genera el listado de los formularios abiertos
            foreach (Form x in Application.OpenForms)
            {
                string sForm = x.Name.ToString();

                if (!sForm.Equals("Login") && !sForm.Equals("FPrincipal") && !sForm.Equals("EnviarMensajes") && !sForm.Equals("frmDirectorio"))
                {
                    _FPrincipal.panelContenedor.Controls.Remove(x);
                    sAforms[iContador] = x;
                    iContador++;
                }
            }
            // Cierra los formularios
            for (int i = 0; i < 10; i++)
            {
                if (sAforms[i] != null)
                {
                    sAforms[i].Close();
                }
            }
        }

        #endregion FUNCIONES USADAS POR CONTROLES

		MRUEdit edit;
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			FindControl find = null;
			foreach (Control ctrl in grdClientes.Controls)
				if (ctrl.GetType() == typeof(FindControl))
					find = ctrl as FindControl;
			if (find != null)
			{
				LayoutControl layout = find.Controls[0] as LayoutControl;
				edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
			}
		}

		private void txtBuscar_TextChanged(Object sender, EventArgs e)
		{
			edit.Text = txtBuscar.Text.ToString();
		}

		public int iIdClienteSeleccionado = 0;
		private void gridView1_DoubleClick(Object sender, EventArgs e)
		{
			BeginInvoke(new Action(delegate {
				gridView1.SelectRow(gridView1.FocusedRowHandle);
				if (gridView1.RowCount > 0)
				{
					if (iIdClienteSeleccionado > 0)
					{
						int		iIdCliente		= 0;
						string	sFechaInicio	= null;
						string	sFechaTermino	= null;

						iIdCliente		= int.Parse(gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
						sFechaInicio	= dttmDesde.Value.ToShortDateString();
						sFechaTermino	= dttmHasta.Value.ToShortDateString();


						frmObligacionesCliente _frmObligacionesCliente = new frmObligacionesCliente(iIdCliente, sFechaInicio, sFechaTermino);

						FPrincipal _FPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;

						_FPrincipal.MostrarFormulario(_frmObligacionesCliente);
						_FPrincipal.btnOFVerObligacionesFiscales.Enabled = false;
					}
				}

			}));
		}

		private void gridView1_RowClick(Object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
		{
			try
			{
				iIdClienteSeleccionado = int.Parse(gridView1.GetFocusedRowCellValue("iIdCliente").ToString());
			}
			catch
			{
				iIdClienteSeleccionado = 0;
			}
		}

		/// <summary>
		/// Cuenta los registros que se encuentran en el gridView
		/// </summary>
		public void ContarRegistros()
		{
			if (gridView1.RowCount > 0)
				lblNoRegitros.Text = string.Format("No. de Registros: {0}", gridView1.RowCount);
			else
				lblNoRegitros.Text = "No. de Registros: --";
		}

		private void gridView1_ColumnFilterChanged(Object sender, EventArgs e)
		{
			ContarRegistros();
		}
	}
}
