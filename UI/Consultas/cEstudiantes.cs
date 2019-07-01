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
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiantes>();
            Repositorio<Estudiantes> rep = new Repositorio<Estudiantes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = rep.GetList(p => true);
                        break;

                    case 1:
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.EstudianteId == id);
                        break;

                    case 2:
                        listado = rep.GetList(p => p.Nombres.Contains(CriterioTextBox.Text));
                        break;

                    case 3:
                        decimal balance = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = rep.GetList(p => p.Balance == balance);
                        break;

                    case 4:
                        listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();
                        break;

                }
                listado = listado.Where(c => c.FechaIngreso.Date >= DesdeDateTimePicker.Value.Date && c.FechaIngreso.Date <= HastaDateTimePicker.Value.Date).ToList();


            }
            else
            {
                listado = rep.GetList(p => true);
            }

            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Estudiantes> rep = new Repositorio<Estudiantes>();
            int id;
            Estudiantes es = new Estudiantes();
            int.TryParse(ConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(), out id);
            es = rep.Buscar(id);
            rEstudiantes re = new rEstudiantes(es);
            this.Hide();
            re.ShowDialog();
        }
    }
}
