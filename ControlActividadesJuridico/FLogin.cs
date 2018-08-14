using ClaseData.Clases;
using ClaseData.Funciones;
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
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        /*Funcion para validar que el usuario este registrado y de acceso al sistema*/
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UsuarioValidar AUsuario     = new UsuarioValidar();
            DatosUsuario ADatosUsuario  = DatosUsuario.Instancia;

            try
            {
                AUsuario.Validar(txtUsuario.Text, txtContrasena.Text);

                if (ADatosUsuario.sIdusuario != null)
                {
                    this.Hide();
                    var form = new FBandeja();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                }
                else
                {
                    txtUsuario.Clear();
                    txtContrasena.Clear();
                    MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTOS.",
                                    "ATENCIÓN!...",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR DE CONEXIÓN" + Environment.NewLine + 
                                "FAVOR DE PONERSE EN CONTACTO CON EL ADMINISTRADOR",
                                "ATENCIÓN!.",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
