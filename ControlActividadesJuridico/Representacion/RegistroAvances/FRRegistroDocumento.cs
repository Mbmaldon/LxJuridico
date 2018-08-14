using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Solicitud;
using ClaseData.Clases.Solicitud.Entidades;
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
    public partial class FRRegistroDocumento : Form
    {
        
        ISDocumento         detalle;
        ISRutaDocumento     rutaDocument;
        private LinkLabel   link;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRRegistroDocumento(int iIdDocumento, int iRecibido)
        {
            InitializeComponent();

            detalle = null;
            DDRegistrado detalleDocumento = new DDRegistrado();
            detalle = detalleDocumento.documentoRegistrado(iIdDocumento);
            DetalleDocumento(detalle, iRecibido);

            rutaDocument = null;
            rutaDocument = detalleDocumento.rutaDocumentoRegistrado(iIdDocumento);
            rutaArchivo(rutaDocument);
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void DetalleDocumento(ISDocumento Info, int iRec)
        {
            txtRequ.Text    = Info.sRequisicion.ToString();
            lblReq.Text     = Info.sTipoReq.ToString();

            if (iRec == 1)
            {
                rbSI.Checked = true;
            }
        }

        /*Función para generar linkLabel para el archivo adjunto*/
        private void rutaArchivo(ISRutaDocumento rta)
        {
            try
            {
                if (rta != null)
                {
                    string nomAr        = Path.GetFileName(rutaDocument.sRutaArchivo.ToString());
                    link                = new LinkLabel();
                    link.Location       = new Point(108, 106);
                    link.Name           = rutaDocument.sRutaArchivo.ToString();
                    link.AutoSize       = true;
                    link.Text           = nomAr;
                    link.LinkClicked    += Link_LinkClicked;
                    frm2.Controls.Add(link);
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Evento click de cerrar formulario*/
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
