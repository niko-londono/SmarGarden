using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_OrdenesPaisa
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Paisajismo_Empleado> listar()
        {
            List<Paisajismo_Empleado> list = db.Paisajismo_Empleado.ToList();
            return list;
        }

        public Paisajismo_Empleado obtener(int key)
        {
            Paisajismo_Empleado objeto = db.Paisajismo_Empleado.Single(r => r.PaisaID == key);
            return objeto;
        }

        public void registrar(Paisajismo_Empleado objprueba)
        {
            db.Paisajismo_Empleado.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Paisajismo_Empleado objprueba)
        {
            Paisajismo_Empleado objactualizacion = db.Paisajismo_Empleado.Single(r => r.PaisaID == objprueba.PaisaID);
            objactualizacion.Localizacion = objprueba.Localizacion;

            objactualizacion.EmpID = objprueba.EmpID;

            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Paisajismo_Empleado objeliminar = db.Paisajismo_Empleado.Single(r => r.PaisaID == key);
            db.Paisajismo_Empleado.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
