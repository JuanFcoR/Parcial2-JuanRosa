using Parcial2_JuanRosa.BLL;
using Parcial2_JuanRosa.Entidades;
using Parcial2_JuanRosa.UI.Consultas;
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
    public partial class rInscripcion : Form
    {
        public List<InscripcionDetalle> Detalle;
        public rInscripcion()
        {
            InitializeComponent();
            this.Detalle = new List<InscripcionDetalle>();
        }

        public rInscripcion(Inscripcion ins)
        {
            InitializeComponent();
            this.Detalle = new List<InscripcionDetalle>();
            LlenarCampos(ins);
        }

        

        private void CargarComboBox()
        {
            InscripcionRepositorio ir = new InscripcionRepositorio();
            Repositorio<Estudiantes> estudiantes = new Repositorio<Estudiantes>();
            Repositorio<Asignaturas> asignaturas = new Repositorio<Asignaturas>();
            EstudianteComboBox.DisplayMember ="Nombres";
            EstudianteComboBox.ValueMember = "EstudianteId";
            EstudianteComboBox.DataSource = estudiantes.GetList(p=>true);

            AsignaturaComboBox.DisplayMember = "Descripcion";
            AsignaturaComboBox.ValueMember = "AsignaturaId";
            AsignaturaComboBox.DataSource = asignaturas.GetList(p => true);
        }

        public bool validar()
        {
            bool paso = true;

            

            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            InscripcionRepositorio rep = new InscripcionRepositorio();
            Inscripcion est = rep.Buscar((int)InscripcionIdNumericUpDown.Value);


            return (est != null);
        }

        private void limpiar()
        {
            InscripcionIdNumericUpDown.Value = 0;
            FechaInscripcionDateTimePicker.Value = DateTime.Now;
            MontoNumericUpDown.Value = 0;
            PrecioCreditosNumericUpDown.Value = 0;

        }

        private Inscripcion LlenarClase()
        {
            Inscripcion est = new Inscripcion();
            est.InscripcionId = Convert.ToInt32(InscripcionIdNumericUpDown.Value);
            est.Fecha = FechaInscripcionDateTimePicker.Value;
            est.Monto = MontoNumericUpDown.Value;
            est.PrecioCredito = PrecioCreditosNumericUpDown.Value;
            return est;
        }

        public void LlenarCampos(Inscripcion est)
        {
            InscripcionIdNumericUpDown.Value = est.InscripcionId;
            FechaInscripcionDateTimePicker.Value = est.Fecha;
            MontoNumericUpDown.Value = est.Monto;
            PrecioCreditosNumericUpDown.Value = est.PrecioCredito;

        }


        private void EliminarButton_Click(object sender, EventArgs e)
        {
            InscripcionRepositorio ir = new InscripcionRepositorio();
            SuperErrorProvider.Clear();
            int id;
            int.TryParse(InscripcionIdNumericUpDown.Text, out id);
            limpiar();
            if (ir.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                SuperErrorProvider.SetError(InscripcionIdNumericUpDown, "No se puede eliminar una inscripcion que no existe");
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            InscripcionRepositorio isr = new InscripcionRepositorio();
            Inscripcion ins;
            bool paso = false;

            if (!validar())
                return;

            ins = LlenarClase();

            if (InscripcionIdNumericUpDown.Value == 0)
                paso = isr.Guardar(ins);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una Inscripcion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = isr.Modificar(ins);
            }

            
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            InscripcionRepositorio r = new InscripcionRepositorio();
            Estudiantes est = new Estudiantes();
            int.TryParse(InscripcionIdNumericUpDown.Text, out id);
            cInscripcion cons = new cInscripcion();
            cons.ShowDialog();
        }

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            if (DetalleDataGridView.DataSource != null)
                this.Detalle = (List<InscripcionDetalle>)DetalleDataGridView.DataSource;
            Repositorio<Estudiantes> estu = new Repositorio<Estudiantes>();
            Repositorio<Asignaturas> asign = new Repositorio<Asignaturas>();
            Estudiantes es = estu.Buscar(EstudianteComboBox.SelectedIndex);
            Asignaturas asi = asign.Buscar(AsignaturaComboBox.SelectedIndex);
            //todo: validar campos del detalle


            //Agregar un nuevo detalle con los datos introducidos.
            this.Detalle.Add(
                new InscripcionDetalle(
                    iD: 0,
                    inscripcionId: (int)InscripcionIdNumericUpDown.Value,
                    estudianteId: (int)EstudianteComboBox.SelectedIndex,
                    asignaturaId: (int)AsignaturaComboBox.SelectedIndex,
                    total: PrecioCreditosNumericUpDown.Value * asi.Creditos
                    )
               );
            MontoNumericUpDown.Maximum = 100000;
            MontoNumericUpDown.Value = this.Detalle.Sum(p=>p.Total);

            CargarGrid();
        }

        private void CargarGrid()
        {
            DetalleDataGridView.DataSource = null;
            DetalleDataGridView.DataSource = Detalle;
        }

        private void RInscripcion_Load(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void RemoverButton_Click(object sender, EventArgs e)
        {
            Detalle.RemoveAt(DetalleDataGridView.CurrentRow.Index);
            CargarGrid();
            MontoNumericUpDown.Value = Detalle.Sum(p => p.Total);
        }
    }
}
