USE [SPISA]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Articulos](
	[idArticulo] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[codigo] [varchar](20) NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
	[cantidad] [decimal](10, 2) NOT NULL,
	[preciounitario] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[idArticulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categorias](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
	[Descuento] [int] NOT NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [varchar](10) NOT NULL,
	[RazonSocial] [varchar](100) NOT NULL,
	[Domicilio] [varchar](100) NULL,
	[Localidad] [varchar](40) NULL,
	[IdProvincia] [int] NOT NULL,
	[IdCondicionIVA] [int] NOT NULL,
	[CUIT] [varchar](11) NOT NULL,
	[IdOperatoria] [int] NOT NULL,
	[Saldo] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CondicionesIVA]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CondicionesIVA](
	[IdCondicionIVA] [int] IDENTITY(1,1) NOT NULL,
	[CondicionIVA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CondicionesIVA] PRIMARY KEY CLUSTERED 
(
	[IdCondicionIVA] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CuentaCorriente_Movimientos]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaCorriente_Movimientos](
	[IdCuentaCorriente] [int] NOT NULL,
	[IdMovimiento] [int] NOT NULL,
	[IdFactura] [int] NULL,
	[IdFormaDePago] [int] NULL,
	[Monto] [decimal](10, 2) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CuentaCorriente_Pagos]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaCorriente_Pagos](
	[IdPago] [int] NOT NULL,
	[IdCuentaCorriente] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdFormaDePago] [int] NOT NULL,
	[Monto] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_CuentaCorriente_Pagos] PRIMARY KEY CLUSTERED 
(
	[IdPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CuentaCorriente_Pagos_DatosDelPago]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaCorriente_Pagos_DatosDelPago](
	[IdPago] [int] NOT NULL,
	[ChequeNumero] [int] NOT NULL,
	[FechaCheque] [datetime] NOT NULL,
	[FechaCobro] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CuentasCorriente]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentasCorriente](
	[IdCuentaCorriente] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[IdCliente] [int] NOT NULL,
 CONSTRAINT [PK_CuentasCorriente] PRIMARY KEY CLUSTERED 
(
	[IdCuentaCorriente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Descuentos]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Descuentos](
	[IdCliente] [int] NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Descuento] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[IdFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdNotaPedido] [int] NOT NULL,
	[NumeroFactura] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Observaciones] [varchar](200) NULL,
	[FueImpresa] [bit] NOT NULL CONSTRAINT [DF_Facturas_FueImpresa]  DEFAULT ((0)),
	[ValorDolar] [decimal](3, 2) NULL,
	[FueCancelada] [bit] NOT NULL CONSTRAINT [DF_Facturas_FueCancelada]  DEFAULT ((0)),
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[IdFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormasDePago]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormasDePago](
	[IdFormaDePago] [int] NOT NULL,
	[FormaDePago] [varchar](50) NOT NULL,
 CONSTRAINT [PK_FormasDePago] PRIMARY KEY CLUSTERED 
(
	[IdFormaDePago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MovimientosTipo]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MovimientosTipo](
	[IdMovimiento] [int] NOT NULL,
	[Movimiento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Movimientos] PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NotaPedido_Items]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaPedido_Items](
	[IdNotaPedido] [int] NOT NULL,
	[IdArticulo] [int] NOT NULL,
	[Cantidad] [decimal](10, 2) NOT NULL CONSTRAINT [DF_OrdenDeCompra_Items_Cantidad]  DEFAULT ((0)),
	[PrecioUnitario] [decimal](18, 2) NULL,
	[Descuento] [decimal](10, 2) NULL CONSTRAINT [DF_NotaPedido_Items_Descuento]  DEFAULT ((0))
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NotaPedidos]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NotaPedidos](
	[IdNotaPedido] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[FechaEmision] [datetime] NOT NULL,
	[FechaEntrega] [datetime] NULL,
	[NumeroOrden] [varchar](16) NOT NULL,
	[Observaciones] [varchar](200) NULL,
	[DescuentoEspecial] [float] NULL CONSTRAINT [DF_NotaPedidos_DescuentoEspecial]  DEFAULT ((0)),
 CONSTRAINT [PK_OrdenesDeCompra] PRIMARY KEY CLUSTERED 
(
	[IdNotaPedido] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Operatorias]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Operatorias](
	[IdOperatoria] [int] IDENTITY(1,1) NOT NULL,
	[Operatoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Operatorias] PRIMARY KEY CLUSTERED 
(
	[IdOperatoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Provincias](
	[IdProvincia] [int] IDENTITY(1,1) NOT NULL,
	[Provincia] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Provincias] PRIMARY KEY CLUSTERED 
(
	[IdProvincia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Remitos]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Remitos](
	[IdRemito] [int] IDENTITY(1,1) NOT NULL,
	[IdNotaPedido] [int] NOT NULL,
	[NumeroRemito] [varchar](16) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Observaciones] [varchar](200) NULL,
	[IdTransportista] [int] NULL,
	[Peso] [decimal](10, 2) NULL,
	[Bultos] [int] NULL,
	[Valor] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Remitos] PRIMARY KEY CLUSTERED 
(
	[IdRemito] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Transportistas]    Script Date: 09/09/2007 16:47:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Transportistas](
	[IdTransportista] [int] NOT NULL,
	[Transportista] [varchar](100) NOT NULL,
	[Domicilio] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Transportistas] PRIMARY KEY CLUSTERED 
(
	[IdTransportista] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Categoria]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_CondicionesIVA] FOREIGN KEY([IdCondicionIVA])
REFERENCES [dbo].[CondicionesIVA] ([IdCondicionIVA])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_CondicionesIVA]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Operatorias] FOREIGN KEY([IdOperatoria])
REFERENCES [dbo].[Operatorias] ([IdOperatoria])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Operatorias]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Provincias] FOREIGN KEY([IdProvincia])
REFERENCES [dbo].[Provincias] ([IdProvincia])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Provincias]
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos]  WITH CHECK ADD  CONSTRAINT [FK_CuentaCorriente_Movimientos_CuentasCorriente] FOREIGN KEY([IdCuentaCorriente])
REFERENCES [dbo].[CuentasCorriente] ([IdCuentaCorriente])
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos] CHECK CONSTRAINT [FK_CuentaCorriente_Movimientos_CuentasCorriente]
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos]  WITH NOCHECK ADD  CONSTRAINT [FK_CuentaCorriente_Movimientos_Facturas] FOREIGN KEY([IdFactura])
REFERENCES [dbo].[Facturas] ([IdFactura])
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos] NOCHECK CONSTRAINT [FK_CuentaCorriente_Movimientos_Facturas]
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos]  WITH NOCHECK ADD  CONSTRAINT [FK_CuentaCorriente_Movimientos_FormasDePago] FOREIGN KEY([IdFormaDePago])
REFERENCES [dbo].[FormasDePago] ([IdFormaDePago])
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos] NOCHECK CONSTRAINT [FK_CuentaCorriente_Movimientos_FormasDePago]
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos]  WITH CHECK ADD  CONSTRAINT [FK_CuentaCorriente_Movimientos_Movimientos] FOREIGN KEY([IdMovimiento])
REFERENCES [dbo].[MovimientosTipo] ([IdMovimiento])
GO
ALTER TABLE [dbo].[CuentaCorriente_Movimientos] CHECK CONSTRAINT [FK_CuentaCorriente_Movimientos_Movimientos]
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos]  WITH CHECK ADD  CONSTRAINT [FK_CuentaCorriente_Pagos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos] CHECK CONSTRAINT [FK_CuentaCorriente_Pagos_Clientes]
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos]  WITH CHECK ADD  CONSTRAINT [FK_CuentaCorriente_Pagos_CuentasCorriente] FOREIGN KEY([IdCuentaCorriente])
REFERENCES [dbo].[CuentasCorriente] ([IdCuentaCorriente])
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos] CHECK CONSTRAINT [FK_CuentaCorriente_Pagos_CuentasCorriente]
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos]  WITH CHECK ADD  CONSTRAINT [FK_CuentaCorriente_Pagos_FormasDePago] FOREIGN KEY([IdFormaDePago])
REFERENCES [dbo].[FormasDePago] ([IdFormaDePago])
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos] CHECK CONSTRAINT [FK_CuentaCorriente_Pagos_FormasDePago]
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos_DatosDelPago]  WITH CHECK ADD  CONSTRAINT [FK_CuentaCorriente_Pagos_DatosDelPago_CuentaCorriente_Pagos] FOREIGN KEY([IdPago])
REFERENCES [dbo].[CuentaCorriente_Pagos] ([IdPago])
GO
ALTER TABLE [dbo].[CuentaCorriente_Pagos_DatosDelPago] CHECK CONSTRAINT [FK_CuentaCorriente_Pagos_DatosDelPago_CuentaCorriente_Pagos]
GO
ALTER TABLE [dbo].[Descuentos]  WITH CHECK ADD  CONSTRAINT [FK_Descuentos_Categorias] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categorias] ([IdCategoria])
GO
ALTER TABLE [dbo].[Descuentos] CHECK CONSTRAINT [FK_Descuentos_Categorias]
GO
ALTER TABLE [dbo].[Descuentos]  WITH CHECK ADD  CONSTRAINT [FK_Descuentos_Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[Descuentos] CHECK CONSTRAINT [FK_Descuentos_Clientes]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas1_1NotaPedidos] FOREIGN KEY([IdNotaPedido])
REFERENCES [dbo].[NotaPedidos] ([IdNotaPedido])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas1_1NotaPedidos]
GO
ALTER TABLE [dbo].[NotaPedido_Items]  WITH CHECK ADD  CONSTRAINT [FK_NotaPedido_Items1_1Articulo] FOREIGN KEY([IdArticulo])
REFERENCES [dbo].[Articulos] ([idArticulo])
GO
ALTER TABLE [dbo].[NotaPedido_Items] CHECK CONSTRAINT [FK_NotaPedido_Items1_1Articulo]
GO
ALTER TABLE [dbo].[NotaPedido_Items]  WITH CHECK ADD  CONSTRAINT [FK_NotaPedido_Items1_nNotaPedidos] FOREIGN KEY([IdNotaPedido])
REFERENCES [dbo].[NotaPedidos] ([IdNotaPedido])
GO
ALTER TABLE [dbo].[NotaPedido_Items] CHECK CONSTRAINT [FK_NotaPedido_Items1_nNotaPedidos]
GO
ALTER TABLE [dbo].[NotaPedidos]  WITH CHECK ADD  CONSTRAINT [FK_NotaPedidos1_1Clientes] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO
ALTER TABLE [dbo].[NotaPedidos] CHECK CONSTRAINT [FK_NotaPedidos1_1Clientes]
GO
ALTER TABLE [dbo].[Remitos]  WITH CHECK ADD  CONSTRAINT [FK_Remitos_NotaPedidos] FOREIGN KEY([IdNotaPedido])
REFERENCES [dbo].[NotaPedidos] ([IdNotaPedido])
GO
ALTER TABLE [dbo].[Remitos] CHECK CONSTRAINT [FK_Remitos_NotaPedidos]