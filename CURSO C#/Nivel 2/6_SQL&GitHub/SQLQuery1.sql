
-- CONSULTAS SQL
-- SQL tien 4 consultas: LECTURA, INSERTAR, MODIFICAR Y ELIMINAR datos

-- //LEER//
--select * from DISCOS
--select * from ESTILOS
--select D.Titulo, D.CantidadCanciones Canciones, E.Descripcion Genero from DISCOS D, ESTILOS E
--where D.IdEstilo = E.Id


--//ESCRIBIR//
--Forma 1
-- insert into DISCOS (columna, columna, columna) values (valor, valor, valor)

--insert into DISCOS (Titulo, CantidadCanciones) 
--values ('Highway to Hell',10)

--Forma 2
--insert into DISCOS values (valor1, valor2, valor3)

--insert into DISCOS 
--values ('Highway to Hell',GETDATE(), 10,'url', 4, 1)


--//MODIFICAR//
--update ESTILOS set Descripcion = 'Rock' where Id = 3
--update ESTILOS set Descripcion = 'Hard-Rock' where Id = 4


--//ELIMINAR//
--delete from DISCOS where id = 3
