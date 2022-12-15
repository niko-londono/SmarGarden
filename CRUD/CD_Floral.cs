using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_Floral
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<ArregloFloral> listar()
        {
            List<ArregloFloral> list = db.ArregloFloral.ToList();
            return list;
        }
        public ArregloFloral obtener(int key)
        {
            ArregloFloral objeto = db.ArregloFloral.Single(r => r.ArregloID == key);
            return objeto;
        }

        public void registrar(ArregloFloral objprueba)
        {
            db.ArregloFloral.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(ArregloFloral objprueba)
        {
            ArregloFloral objactualizacion = db.ArregloFloral.Single(r => r.ArregloID == objprueba.ArregloID);
            objactualizacion.Descripcion = objprueba.Descripcion;
            objactualizacion.Precio_de_Complejidad = objprueba.Precio_de_Complejidad;

            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            ArregloFloral objeliminar = db.ArregloFloral.Single(r => r.ArregloID == key);
            db.ArregloFloral.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
