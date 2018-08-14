using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraLayout;
using LogicaCC.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LxCallcenter
{
    public partial class frmProspectosInactivos : Form
    {
        UsuarioData AUsuarioData = UsuarioData.Instancia;
        
        public int iIdProspSel = 0;
        List<Prospecto> List;
        public frmProspectosInactivos()
        {
            InitializeComponent();
            InitializeControls();
        }

        #region Funciones
        public void InitializeControls()
        {
            LoadProspectos();
        }

        public void LoadProspectos()
        {
            List = new Prospecto().GetCanceledList(int.Parse(AUsuarioData.sIdusuario));
            grdProspectos.DataSource = List;
        }

        /// <summary>
        /// Reactiva al prospectos seleccionado en el formulario
        /// </summary>
        public void ReactiveProsp()
        {
            if (iIdProspSel != 0)
            {
                if (FlatMessageBox.Show("¿Está seguro de reactivar al prospecto?", "Si", "No", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (new Prospecto().Active(iIdProspSel))
                    {
                        this.Invoke((MethodInvoker)delegate { LoadProspectos(); });
                        iIdProspSel = 0;
                        FlatMessageBox.Show("Prospecto Activado Correctamente", "OK", string.Empty, FlatMessageBoxIcon.Information);
                    }
                }
            }
            else
                FlatMessageBox.Show("Seleccione un prospecto", "Ok", string.Empty, FlatMessageBoxIcon.Warning);
        }

        /// <summary>
        /// Reactiva a todo el listado de prospectos que se muestran en el formulario
        /// </summary>
        public void ReactiveAllProsp()
        {
            if (FlatMessageBox.Show("¿Está seguro de reactivar a los prospecto?", "Si", "No", FlatMessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < List.Count; i++)
                {
                    new Prospecto().Active(List[i].iIdProspecto);
                }

                this.Invoke((MethodInvoker)delegate { LoadProspectos(); });
                FlatMessageBox.Show("Prospectos Activado Correctamente", "OK", string.Empty, FlatMessageBoxIcon.Information);
            }
        }

        MRUEdit edit;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            FindControl find = null;
            foreach (Control ctrl in grdProspectos.Controls)
                if (ctrl.GetType() == typeof(FindControl))
                    find = ctrl as FindControl;
            if (find != null)
            {
                LayoutControl layout = find.Controls[0] as LayoutControl;
                edit = (layout.Items[2] as LayoutControlItem).Control as MRUEdit;
            }
        }
        #endregion

        #region eventos
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridView1.RowCount > 0)
                iIdProspSel = int.Parse(gridView1.GetFocusedRowCellValue("iIdProspecto").ToString());
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            edit.Text = txtBuscar.Text.ToString();
        }
        #endregion


    }
}
