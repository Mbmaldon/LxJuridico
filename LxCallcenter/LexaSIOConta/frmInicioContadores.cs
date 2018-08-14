using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmInicioContadores : Form
    {
        LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
        public int iIdUsuario;
        public List<LogicaCC.LexaSIOContaLogica.RegistroObligacion> clientes;
        FPrincipal _frmPrincipal;

        public frmInicioContadores()
        {
            //this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint, true);
            iIdUsuario = int.Parse(AUsuarioData.sIdusuario);
            cargarContadores();

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;

            if (gridView1.RowCount == 0)
            {
                _frmPrincipal.btnOFVerClientes.Enabled = false;
            }
            else
            {
                _frmPrincipal.btnOFVerClientes.Enabled = true;
            }
        }


        private void cargarContadores()
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
            clientes = cliente.InformacionContadorSemanaObligacion(new LogicaCC.LexaSIOContaLogica.RegistroObligacion()
            {
                iIdUsuarioRegistra = iIdUsuario
            }, vPrimerDiaMes.ToString(), vUltimoDia.ToString(), string.Empty);
            grdContadores.DataSource = clientes;

            ////MUESTRA UNA LISTA DINAMICA DE LOS CONTADORES QUE TIENEN CLIENTES CON OBLIGACIONES PENDIENTES LA SEMANA EN CURSO
            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    Panel pnlContador = new Panel();
            //    pnlContador.BackColor = Color.FromArgb(0xF2, 0xF1, 0xF1);
            //    pnlContador.Width = 180;
            //    pnlContador.Height = 110;//200
            //    pnlContador.Location = new Point(181 * i + 0, 0);
            //    //pnlClientes.Controls.Add(pnlCliente);
            //    flowLayoutPanel1.Controls.Add(pnlContador);

            //    PictureBox ptbxImage = new PictureBox();
            //    ptbxImage.BackgroundImage = Properties.Resources.businessman_96px;
            //    ptbxImage.BackgroundImageLayout = ImageLayout.Zoom;
            //    ptbxImage.Location = new Point(0, pnlContador.Height / 2);
            //    ptbxImage.Height = 40;
            //    ptbxImage.Width = 40;
            //    pnlContador.Controls.Add(ptbxImage);

            //    Label label = new Label();
            //    label.Location = new Point(2, 35);
            //    label.Font = new Font("Segoe UI", 9);
            //    label.Width = 240;
            //    label.Text = string.Format("{0} {1} {2}", clientes[i].sNombre, clientes[i].sAPaterno, clientes[i].sAMaterno);
            //    pnlContador.Controls.Add(label);

            //    Button btnContador = new Button();
            //    btnContador.Location = new Point(20, 60);
            //    btnContador.Name = clientes[i].iIdCliente.ToString();
            //    btnContador.Text = "Ver Clientes";
            //    btnContador.Width = 140;
            //    btnContador.Height = 23;
            //    btnContador.FlatStyle = FlatStyle.Flat;
            //    btnContador.FlatAppearance.BorderSize = 0;
            //    btnContador.BackColor = Color.FromArgb(7, 22, 127);// 0, 179,  219
            //    btnContador.ForeColor = Color.White;
            //    btnContador.Cursor = Cursors.Hand;
            //    //CREAMOS EL EVENTO CLCIK DE BOTÓN
            //    btnContador.Click += BtnContador_Click;
            //    pnlContador.Controls.Add(btnContador);
            //}


        }

        public static int    iIdCliente;
        public static string sfechaInicio;
        public static string sfechaTermino;
        //private void BtnContador_Click(object sender, EventArgs e)
        //{
        //    //OBTIENE EL ID DEL CLIENTE SELECCIONADO Y LO GUARDA EN UNA VARIABLE PUBLICA
        //    Button button   = sender as Button;
        //    iIdCliente      = int.Parse(button.Name);
        //    sfechaInicio    = dttmDesde.Value.ToShortDateString();
        //    sfechaTermino   = dttmHasta.Value.ToShortDateString();


        //    LexaSIOConta.frmInicioObligaciones _frmInicioObligaciones = new LexaSIOConta.frmInicioObligaciones(iIdCliente);
        //    LexaSIOConta.frmInicioObligaciones InicioObligaciones = _frmInicioObligaciones ?? new LexaSIOConta.frmInicioObligaciones(iIdCliente);
        //    MostrarForm(InicioObligaciones);


        //    //MessageBox.Show(string.Format("{1}{0}{2}{0}{3}", Environment.NewLine, iIdCliente, sfechaInicio, sfechaTermino));

        //}


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //LIMPIA EL PANEL DE CLIENTES Y GUARDA LAS FECHAS EN VARIABLES PARA
            //USARLAS POSTERIORMENTE.
            //flowLayoutPanel1.Controls.Clear();
            var vPrimerDia = dttmDesde.Value;
            var vUltimoDia = dttmHasta.Value;

            lblFecha.Location   = new Point(65, 74);
            lblFecha.Text       = string.Format("{0}  - {1}", vPrimerDia.ToShortDateString(), vUltimoDia.ToShortDateString());
            lblFecha.Font       = new Font("Calibri Light", 14);

            //OBTIENE NUEVOS DATOS PASANDO LOS NUEVOS PARAMETROS DE BUSQUEDA
            LogicaCC.LexaSIOContaLogica.RegistroObligacion cliente = new LogicaCC.LexaSIOContaLogica.RegistroObligacion();
            clientes = cliente.InformacionContadorSemanaObligacion(new LogicaCC.LexaSIOContaLogica.RegistroObligacion()
            {
                iIdUsuarioRegistra = iIdUsuario
            }, vPrimerDia.ToString(), vUltimoDia.ToString(), txtContador.Text);

            //CREA UNA LISTA DINAMICA DE LOS CLIENTES QUE TIENEN OBLIGACIONES ENTRE LAS FECHAS FILTRADAS
            //for (int i = 0; i < clientes.Count; i++)
            //{
            //    Panel pnlContador = new Panel();
            //    pnlContador.BackColor = Color.FromArgb(0xF2, 0xF1, 0xF1);
            //    pnlContador.Width = 180;
            //    pnlContador.Height = 110;//200
            //    pnlContador.Location = new Point(181 * i + 0, 0);
            //    //pnlClientes.Controls.Add(pnlCliente);
            //    flowLayoutPanel1.Controls.Add(pnlContador);

            //    PictureBox ptbxImage = new PictureBox();
            //    ptbxImage.BackgroundImage = Properties.Resources.businessman_96px;
            //    ptbxImage.BackgroundImageLayout = ImageLayout.Zoom;
            //    ptbxImage.Location = new Point(0, pnlContador.Height/2);
            //    ptbxImage.Height = 30;
            //    ptbxImage.Width = 30;
            //    pnlContador.Controls.Add(ptbxImage);
                

            //    Label label = new Label();
            //    label.Location  = new Point(2, 35);
            //    label.Font      = new Font("Segoe UI", 9);
            //    label.Width     = 240;
            //    label.Text      = string.Format("{0} {1} {2}", clientes[i].sNombre, clientes[i].sAPaterno, clientes[i].sAMaterno);
            //    pnlContador.Controls.Add(label);

            //    Button btnContador = new Button();
            //    btnContador.Location                     = new Point(20, 60);//275
            //    btnContador.Name                         = clientes[i].iIdCliente.ToString();
            //    btnContador.Text                         = "Ver Clientes";
            //    btnContador.Width                        = 140;
            //    btnContador.Height                       = 23;
            //    btnContador.FlatStyle                    = FlatStyle.Flat;
            //    btnContador.FlatAppearance.BorderSize    = 0;
            //    btnContador.BackColor                    = Color.FromArgb(7, 22, 127);
            //    btnContador.ForeColor                    = Color.White;
            //    btnContador.Cursor                       = Cursors.Hand;
            //    //CREAMOS EL EVENTO CLICK DEL BOTÓN
            //    btnContador.Click += BtnContador_Click;
            //    pnlContador.Controls.Add(btnContador);
            //}
        }

        private void btnBusquedaPerso_Click(object sender, EventArgs e)
        {
            //VALIDA SI SE MUESTRA O NO EL PANEL PARA REALIZAR BUSQUEDA
            if (pnlBusqueda.Visible == false)
                pnlBusqueda.Visible = true;
            else
                pnlBusqueda.Visible = false;
        }

        private void txtContador_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    btnBuscar_Click(sender, e);
            //}
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

        private void txtContador_TextChanged(object sender, EventArgs e)
        {
            gridView1.ActiveFilterCriteria = new DevExpress.Data.Filtering.BinaryOperator(new DevExpress.Data.Filtering.OperandProperty("sNombre"), new DevExpress.Data.Filtering.OperandValue("%" + txtContador.Text + "%"), DevExpress.Data.Filtering.BinaryOperatorType.Like);
            gridView1.ExpandAllGroups();
        }
    }
}
