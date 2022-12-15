using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP
{
    internal class CD_Empleados
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public List<Empleado> listar()
        {
            List<Empleado> list = db.Empleado.ToList();
            return list;
        }

        public Empleado obtener(int key)
        {
            Empleado objeto = db.Empleado.Single(r => r.EmpID == key);
            return objeto;
        }

        public void registrar(Empleado objprueba)
        {
            db.Empleado.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }

        public void actualizar(Empleado objprueba)
        {
            Empleado objactualizacion = db.Empleado.Single(r => r.EmpID == objprueba.EmpID);
            //objactualizacion.Fecha_de_Contrato = objprueba.Fecha_de_Contrato;
            objactualizacion.Salario = objprueba.Salario;
            objactualizacion.Cargo = objprueba.Cargo;
            objactualizacion.Cedula = objprueba.Cedula;
            objactualizacion.Correo = objprueba.Correo;
            objactualizacion.Telefono = objprueba.Telefono;
            objactualizacion.FechaNac = objprueba.FechaNac;
            objactualizacion.Nombre = objprueba.Nombre;
            objactualizacion.Apellido = objprueba.Apellido;
            objactualizacion.Genero = objprueba.Genero;
            db.SubmitChanges();
        }

        public void eliminar(int key)
        {
            Empleado objeliminar = db.Empleado.Single(r => r.EmpID == key);
            db.Empleado.DeleteOnSubmit(objeliminar);
            db.SubmitChanges();
        }

    }
}
