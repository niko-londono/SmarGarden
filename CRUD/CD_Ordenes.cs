using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_Ordenes
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<ArregloFloral_Cliente> listar()
        {
            List<ArregloFloral_Cliente> list = db.ArregloFloral_Cliente.ToList();
            return list;
        }

        public ArregloFloral_Cliente obtener(int key)
        {
            ArregloFloral_Cliente objeto = db.ArregloFloral_Cliente.Single(r => r.Arreglo_clienteID == key);
            return objeto;
        }

        public void registrar(ArregloFloral_Cliente objprueba)
        {
            db.ArregloFloral_Cliente.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(ArregloFloral_Cliente objprueba)
        {
            ArregloFloral_Cliente objactualizacion = db.ArregloFloral_Cliente.Single(r => r.Arreglo_clienteID == objprueba.Arreglo_clienteID);
            objactualizacion.Fecha_Inicial = objprueba.Fecha_Inicial;
            objactualizacion.DeadLine = objprueba.DeadLine;
            objactualizacion.Cantidad = objprueba.Cantidad;

            objactualizacion.ClienteID = objprueba.ClienteID;
            objactualizacion.ArregloID = objprueba.ArregloID;
            objactualizacion.EmpID = objprueba.EmpID;


            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            ArregloFloral_Cliente objeliminar = db.ArregloFloral_Cliente.Single(r => r.Arreglo_clienteID == key);
            db.ArregloFloral_Cliente.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
