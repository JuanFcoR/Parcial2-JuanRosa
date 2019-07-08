
using BLL;
using Entidades;
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
    public partial class cInscripcion : Form
    {
        public cInscripcion()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripcion>();
            InscripcionRepositorio rep = new InscripcionRepositorio();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = rep.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.InscripcionId == id);
                        break;

                    case 2:
                        decimal monto = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.Monto == monto);
                        break;

                    case 3:
                        DateTime fecha = Convert.ToDateTime(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.Fecha==fecha);
                        break;

                    case 4:
                        decimal pc = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.PrecioCredito == pc);
                        break;

                    case 5:
                        listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
                        break;

                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();


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
            InscripcionRepositorio rep = new InscripcionRepositorio();
            int id;
            Inscripcion es = new Inscripcion();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            es = rep.Buscar(id);
            rInscripcion re = new rInscripcion(es);
            this.Hide();
            re.ShowDialog();
        }
    }
}
