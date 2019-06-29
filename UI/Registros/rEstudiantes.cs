using Parcial2_JuanRosa.BLL;
using Parcial2_JuanRosa.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JuanRosa.UI.Registros
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        public bool validar()
        {
            bool paso = true;

            if(string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                SuperErrorProvider.SetError(NombresTextBox, "Este campo no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Estudiantes> rep = new Repositorio<Estudiantes>();
            Estudiantes est = rep.Buscar((int)EstudainteIdNumericUpDown.Value);
            
            
            return (est != null);
        }

        private void limpiar()
        {
            EstudainteIdNumericUpDown.Value = 0;
            FechaIngresoDateTimePicker.Value = DateTime.Now;
            NombresTextBox.Text = string.Empty;
            BalanceNumericUpDown.Value = 0;

        }

        private Estudiantes LlenarCalse()
        {
            Estudiantes est = new Estudiantes();
            est.EstudianteId = Convert.ToInt32(EstudainteIdNumericUpDown.Value);
            est.FechaIngreso = FechaIngresoDateTimePicker.Value;
            est.Nombres = NombresTextBox.Text;
            est.Balance = BalanceNumericUpDown.Value;
            return est;
        }

        public void LlenarCampos(Estudiantes est)
        {
            EstudainteIdNumericUpDown.Value = est.EstudianteId;
            FechaIngresoDateTimePicker.Value = est.FechaIngreso;
            NombresTextBox.Text = est.Nombres;
            BalanceNumericUpDown.Value = est.Balance;

        }



        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Repositorio<Estudiantes> r = new Repositorio<Estudiantes>();
            Estudiantes est = new Estudiantes();
            int.TryParse(EstudainteIdNumericUpDown.Text, out id);
            limpiar();
            est=r.Buscar(id);

            if (est != null)
            {
                MessageBox.Show("Estudiante Encontrado");
                LlenarCampos(est);
            }
            else
            {
                MessageBox.Show("Estudiante no encontrado");
            }
            

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Estudiantes> r = new Repositorio<Estudiantes>();
            Estudiantes est;
            bool paso = false;
            if (!validar())
                return;
            est = LlenarCalse();
            if (EstudainteIdNumericUpDown.Value == 0)
                paso=r.Guardar(est);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudainte que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    paso=r.Modificar(est);
            }
            if (paso)
                MessageBox.Show("Guardado!!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No Guardado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Estudiantes> rep = new Repositorio<Estudiantes>();
            int id;
            SuperErrorProvider.Clear();
            int.TryParse(EstudainteIdNumericUpDown.Text,out id);
            limpiar();
            if (rep.Eliminar(id))
                MessageBox.Show("Elminado");
            else
                SuperErrorProvider.SetError(EstudainteIdNumericUpDown, "No se puede Eliminar un estudiante que no existe");
        }
    }
}
