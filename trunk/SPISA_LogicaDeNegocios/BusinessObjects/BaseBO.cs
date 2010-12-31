using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPISA.Libreria.Interfaces;

namespace SPISA.Libreria
{
    
    public class BaseBO
    {
        protected IDaoFactory factory;

        public IDaoFactory Factory
        {
            get
            {
                return factory;
            }
        }

        public BaseBO(IDaoFactory factory) { this.factory = factory; }

    }
}
