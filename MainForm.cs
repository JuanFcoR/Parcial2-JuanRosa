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

namespace Parcial2_JuanRosa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripcion ins = new rInscripcion();
            ins.ShowDialog();
        }

       

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes res = new rEstudiantes();
            res.ShowDialog();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas ras = new rAsignaturas();
            ras.ShowDialog();
        }
    }
}
