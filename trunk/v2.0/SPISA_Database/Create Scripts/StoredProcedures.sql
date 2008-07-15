 USE [SPISA]
GO
/****** Object:  StoredProcedure [dbo].[Articulos_Actualizar]    Script Date: 09/08/2007 20:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Articulos_Actualizar]
	@IdArticulo int,
	@IdCategoria int,
	@Codigo varchar(20),
	@Descripcion varchar(`500),
	@Cantidad Decimal(10,2), 
	@PrecioUnitario money
AS
BEGIN
	UPDATE Articulos
	SET IdCategoria=@IdCategoria, Codigo=@Codigo, Descripcion=@Descripcion, Cantidad=@Cantidad, PrecioUnitario=@PrecioUnitario
	WHERE IdArticulo=@IdArticulo
END




GO
/****** Object:  StoredProcedure [dbo].[Articulos_Buscar]    Script Date: 09/08/2007 20:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Articulos_Buscar]
	@Codigo varchar(20) = null,
	@Descripcion varchar(500) = null,
	@IdCategoria int = -1
AS
BEGIN
	SELECT a.IdArticulo, a.Codigo, a.Cantidad, a.Descripcion, a.PrecioUnitario, c.Descripcion
	FROM Articulos a
	INNER JOIN Categorias c on c.IdCategoria = a.IdCategoria

	WHERE (not (@Codigo is null) and not (@Descripcion is null) and not (@IdCategoria = -1) 
			   and (a.Codigo like '%' + @Codigo + '%' and
					a.Descripcion like '%' + @Descripcion + '%' and
					c.Descripcion=(Select Descripcion from Categorias where IdCategoria = @IdCategoria))
		  
		  )


END



GO
/****** Object:  StoredProcedure [dbo].[Articulos_CantidadSalidasPorArticuloPorFecha]    Script Date: 09/08/2007 20:32:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Articulos_CantidadSalidasPorArticuloPorFecha]
	@IdArticulo int,
	@Fecha DateTime
AS
BEGIN
	select sum(cantidad) from notapedido_items npi 
	inner join Facturas f on f.IdNotaPedido = npi.IdNotaPedido
	where npi.IdArticulo=@IdArticulo and Month(f.Fecha)=Month(@Fecha) and Year(f.Fecha) = Year(@Fecha)
END





GO
/****** Object:  StoredProcedure [dbo].[Articulos_GuardarArticulo]    Script Date: 09/08/2007 20:32:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Articulos_GuardarArticulo]
	@IdCategoria int,
	@Codigo varchar(20),
	@Descripcion varchar(500),
	@Cantidad Decimal(10,2), 
	@PrecioUnitario money
AS
BEGIN

	INSERT INTO ARTICULOS (idCategoria, codigo, descripcion, cantidad, preciounitario)
	VALUES(@IdCategoria, @Codigo, @Descripcion, @Cantidad, @PrecioUnitario)
	
	select @@identity as Id
END





GO
/****** Object:  StoredProcedure [dbo].[Articulos_SustraerCantidad]    Script Date: 09/08/2007 20:32:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Articulos_SustraerCantidad]
	@IdArticulo int,
	@Cantidad int 
AS
BEGIN
	UPDATE Articulos
	SET cantidad=cantidad-@Cantidad
	WHERE idArticulo=@IdArticulo

	select @@RowCount 
END



GO
/****** Object:  StoredProcedure [dbo].[Articulos_TraerArticuloPorCodigo]    Script Date: 09/08/2007 20:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Articulos_TraerArticuloPorCodigo]
	@codigo varchar(20)
AS
BEGIN
	select * from Articulos where codigo=@codigo
END



GO
/****** Object:  StoredProcedure [dbo].[Articulos_TraerArticuloPorID]    Script Date: 09/08/2007 20:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Articulos_TraerArticuloPorID]
	@IdArticulo int
AS
BEGIN
	SELECT * FROM Articulos
	WHERE IdArticulo=@IdArticulo
END



GO
/****** Object:  StoredProcedure [dbo].[Articulos_TraerArticulosPorDescripcion]    Script Date: 09/08/2007 20:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Articulos_TraerArticulosPorDescripcion]
	@Descripcion varchar(500)
AS
BEGIN
	SELECT IdArticulo, IdCategoria, Codigo, Descripcion, Cantidad, PrecioUnitario
	FROM Articulos
	WHERE Descripcion like '%' + @Descripcion + '%'
END



GO
/****** Object:  StoredProcedure [dbo].[Articulos_TraerTodos]    Script Date: 09/08/2007 20:32:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Articulos_TraerTodos]
AS
BEGIN
	SELECT IdArticulo, Codigo, c.Descripcion as Categoria, a.Descripcion, Cantidad, PrecioUnitario
	FROM Articulos a
	INNER JOIN Categorias c on c.IdCategoria=a.IdCategoria
END






GO
/****** Object:  StoredProcedure [dbo].[Categorias_ActualizarCategoria]    Script Date: 09/08/2007 20:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categorias_ActualizarCategoria]
	@IdCategoria int,
	@Descripcion varchar(50),	
	@Descuento int
AS
BEGIN
	UPDATE Categorias
	SET Descripcion=@Descripcion, Descuento=@Descuento
	WHERE IdCategoria=@IdCategoria
END



GO
/****** Object:  StoredProcedure [dbo].[Categorias_GuardarCategoria]    Script Date: 09/08/2007 20:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categorias_GuardarCategoria]
	@Descripcion varchar(50),
	@Descuento int 
AS
BEGIN
	INSERT INTO Categorias
	VALUES (@Descripcion, @Descuento)
END



GO
/****** Object:  StoredProcedure [dbo].[Categorias_TraerPorDescripcion]    Script Date: 09/08/2007 20:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categorias_TraerPorDescripcion]
	@Descripcion varchar(50)
AS
BEGIN
	SELECT IdCategoria, Descripcion, Descuento
    FROM Categorias
	WHERE Descripcion=@Descripcion
END



GO
/****** Object:  StoredProcedure [dbo].[Categorias_TraerPorId]    Script Date: 09/08/2007 20:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categorias_TraerPorId]
	@IdCategoria int
AS
BEGIN
	SELECT IdCategoria, Descripcion, Descuento
	FROM Categorias
	WHERE IdCategoria=@IdCategoria
END




GO
/****** Object:  StoredProcedure [dbo].[Categorias_TraerTodas]    Script Date: 09/08/2007 20:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Categorias_TraerTodas]
	
AS
BEGIN
	SELECT Idcategoria, Descripcion
	FROM Categorias
END



GO
/****** Object:  StoredProcedure [dbo].[Clientes_ActualizarCliente]    Script Date: 09/08/2007 20:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clientes_ActualizarCliente]
	@IdCliente int,
	@Codigo varchar(10),
	@RazonSocial varchar(100),
	@Domicilio varchar(100),
	@Localidad varchar(40),
	@IdProvincia int,
	@IdCondicionIVA int,
	@CUIT varchar(11),
	@IdOperatoria int
	

AS
BEGIN
	UPDATE Clientes 
	SET Codigo=@Codigo,
	    RazonSocial=@RazonSocial, 
		Domicilio=@Domicilio, 
		Localidad=@Localidad, 
		IdProvincia=@IdProvincia, 
		IdCondicionIVA=@IdCondicionIVA, 
		CUIT=@CUIT, 
		IdOperatoria=@IdOperatoria
	WHERE IdCliente=@IdCliente
END



GO
/****** Object:  StoredProcedure [dbo].[Clientes_Buscar]    Script Date: 09/08/2007 20:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clientes_Buscar]
	@Codigo varchar(10) = '',
	@Localidad varchar(40) = '',
	@RazonSocial varchar(100) = '',
	@SaldoNegativo bit = 0
AS
BEGIN
	select IdCliente, Codigo, RazonSocial, Domicilio, Localidad, p.Provincia, ci.CondicionIVA, CUIT, o.Operatoria, Saldo
	FROM Clientes c
	INNER JOIN Provincias p on p.IdProvincia = c.IdProvincia
	INNER JOIN CondicionesIVA ci on ci.IdCondicionIVA = c.IdCondicionIVA
	INNER JOIN Operatorias o on o.IdOperatoria = c.IdOperatoria
	WHERE
	((@Codigo = '') and (@RazonSocial = '') and (@Localidad = '') and (@SaldoNegativo = 1) and  --0001
		  (c.Saldo<0))
	 or
	((@Codigo = '') and  (@RazonSocial = '') and not (@Localidad = '') and (@SaldoNegativo = 0) and --0010
		  (c.Localidad like '%' + @Localidad + '%'))
	 or
	((@Codigo = '') and  (@RazonSocial = '') and not (@Localidad = '') and (@SaldoNegativo = 1) and --0011
		  (c.Localidad like '%' + @Localidad + '%') and (c.Saldo<0))
	 or
	((@Codigo = '') and  not (@RazonSocial = '') and  (@Localidad = '') and (@SaldoNegativo = 0) and --0100
		  (c.RazonSocial like '%' + @RazonSocial + '%' ))
     or
	((@Codigo = '') and  not (@RazonSocial = '') and  (@Localidad = '') and (@SaldoNegativo = 1) and --0101
		  (c.RazonSocial like '%' + @RazonSocial + '%' ) and (c.Saldo<0))
	or
	((@Codigo = '') and  not (@RazonSocial = '') and  not (@Localidad = '') and (@SaldoNegativo = 1) and --0111
		  (c.RazonSocial like '%' + @RazonSocial + '%' ) and (c.Localidad like '%' + @Localidad + '%') and (c.Saldo<0))	
	or
	(not (@Codigo = '') and   (@RazonSocial = '') and   (@Localidad = '') and (@SaldoNegativo = 0) and --1000
		  (c.Codigo like '%' + @Codigo + '%' ))	
	or
	(not (@Codigo = '') and   (@RazonSocial = '') and   (@Localidad = '') and (@SaldoNegativo = 1) and --1001
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.Saldo<0))
	or
	(not (@Codigo = '') and   (@RazonSocial = '') and   not (@Localidad = '') and (@SaldoNegativo = 0) and --1010
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.Localidad like '%' + @Localidad + '%'))
	or
	(not (@Codigo = '') and   (@RazonSocial = '') and   not (@Localidad = '') and (@SaldoNegativo = 1) and --1011
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.Localidad like '%' + @Localidad + '%') and (c.Saldo<0))
	or
	(not (@Codigo = '') and  not (@RazonSocial = '') and (@Localidad = '') and (@SaldoNegativo = 0) and --1100
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.RazonSocial like '%' + @RazonSocial + '%' ))
	or
	(not (@Codigo = '') and  not (@RazonSocial = '') and (@Localidad = '') and (@SaldoNegativo = 1) and --1101
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.RazonSocial like '%' + @RazonSocial + '%' ) and (c.Saldo<0))
	or
	(not (@Codigo = '') and  not (@RazonSocial = '') and not (@Localidad = '') and (@SaldoNegativo = 0) and --1110
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.RazonSocial like '%' + @RazonSocial + '%' ) and (c.Localidad like '%' + @Localidad + '%'))
	or
	(not (@Codigo = '') and  not (@RazonSocial = '') and not (@Localidad = '') and (@SaldoNegativo = 1) and --1111
		  (c.Codigo like '%' + @Codigo + '%' ) and (c.RazonSocial like '%' + @RazonSocial + '%' ) and (c.Localidad like '%' + @Localidad + '%') and (c.Saldo<0))
END



GO
/****** Object:  StoredProcedure [dbo].[Clientes_GuardarCliente]    Script Date: 09/08/2007 20:32:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clientes_GuardarCliente]
	@Codigo varchar(10),
	@RazonSocial varchar(100),
	@Domicilio varchar(100),
	@Localidad varchar(40),
	@IdProvincia int,
	@IdCondicionIVA int,
	@CUIT varchar(11),
	@IdOperatoria int
	

AS
BEGIN
	IF (NOT EXISTS(SELECT IdCliente from Clientes where Codigo=@Codigo))
	BEGIN
		INSERT INTO Clientes 
		VALUES (@Codigo, @RazonSocial, @Domicilio, @Localidad, @IdProvincia, @IdCondicionIVA, @CUIT, @IdOperatoria, 0)
	END
	
END




GO
/****** Object:  StoredProcedure [dbo].[Clientes_TraerClientePorCodigo]    Script Date: 09/08/2007 20:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clientes_TraerClientePorCodigo]
	@Codigo varchar(50)
AS
BEGIN
	select IdCliente, Codigo, RazonSocial, Domicilio, Localidad, IdProvincia, IdCondicionIVA, CUIT, IdOperatoria, Saldo
	FROM Clientes c
	where Codigo=@Codigo 
END






GO
/****** Object:  StoredProcedure [dbo].[Clientes_TraerPorId]    Script Date: 09/08/2007 20:32:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Clientes_TraerPorId]
	@IdCliente int
AS
BEGIN
	select IdCliente, Codigo, RazonSocial, Domicilio, Localidad, IdProvincia, IdCondicionIVA, CUIT, IdOperatoria, Saldo
	FROM Clientes c
	WHERE IdCliente = @IdCliente
END






GO
/****** Object:  StoredProcedure [dbo].[Clientes_TraerTodos]    Script Date: 09/08/2007 20:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clientes_TraerTodos]

AS
BEGIN

	select IdCliente, Codigo, RazonSocial, Domicilio, Localidad, p.Provincia, ci.CondicionIVA, CUIT, o.Operatoria, Saldo
	FROM Clientes c
	INNER JOIN Provincias p on p.IdProvincia = c.IdProvincia
	INNER JOIN CondicionesIVA ci on ci.IdCondicionIVA = c.IdCondicionIVA
	INNER JOIN Operatorias o on o.IdOperatoria = c.IdOperatoria

END









GO
/****** Object:  StoredProcedure [dbo].[CondicionesIVA_TraerPorId]    Script Date: 09/08/2007 20:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CondicionesIVA_TraerPorId]
	@IdCondicionIva int 
AS
BEGIN
	SELECT IdCondicionIVA, CondicionIVA
	FROM CondicionesIVA
	WHERE IdCondicionIVA=@IdCondicionIVA
END




GO
/****** Object:  StoredProcedure [dbo].[CondicionesIVA_TraerTodas]    Script Date: 09/08/2007 20:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CondicionesIVA_TraerTodas]
	
AS
BEGIN
	SELECT IdCondicionIVA, CondicionIVA
	FROM CondicionesIVA
END




GO
/****** Object:  StoredProcedure [dbo].[CuentaCorriente_Agregar]    Script Date: 09/08/2007 20:32:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CuentaCorriente_Agregar]
	@IdCliente int 
AS
BEGIN
	declare @FechaCreacion datetime
	declare @IdCuentaCorriente int 

	set @FechaCreacion = getdate()
	INSERT INTO CuentasCorriente (FechaCreacion, IdCliente) Values(@FechaCreacion, @IdCliente)

	set @IdCuentaCorriente=@@Identity

	select @IdCuentaCorriente as IdCuentaCorriente

	
END




GO
/****** Object:  StoredProcedure [dbo].[CuentaCorriente_AlmacenarMovimiento]    Script Date: 09/08/2007 20:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CuentaCorriente_AlmacenarMovimiento]
	@IdCuentaCorriente int,
	@IdFactura int,
	@Fecha datetime,
	@Monto varchar(50)
AS
BEGIN


	BEGIN TRANSACTION
		INSERT INTO CuentaCorriente_Movimientos
		VALUES(@IdCuentaCorriente, @IdFactura, @Fecha, @Monto)	

		
		declare @saldo decimal(10,2)
		set @Saldo = (select c.Saldo from Clientes c
						inner join cuentascorriente cc on cc.IdCliente = c.IdCliente
					  where cc.IdCuentaCorriente=1 )
		set @saldo = @saldo - @Monto

		declare @IdCliente int
		set @IdCliente = (select c.IdCliente from Clientes c
							inner join cuentascorriente cc on cc.IdCliente = c.IdCliente
					  where cc.IdCuentaCorriente=@IdCuentaCorriente)

		update Clientes set Saldo = @saldo where IdCliente=@IdCliente
	
		if (@@error>0)
		begin
			ROLLBACK TRANSACTION
			goto fin
		end

	COMMIT TRANSACTION

fin:
END






GO
/****** Object:  StoredProcedure [dbo].[CuentaCorriente_TraerPorIdCliente]    Script Date: 09/08/2007 20:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CuentaCorriente_TraerPorIdCliente]
	@IdCliente int 
AS
BEGIN
	select IdCuentaCorriente, FechaCreacion
    from CuentasCorriente 
	where IdCliente=@IdCliente
END




GO
/****** Object:  StoredProcedure [dbo].[Descuentos_AgregarDescuento]    Script Date: 09/08/2007 20:32:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Descuentos_AgregarDescuento]
	@IdCliente int,
	@IdCategoria int,
	@Descuento int
AS
BEGIN
	INSERT INTO Descuentos
	Values(@IdCliente, @IdCategoria, @Descuento)
END



GO
/****** Object:  StoredProcedure [dbo].[Descuentos_EliminarPorIdCliente]    Script Date: 09/08/2007 20:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Descuentos_EliminarPorIdCliente]
	@IdCliente int 
AS
BEGIN
	DELETE 
	FROM Descuentos
	WHERE IdCliente=@IdCliente
END



GO
/****** Object:  StoredProcedure [dbo].[Descuentos_TraerPorIdCliente]    Script Date: 09/08/2007 20:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Descuentos_TraerPorIdCliente]
	@IdCliente int
AS
BEGIN
	SELECT IdCategoria, Descuento 
	FROM Descuentos
	WHERE IdCliente=@IdCliente
END




GO
/****** Object:  StoredProcedure [dbo].[Factura_Imprimir]    Script Date: 09/08/2007 20:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Factura_Imprimir]
	@IdFactura int
AS
BEGIN
	
	
	declare @valorDolar Decimal(10,2)
	declare @IdNotaPedido int

	set @IdNotaPedido = (SELECT IdNotaPedido FROM Facturas WHERE IdFactura=@IdFactura)
	set @valorDolar = (select valorDolar from Facturas where IdFactura=@IdFactura)

	SELECT f.Fecha, c.RazonSocial, c.Domicilio, c.Localidad
	from Facturas f
	INNER JOIN NotaPedidos np on np.IdNotaPedido = @IdNotaPedido
	INNER JOIN Clientes c on c.IdCliente = np.IdCliente
	WHERE f.IdFactura=@IdFactura

	SELECT Cantidad, (PrecioUnitario*@valorDolar) 'PrecioUnitario', ((Cantidad*(PrecioUnitario*@valorDolar))-(Cantidad*(PrecioUnitario*@valorDolar)*Descuento/100)) 'Importe'
	FROM NotaPedido_Items
	WHERE IdNotaPedido=@IdNotaPedido
	
	declare @SubTotal decimal(10,2)
	declare @IvaInscripto decimal(10,2)
	declare @Total decimal(10,2)

	select @SubTotal = 	(select sum(SubTotal) 'SubTotal'
						From
								(SELECT ((Cantidad*(PrecioUnitario*@valorDolar))-(Cantidad*(PrecioUnitario*@valorDolar)*Descuento/100)) 'SubTotal'
								FROM NotaPedido_Items
								WHERE IdNotaPedido=@IdNotaPedido) as SubTotal)
	select @IvaInscripto = (select (sum(SubTotal)*0.21)  'SubTotal'
							From
								(SELECT ((Cantidad*(PrecioUnitario*@valorDolar))-(Cantidad*(PrecioUnitario*@valorDolar)*Descuento/100)) 'SubTotal'
								FROM NotaPedido_Items
								WHERE IdNotaPedido=@IdNotaPedido) as SubTotal)
	set @Total = @SubTotal + @IvaInscripto
	
	select @SubTotal 'SubTotal', @IvaInscripto 'Iva21', @Total 'Total'
END



GO
/****** Object:  StoredProcedure [dbo].[Facturas_ActualizarFactura]    Script Date: 09/08/2007 20:32:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[Facturas_ActualizarFactura]
	@IdFactura int, 
	@Fecha DateTime,
	@Observaciones varchar(500),
	@DescuentoEspecial int,
	@ValorDolar	float
AS
BEGIN
	UPDATE Facturas SET Fecha=@Fecha, Observaciones=@Observaciones, ValorDolar=@ValorDolar
	WHERE IdFactura=@IdFactura

	DECLARE @IdNotaPedido int
	SET @IdNotaPedido = (select IdNotaPedido from Facturas where IdFactura = @IdFactura)

	UPDATE NotaPedidos
	SET DescuentoEspecial = @DescuentoEspecial
	WHERE IdNotaPedido = @IdNotaPedido
END







GO
/****** Object:  StoredProcedure [dbo].[Facturas_AlmacenarImpresion]    Script Date: 09/08/2007 20:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Facturas_AlmacenarImpresion]
	@IdFactura int
AS
BEGIN
	UPDATE Facturas set FueImpresa=1 
	WHERE IdFactura=@IdFactura
END



GO
/****** Object:  StoredProcedure [dbo].[Facturas_CancelarFactura]    Script Date: 09/08/2007 20:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Facturas_CancelarFactura]
	@IdFactura int
AS
BEGIN
	
	if (exists(SELECT IdFactura FROM Facturas WHERE IdFactura=@IdFactura))
	begin
		BEGIN TRANSACTION
		
		declare @FueImpresa int 
		declare @IdNotaPedido int
		set @FueImpresa = (SELECT FueImpresa from Facturas where IdFactura=@IdFactura)
		set @IdNotaPedido = (SELECT IdNotaPedido from Facturas where IdFactura=@IdFactura)
		
		
		if (@FueImpresa=1)
		begin
			DECLARE @IdArticulo int, @Cantidad int
			DECLARE Items CURSOR FORWARD_ONLY READ_ONLY
			FOR SELECT IdArticulo, Cantidad from NotaPedido_Items WHERE IdNotaPedido=@IdNotaPedido

			open Items
			FETCH NEXT FROM Items INTO @IdArticulo, @Cantidad
	
			WHILE @@FETCH_STATUS = 0
			BEGIN
				UPDATE Articulos SET Cantidad = Cantidad + @Cantidad 
				WHERE IdArticulo=@IdArticulo

				FETCH NEXT FROM Items INTO @IdArticulo, @Cantidad

				if (@@error>0)
				begin
					ROLLBACK TRANSACTION
					goto fin
				end
			END
	
			close Items
			deallocate items		

			declare @Monto decimal(10,2) -- eliminamos el movimientos y actualizamos el saldo del cliente
			set @Monto = (SELECT Monto from CuentaCorriente_Movimientos WHERE IdFactura = @IdFactura)
	

			declare @IdCliente int
			set @IdCliente = (SELECT np.IdCliente from Facturas f
							  INNER JOIN NotaPedidos np on np.IdNotaPedido = f.IdNotaPedido
							  WHERE f.IdFactura=@IdFactura)

			UPDATE Clientes Set Saldo=(Saldo+@Monto)
			WHERE IdCliente=@IdCliente

			if (@@error>0)
			begin
				ROLLBACK TRANSACTION
				goto fin
			end

			DELETE FROM CuentaCorriente_Movimientos	
			WHERE IdFactura=@IdFactura
			
			if (@@error>0)
			begin
				ROLLBACK TRANSACTION
				goto fin
			end

			UPDATE Facturas set FueCancelada = 1 
			WHERE IdFactura=@IdFactura

			if (@@error>0)
			begin
				ROLLBACK TRANSACTION
				goto fin
			end
		end
		else
		begin
			
			delete from Facturas where IdFactura=@IdFactura
	
		
		end

		

		
	end	

	COMMIT TRANSACTION

fin:

END




GO
/****** Object:  StoredProcedure [dbo].[Facturas_GuardarFactura]    Script Date: 09/08/2007 20:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Facturas_GuardarFactura]
	@Fecha datetime, 
	@IdNotaPedido int,
	@NumeroFactura int,
	@Observaciones varchar(500),
	@DescuentoEspecial int,
	@ValorDolar float
AS
BEGIN
		INSERT INTO Facturas (IdNotaPedido, NumeroFactura, Fecha, Observaciones,  ValorDolar)
		VALUES (@IdNotaPedido, @NumeroFactura, @Fecha, @Observaciones,  @ValorDolar)

		UPDATE NotaPedidos
		SET DescuentoEspecial = @DescuentoEspecial
		WHERE IdNotaPedido = @IdNotaPedido

		select @@identity
END













GO
/****** Object:  StoredProcedure [dbo].[Facturas_ObtenerNumeroNumeroDeFactura]    Script Date: 09/08/2007 20:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Facturas_ObtenerNumeroNumeroDeFactura]
	
AS
BEGIN
	SELECT ISNULL(MAX(NumeroFactura) + 1, 1) 'NumeroFactura'
	FROM Facturas
END





GO
/****** Object:  StoredProcedure [dbo].[Facturas_TraerEntreFechas]    Script Date: 09/08/2007 20:32:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Facturas_TraerEntreFechas]
	@FechaInicio datetime,
	@FechaFin datetime
AS
BEGIN
	SELECT f.IdNotaPedido, f.IdFactura,  f.NumeroFactura, f.Fecha, c.RazonSocial
	FROM Facturas f 
	INNER JOIN NotaPedidos np on np.IdNotaPedido = f.IdNotaPedido
	INNER JOIN Clientes c on c.IdCliente=np.IdCliente
	WHERE f.Fecha between @FechaInicio and @FechaFin
	ORDER BY f.IdNotaPedido

	
	select npi.idNotaPedido, a.descripcion, npi.cantidad 
	FROM NotaPedido_items npi
	INNER JOIN Articulos a on a.IdArticulo=npi.IdArticulo
	WHERE npi.IdNotaPedido in (select IdNotaPedido from Facturas)
	ORDER BY npi.IdNotaPedido
END



GO
/****** Object:  StoredProcedure [dbo].[Facturas_TraerFacturaPorID]    Script Date: 09/08/2007 20:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Facturas_TraerFacturaPorID]
	@IdFactura int
AS
BEGIN
SELECT f.IdNotaPedido, f.IdFactura, f.Observaciones, f.FueImpresa, f.FueCancelada,  f.NumeroFactura, f.Fecha, f.ValorDolar, c.RazonSocial
	FROM Facturas f 
	INNER JOIN NotaPedidos np on np.IdNotaPedido = f.IdNotaPedido
	INNER JOIN Clientes c on c.IdCliente=np.IdCliente
	WHERE f.IdFactura=@IdFactura
	ORDER BY f.IdNotaPedido

	SELECT * FROM NotaPedido_Items where IdNotaPedido=(SELECT IdNotaPedido FROM Facturas where IdFactura=@IdFactura)
	
	
END













GO
/****** Object:  StoredProcedure [dbo].[Facturas_TraerFacturaPorIdNotaPedido]    Script Date: 09/08/2007 20:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Facturas_TraerFacturaPorIdNotaPedido]
	@IdNotaPedido int 
AS
BEGIN
	SELECT * FROM Facturas
	WHERE IdNotaPedido=@IdNotaPedido
END



GO
/****** Object:  StoredProcedure [dbo].[Facturas_TraerItems]    Script Date: 09/08/2007 20:32:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
CREATE PROCEDURE [dbo].[Facturas_TraerItems]
	@idFactura int
AS
BEGIN
	select tm.id, tm.descripcion, fi.cantidad, tm.preciounitario from tblFacturas_Items fi
	inner join tblMateriales tm on tm.id=fi.idMaterial
	where idFactura=@idFactura
END



GO
/****** Object:  StoredProcedure [dbo].[Facturas_TraerPorIdNotaPedido]    Script Date: 09/08/2007 20:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Facturas_TraerPorIdNotaPedido] 
	@IdNotaPedido int
AS
BEGIN
	SELECT * FROM Facturas
	WHERE IdNotaPedido=@IdNotaPedido
END



GO
/****** Object:  StoredProcedure [dbo].[Facturas_TraerTodas]    Script Date: 09/08/2007 20:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Facturas_TraerTodas]

AS
BEGIN
	
	SELECT f.IdNotaPedido, f.IdFactura,  f.NumeroFactura, f.Fecha, c.RazonSocial
	FROM Facturas f 
	INNER JOIN NotaPedidos np on np.IdNotaPedido = f.IdNotaPedido
	INNER JOIN Clientes c on c.IdCliente=np.IdCliente
	ORDER BY f.IdNotaPedido

	select npi.idNotaPedido, a.descripcion, npi.cantidad 
	FROM NotaPedido_items npi
	INNER JOIN Articulos a on a.IdArticulo=npi.IdArticulo
	WHERE npi.IdNotaPedido in (select IdNotaPedido from Facturas)
	ORDER BY npi.IdNotaPedido

END




GO
/****** Object:  StoredProcedure [dbo].[MovimientosStock_AlmacenarMovimiento]    Script Date: 09/08/2007 20:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[MovimientosStock_AlmacenarMovimiento]
	@IdArticulo int,
	@Fecha datetime,
	@Cantidad int
AS
BEGIN
	INSERT INTO MovimientosStock
	Values(@IdArticulo, @Fecha, @Cantidad)
END



GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_Actualizar]    Script Date: 09/08/2007 20:32:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_Actualizar]
	@IdNotaPedido int,
	@IdCliente int,
	@FechaEntrega datetime,
	@DescuentoEspecial int,
	@Observaciones varchar(500)
AS
BEGIN
	UPDATE NotaPedidos set IdCliente=@IdCliente, FechaEntrega=@FechaEntrega, DescuentoEspecial=@DescuentoEspecial, Observaciones=@Observaciones
	WHERE IdNotaPedido=@IdNotaPedido
END






GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_Borrar]    Script Date: 09/08/2007 20:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_Borrar]
	@IdNotaPedido int
AS
BEGIN
	BEGIN TRANSACTION
		DELETE FROM NotaPedido where IdNotaPedido=@IdNotaPedido
		DELETE FROM NotaPedido_Items where IdNotaPedido=@IdNotaPedido
	IF (@@ERROR=0)
	BEGIN
		COMMIT TRANSACTION
	END
	ELSE
	BEGIN
		ROLLBACK TRANSACTION
	END
END





GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_Buscar]    Script Date: 09/08/2007 20:32:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_Buscar]
	@RazonSocial varchar(200) = '',
	@FechaEmision DateTime = null,
	@FechaEntrega DateTime = null,
	@Observaciones varchar(500) = ''
AS
BEGIN
	DECLARE @auxIdNotasDePedido TABLE(
		IdNotaPedido int
	)

	
	INSERT INTO @auxIdNotasDePedido
	SELECT np.IdNotaPedido 
	FROM NotaPedidos np
	INNER JOIN Clientes c on c.IdCliente=np.IdCliente
	WHERE 
		(@RazonSocial='' and YEAR(@FechaEmision)='1753' and year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 0001
			np.Observaciones like '%' + @Observaciones + '%')
		or 
		(@RazonSocial='' and YEAR(@FechaEmision)='1753' and not year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 0010
		  (datediff(d, FechaEntrega, @FechaEntrega)=0))
		or
		(@RazonSocial='' and YEAR(@FechaEmision)='1753' and not year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 0011
		  (datediff(d, FechaEntrega, @FechaEntrega)=0 and np.Observaciones like '%' + @Observaciones + '%'))
		or
		(@RazonSocial='' and not YEAR(@FechaEmision)='1753' and  year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 0100
		  (datediff(d, FechaEmision, @FechaEmision)=0))
		or
		(@RazonSocial='' and not YEAR(@FechaEmision)='1753' and  year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 0101
		  (datediff(d, FechaEmision, @FechaEmision)=0) and np.Observaciones like '%' + @Observaciones + '%')
		or
		(@RazonSocial='' and not YEAR(@FechaEmision)='1753' and  not year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 0110
		  (datediff(d, FechaEmision, @FechaEmision)=0) and datediff(d, FechaEntrega, @FechaEntrega)=0)
		or
		(@RazonSocial='' and not YEAR(@FechaEmision)='1753' and  not year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 0111
		  (datediff(d, FechaEmision, @FechaEmision)=0) and datediff(d, FechaEntrega, @FechaEntrega)=0 and np.Observaciones like '%' + @Observaciones + '%')
		or
		(not @RazonSocial='' and YEAR(@FechaEmision)='1753' and year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 1000
		  (c.RazonSocial like '%' + @RazonSocial + '%'))
		or
		(not @RazonSocial='' and YEAR(@FechaEmision)='1753' and year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 1001
		  (c.RazonSocial like '%' + @RazonSocial + '%' and np.Observaciones like '%' + @Observaciones + '%'))
		or
		(not @RazonSocial='' and YEAR(@FechaEmision)='1753' and not year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 1010
		  (c.RazonSocial like '%' + @RazonSocial + '%' and datediff(d, FechaEntrega, @FechaEntrega)=0)) 
		or
		(not @RazonSocial='' and YEAR(@FechaEmision)='1753' and not year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 1011
		  (c.RazonSocial like '%' + @RazonSocial + '%' and datediff(d, FechaEntrega, @FechaEntrega)=0) and np.Observaciones like '%' + @Observaciones + '%') 
		or
		(not @RazonSocial='' and not YEAR(@FechaEmision)='1753' and year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 1100
		  (c.RazonSocial like '%' + @RazonSocial + '%' and datediff(d, FechaEmision, @FechaEmision)=0)) 
		or
		(not @RazonSocial='' and not YEAR(@FechaEmision)='1753' and year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 1101
		  (c.RazonSocial like '%' + @RazonSocial + '%' and datediff(d, FechaEmision, @FechaEmision)=0) and np.Observaciones like '%' + @Observaciones + '%') 
		or
		(not @RazonSocial='' and not YEAR(@FechaEmision)='1753' and not year(@FechaEntrega)='1753' and (@Observaciones='') and  -- 1110
		  (c.RazonSocial like '%' + @RazonSocial + '%' and datediff(d, FechaEmision, @FechaEmision)=0) and datediff(d, FechaEntrega, @FechaEntrega)=0) 
		or
		(not @RazonSocial='' and not YEAR(@FechaEmision)='1753' and not year(@FechaEntrega)='1753' and not (@Observaciones='') and  -- 1111
		  (c.RazonSocial like '%' + @RazonSocial + '%' and datediff(d, FechaEmision, @FechaEmision)=0) and datediff(d, FechaEntrega, @FechaEntrega)=0 and np.Observaciones like '%' + @Observaciones + '%') 

	SELECT np.IdNotaPedido, np.NumeroOrden, c.RazonSocial, np.FechaEmision, np.FechaEntrega, np.Observaciones	
	FROM NotaPedidos np
	INNER JOIN Clientes c on c.IdCliente=np.IdCliente
	WHERE np.IdNotaPedido in (select * from @auxIdNotasDePedido)
	
	select npi.idNotaPedido, a.descripcion, npi.cantidad, npi.descuento
	FROM NotaPedido_items npi
	INNER JOIN Articulos a on a.IdArticulo=npi.IdArticulo
	WHERE npi.IdNotaPedido in (select * from @auxIdNotasDePedido)
END





GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_Guardar]    Script Date: 09/08/2007 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_Guardar]
	@IdCliente int,
	@FechaEmision datetime,
	@FechaEntrega datetime,
	@DescuentoEspecial int,
	@Observaciones varchar(500)
AS
BEGIN
	declare @NuevoNumeroOrden int
	set @NuevoNumeroOrden = IsNull((select max(NumeroOrden) from NotaPedidos),0) + 1

	INSERT INTO NotaPedidos(NumeroOrden, IdCliente, FechaEmision, FechaEntrega, DescuentoEspecial, Observaciones)
	values (@NuevoNumeroOrden, @IdCliente, @FechaEmision, @FechaEntrega, @DescuentoEspecial, @Observaciones) 

	select @@identity	
END








GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_Items_AgregarItem]    Script Date: 09/08/2007 20:32:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_Items_AgregarItem]
	@IdNotaPedido int, 
	@IdArticulo int,
	@Cantidad Decimal(10,2),
	@PrecioUnitario decimal(18,2),
	@Descuento int
AS
BEGIN
	INSERT INTO NotaPedido_Items
	values (@IdNotaPedido, @IdArticulo, @Cantidad, @PrecioUnitario, @Descuento)
END














GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_Items_BorrarPorIdNotaPedido]    Script Date: 09/08/2007 20:32:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_Items_BorrarPorIdNotaPedido]
	@IdNotaPedido int 
AS
BEGIN
	DELETE FROM NotaPedido_Items
	WHERE IdNotaPedido=@IdNotaPedido
END




GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_ObtenerUltimoNumeroDeOrden]    Script Date: 09/08/2007 20:32:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_ObtenerUltimoNumeroDeOrden]
	
AS
BEGIN
	SELECT ISNULL(MAX(NumeroOrden),0) FROM NotaPedidos
END




GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_TraerPorId]    Script Date: 09/08/2007 20:32:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[NotaPedido_TraerPorId] 
	@IdNotaPedido int 
AS
BEGIN
	declare @fueFacturado bit 
	set @fueFacturado = ISNULL((select 1 from facturas where idnotapedido=@idnotapedido), 0) 

	SELECT np.*, @fueFacturado as Facturado
	FROM NotaPedidos np
	WHERE IdNotaPedido=@idnotapedido
	
	SELECT * FROM NotaPedido_Items where IdNotaPedido=@IdNotaPedido
END




GO
/****** Object:  StoredProcedure [dbo].[NotaPedido_TraerTodas]    Script Date: 09/08/2007 20:32:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[NotaPedido_TraerTodas]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	select np.IdNotaPedido, NumeroOrden, c.RazonSocial, FechaEmision, Fechaentrega,  Observaciones
	FROM NotaPedidos np
	INNER JOIN Clientes c on c.IdCliente=np.IdCliente
	
	
	select npi.idNotaPedido, a.descripcion, npi.cantidad, npi.descuento
	FROM NotaPedido_items npi
	INNER JOIN Articulos a on a.IdArticulo=npi.IdArticulo

END










GO
/****** Object:  StoredProcedure [dbo].[Operatorias_TraerPorId]    Script Date: 09/08/2007 20:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Operatorias_TraerPorId]
	@IdOperatoria int
AS
BEGIN
	SELECT IdOperatoria, Operatoria
	FROM Operatorias
	WHERE IdOperatoria=@IdOperatoria
END




GO
/****** Object:  StoredProcedure [dbo].[Operatorias_TraerTodas]    Script Date: 09/08/2007 20:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Operatorias_TraerTodas]
	
AS
BEGIN
	SELECT IdOperatoria, Operatoria
	FROM Operatorias
END



GO
/****** Object:  StoredProcedure [dbo].[Provincias_TraerPorId]    Script Date: 09/08/2007 20:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Provincias_TraerPorId]
	@idProvincia int 
AS
BEGIN
	SELECT IdProvincia, Provincia 
	FROM Provincias	
END





GO
/****** Object:  StoredProcedure [dbo].[Provincias_TraerTodas]    Script Date: 09/08/2007 20:32:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Provincias_TraerTodas]
	
AS
BEGIN
	SELECT IdProvincia, Provincia
	FROM Provincias
END




GO
/****** Object:  StoredProcedure [dbo].[Remitos_ActualizarRemito]    Script Date: 09/08/2007 20:32:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Remitos_ActualizarRemito]
	@IdRemito int,
	@Fecha datetime,
	@Observaciones varchar(200),
	@IdTransportista int,
	@Peso decimal(10,2),
	@Bultos int,
	@Valor decimal(10,2)
AS
BEGIN
	UPDATE Remitos 
		   SET Fecha=@Fecha, Observaciones=@Observaciones, IdTransportista=@IdTransportista, Peso=@Peso, Bultos=Bultos, Valor=@Valor
	WHERE IdRemito=@IdRemito
END





GO
/****** Object:  StoredProcedure [dbo].[Remitos_GuardarRemito]    Script Date: 09/08/2007 20:32:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Remitos_GuardarRemito]
	@IdNotaPedido int,
	@NumeroRemito varchar(16),
	@Fecha datetime,
	@Observaciones varchar(200),
	@IdTransportista int,
	@Peso decimal(10,2),
	@Bultos int,
	@Valor decimal(10,2)
AS
BEGIN
	INSERT INTO Remitos Values(@IdNotaPedido, @NumeroRemito, @Fecha, @Observaciones, @IdTransportista, @Peso, @Bultos, @Valor);

	select @@Identity
END




GO
/****** Object:  StoredProcedure [dbo].[Remitos_TraerRemitoPorID]    Script Date: 09/08/2007 20:32:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Remitos_TraerRemitoPorID] 
	@IdRemito int
AS
BEGIN
	SELECT r.IdRemito, r.IdNotaPedido, np.IdCliente, r.NumeroRemito, r.Fecha, r.Observaciones, r.IdTransportista, r.Peso,
		   r.Bultos, r.Valor
    FROM Remitos r
	INNER JOIN NotaPedidos np on np.idNotaPedido = r.IdNotaPedido
	WHERE r.IdRemito = @IdRemito

	SELECT IdArticulo, Cantidad, PrecioUnitario, Descuento
	FROM NotaPedido_Items
	WHERE IdNotaPedido=(SELECT IdNotaPedido FROM Remitos WHERE IdRemito=@IdRemito)

END



GO
/****** Object:  StoredProcedure [dbo].[Remitos_TraerRemitoPorIdNotaPedido]    Script Date: 09/08/2007 20:32:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Remitos_TraerRemitoPorIdNotaPedido]
	@IdNotaPedido int
AS
BEGIN
	SELECT r.IdRemito, r.IdNotaPedido, np.IdCliente, r.NumeroRemito, r.Fecha, r.Observaciones, r.IdTransportista, r.Peso,
		   r.Bultos, r.Valor
    FROM Remitos r
	INNER JOIN NotaPedidos np on np.idNotaPedido = r.IdNotaPedido
	WHERE r.IdNotaPedido = @IdNotaPedido

	SELECT IdArticulo, Cantidad, PrecioUnitario, Descuento
	FROM NotaPedido_Items
	WHERE IdNotaPedido=@IdNotaPedido

END



GO
/****** Object:  StoredProcedure [dbo].[Remitos_TraerTodos]    Script Date: 09/08/2007 20:32:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Remitos_TraerTodos]
	
AS
BEGIN
	SELECT r.IdRemito, r.IdNotaPedido, r.NumeroRemito, r.Fecha, c.RazonSocial	
	FROM Remitos r
	INNER JOIN NotaPedidos np on np.IdNotaPedido = r.IdNotaPedido
	INNER JOIN Clientes c on c.IdCliente = np.IdCliente

	select npi.idNotaPedido, a.descripcion, npi.cantidad 
	FROM NotaPedido_items npi
	INNER JOIN Articulos a on a.IdArticulo=npi.IdArticulo
	WHERE npi.IdNotaPedido in (select IdNotaPedido from Remitos)
	ORDER BY npi.IdNotaPedido
	
END



GO
/****** Object:  StoredProcedure [dbo].[ResetearSPISA]    Script Date: 09/08/2007 20:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ResetearSPISA]
	
AS
BEGIN

if exists(select 1 from sys.objects where name='FK_Facturas1_1NotaPedidos' and type='F')
BEGIN
ALTER TABLE dbo.Facturas
	DROP CONSTRAINT FK_Facturas1_1NotaPedidos
END

if exists(select 1 from sys.objects where name='FK_NotaPedido_Items1_1Articulo' and type='F')
BEGIN
ALTER TABLE dbo.NotaPedido_Items
	DROP CONSTRAINT FK_NotaPedido_Items1_1Articulo
END

if exists(select 1 from sys.objects where name='FK_NotaPedido_Items1_nNotaPedidos' and type='F')
BEGIN
ALTER TABLE dbo.NotaPedido_Items
	DROP CONSTRAINT FK_NotaPedido_Items1_nNotaPedidos
END

if exists(select 1 from sys.objects where name='FK_NotaPedidos1_1Clientes' and type='F')
BEGIN
ALTER TABLE dbo.NotaPedidos
	DROP CONSTRAINT FK_NotaPedidos1_1Clientes
END

if exists(select 1 from sys.objects where name='FK_Articulos_Categoria' and type='F')
BEGIN
ALTER TABLE dbo.Articulos
	DROP CONSTRAINT FK_Articulos_Categoria
END
if exists(select 1 from sys.objects where name='FK_Clientes_Provincias' and type='F')
BEGIN
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_Provincias
END
if exists(select 1 from sys.objects where name='FK_Clientes_Operatorias' and type='F')
BEGIN
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_Operatorias
END
if exists(select 1 from sys.objects where name='FK_Clientes_CondicionesIVA' and type='F')
BEGIN
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Clientes_CondicionesIVA

END
if exists(select 1 from sys.objects where name='FK_Descuentos_Clientes' and type='F')
BEGIN
ALTER TABLE dbo.Descuentos
	DROP CONSTRAINT FK_Descuentos_Clientes

END

if exists(select 1 from sys.objects where name='FK_Descuentos_Clientes' and type='F')
BEGIN
ALTER TABLE dbo.Clientes
	DROP CONSTRAINT FK_Descuentos_Clientes

END

if exists(select 1 from sys.objects where name='FK_Descuentos_Categorias' and type='F')
BEGIN
ALTER TABLE dbo.Descuentos
	DROP CONSTRAINT FK_Descuentos_Categorias

END

if exists(select 1 from sys.objects where name='FK_Remitos_NotaPedidos' and type='F')
BEGIN
ALTER TABLE dbo.Remitos
	DROP CONSTRAINT FK_Remitos_NotaPedidos

END





TRUNCATE TABLE Facturas
TRUNCATE TABLE NotaPedido_Items
TRUNCATE TABLE NotaPedidos
TRUNCATE TABLE Articulos
TRUNCATE TABLE Categorias
TRUNCATE TABLE CuentaCorriente_Movimientos
TRUNCATE TABLE CuentasCorriente
TRUNCATE TABLE Remitos
TRUNCATE TABLE Clientes
TRUNCATE TABLE Provincias
TRUNCATE TABLE CondicionesIVA
TRUNCATE TABLE Operatorias
TRUNCATE TABLE Descuentos


/* INSERTS */
INSERT INTO Categorias Values('Accesorios', '0')
INSERT INTO Categorias Values('Bridas', '0')
INSERT INTO Categorias Values('Válvulas', '0')

INSERT INTO Articulos Values(1, 'Articulo1', 'Articulo 1', 9999999, 10)
INSERT INTO Articulos Values(1, 'Articulo2', 'Articulo 2', 9999999, 20)
INSERT INTO Articulos Values(1, 'Articulo3', 'Articulo 3', 9999999, 30)

INSERT INTO Provincias Values('Buenos Aires')

INSERT INTO CondicionesIVA Values('Responsable Inscripto')
INSERT INTO CondicionesIVA Values('Responsable No Inscripto')
INSERT INTO CondicionesIVA Values('Exento')

INSERT INTO Operatorias Values('Contado')
INSERT INTO Operatorias Values('Cheque 30 días')
INSERT INTO Operatorias Values('Cheque 60 días')
INSERT INTO Operatorias Values('Transferencia Bancaria')

INSERT INTO Clientes Values('001', 'Suministros Petroleros e Industriales S.A.', 'Coronel Suarez 955', 'La Matanza', 1, 1, '33708293739', 1, 0)

INSERT INTO Descuentos Values(1, 1, 10)
INSERT INTO Descuentos Values(1, 2, 20)


ALTER TABLE dbo.NotaPedidos ADD CONSTRAINT 
	FK_NotaPedidos1_1Clientes FOREIGN KEY
 ( 
	IdCliente
 ) REFERENCES dbo.Clientes
 (
	IdCliente
 ) ON UPDATE NO ACTION
   ON DELETE NO ACTION


ALTER TABLE dbo.NotaPedido_Items ADD CONSTRAINT 
	FK_NotaPedido_Items1_nNotaPedidos FOREIGN KEY
 ( 
	IdNotaPedido
 ) REFERENCES dbo.NotaPedidos
 (
	IdNotaPedido
 ) ON UPDATE NO ACTION
   ON DELETE NO ACTION


ALTER TABLE dbo.Facturas ADD CONSTRAINT 
	FK_Facturas1_1NotaPedidos FOREIGN KEY
 ( 
	IdNotaPedido
 ) REFERENCES dbo.NotaPedidos
 (
	IdNotaPedido
 ) ON UPDATE NO ACTION
   ON DELETE NO ACTION


ALTER TABLE dbo.NotaPedido_Items ADD CONSTRAINT 
	FK_NotaPedido_Items1_1Articulo FOREIGN KEY
 ( 
	IdArticulo
 ) REFERENCES dbo.Articulos
 (
	IdArticulo
 ) ON UPDATE NO ACTION
   ON DELETE NO ACTION

ALTER TABLE dbo.Articulos ADD CONSTRAINT
	FK_Articulos_Categoria FOREIGN KEY
(
	IdCategoria
) REFERENCES dbo.Categorias
( 
	IdCategoria
) ON UPDATE NO ACTION
  ON DELETE NO ACTION

ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_Operatorias FOREIGN KEY
(
	IdOperatoria
) REFERENCES dbo.Operatorias
(
	IdOperatoria
) ON UPDATE NO ACTION
  ON DELETE NO ACTION

ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_CondicionesIVA FOREIGN KEY
(
	IdCondicionIVA
) REFERENCES dbo.CondicionesIVA
(
	IdCondicionIVA
) ON UPDATE NO ACTION
  ON DELETE NO ACTION

ALTER TABLE dbo.Clientes ADD CONSTRAINT
	FK_Clientes_Provincias FOREIGN KEY
(
	IdProvincia
) REFERENCES dbo.Provincias
(
	IdProvincia
) ON UPDATE NO ACTION
  ON DELETE NO ACTION

	
ALTER TABLE dbo.Descuentos ADD CONSTRAINT
	FK_Descuentos_Clientes FOREIGN KEY
	(
	IdCliente
	) REFERENCES dbo.Clientes
	(
	IdCliente
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	

ALTER TABLE dbo.Descuentos ADD CONSTRAINT
	FK_Descuentos_Categorias FOREIGN KEY
	(
	IdCategoria
	) REFERENCES dbo.Categorias
	(
	IdCategoria
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION	

ALTER TABLE dbo.Remitos ADD CONSTRAINT
	FK_Remitos_NotaPedidos FOREIGN KEY
	(
	IdNotaPedido
	) REFERENCES dbo.NotaPedidos
	(
	IdNotaPedido
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
CREATE UNIQUE NONCLUSTERED INDEX IX_Clientes ON dbo.Clientes
	(
	Codigo
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

END


GO
/****** Object:  StoredProcedure [dbo].[Transportistas_TraerPorId]    Script Date: 09/08/2007 20:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Transportistas_TraerPorId]
	@IdTransportista int
AS
BEGIN
	SELECT IdTransportista, Transportista, Domicilio
	FROM Transportistas
	WHERE IdTransportista=@IdTransportista
END



GO
/****** Object:  StoredProcedure [dbo].[Transportistas_TraerTodos]    Script Date: 09/08/2007 20:32:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Transportistas_TraerTodos]
	
AS
BEGIN
	SELECT IdTransportista, Transportista, Domicilio
	FROM Transportistas
END
