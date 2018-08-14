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

namespace ControlActividadesJuridico.Representacion.AddFolders
{
    public partial class FAddFolder : Form
    {
        string sRuta;
        public FAddFolder(string ruta)
        {
            InitializeComponent();
            sRuta = ruta;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(Directory.Exists(sRuta + "\\" + txtNomFolder.Text)))
                {
                    Directory.CreateDirectory(sRuta + "\\" + txtNomFolder.Text);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("La carpeta ya existe.",
                      "Carpeta existente", MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La carpeta no ha sido generada, contactar al administrador", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
