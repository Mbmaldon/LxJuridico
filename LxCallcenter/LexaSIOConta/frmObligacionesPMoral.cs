using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaCC.LexaSIOContaLogica;
using LogicaCC.Logica;
using MetroFramework.Controls;

namespace LxCallcenter.LexaSIOConta
{
    public partial class frmObligacionesPMoral : Form
    {
        public List<DetalleObligacion> obligaciones;
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        bool bNuevaEmpresa;
        bool bExistente;

        public frmObligacionesPMoral()
        {
            InitializeComponent();
            panel1.Visible       = false;
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelControl1.Size   = new Size(1177, 613);
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

                if (!sForm.Equals("Login") && !sForm.Equals("FPrincipal") && !sForm.Equals("EnviarMensajes"))
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
                    sAforms[i].Close();
            }
        }
        #endregion FUNCIONES USADAS POR CONTROLES

        #region EVENTOS
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Revisamos si esta seleccionado un regimen
			int i			= 0;
			bNuevaEmpresa	= false;
			bExistente		= false;

            foreach (Control ctrl in panel4.Controls)
            {
                if (ctrl is LollipopRadioButton)
                {
                    LollipopRadioButton rdb = ctrl as LollipopRadioButton;
                    if (rdb.Checked)
                    {
                        i++;
                        switch (rdb.Name)
                        {
                            case "rdbNueva":
                                bNuevaEmpresa = true;
                                break;
                            case "rdbExistente":
                                bExistente = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

			// Si se ha marcado un regimen, continuamos
			if (i > 0)
			{
                panel1.Visible       = true;
                panelControl1.Anchor = AnchorStyles.Top;
                panelControl1.Size   = new Size(1177, 1297);

                materialLabel1.Visible	= true;
                materialLabel2.Visible  = true;
                materialLabel3.Visible  = true;

                lblTitulo.Text				= "Marque las casillas de las obligaciones que desea asignar.";
				btnModificarRegimen.Visible = true;
				btnContinuar.Visible		= false;
				lblTitulo.Location			= new Point(btnModificarRegimen.Location.X, 170);//18

				// Ocultamos controles checkbox
                rdbExistente.Visible    = false;
                rdbNueva.Visible        = false;

				// Ocultamos controles SmallCards
				btnHonorarios.Visible		= false;
				btnArrendamiento.Visible	= false;

                List<DetalleObligacion> lista = new DetalleObligacion().GetListObligaciones(0,
                                                                                            0,
                                                                                            bExistente ? 12 : 0,
                                                                                            bNuevaEmpresa ? 13 : 0);
                cargarObligaciones(pnlObligaciones, lista, 20);

                List<DetalleObligacion> listaDictamenes = new DetalleObligacion().GetListDictamenes(15); //bNueva ? 14 : 15
                cargarDictamenes(pnlDictamenes, listaDictamenes, 20);

                List<DetalleObligacion> listaISN = new DetalleObligacion().GetListISN(13); //bNueva ? 10 : 11
                cargarISN(pnlISN, listaISN, 20);

                btnGuardar.Visible			= true;

				int iUbicacion = 571;//480;//476;//580;

				if (bExistente)
				{
					btnVExistente.Visible	= true;
					btnVExistente.Location	= new Point(iUbicacion, 101); // 434, 67
					iUbicacion				= iUbicacion + 50;
				}

				if (bNuevaEmpresa)
				{
					btnVNueva.Visible	= true;
					btnVNueva.Location	= new Point(iUbicacion, 101);
					iUbicacion			= iUbicacion + 50;
				}
			}
			else
                FlatMessageBox.Show("Debes marcar al menos un regimen", "OK", string.Empty, FlatMessageBoxIcon.Warning);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnHonorarios.ThumbnailColor	= "#cfd8dc";
			btnHonorarios.FontColor			= "#cfd8dc";
			btnArrendamiento.ThumbnailColor = "#cfd8dc";
			btnArrendamiento.FontColor		= "#cfd8dc";

			btnGuardar.Enabled			= false;
            rdbNueva.Enabled            = false;
            rdbExistente.Enabled        = false;
			pnlObligaciones.Enabled		= false;
            pnlDictamenes.Enabled       = false;
            pnlISN.Enabled              = false;
			btnModificarRegimen.Enabled = false;

            //if (GuardarObligaciones(pnlObligaciones, 1) && GuardarObligaciones(pnlDictamenes, 2) && GuardarObligaciones(pnlISN, 3))
            if (GuardarObligaciones(pnlObligaciones, 1) && GuardarObligaciones(pnlISN, 3))
            {
                frmPendientes _frmPendientes = new frmPendientes(frmAsignarObligaciones.iIdCliente);
                frmPendientes Pendientes = _frmPendientes ?? new frmPendientes(frmAsignarObligaciones.iIdCliente);
                MostrarForm(Pendientes);
            }
			else
			{
				btnHonorarios.ThumbnailColor	= "#5d4037";
				btnHonorarios.FontColor			= "#5d4037";
				btnArrendamiento.ThumbnailColor = "#558b2f";
				btnArrendamiento.FontColor		= "#558b2f";

				btnGuardar.Enabled			= true;
                rdbNueva.Enabled            = true;
                rdbExistente.Enabled        = true;
				pnlObligaciones.Enabled		= true;
                pnlDictamenes.Enabled       = true;
                pnlISN.Enabled              = true;
				btnModificarRegimen.Enabled = true;
			}
        }

        private void btnModificarRegimen_Click(object sender, EventArgs e)
        {
            panel1.Visible       = false;
            panelControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelControl1.Size   = new Size(1177, 545);

            btnModificarRegimen.Visible = false;
			materialLabel1.Visible		= false;
            materialLabel2.Visible      = false;
            materialLabel3.Visible      = false;
			btnGuardar.Visible			= false;
			btnVExistente.Visible		= false;
			btnVNueva.Visible	        = false;

			lblTitulo.Text		= "Marque las casillas del régimen perteneciente al cliente, para selección de obligaciones fiscales.";
			lblTitulo.Location	= new Point(259, 253);

			btnContinuar.Visible     = true;
			btnHonorarios.Visible	 = true;
			btnArrendamiento.Visible = true;

            rdbExistente.Visible    = true;
            rdbNueva.Visible        = true;

			pnlObligaciones.Controls.Clear();
            pnlDictamenes.Controls.Clear();
            pnlISN.Controls.Clear();
        }
        #endregion

        #region FUNCIONES
        /// <summary>
        /// Guarda las obligaciones fiscales marcadas en el listado mostrado
        /// </summary>
        /// <param name="pnlListaObligaciones">Panel de donde se guardaran las obligaciones</param>
        /// <returns></returns>
        public bool GuardarObligaciones(Panel pnlListaObligaciones, int iTipo)
        {
            bool bResultado = false;
            try
            {
                // VALIDA QUE EXISTA AL MENOS UNA OBLIGACIÓN MARCADA
                int ckbxValido = 0;
                foreach (Control control in pnlListaObligaciones.Controls)
                {
                    if (control is LollipopCheckBox)
                    {
                        LollipopCheckBox checkBox = control as LollipopCheckBox;
                        if (checkBox.Checked)
                            ckbxValido = 1;
                    }
                }

                // CONDICIÓN SI EXISTE UNA OBLIGACIÓN MARCADA
                if (ckbxValido == 0)
                {
                    string sTipo = "";
                    switch (iTipo)
                    {
                        case 1:
                            sTipo = "una Obligación Fiscal";
                            break;
                        case 2:
                            sTipo = "un Dictamen";
                            break;
                        case 3:
                            sTipo = "un ISN";
                            break;
                        default:
                            break;
                    }
                    FlatMessageBox.Show(string.Format("Debe seleccionar al menos {0}", sTipo), "OK", string.Empty, FlatMessageBoxIcon.Warning);
                    bResultado = false;
                }
                else
                {
                    // RECORRE LA LISTA DE OBLIGACIONES Y GUARDA LAS QUE SE ENCUENTREN MARCADASEN LA BD
                    foreach (Control control in pnlListaObligaciones.Controls)
                    {
                        if (control is LollipopCheckBox)
                        {
                            // VALIDACIÓN SI SE ENCUENTRA MARCADA LA OBLIGACIÓN SE GUARDA EN LA BD
                            LollipopCheckBox checkBox = control as LollipopCheckBox;
                            if (checkBox.Checked)
                            {
                                new RegistroObligacion().insertarRegistroObligacion(new RegistroObligacion()
								{
									iIdUsuarioRegistra		= int.Parse(AUsuarioData.sIdusuario),
									iIdDetalleObligacion	= int.Parse(checkBox.Name),
									iIdCliente				= frmAsignarObligaciones.iIdCliente
								});
                            }
                        }
                    }
                    bResultado = true;
                }
            }
            catch
            {
                bResultado = false;
            }
            return bResultado;
        }

        /// <summary>
        /// Carga el listado de obligaciones y los muestra
        /// </summary>
        /// <param name="panel">Panel donde se mostraran</param>
        /// <param name="obligaciones">Listado de obligaciones que se mostraran</param>
        /// <param name="iSeparacion">Separación que habra entre cada obligación</param>
        public void cargarObligaciones(Panel panel, List<DetalleObligacion> obligaciones, int iSeparacion)
        {
            //CREA UNA LISTA DINAMICA DE OBLIGACIONES
            for (int i = 0; i < obligaciones.Count; i++)
            {
                MaterialSkin.Controls.MaterialLabel lblObligacion = new MaterialSkin.Controls.MaterialLabel();
                lblObligacion.Location     = new Point(2, 28 * i + iSeparacion);
                lblObligacion.Text         = string.Format("{0}. {1}", (i + 1).ToString(), obligaciones[i].sDetalleObligacion);
                lblObligacion.Width        = 400;
                lblObligacion.AutoEllipsis = true;

                DevExpress.XtraEditors.SeparatorControl separador = new DevExpress.XtraEditors.SeparatorControl();
                separador.LineOrientation = Orientation.Horizontal;
                separador.Size            = new Size(590, 18);// 937, 18
                separador.Location        = new Point(365, lblObligacion.Location.Y + 15);

                panel.Controls.Add(separador);
                panel.Controls.Add(lblObligacion);
                lblObligacion.BringToFront();

                int iDistancia = 480; // 600

                if (bExistente)
                {
                    if (obligaciones[i].iR03 != null)
                    {
                        LollipopCheckBox chkbR1 = new LollipopCheckBox();
                        chkbR1.Name       = obligaciones[i].iR03.Value.ToString();
                        chkbR1.Location   = new Point(iDistancia, lblObligacion.Location.Y);
                        chkbR1.Text       = "";
                        chkbR1.Size       = new Size(20, 20);
                        chkbR1.Cursor     = Cursors.Hand;
                        chkbR1.CheckColor = "#5d4037";

                        if (obligaciones[i].iDefault == 1)
                            chkbR1.Checked = true;

                        panel.Controls.Add(chkbR1);
                        chkbR1.BringToFront();
                    }
                    iDistancia = iDistancia + 50;//200;
                }

                if (bNuevaEmpresa)
                {
                    if (obligaciones[i].iR04 != null)
                    {
                        LollipopCheckBox chkbR2 = new LollipopCheckBox();
                        chkbR2.Name       = obligaciones[i].iR04.Value.ToString();
                        chkbR2.Location   = new Point(iDistancia, lblObligacion.Location.Y);
                        chkbR2.Text       = "";
                        chkbR2.Size       = new Size(20, 20);
                        chkbR2.Cursor     = Cursors.Hand;
                        chkbR2.CheckColor = "#558b2f";

                        if (obligaciones[i].iDefault == 1)
                            chkbR2.Checked = true;

                        panel.Controls.Add(chkbR2);
                        chkbR2.BringToFront();
                    }
                    iDistancia = iDistancia + 50;
                }
                separador.SendToBack();
                panel.AutoScroll = true;
            }
        }

        /// <summary>
        /// Carga el listado de dictamenes y los muestra
        /// </summary>
        /// <param name="panel">Panel donde se mostraran</param>
        /// <param name="obligaciones">Listado de obligaciones que se mostraran</param>
        /// <param name="iSeparacion">Separación que habra entre cada obligación</param>
        public void cargarDictamenes(Panel panel, List<DetalleObligacion> dictamenes, int iSeparacion)
        {
            // Crea una lista dinamica de obligaciones
            for (int i = 0; i < dictamenes.Count; i++)
            {
                MaterialSkin.Controls.MaterialLabel lblDictamen = new MaterialSkin.Controls.MaterialLabel();
                lblDictamen.Location     = new Point(2, 28 * i + iSeparacion);
                lblDictamen.Text         = string.Format("{0}. {1}", (i + 1).ToString(), dictamenes[i].sDetalleObligacion);
                lblDictamen.Width        = 400;
                lblDictamen.AutoEllipsis = true;

                DevExpress.XtraEditors.SeparatorControl separador = new DevExpress.XtraEditors.SeparatorControl();
                separador.LineOrientation = Orientation.Horizontal;
                separador.Size            = new Size(590, 18);// 937, 18
                separador.Location        = new Point(365, lblDictamen.Location.Y + 15);

                panel.Controls.Add(separador);
                panel.Controls.Add(lblDictamen);
                lblDictamen.BringToFront();

                int iDistancia = 480;
                if (dictamenes[i].iR01 != null)
                {
                    LollipopCheckBox chkbR1 = new LollipopCheckBox();
                    chkbR1.Name         = dictamenes[i].iR01.Value.ToString();
                    chkbR1.Location     = new Point(iDistancia, lblDictamen.Location.Y);
                    chkbR1.Text         = "";
                    chkbR1.Size         = new Size(20, 20);
                    chkbR1.Cursor       = Cursors.Hand;
                    chkbR1.CheckColor   = bExistente ? "#5d4037" : "#558b2f";

                    if (dictamenes[i].iDefault == 1)
                        chkbR1.Checked = true;

                    //panel.Controls.Add(chkbR1);
                    //chkbR1.BringToFront();
                }
                iDistancia = iDistancia + 50;
                separador.SendToBack();
                panel.AutoScroll = true;
            }
        }

        /// <summary>
        /// Carga el listado de dictamenes y los muestra
        /// </summary>
        /// <param name="panel">Panel donde se mostraran</param>
        /// <param name="obligaciones">Listado de obligaciones que se mostraran</param>
        /// <param name="iSeparacion">Separación que habra entre cada obligación</param>
        public void cargarISN(Panel panel, List<DetalleObligacion> ISN, int iSeparacion)
        {
            // Crea una lista de obligaciones ISN
            for (int i = 0; i < ISN.Count; i++)
            {
                MaterialSkin.Controls.MaterialLabel lblISN = new MaterialSkin.Controls.MaterialLabel();
                lblISN.Location     = new Point(2, 28 * i + iSeparacion);
                lblISN.Text         = string.Format("{0}. {1}", (i + 1).ToString(), ISN[i].sDetalleObligacion);
                lblISN.Width        = 400;
                lblISN.AutoEllipsis = true;

                DevExpress.XtraEditors.SeparatorControl separador = new DevExpress.XtraEditors.SeparatorControl();
                separador.LineOrientation = Orientation.Horizontal;
                separador.Size            = new Size(590, 18);// 937, 18
                separador.Location        = new Point(365, lblISN.Location.Y + 15);

                panel.Controls.Add(separador);
                panel.Controls.Add(lblISN);
                lblISN.BringToFront();

                int iDistancia = 480;
                if (ISN[i].iR01 != null)
                {
                    LollipopCheckBox chkbR1 = new LollipopCheckBox();
                    chkbR1.Name       = ISN[i].iR01.Value.ToString();
                    chkbR1.Location   = new Point(iDistancia, lblISN.Location.Y);
                    chkbR1.Text       = "";
                    chkbR1.Size       = new Size(20, 20);
                    chkbR1.Cursor     = Cursors.Hand;
                    chkbR1.CheckColor = bExistente ? "#5d4037" : "#558b2f";

                    if (ISN[i].iDefault == 1)
                        chkbR1.Checked = true;

                    panel.Controls.Add(chkbR1);
                    chkbR1.BringToFront();
                }
                iDistancia = iDistancia + 50;
                separador.SendToBack();
                panel.AutoScroll = true;
            }
        }
        #endregion
    }
}