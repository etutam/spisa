﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gestioname.DomainModel;
using Gestioname.DomainModel.Repositories;
using NUnit.Framework;

namespace Gestioname.Repositories.Test
{   
    [TestFixture]
    class FacturaRepositoryTest: RepositoryTestCase<Factura,FacturaRepository>
    {

        public IFacturaRepository FacturaRepository { get; set; } 

        [Test]
        public void FindByNumeroFactura()
        {
            Factura facturaprueba = new Factura().GetTestInstance();
            
            FacturaRepository.Save(facturaprueba);
            
            Factura resultado = FacturaRepository.FindByNumeroFactura(facturaprueba.NumeroFactura);

            Assert.NotNull(resultado);

            Assert.AreEqual(facturaprueba.NumeroFactura,resultado.NumeroFactura);

            FacturaRepository.Remove(facturaprueba);
        }
    }
}
