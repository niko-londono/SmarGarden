using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP
{
    internal class CD_Cargo
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Cargo> listar()
        {
            List<Cargo> list = db.Cargo.ToList();
            return list;
        }

        public Cargo obtener(int key)
        {
            Cargo objeto = db.Cargo.Single(r => r.CargoID == key);
            return objeto;
        }

        public void registrar(Cargo objprueba)
        {
            db.Cargo.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Cargo objprueba)
        {
            Cargo objactualizacion = db.Cargo.Single(r => r.CargoID == objprueba.CargoID);
            objactualizacion.Cargo1 = objprueba.Cargo1;
            objactualizacion.Descripcion = objprueba.Descripcion;
            objactualizacion.Beneficios = objprueba.Beneficios;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Cargo objeliminar = db.Cargo.Single(r => r.CargoID == key);
            db.Cargo.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
