using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Libreria.Interfaces;

using System.Configuration;
using System.Reflection;

namespace SPISA.Libreria
{
    public class Utilities
    {
        private const string FACTORY_ASSEMBLY = "SPISA.AccesoADatos";

        public static IDaoFactory CreateFactoryInstance()
        {
            string typeStr = ConfigurationManager.AppSettings["FactoryClass"];
            
            IDaoFactory f = null;
            try
            {
                Assembly a = Assembly.Load(FACTORY_ASSEMBLY);
                if (a != null)
                {
                    Type fType = a.GetType(typeStr);
                    if (fType == null) fType = a.GetType(String.Format("{0}.{1}",
                         FACTORY_ASSEMBLY, typeStr));
                    f = Activator.CreateInstance(fType) as IDaoFactory;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(String.Format("Unable to load {0} from Northwind.Data",
                          typeStr), ex);
            }
            return f;

            Entities.EntitiesContext c = new SPISA.Entities.EntitiesContext();
            
        }
    }
}
