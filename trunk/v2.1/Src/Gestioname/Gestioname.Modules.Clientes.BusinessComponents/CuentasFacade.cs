using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Gestioname.Modules.Clientes.Interfaces;
using Gestioname.Framework.BaseClasses;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Modules.Clientes.BusinessComponents
{
    public class CuentasFacade : FacadeBase<Cuenta>, ICuentasFacade
    {
        #region ICuentasFacade Members

        public void AddCuenta(Cuenta cuenta)
        {
            try
            {
                Add("CuentaSet", cuenta);
                SaveAllObjectChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateCuenta()
        {
            throw new NotImplementedException();
        }

        public void DeleteCuenta()
        {
            throw new NotImplementedException();
        }

        public void AddTransaccion()
        {
            throw new NotImplementedException();
        }

        public void UpdateTransaccion()
        {
            throw new NotImplementedException();
        }

        public void DeleteTransaccion()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
