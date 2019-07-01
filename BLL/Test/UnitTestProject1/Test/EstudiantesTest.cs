using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_JuanRosa.BLL;
using Parcial2_JuanRosa.Entidades;

namespace UnitTestProject1.Test
{
    [TestClass]
    public class EstudiantesTest
    {
        [TestMethod]
        public void GuardarTest()
        {
            Repositorio<Estudiantes> db = new Repositorio<Estudiantes>();
            Estudiantes p = new Estudiantes();
            p.EstudianteId = 1;
            p.FechaIngreso = DateTime.Now;
            p.Nombres = "Juan Rosa";

           

            bool paso = false;

            paso = db.Guardar(p);

            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Repositorio<Estudiantes> repositorio = new Repositorio<Estudiantes>();
            bool paso = false;
            Estudiantes p = repositorio.Buscar(1);
            p.Nombres = "sdfsf";
            paso = repositorio.Modificar(p);
            Assert.AreEqual(true, paso);

        }

        [TestMethod()]

        public void BuscarTest()
        {
            Repositorio<Estudiantes> repositorio = new Repositorio<Estudiantes>();
            Assert.IsNotNull(repositorio.Buscar(1));

        }

        [TestMethod()]

        public void GetListTest()
        {
            Repositorio<Estudiantes> repositorio = new Repositorio<Estudiantes>();
            Assert.IsNotNull(repositorio.GetList(p => true));

        }



        [TestMethod()]

        public void EliminarTest()
        {
            Repositorio<Estudiantes> repositorio = new Repositorio<Estudiantes>();
            Assert.IsTrue(repositorio.Eliminar(1));

        }
    }
    
}
