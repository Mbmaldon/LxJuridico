using ClaseData.Clases.AltaUsuario;
using ClaseData.Clases.AltaUsuario.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlActividadesJuridico
{
    public partial class FAltaUsuario : Form
    {
        int validaCampos = 0;

        cTipoUsuario lTipoUsuarios;
        cMateria lMateria;

        public FAltaUsuario()
        {
            InitializeComponent();
        }
       
        private void FAltaUsuario_Load(object sender, EventArgs e)
        {
            //Se consume instancia para cargar combobox con los tipos de usuarios
            DatosTipoUsuarios ATipoUsuario      = new DatosTipoUsuarios();
            List<cTipoUsuario> LTipoUsuarios    = ATipoUsuario.listaTiposUsuarios();
            this.cmbTipoUsuario.DataSource      = LTipoUsuarios;
            this.cmbTipoUsuario.ValueMember     = "sIdUsuarioTipo";
            this.cmbTipoUsuario.DisplayMember   = "sUsuarioTipo";
            this.cmbTipoUsuario.SelectedIndex   = -1;
            //this.cmbTipoUsuario.SelectedItem = 1;

            //Se consume instancia para cargar combobox de las materias
            DatosMaterias AMateria          = new DatosMaterias();
            List<cMateria> LMateria         = AMateria.listaMaterias();
            this.cmbMateria.DataSource      = LMateria;
            this.cmbMateria.ValueMember     = "sIdMateria";
            this.cmbMateria.DisplayMember   = "sMateria";
            //this.cmbMateria.SelectedIndex = -1;
            //this.cmbTipoUsuario.SelectedItem = 1;
        }

        /*Evento click de boton Registrar para dar de alta a un nuevo usuario*/
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int     iMateria;
            int     iTipoUsuario;

            string  sAMaterno;
            string  sTelefono;
            string  sExtension;

            validarCampos();

            if (txtAMaterno.Text == string.Empty)
            {
                sAMaterno = " ";
            }
            else
            {
                sAMaterno = txtAMaterno.Text;
            }

            if (txtTelefono.Text == string.Empty)
            {
                sTelefono = " ";
            }
            else
            {
                sTelefono = txtTelefono.Text;
            }

            if (txtExtensión.Text == string.Empty)
            {
                sExtension = " ";
            }
            else
            {
                sExtension = txtExtensión.Text;
            }

            if (cmbMateria.Text == string.Empty)
            {
                iMateria = 1;
            }
            else
            {
                lMateria = (cMateria)cmbMateria.SelectedItem;
                iMateria = int.Parse(lMateria.sIdMateria);
            }

            if (validaCampos > 0)
            {
                MessageBox.Show("Es necesario ingresar la información marcada con un *", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lTipoUsuarios   = (cTipoUsuario)cmbTipoUsuario.SelectedItem;
                iTipoUsuario    = int.Parse(lTipoUsuarios.sIdUsuarioTipo);

                DialogResult rs = MessageBox.Show("Esta seguro de realizar el registro de este usuario.", "Mensaje", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    new cAltaUsuario().AltaUsuario(iTipoUsuario, iMateria, txtNombre.Text, txtAPaterno.Text, sAMaterno, txtUsuario.Text, txtContrasena.Text, txtCorreo.Text, sTelefono, sExtension);
                    DialogResult us = MessageBox.Show("El registro del usuario se realizo correctamente.", "Mensaje", MessageBoxButtons.OK);
                    if (us == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
        }

        /*Función para validar campos en formulario*/
        private void validarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                validaCampos    = 1;
                lblNom.Visible  = true;
            }
            else
            {
                validaCampos    = 0;
                lblNom.Visible  = false;
            }

            if (txtAPaterno.Text == string.Empty)
            {
                validaCampos    = 1;
                lblAPat.Visible = true;
            }
            else
            {
                validaCampos    = 0;
                lblAPat.Visible = false;
            }

            if (txtCorreo.Text == string.Empty)
            {
                validaCampos        = 1;
                lblCorreo.Visible   = true;
            }
            else
            {
                validaCampos        = 0;
                lblCorreo.Visible   = false;
            }

            if (cmbTipoUsuario.Text == string.Empty)
            {
                validaCampos        = 1;
                lblTUsuario.Visible = true;
            }
            else
            {
                validaCampos        = 0;
                lblTUsuario.Visible = false;
            }

            if (txtUsuario.Text == string.Empty)
            {
                validaCampos    = 1;
                lblUse.Visible  = true;
            }
            else
            {
                validaCampos    = 0;
                lblUse.Visible  = false;
            }

            if (txtContrasena.Text == string.Empty)
            {
                validaCampos    = 1;
                lblPass.Visible = true;
            }
            else
            {
                validaCampos    = 0;
                lblPass.Visible = false;
            }
        }

        /*Evento click que cierra formulario*/
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        ///*Evento TextChanged para cambiar el texto a mayusculas*/
        //private void txtNombre_TextChanged(object sender, EventArgs e)
        //{
        //    txtNombre.CharacterCasing = CharacterCasing.Upper;
        //}

        ///*Evento TextChanged para cambiar el texto a mayusculas*/
        //private void txtAPaterno_TextChanged(object sender, EventArgs e)
        //{
        //    txtAPaterno.CharacterCasing = CharacterCasing.Upper;
        //}

        ///*Evento TextChanged para cambiar el texto a mayusculas*/
        //private void txtAMaterno_TextChanged(object sender, EventArgs e)
        //{
        //    txtAMaterno.CharacterCasing = CharacterCasing.Upper;
        //}

        ///*Evento TextChanged para cambiar el texto a mayusculas*/
        //private void txtUsuario_TextChanged(object sender, EventArgs e)
        //{
        //    txtUsuario.CharacterCasing = CharacterCasing.Upper;
        //}

        ///*Evento TextChanged para cambiar el texto a mayusculas*/
        //private void txtContrasena_TextChanged(object sender, EventArgs e)
        //{
        //    txtContrasena.CharacterCasing = CharacterCasing.Upper;
        //}
    }
}
