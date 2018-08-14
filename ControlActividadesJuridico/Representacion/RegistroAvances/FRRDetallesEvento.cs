using ClaseData.Clases.AccesoArchivos;
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
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.Representacion.RegistroAvances
{
    public partial class FRRDetallesEvento : Form
    {
        string nomArchivo;
        EDetalleEvento detalle;
        List<ERArchivo> LRuta;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRRDetallesEvento(int iIdEvento)
        {
            InitializeComponent();
            DEvento detalleEve = new DEvento();
            detalle = detalleEve.infoEvento(iIdEvento);
            detallesEvento(detalle);

            CDocumentosOficialia Archivos = new CDocumentosOficialia();
            LRuta = Archivos.listaArchivoEvento(iIdEvento);

            if (LRuta.Count != 0)
            {
                for (int i = 0; i < LRuta.Count; i++)
                {
                    nomArchivo = Path.GetFileName(LRuta[i].sRuta);
                    LinkLabel lnkDocumento = new LinkLabel();
                    lnkDocumento.Text = nomArchivo;
                    lnkDocumento.AutoSize = true;
                    lnkDocumento.Location = new Point(5, 15 * i + 2);
                    lnkDocumento.Name = LRuta[i].sRuta;
                    lnkDocumento.Click += LnkDocumento_Click;
                    listArchivos.Controls.Add(lnkDocumento);
                }
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void LnkDocumento_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        public void detallesEvento(EDetalleEvento Evento)
        {
            //if (Evento.sExpOrigen == " ")
            //{
            //    txtExpOrigen.Text = string.Empty;
            //}
            //else
            //{
            //    txtExpOrigen.Text = Evento.sExpOrigen;
            //}
            if (Evento.sNumExpediente == " ")
            {
                txtNumExp.Text = string.Empty;
            }
            else
            {
                txtNumExp.Text = Evento.sNumExpediente;
            }

            if (Evento.sJuzgado == " ")
            {
                txtJuzgado.Text = string.Empty;
            }
            else
            {
                txtJuzgado.Text = Evento.sJuzgado;
            }

            if (Evento.sContraparte == " ")
            {
                txtContraparte.Text = string.Empty;
            }
            else
            {
                txtContraparte.Text = Evento.sContraparte;
            }
            if (Evento.sTipoJuicio == " ")
            {
                txtTJuicio.Text = string.Empty;
            }
            else
            {
                txtTJuicio.Text = Evento.sTipoJuicio;
            }

            //if (Evento.sDecripcionActo == " ")
            //{
            //    txtDescripActo.Text = string.Empty;
            //}
            //else
            //{
            //    txtDescripActo.Text = Evento.sDecripcionActo;
            //}

            txtEvento.Text          = Evento.sEvento;
            txtTarea.Text           = Evento.sTarea;
            dtpTeminoLegal.Text     = Evento.sFTerLegal;
            dtpTerminoInterno.Text  = Evento.sFTerInterno;
            txtDescripcion.Text     = Evento.sPropuesta;

        }

        /*Evento KeyPress evita la escritura de texto en el control*/
        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /*Evento click de cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
