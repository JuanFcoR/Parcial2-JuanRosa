using Parcial2_JuanRosa.BLL;
using Parcial2_JuanRosa.Entidades;
using Parcial2_JuanRosa.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JuanRosa.UI.Consultas
{
    public partial class cAsignaturas : Form
    {
        public cAsignaturas()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asignaturas>();
            Repositorio<Asignaturas> rep = new Repositorio<Asignaturas>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = rep.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.AsignaturaId == id);
                        break;

                    case 2:
                        listado = rep.GetList(p => p.Descripcion.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        decimal creditos = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.Creditos==creditos);
                        break;

                }
               

            }
            else
            {
                listado = rep.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Asignaturas> rep = new Repositorio<Asignaturas>();
            int id;
            Asignaturas es = new Asignaturas();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            es = rep.Buscar(id);
            rAsignaturas re = new rAsignaturas(es);
            this.Hide();
            re.ShowDialog();
        }
    }
}
