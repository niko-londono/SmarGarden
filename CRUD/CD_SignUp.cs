using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGardenP.CRUD
{
    internal class CD_SignUp
    {
        ModelDatosDataContext db = new ModelDatosDataContext();

        public void registrar(Usuario objprueba)
        {
            db.Usuario.InsertOnSubmit(objprueba);
            db.SubmitChanges();
        }
    }
}
