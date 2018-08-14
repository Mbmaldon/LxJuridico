using ClaseData.Clases;
using ClaseData.Clases.Archivo;
using ClaseData.Clases.Archivo.ArchivoEntidades;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.DetalleServicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRDetallesOficialiaT : Form
    {
        int iIdOficial;
        int idUsuario;
        string nomArchivo;
        EDetalleOficilia detalle;
        List<ERArchivo> LRuta;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRDetallesOficialiaT(int iIdOficialia)
        {
            InitializeComponent();
            iIdOficial = iIdOficialia;
        }

        /*Evento Load del formulario para realizar la carga de informacion cuando sea requerido*/
        private void FRDetallesOficialiaT_Load(object sender, EventArgs e)
        {
            //DatosUsuario ADatosUsuario = DatosUsuario.Instancia;
            LogicaCC.Logica.UsuarioData AUsuarioData = LogicaCC.Logica.UsuarioData.Instancia;
            idUsuario = int.Parse(AUsuarioData.sIdusuario);

            detalle = null;
            DEvento detalleEve = new DEvento();
            detalle = detalleEve.infoOficialia(iIdOficial);
            detallesOficialia(detalle);

            CDocumentosOficialia Archivos = new CDocumentosOficialia();
            LRuta = Archivos.listaDocumentos(iIdOficial);

            if (LRuta.Count != 0)
            {
                for (int i = 0; i < LRuta.Count; i++)
                {
                    nomArchivo              = Path.GetFileName(LRuta[i].sRuta);
                    LinkLabel lnkDocumento  = new LinkLabel();
                    lnkDocumento.Text       = nomArchivo;
                    lnkDocumento.AutoSize   = true;
                    lnkDocumento.Location   = new Point(20, 15 * i + 2);
                    lnkDocumento.Name       = LRuta[i].sRuta;
                    lnkDocumento.Click      += LnkDocumento_Click;
                    listArchivos.Controls.Add(lnkDocumento);
                }
            }
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void detallesOficialia(EDetalleOficilia detOficilia)
        {
            if (detOficilia.sExpOrigen == " ")
            {
                txtExpOrigen.Text = string.Empty;
            }
            else
            {
                txtExpOrigen.Text = detOficilia.sExpOrigen;
            }
            if (detOficilia.sNumExpediente == " ")
            {
                txtNumExp.Text = string.Empty;
            }
            else
            {
                txtNumExp.Text = detOficilia.sNumExpediente;
            }

            if (detOficilia.sJuzgado == " ")
            {
                txtJuzgado.Text = string.Empty;
            }
            else
            {
                txtJuzgado.Text = detOficilia.sJuzgado;
            }

            if (detOficilia.sContraparte == " ")
            {
                txtContraparte.Text = string.Empty;
            }
            else
            {
                txtContraparte.Text = detOficilia.sContraparte;
            }
            if (detOficilia.sTipoJuicio == " ")
            {
                txtTJuicio.Text = string.Empty;
            }
            else
            {
                txtTJuicio.Text = detOficilia.sTipoJuicio;
            }

            txtDescripcion.Text = detOficilia.sOficialia;
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void LnkDocumento_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            System.Diagnostics.Process.Start(ruta.Name);
        }

        /*Evento click de boton cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento KeyPress evita la escritura de texto en el control*/
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
