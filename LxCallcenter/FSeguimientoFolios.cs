using AxWMPLib;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class FSeguimientoFolios : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        FPrincipal _frmPrincipal;

        List<Caso> LCaso;
        List<CasoHistorial> LCasoHistorial;

        public FSeguimientoFolios()
        {
            InitializeComponent();
        }

        #region Eventos
        #endregion

        #region Funciones
        #endregion

        public void BtnFolio_Click(object sender, EventArgs e)
        {
            Button btnFolio = sender as Button;
            StopPlayer();
            //scFoliosAbiertos.Panel2.Controls.Clear();

            Caso caso = new Caso().InformacionCaso(int.Parse(btnFolio.Name));
            lblTitulo.Text        = "Detalles Folio " + caso.iIdCaso;
            lblMotivo.Text        = string.Format("Tipo de Llamada{0}{1}", Environment.NewLine, caso.sMotivo);
            lblFechaCreacion.Text = string.Format("Fecha de Solicitud{0}{1}", Environment.NewLine, caso.dtFechaCreacion);
            lblFechaCierre.Text   = string.Format("Fecha de Cierre{0}{1}", Environment.NewLine, caso.sFechaCierre);
            lblCliente.Text       = string.Format("No. cliente{0}{1}", Environment.NewLine, caso.sCliente);
            lblClienteNombre.Text = string.Format("Cliente{0}{1} {2}  {3}", Environment.NewLine, caso.sNombre, caso.sAPaterno, caso.sAMaterno);
            lblContador.Text      = string.Format("Contador{0}{1} {2} {3}", Environment.NewLine, caso.sContadorNombre, caso.sContadorAPaterno, caso.sContadorAMaterno);
            txtComentario.Text    = string.Format("Comentario{0}{1}", Environment.NewLine, caso.sDescripcion);



            //SE GENERA UNA LISTA DE CASOS
            CasoHistorial casoHistorial = new CasoHistorial();
            LCasoHistorial = casoHistorial.GetListCasoHistorial(caso.iIdCaso);
            for (int i = 0; i < LCasoHistorial.Count; i++)
            {
                //SE CREA UNA LISTA DE BOTONES
                Button btnHistorial     = new Button();
                btnHistorial.Location   = new Point(0, 24 * i + 0);
                btnHistorial.Name       = LCasoHistorial[i].iIdCasoHistorial.ToString();
                btnHistorial.Text       = "  " + LCasoHistorial[i].dtFechaCreacion.ToString();
                btnHistorial.Font       = new Font("Segoe UI", 9);
                btnHistorial.ForeColor  = Color.FromArgb(105, 105, 105);
                btnHistorial.Width      = 180;//225
                btnHistorial.Height     = 24;
                btnHistorial.FlatStyle  = FlatStyle.Flat;
                btnHistorial.FlatAppearance.BorderSize = 0;
                btnHistorial.Anchor     = AnchorStyles.Left | AnchorStyles.Right;
                btnHistorial.TextAlign  = ContentAlignment.MiddleLeft;
                btnHistorial.Cursor     = Cursors.Hand;
                btnHistorial.Image      = Properties.Resources.clock_16px1;
                btnHistorial.ImageAlign = ContentAlignment.TopLeft;
                btnHistorial.TextImageRelation = TextImageRelation.ImageBeforeText;

                //EVENTO CLICK DEL BOTON HISTORIAL
                btnHistorial.Click += (s, ev) =>
                {
                    sCHistorial.Panel2.Controls.Clear();
                    CasoHistorial casoH         = new CasoHistorial().GetInfoCasoHistorial(int.Parse(btnHistorial.Name));

                    //SE GENERA LABEL QUE CONTENDRA LA FECHA DEL HISTORICO
                    Label lblFechaCreacionH     = new Label();
                    lblFechaCreacionH.Width     = 200;
                    lblFechaCreacionH.Height    = 45;
                    lblFechaCreacionH.Location  = new Point(10, 15);
                    lblFechaCreacionH.Font      = new Font("Calibri Light", 11);
                    lblFechaCreacionH.Text      = string.Format("Por{0}{1}", Environment.NewLine, casoH.sUsuario);

                    //SE GENERA UN ACONTROL RICHTEXTBOX DONDE SE AGREGARA EL COMENTARIO DEL HISTORICO
                    RichTextBox txtComentarioH   = new RichTextBox();
                    txtComentarioH.Text          = string.Format("Comentario{0}{1}", Environment.NewLine, casoH.sComentario);
                    txtComentarioH.Location      = new Point(10, 65);//29, 8
                    txtComentarioH.Font          = new Font("Calibri Light", 11);//122,23
                    txtComentarioH.Width         = 250;//470
                    txtComentarioH.Height        = 80;
                    txtComentarioH.Anchor        = AnchorStyles.Left | AnchorStyles.Right;
                    txtComentarioH.BorderStyle   = BorderStyle.None;
                    txtComentarioH.ReadOnly      = true;
                    txtComentarioH.BackColor     = Color.White;

                    sCHistorial.Panel2.Controls.Add(txtComentarioH);
                    sCHistorial.Panel2.Controls.Add(lblFechaCreacionH);                                   
                };

                sCHistorial.Panel1.Controls.Add(btnHistorial);
            }


			
            //SE GENERA BOTON PARA CERRAR FOLIO(SOLO SI EL FOLIO ESTA ABIERTO)
            MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrarFolio = new MaterialSkin.Controls.MaterialRaisedButtonCustom();
            btnCerrarFolio.Location = new Point(699, 18); //745, 18
            btnCerrarFolio.Name     = caso.iIdCaso.ToString();
            btnCerrarFolio.Text     = "Cerrar Folio";
            btnCerrarFolio.Width    = 105;//160
            btnCerrarFolio.Height   = 23;
            btnCerrarFolio.Anchor   = AnchorStyles.Right | AnchorStyles.Top;
            btnCerrarFolio.Cursor   = Cursors.Hand;
            btnCerrarFolio.Tag      = caso.sMotivo;
            btnCerrarFolio.BGColor  = "#304FFE";            
            btnCerrarFolio.Click += BtnCerrarFolio_Click;

            //AGREGAMOS LOS CONTROLES AL PANEL 2
            //scFoliosAbiertos.Panel2.Controls.Add(pctInfo);
            //scFoliosAbiertos.Panel2.Controls.Add(lblTitulo);
            //scFoliosAbiertos.Panel2.Controls.Add(lblMotivo);
            //scFoliosAbiertos.Panel2.Controls.Add(lblFechaCreacion);
            //scFoliosAbiertos.Panel2.Controls.Add(lblFechaCierre);
            //scFoliosAbiertos.Panel2.Controls.Add(lblCliente);
            //scFoliosAbiertos.Panel2.Controls.Add(lblClienteNombre);
            //scFoliosAbiertos.Panel2.Controls.Add(lblContador);
            //scFoliosAbiertos.Panel2.Controls.Add(txtComentario);
            //scFoliosAbiertos.Panel2.Controls.Add(lblHistorial);
            //scFoliosAbiertos.Panel2.Controls.Add(sCHistorial);
            //scFoliosAbiertos.Panel2.Controls.Add(sCGrabaciones);

            if(caso.bActivo)
                scFoliosAbiertos.Panel2.Controls.Add(btnCerrarFolio);
        }

        private void StopPlayer()
        {
            foreach (Control x in scFoliosAbiertos.Panel2.Controls)
            {
                if (x is SplitContainer)
                {
                    if(x.Name == "sCGrabaciones")
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

        
        private void BtnCerrarFolio_Click(object sender, EventArgs e)
        {
            MaterialSkin.Controls.MaterialRaisedButtonCustom btnCerrarFolio = sender as MaterialSkin.Controls.MaterialRaisedButtonCustom;

            _frmPrincipal = Application.OpenForms["FPrincipal"] as FPrincipal;

            if (FlatMessageBox.Show(string.Format("¿Está seguro de cerrar el folio no. {0}?", btnCerrarFolio.Name), "SI", "NO", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
                frmComentarioCerrarFolio.Show(_frmPrincipal, int.Parse(btnCerrarFolio.Name), btnCerrarFolio);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != string.Empty)
            {
                lblCampoRequerido.Visible = false;
                cargarFoliosBusqueda(0, 40, 230);
            }
            else
                lblCampoRequerido.Visible = true;
        }

        /// <summary>
        /// Método para cargar una lista de folios
        /// </summary>
        /// <param name="x">Medida para agulo X de la lista</param>
        /// <param name="y">Medida para angulo Y de la lista</param>
        /// <param name="xB">Tamaño X de los botones de la lista</param>
        public void cargarFoliosBusqueda(int x, int y, int xB)
        {
            Caso caso = new Caso();
            LCaso = caso.LTodosBusqueda(txtCliente.Text);
            if (LCaso.Count != 0)
            {
                scFoliosAbiertos.Panel1.Controls.Clear();
                Label lblTitulo      = new Label();
                lblTitulo.Text       = "Folios";
                lblTitulo.Location   = new Point(85, 8);//29, 8
                lblTitulo.Font       = new Font("Calibri Light", 14);//122,23
                lblTitulo.Anchor     = AnchorStyles.Top;
                lblTitulo.TextAlign  = ContentAlignment.TopLeft;
                lblTitulo.Width      = 122;
                scFoliosAbiertos.Panel1.Controls.Add(lblTitulo);

                for (int i = 0; i < LCaso.Count; i++)
                {
                    PictureBox ptbMarca = new PictureBox();
                    ptbMarca.Image      = Properties.Resources.new_moon_filled_10px;
                    ptbMarca.Location   = new Point(14, 24 * i + 45);
                    ptbMarca.SizeMode   = PictureBoxSizeMode.StretchImage;
                    ptbMarca.BackColor  = Color.Transparent;
                    ptbMarca.Width      = 7;
                    ptbMarca.Height     = 7;

                    Button btnFolio     = new Button();
                    btnFolio.Location   = new Point(x, 24 * i + y);/*new Point(0, 24 * i + -50);*/
                    btnFolio.Name       = LCaso[i].iIdCaso.ToString();
                    btnFolio.Text       = string.Format("   Folio: {0}     {1}", LCaso[i].iIdCaso, LCaso[i].sCliente);
                    btnFolio.Font       = new Font("Segoe UI", 9);
                    btnFolio.ForeColor  = Color.FromArgb(105, 105, 105);
                    btnFolio.Width      = scFoliosAbiertos.Panel1.Width - 5;//200//xB
                    btnFolio.Height     = 24;
                    btnFolio.FlatStyle  = FlatStyle.Flat;
                    btnFolio.FlatAppearance.BorderSize = 0;
                    btnFolio.TextAlign  = ContentAlignment.MiddleLeft;
                    btnFolio.Cursor     = Cursors.Hand;
                    btnFolio.Image      = Properties.Resources.phone_16px1;
                    btnFolio.ImageAlign = ContentAlignment.MiddleLeft;
                    btnFolio.TextImageRelation = TextImageRelation.ImageBeforeText;

                    btnFolio.Click += BtnFolio_Click;

                    if (LCaso[i].bActivo)
                        scFoliosAbiertos.Panel1.Controls.Add(ptbMarca);
                    scFoliosAbiertos.Panel1.Controls.Add(btnFolio);
                }
                scFoliosAbiertos.Visible = true;
            }
            else
            {
                //MessageBox.Show("No se encontraron folios de este clientes");
                StopPlayer();
                scFoliosAbiertos.Panel1.Controls.Clear();
                //scFoliosAbiertos.Panel2.Controls.Clear();
                Label lblTitulo      = new Label();
                lblTitulo.Text       = "Folios";
                lblTitulo.Location   = new Point(85, 8);//29, 8
                lblTitulo.Font       = new Font("Calibri Light", 14);//122,23
                lblTitulo.Anchor     = AnchorStyles.Top;
                lblTitulo.TextAlign  = ContentAlignment.TopLeft;
                lblTitulo.Width      = 122;


                Label lblNotifica = new Label();
                lblNotifica.Text = string.Format("No Se Encontraron{0}Folios del Cliente.", Environment.NewLine);
                lblNotifica.Location = new Point(30, 100);
                lblNotifica.Font = new Font("Segoe UI", 13);
                lblNotifica.Width = 180;
                lblNotifica.Height = 100;
                lblNotifica.ForeColor = Color.FromArgb(200, 200, 200);//105
                lblNotifica.TextAlign = ContentAlignment.MiddleCenter;

                scFoliosAbiertos.Panel1.Controls.Add(lblNotifica);
                scFoliosAbiertos.Panel1.Controls.Add(lblTitulo);
            }
            scFoliosAbiertos.Visible = true;
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
            if (e.KeyChar == (char)13)
                btnBuscar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cancelar();
        }

        public void cancelar()
        {
            txtCliente.Text          = "";
            scFoliosAbiertos.Visible = false;
            scFoliosAbiertos.Panel1.Controls.Clear();
            //scFoliosAbiertos.Panel2.Controls.Clear();
        }
    }
}
