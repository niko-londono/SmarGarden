using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_Clientes
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Cliente> listar()
        {
            List<Cliente> list = db.Cliente.ToList();
            return list;
        }

        public Cliente obtener(int key)
        {
            Cliente objeto = db.Cliente.Single(r => r.ClienteID == key);
            return objeto;
        }

        public void registrar(Cliente objprueba)
        {
            db.Cliente.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Cliente objprueba)
        {
            Cliente objactualizacion = db.Cliente.Single(r => r.ClienteID == objprueba.ClienteID);
            objactualizacion.Nombre = objprueba.Nombre;
            objactualizacion.Correo = objprueba.Correo;
            objactualizacion.Telefono = objprueba.Telefono;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Cliente objeliminar = db.Cliente.Single(r => r.ClienteID == key);
            db.Cliente.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
