using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_JuanRosa.BLL;
using Parcial2_JuanRosa.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1.Test
{
    [TestClass]
    public class AsignaturasTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            Repositorio<Asignaturas> db = new Repositorio<Asignaturas>();
            Asignaturas p = new Asignaturas();
            p.AsignaturaId = 1;
            p.Descripcion = "Hol";
            p.Creditos=345;



            bool paso = false;

            paso = db.Guardar(p);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Asignaturas> repositorio = new Repositorio<Asignaturas>();
            bool paso = false;
            Asignaturas p = repositorio.Buscar(1);
            p.Descripcion = "Asdf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Asignaturas> repositorio = new Repositorio<Asignaturas>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Asignaturas> repositorio = new Repositorio<Asignaturas>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Asignaturas> repositorio = new Repositorio<Asignaturas>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
}
