using System;
using System.Collections.Generic;
using System.Text;

namespace SPISA.Libreria
{
    internal struct Consts
    {
        public const string Articulos_Buscar = "Articulos_Buscar";
        public const string Articulos_TraerTodos = "Articulos_TraerTodos";
        public const string Articulos_TraerArticuloPorID = "Articulos_TraerArticuloPorID"; 
        public const string Articulos_TraerArticuloPorCodigo = "Articulos_TraerArticuloPorCodigo";
        public const string Articulos_TraerArticulosPorDescripcion = "Articulos_TraerArticulosPorDescripcion";
        public const string Articulos_GuardarArticulo = "Articulos_GuardarArticulo";
        public const string Articulos_Actualizar = "Articulos_Actualizar";
        public const string Articulos_ModificarCantidad = "Articulos_ModificarCantidad";
        public const string Articulos_CantidadSalidasPorArticuloPorMes = "Articulos_CantidadSalidasPorArticuloPorFecha";

        public const string Facturas_TraerTodas = "Facturas_TraerTodas";
        public const string Facturas_TraerFacturaPorID = "Facturas_TraerFacturaPorID";
        public const string Facturas_TraerFacturaPorIdNotaPedido = "Facturas_TraerFacturaPorIdNotaPedido";
        public const string Facturas_GuardarFactura = "Facturas_GuardarFactura";
        public const string Facturas_ActualizarFactura = "Facturas_ActualizarFactura";
        public const string Facturas_AlmacenarImpresion = "Facturas_AlmacenarImpresion";
        public const string Facturas_CancelarFactura = "Facturas_CancelarFactura";
        public const string Facturas_ObtenerNumeroNumeroDeFactura = "Facturas_ObtenerNumeroNumeroDeFactura";
        public const string Facturas_Buscar = "Facturas_Buscar";

        public const string Remitos_TraerTodos = "Remitos_TraerTodos";
        public const string Remitos_TraerRemitoPorID = "Remitos_TraerRemitoPorID";
        public const string Remitos_TraerRemitoPorIdNotaPedido = "Remitos_TraerRemitoPorIdNotaPedido";
        public const string Remitos_GuardarRemito = "Remitos_GuardarRemito";
        public const string Remitos_ActualizarRemito = "Remitos_ActualizarRemito";
        public const string Remitos_ObtenerNuevoNumeroDeRemito = "Remitos_ObtenerNuevoNumeroDeRemito";

        public const string Clientes_TraerClientePorCodigo = "Clientes_TraerClientePorCodigo";
        public const string Clientes_TraerClientePorRazonSocial = "Clientes_TraerClientePorRazonSocial";
        public const string Clientes_TraerPorId = "Clientes_TraerPorId";
        public const string Clientes_TraerTodos = "Clientes_TraerTodos";
        public const string Clientes_GuardarCliente = "Clientes_GuardarCliente";
        public const string Clientes_ActualizarCliente = "Clientes_ActualizarCliente";
        public const string Clientes_Buscar = "Clientes_Buscar";
        public const string Clientes_ObtenerNuevoNumeroCliente = "Clientes_ObtenerNuevoNumeroCliente";
        public const string Clientes_EstablecerTransportista = "Clientes_EstablecerTransportista";

        public const string NotaPedido_ObtenerUltimoNumeroDeOrden = "NotaPedido_ObtenerUltimoNumeroDeOrden";
        public const string NotaPedido_Guardar = "NotaPedido_Guardar";
        public const string NotaPedido_Actualizar = "NotaPedido_Actualizar"; 
        public const string NotaPedido_Items_AgregarItem = "NotaPedido_Items_AgregarItem";
        public const string NotaPedido_Items_TraerPorIdNP = "NotaPedido_Items_TraerPorIdNP";
        public const string NotaPedido_Borrar = "NotaPedido_Borrar";
        public const string NotaPedido_Items_BorrarPorIdNotaPedido = "NotaPedido_Items_BorrarPorIdNotaPedido";
        public const string NotaPedido_TraerTodas = "NotaPedido_TraerTodas";
        public const string NotaPedido_TraerPorId = "NotaPedido_TraerPorId";
        public const string NotaPedido_Buscar = "NotaPedido_Buscar";

        public const string Categorias_TraerTodas = "Categorias_TraerTodas";
        public const string Categorias_TraerPorId = "Categorias_TraerPorId";
        public const string Categorias_TraerPorDescripcion = "Categorias_TraerPorDescripcion";
        public const string Categorias_GuardarCategoria = "Categorias_GuardarCategoria";
        public const string Categorias_ActualizarCategoria = "Categorias_ActualizarCategoria";

        public const string CuentaCorriente_Agregar = "CuentaCorriente_Agregar";
        public const string CuentaCorriente_TraerPorIdCliente = "CuentaCorriente_TraerPorIdCliente";
        public const string CuentaCorriente_AlmacenarMovimiento = "CuentaCorriente_AlmacenarMovimiento";

        public const string Provincias_TraerTodas = "Provincias_TraerTodas";
        public const string Provincias_TraerPorId = "Provincias_TraerPorId";
        public const string Provincias_TraerPorNombre = "Provincias_TraerPorNombre";

        public const string CondicionesIVA_TraerTodas = "CondicionesIVA_TraerTodas";
        public const string CondicionesIVA_TraerPorId = "CondicionesIVA_TraerPorId";
        public const string CondicionesIVA_TraerPorCondicionIVA = "CondicionesIVA_TraerPorCondicionIVA";

        public const string Operatorias_TraerTodas = "Operatorias_TraerTodas";
        public const string Operatorias_TraerPorId = "Operatorias_TraerPorId";
        public const string Operatorias_TraerPorOperatoria = "Operatorias_TraerPorOperatoria";

        public const string Descuentos_TraerPorIdCliente = "Descuentos_TraerPorIdCliente";
        public const string Descuentos_EliminarPorIdCliente = "Descuentos_EliminarPorIdCliente";
        public const string Descuentos_AgregarDescuento = "Descuentos_AgregarDescuento";

        public const string Transportistas_TraerTodos = "Transportistas_TraerTodos";
        public const string Transportistas_TraerPorId = "Transportistas_TraerPorId";

        public const string GetTableColumns = "GetTableColumns";
        






        
    }
}

