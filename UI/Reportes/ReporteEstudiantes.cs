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

namespace Parcial2_JuanRosa.UI.Reportes
{
    public partial class ReporteEstudiantes : Form
    {
        private List<Estudiantes> ListaE;
        public ReporteEstudiantes()
        {
            InitializeComponent();
        }

        public ReporteEstudiantes(List<Estudiantes> estudiantes)
        {
            this.ListaE = estudiantes;
            InitializeComponent();
        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
