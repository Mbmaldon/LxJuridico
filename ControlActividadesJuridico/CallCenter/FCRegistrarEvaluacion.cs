using ClaseData.Clases.CallCenter;
using ClaseData.Clases.CallCenter.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico.CallCenter
{
    public partial class FCRegistrarEvaluacion : Form
    {
        int idCallCenter;
        int iTotalRegistro;

        /*Funciones que se inicializan cuando el formulario es llamado*/
        public FCRegistrarEvaluacion(int iIdCallCenter, int iRegistro)
        {
            InitializeComponent();

            idCallCenter    = iIdCallCenter;
            iTotalRegistro  = iRegistro;
            this.Size       = new Size(647, 150);
            btnCancelar.Location = new Point(28, 78);
            evaluaciones();
        }

        /*Evento CheckedChanged de control redioButton en el cual dependiendo lo seleccionado habilta controles*/
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            LimpiarControles();
            if (rbSI.Checked == true)
            {
                this.Size               = new Size(647, 462);
                btnCancelar.Location    = new Point(21, 380);
                btnRegistrar.Location   = new Point(553, 380);
                btnRegistrar.Visible    = true;
                this.CenterToScreen();
                groupBox2.Visible       = true;
                groupBox3.Visible       = false;
            }
            else if (rbNO.Checked == true)
            {
                this.Size               = new Size(647, 308);
                btnCancelar.Location    = new Point(21, 234);
                btnRegistrar.Location   = new Point(553, 234);
                btnRegistrar.Visible    = true;
                this.CenterToScreen();
                groupBox2.Visible       = false;
                groupBox3.Visible       = true;
            }
        }

        EEvaluaciones eEvaluaciones;

        /*Función para realizar la carga de información en los controles para realizar la evaluación*/
        public void evaluaciones()
        {
            DListaEvaluaciones listaEva1        = new DListaEvaluaciones();
            List<EEvaluaciones> lEvaluaciones1  = listaEva1.listaEvaluaciones();

            DListaEvaluaciones listaEva2        = new DListaEvaluaciones();
            List<EEvaluaciones> lEvaluaciones2  = listaEva2.listaEvaluaciones();

            DListaEvaluaciones listaEva3        = new DListaEvaluaciones();
            List<EEvaluaciones> lEvaluaciones3  = listaEva3.listaEvaluaciones();

            DListaEvaluaciones listaEva4        = new DListaEvaluaciones();
            List<EEvaluaciones> lEvaluaciones4  = listaEva4.listaEvaluaciones();

            DListaEvaluaciones listaEva5        = new DListaEvaluaciones();
            List<EEvaluaciones> lEvaluaciones5  = listaEva5.listaEvaluaciones();

            DListaEvaluaciones listaEva6        = new DListaEvaluaciones();
            List<EEvaluaciones> lEvaluaciones6  = listaEva6.listaEvaluaciones();

            this.cmbP1.DataSource       = lEvaluaciones1;
            this.cmbP1.ValueMember      = "sIdEvaluacion";
            this.cmbP1.DisplayMember    = "sEvaluacion";
            this.cmbP1.SelectedIndex    = -1;

            this.cmbP2.DataSource       = lEvaluaciones2;
            this.cmbP2.ValueMember      = "sIdEvaluacion";
            this.cmbP2.DisplayMember    = "sEvaluacion";
            this.cmbP2.SelectedIndex    = -1;

            this.cmbP3.DataSource       = lEvaluaciones3;
            this.cmbP3.ValueMember      = "sIdEvaluacion";
            this.cmbP3.DisplayMember    = "sEvaluacion";
            this.cmbP3.SelectedIndex    = -1;

            this.cmbP4.DataSource       = lEvaluaciones4;
            this.cmbP4.ValueMember      = "sIdEvaluacion";
            this.cmbP4.DisplayMember    = "sEvaluacion";
            this.cmbP4.SelectedIndex    = -1;

            this.cmbP5.DataSource       = lEvaluaciones5;
            this.cmbP5.ValueMember      = "sIdEvaluacion";
            this.cmbP5.DisplayMember    = "sEvaluacion";
            this.cmbP5.SelectedIndex    = -1;

            this.cmbP6.DataSource       = lEvaluaciones6;
            this.cmbP6.ValueMember      = "sIdEvaluacion";
            this.cmbP6.DisplayMember    = "sEvaluacion";
            this.cmbP6.SelectedIndex    = -1;

        }

        /*Función para limpiar controles cuando es requerido*/
        public void LimpiarControles()
        {
            txtComentario.Clear();
            txtObservaciones.Clear();
        }

        /*Evento click de boton cancelar para cerrar formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*Evento click boton registrar evaluacion realizada*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int    p1;
            int    p2;
            int    p3;
            int    p4;
            int    p5;
            int    p6;
            string p7;

            if (rbSI.Checked == true)
            {
                if (cmbP1.Text != string.Empty && cmbP2.Text != string.Empty && cmbP3.Text != string.Empty && cmbP4.Text != string.Empty && cmbP5.Text != string.Empty && cmbP6.Text != string.Empty)
                {
                    eEvaluaciones = (EEvaluaciones)cmbP1.SelectedItem;
                    p1 = int.Parse(eEvaluaciones.sIdEvaluacion);

                    eEvaluaciones = (EEvaluaciones)cmbP2.SelectedItem;
                    p2= int.Parse(eEvaluaciones.sIdEvaluacion);

                    eEvaluaciones = (EEvaluaciones)cmbP3.SelectedItem;
                    p3 = int.Parse(eEvaluaciones.sIdEvaluacion);

                    eEvaluaciones = (EEvaluaciones)cmbP4.SelectedItem;
                    p4 = int.Parse(eEvaluaciones.sIdEvaluacion);

                    eEvaluaciones = (EEvaluaciones)cmbP5.SelectedItem;
                    p5 = int.Parse(eEvaluaciones.sIdEvaluacion);

                    eEvaluaciones = (EEvaluaciones)cmbP6.SelectedItem;
                    p6 = int.Parse(eEvaluaciones.sIdEvaluacion);

                    if (txtComentario.Text != string.Empty)
                    {
                        p7 = txtComentario.Text;
                    }
                    else
                    {
                        p7 = " ";
                    }

                    DialogResult ap = MessageBox.Show("¿Estas seguro de registrar esta evaluación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (ap == DialogResult.Yes)
                    {
                        if (iTotalRegistro < 3)
                        {

                            new CCRegistroEvaluacion().registroEvaluacionServicio(idCallCenter
                                                                                  , p1
                                                                                  , p2
                                                                                  , p3
                                                                                  , p4
                                                                                  , p5
                                                                                  , p6
                                                                                  , p7
                                                                                  , true
                                                                                  , " ");
                            Close();
                        }
                        else
                        {
                            DialogResult rg = MessageBox.Show("Este es el ultimo intento para registrar la evaluación de servicio" + Environment.NewLine + 
                                                              "¿Deseas proseguir con el registro de la evaluación?",  "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (rg == DialogResult.Yes)
                            {
                                new CCRegistroEvaluacion().registroEvaluacionServicio(idCallCenter
                                                                                      , p1
                                                                                      , p2
                                                                                      , p3
                                                                                      , p4
                                                                                      , p5
                                                                                      , p6
                                                                                      , p7
                                                                                      , true
                                                                                      , " ");
                                Close();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario registrar la evaluacion de cada pregunta", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else if (rbNO.Checked ==  true)
            {
                if (txtObservaciones.Text != string.Empty)
                {
                    DialogResult ap = MessageBox.Show("¿Estas seguro de registrar esta evaluación?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ap == DialogResult.Yes)
                    {
                       new CCRegistroEvaluacion().registroEvaluacionServicio(idCallCenter
                                                                             , 1
                                                                             , 1
                                                                             , 1
                                                                             , 1
                                                                             , 1
                                                                             , 1
                                                                             , " "
                                                                             , false
                                                                             , txtObservaciones.Text);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Es necesario registrar las observaciones del porque no se contacta al cliente", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
    }
}
