using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_RegistrarPaisa
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Paisajismo> listar()
        {
            List<Paisajismo> list = db.Paisajismo.ToList();
            return list;
        }

        public Paisajismo obtener(int key)
        {
            Paisajismo objeto = db.Paisajismo.Single(r => r.PaisaID == key);
            return objeto;
        }

        public void registrar(Paisajismo objprueba)
        {
            db.Paisajismo.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Paisajismo objprueba)
        {
            Paisajismo objactualizacion = db.Paisajismo.Single(r => r.PaisaID == objprueba.PaisaID);
            objactualizacion.Descripcion = objprueba.Descripcion;
            objactualizacion.Precio_Cliente = objprueba.Precio_Cliente;
            objactualizacion.Presupuesto = objprueba.Presupuesto;
            objactualizacion.Fecha_Inicial = objprueba.Fecha_Inicial;
            objactualizacion.DeadLine = objprueba.DeadLine;

            objactualizacion.ClienteID = objprueba.ClienteID;

            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Paisajismo objeliminar = db.Paisajismo.Single(r => r.PaisaID == key);
            db.Paisajismo.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }
    }
}
