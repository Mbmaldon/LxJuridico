using ClaseData.Clases.AccesoArchivos;
using ClaseData.Clases.Archivo;
using ClaseData.Clases.Archivo.ArchivoEntidades;
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
    public partial class FRRAprobarPropuesta : Form
    {
        int idPropuesta;
        int iApro;
        int iAprob;

        ISPropuesta detalle;
        //ISRutaDocumento rutaArchivo;
        List<ERArchivo> LRuta;
        LinkLabel link;

        //NetworkCredential _NetworkCredential = new NetworkCredential(AccessFiles.sUsuario, AccessFiles.sContraseña);
        //string PathFolderShared = @"\\192.169.143.34\Data_Files";

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FRRAprobarPropuesta(int IdPropuesta, int iAprobacion, int iAprobada)
        {
            InitializeComponent();
            idPropuesta     = IdPropuesta;
            iApro           = iAprobacion;
            iAprob          = iAprobada;
            detalle         = null;

            DSDetalleServicio infoPropuesta = new DSDetalleServicio();
            detalle = infoPropuesta.InfoPropuesta(IdPropuesta);

            LRuta = null;
            CDocumentosOficialia lRuta = new CDocumentosOficialia();
            LRuta = lRuta.rutaArchivosPropuesta(IdPropuesta);

            informacionPropuesta(detalle, iAprobacion, iAprobada);
        }

        /*Función para vaciar la información en los controles visibles del diseño*/
        private void informacionPropuesta(ISPropuesta infPropuesta, int iaprobacion, int iaprobada)
        {
            txtPropuesta.Text = infPropuesta.sPropuesta;

            if (iaprobada > 0)
            {
                if (iaprobacion == 1)
                {
                    rbSI.Checked                = true;
                    rbSI.Enabled                = false;
                    rbNO.Enabled                = false;
                    txtMotivoRechazo.Enabled    = false;
                    btnRegistrar.Visible        = false;
                }
                else if (iaprobacion == 2)
                {
                    rbSI.Enabled                = false;
                    rbNO.Checked                = true;
                    rbNO.Enabled                = false;
                    txtMotivoRechazo.Text       = infPropuesta.sRechazo;
                    txtMotivoRechazo.Visible    = true;
                    btnRegistrar.Visible        = false;
                }
                rutaDocument(LRuta);
            }
            else
            {
                if (iaprobacion == 1)
                {
                    rbSI.Checked            = true;
                    //rbSI.Enabled = false;
                    //rbNO.Enabled = false;
                    //txtMotivoRechazo.Enabled = false;
                    btnRegistrar.Visible    = true;
                }
                else if (iaprobacion == 2)
                {
                    //rbSI.Enabled = false;
                    rbNO.Checked                = true;
                    //rbNO.Enabled = false;
                    txtMotivoRechazo.Text       = infPropuesta.sRechazo;
                    txtMotivoRechazo.Visible    = true;
                    btnRegistrar.Visible        = true;
                }
                rutaDocument(LRuta);
            }
        }

        /*Funcion para generar el link del documento cargado*/
        public void rutaDocument(List<ERArchivo> rta)
        {
            try
            {
                if (rta.Count != 0)
                {
                    for (int i = 0; i < rta.Count; i++)
                    {
                        string nomArchivo   = Path.GetFileName(rta[i].sRuta);
                        link                = new LinkLabel();
                        link.Location       = new Point(20, 15 * i + 2);
                        link.AutoSize       = true;
                        link.Text           = nomArchivo;
                        link.Name           = rta[i].sRuta;
                        link.Click          += Link_Click; ;
                        listArchivos.Controls.Add(link);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        /*Funcion click para lanzar la apertura del archivo seleccionado*/
        private void Link_Click(object sender, EventArgs e)
        {
            LinkLabel ruta = sender as LinkLabel;
            //using (new NetworkConnection(PathFolderShared, _NetworkCredential))
            //{
                System.Diagnostics.Process.Start(ruta.Name);
            //}
        }

        /*Evento CheckedChanged de control checBox para habilitar o deshabiltar controles para alimentar el evento registrado*/
        private void Check_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSI.Checked == true)
            {
                btnCancelar.Visible         = true;
                btnRegistrar.Visible        = true;
                label4.Visible              = false;
                txtMotivoRechazo.Visible    = false;
            }
            else if (rbNO.Checked == true)
            {
                btnCancelar.Visible         = true;
                btnRegistrar.Visible        = true;
                label4.Visible              = true;
                txtMotivoRechazo.Visible    = true;
            }
        }

        /*Evento click boton registrar la aprobación de la propuesta de respuesta*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int iDesicion;
            string Rechazo;
            if (rbSI.Checked == true)
            {
                iDesicion = 1;
                Rechazo = " ";
                new Solicitud().AprobacionPropuesta(iDesicion, idPropuesta, Rechazo);
                DialogResult r = MessageBox.Show("Se ha registrado la aprobación exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (r == DialogResult.OK)
                {
                    Close();
                }
            }

            else if (rbNO.Checked == true)
            {
                iDesicion = 0;

                if (txtMotivoRechazo.Text != string.Empty)
                {
                    Rechazo = txtMotivoRechazo.Text;

                    new Solicitud().AprobacionPropuesta(iDesicion, idPropuesta, Rechazo);
                    DialogResult r = MessageBox.Show("Se ha registrado la aprobación exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (r == DialogResult.OK)
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario registrar le motivo de rechazo", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento KeyPress evita la escritura de texto en el control si ya fue aprobada*/
        private void txtMotivoRechazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (iAprob > 0)
            {
                e.Handled = true;
            }
        }
    }
}
