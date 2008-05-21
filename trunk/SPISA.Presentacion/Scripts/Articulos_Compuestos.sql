/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E1/2%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS1/2', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */

/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E1x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS1', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */

/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E11/2x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS11/2', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */


/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E11/4x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS11/4', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */


/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E11/8x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS11/8', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */


/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E13/8x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS13/8', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */


/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E3/4x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS3/4', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */


/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E5/8x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS5/8', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */


/*----------------------------------- */

declare @CodigoEsparrago varchar(20)
declare recorrerArticulos cursor  for

select codigo from articulos 
where codigo like 'E7/8x%'

open recorrerArticulos

fetch next from recorrerArticulos
into @CodigoEsparrago

while @@Fetch_Status=0
begin
	insert into articulos_compuestos
	values (@CodigoEsparrago, 'TS7/8', 2)

	fetch next from recorrerArticulos
	into @CodigoEsparrago

end

close recorrerArticulos
deallocate recorrerARticulos

/*----------------------------------- */
