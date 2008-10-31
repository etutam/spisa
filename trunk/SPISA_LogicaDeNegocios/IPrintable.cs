using System;
using System.Collections.Generic;
using System.Text;

using SPISA.Libreria;

namespace SPISA.Libreria
{
    public interface IPrintable
    {
        IList<Printing.ObjetoAImprimir> GetObjectsToPrint();
    }
}
