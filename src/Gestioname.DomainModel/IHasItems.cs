using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gestioname.DomainModel
{
    public interface IHasItems
    {
        List<OrdenItem> Items { get; set; }
    }
}
