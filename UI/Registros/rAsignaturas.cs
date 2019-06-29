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
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }

        public bool validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                SuperErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            Repositorio<Asignaturas> rep = new Repositorio<Asignaturas>();
            Asignaturas asig = rep.Buscar((int)AsignaturaIdNumericUpDown.Value);


            return (asig != null);
        }

        private void limpiar()
        {
            AsignaturaIdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
            CreditosNumericUpDown.Value = 0;

        }

        private Asignaturas LlenarCalse()
        {
            Asignaturas est = new Asignaturas();
            est.AsignaturaId = Convert.ToInt32(AsignaturaIdNumericUpDown.Value);
            est.Descripcion= DescripcionTextBox.Text;
            est.Creditos = Convert.ToInt32(CreditosNumericUpDown.Value);
            return est;
        }

        public void LlenarCampos(Asignaturas asig)
        {
            AsignaturaIdNumericUpDown.Value = asig.AsignaturaId;
            DescripcionTextBox.Text = asig.Descripcion;
            CreditosNumericUpDown.Value = asig.Creditos;

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Repositorio<Asignaturas> rep = new Repositorio<Asignaturas>();
            Asignaturas ast = new Asignaturas();
            if (!validar())
                return;
            ast = LlenarCalse();
            if (AsignaturaIdNumericUpDown.Value == 0)
                paso = rep.Guardar(ast);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede Modififcar un Estudiante que no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    paso = rep.Modificar(ast);
            }
                if (paso)
                    MessageBox.Show("Guardado!!!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se guardo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Asignaturas asi = new Asignaturas();
            Repositorio <Asignaturas> rep = new Repositorio<Asignaturas>();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            limpiar();
            asi = rep.Buscar(id);
            if (asi != null)
                MessageBox.Show("Asignatura Encontrada");
            else
                MessageBox.Show("Asignatura no encontrada");


        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Asignaturas> rep = new Repositorio<Asignaturas>();
            int id;
            SuperErrorProvider.Clear();
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);
            limpiar();
            if (rep.Eliminar(id))
                MessageBox.Show("Elminado");
            else
                SuperErrorProvider.SetError(AsignaturaIdNumericUpDown, "No se puede una asignatura que no existe");
        }
    }
}
