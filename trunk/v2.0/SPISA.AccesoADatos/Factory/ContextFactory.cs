using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Entities;

namespace SPISA.AccesoADatos
{
    public class ContextFactory
    {
        private static readonly EntitiesContext entitiesContext = new EntitiesContext();

        public static EntitiesContext CreateContext()
        {
            return entitiesContext;
        }
    }
}
