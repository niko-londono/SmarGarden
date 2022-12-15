using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_Suministros
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Suministro> listar()
        {
            List<Suministro> list = db.Suministro.ToList();
            return list;
        }

        public Suministro obtener(int key)
        {
            Suministro objeto = db.Suministro.Single(r => r.SumID == key);
            return objeto;
        }

        public void registrar(Suministro objprueba)
        {
            db.Suministro.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Suministro objprueba)
        {
            Suministro objactualizacion = db.Suministro.Single(r => r.SumID == objprueba.SumID);
            objactualizacion.Fecha_de_Salida = objprueba.Fecha_de_Salida;
            objactualizacion.Presupuesto = objprueba.Presupuesto;
            objactualizacion.Cantidad = objprueba.Cantidad;

            objactualizacion.TipoID = objprueba.TipoID;
            objactualizacion.EmpID = objprueba.EmpID;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Suministro objeliminar = db.Suministro.Single(r => r.SumID == key);
            db.Suministro.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}

