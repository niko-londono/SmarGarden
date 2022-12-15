using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_AsignacionT
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Tarea_Empleado> listar()
        {
            List<Tarea_Empleado> list = db.Tarea_Empleado.ToList();
            return list;
        }

        public Tarea_Empleado obtener(int key)
        {
            Tarea_Empleado objeto = db.Tarea_Empleado.Single(r => r.Tarea_empID == key);
            return objeto;
        }

        public void registrar(Tarea_Empleado objprueba)
        {
            db.Tarea_Empleado.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Tarea_Empleado objprueba)
        {
            Tarea_Empleado objactualizacion = db.Tarea_Empleado.Single(r => r.Tarea_empID == objprueba.Tarea_empID);
            objactualizacion.TareaID = objprueba.TareaID;
            objactualizacion.EmpID = objprueba.EmpID;

            objactualizacion.Horario = objprueba.Horario;
            objactualizacion.Localizacion = objprueba.Localizacion;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Tarea_Empleado objeliminar = db.Tarea_Empleado.Single(r => r.Tarea_empID == key);
            db.Tarea_Empleado.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
