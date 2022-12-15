using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_Unidades
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Unidad> listar()
        {
            List<Unidad> list = db.Unidad.ToList();
            return list;
        }

        public Unidad obtener(int key)
        {
            Unidad objeto = db.Unidad.Single(r => r.UnidadID == key);
            return objeto;
        }

        public void registrar(Unidad objprueba)
        {
            db.Unidad.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Unidad objprueba)
        {
            Unidad objactualizacion = db.Unidad.Single(r => r.UnidadID == objprueba.UnidadID);
            objactualizacion.FeExpirado = objprueba.FeExpirado;
            objactualizacion.Precio_Unidad = objprueba.Precio_Unidad;
            objactualizacion.Condicion = objprueba.Condicion;

            objactualizacion.TipoID = objprueba.TipoID;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Unidad objeliminar = db.Unidad.Single(r => r.UnidadID == key);
            db.Unidad.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
