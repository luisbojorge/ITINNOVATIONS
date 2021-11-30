create procedure uspGuardarProducto
@iidproducto int,
@nombre varchar(100),
@precio decimal(18,2),
@idcategoria int,
@stock int,
@iidmarca int
as
begin

if @iidproducto=0

insert into Producto(nombre,precio,iidcategoria,bhabilitado,stock,iidmarca)
values(@nombre,@precio,@idcategoria,1,@stock,@iidmarca)
else
update Producto
set NOMBRE=@nombre , PRECIO=@precio , iidcategoria=@idcategoria , 
iidmarca=@iidmarca,stock=@stock
where IIDPRODUCTO=@iidproducto

end



select * from Usuario

select * from Categoria

create procedure uspEliminarCategoria
@idcategoria int 
as 
begin 
delete from Categoria 
where IIDCATEGORIA=@idcategoria
end


--Procedure para consulta de las categorias
create procedure uspListarCategoria
as
begin
select IIDCATEGORIA, NOMBRE, DESCRIPCION
from Categoria
where BHABILITADO=1
end 
exec uspListarCategoria