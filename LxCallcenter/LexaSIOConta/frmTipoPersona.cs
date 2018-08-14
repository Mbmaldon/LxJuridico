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
    public partial class frmTipoPersona : Form
    {
        public frmTipoPersona()
        {
            InitializeComponent();

            ////VALIDA SI EL CLIENTE YA TIENE UN TIPO DE PERSONA ASIGNADO
            LogicaCC.LexaSIOContaLogica.TipoPersona tipoPersona = new LogicaCC.LexaSIOContaLogica.TipoPersona();
            tipoPersona = new LogicaCC.LexaSIOContaLogica.TipoPersona().validarPersona(frmAsignarObligaciones.iIdCliente);

            if (!(tipoPersona == null))
                btnSaltarAsignacion.Visible = true;
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

                if (!sForm.Equals("Login") && !sForm.Equals("FPrincipal") && !sForm.Equals("EnviarMensajes") && !sForm.Equals("frmDirectorio") && !sForm.Equals("frmTelefono") && !sForm.Equals("frmTelefonoConfigurar"))
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

        #region EVENTOS
        private void btnPFisica_Click(object sender, EventArgs e)
        {
            //ASIGNAMOS EL TIPO DE PERSONA A FÍSICA
            new LogicaCC.LexaSIOContaLogica.TipoPersona().bAsignarTipoPersona(new LogicaCC.LexaSIOContaLogica.TipoPersona()
            {
                iIdTipoPersona = 2,
                iIdCliente     = frmAsignarObligaciones.iIdCliente
            });
            frmObligacionesPFisica _frmObligacionesPFisica = new frmObligacionesPFisica();
            frmObligacionesPFisica ObligacionesPFisica     = _frmObligacionesPFisica ?? new frmObligacionesPFisica();
            MostrarForm(ObligacionesPFisica);
        }

        private void btnPMoral_Click(object sender, EventArgs e)
        {
            //ASIGNAMOS EL TIPO DE PERSONA A MORAL
            new LogicaCC.LexaSIOContaLogica.TipoPersona().bAsignarTipoPersona(new LogicaCC.LexaSIOContaLogica.TipoPersona()
            {
                iIdTipoPersona = 3,
                iIdCliente     = frmAsignarObligaciones.iIdCliente
            });
            frmObligacionesPMoral _frmObligacionesPMoral = new frmObligacionesPMoral();
            frmObligacionesPMoral ObligacionesPMoral     = _frmObligacionesPMoral ?? new frmObligacionesPMoral();
            MostrarForm(ObligacionesPMoral);
        }

        private void btnSaltarAsignacion_Click(object sender, EventArgs e)
        {
            //CIERRA EL FORM E INICIA UNA NUEVA INSTANCIA DEL FORM FRMONOCIOOBLIGACIONES
            //SALTANDO LA ASIGNACIÓN DE TIPO DE PERSONA.
            frmInicioContadores _frmInicioContadores = new frmInicioContadores();
            frmInicioContadores InicioContadores = _frmInicioContadores ?? new frmInicioContadores();
            MostrarForm(InicioContadores);
        }

        private void frmTipoPersona_Load(object sender, EventArgs e)
        {
            ////VALIDA SI EL CLIENTE YA TIENE UN TIPO DE PERSONA ASIGNADO
            //LogicaCC.LexaSIOContaLogica.TipoPersona tipoPersona = new LogicaCC.LexaSIOContaLogica.TipoPersona();
            //tipoPersona = new LogicaCC.LexaSIOContaLogica.TipoPersona().validarPersona(AltaCliente.iIdCliente);

            //if (!(tipoPersona == null))
            //{
            //    foreach (Form frm in Application.OpenForms)
            //    {
            //        if (frm.Name == "FPrincipal")
            //        {
            //            _frmPrincipal = frm as FPrincipal;
            //            break;
            //        }
            //    }
            //    if (FlatMessageBox.Show(_frmPrincipal, string.Format("Este cliente ya ha sido asignado como PERSONA {0}.{1}Para omitir el siguiente paso, pulse el botón omitir o continuar para seguir.", tipoPersona.sTipoPersona, Environment.NewLine), "Omitir", "Continuar") == DialogResult.No)
            //    {
            //        btnSaltarAsignacion.Visible = true;
            //    }
            //    else
            //    {
            //        frmInicioContadores _frmInicioContadores = new frmInicioContadores();
            //        frmInicioContadores InicioContadores = _frmInicioContadores ?? new frmInicioContadores();
            //        MostrarForm(InicioContadores);
            //    }                
            //}
        }
        #endregion
    }
}
