using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_RegistrarT
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Tarea> listar()
        {
            List<Tarea> list = db.Tarea.ToList();
            return list;
        }

        public Tarea obtener(int key)
        {
            Tarea objeto = db.Tarea.Single(r => r.TareaID == key);
            return objeto;
        }

        public void registrar(Tarea objprueba)
        {
            db.Tarea.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Tarea objprueba)
        {
            Tarea objactualizacion = db.Tarea.Single(r => r.TareaID == objprueba.TareaID);
            objactualizacion.Descripcion = objprueba.Descripcion;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Tarea objeliminar = db.Tarea.Single(r => r.TareaID == key);
            db.Tarea.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
