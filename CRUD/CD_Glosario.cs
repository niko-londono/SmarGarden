using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_Glosario
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Tipo> listar()
        {
            List<Tipo> list = db.Tipo.ToList();
            return list;
        }

        public Tipo obtener(int key)
        {
            Tipo objeto = db.Tipo.Single(r => r.TipoID == key);
            return objeto;
        }

        public void registrar(Tipo objprueba)
        {
            db.Tipo.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Tipo objprueba)
        {
            Tipo objactualizacion = db.Tipo.Single(r => r.TipoID == objprueba.TipoID);
            objactualizacion.Nombre = objprueba.Nombre;
            objactualizacion.Informaciones = objprueba.Informaciones;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Tipo objeliminar = db.Tipo.Single(r => r.TipoID == key);
            db.Tipo.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
