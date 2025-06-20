
-- 1 
--select D.Titulo, D.FechaLanzamiento, E.Descripcion from DISCOS D, ESTILOS E
--where D.IdEstilo = E.Id

-- 2
--insert into ESTILOS values ('Rap')
--insert into TIPOSEDICION values ('Digital')

-- 3
--insert into DISCOS values ('The Last Command', '1985-11-9', 10, 'https://upload.wikimedia.org/wikipedia/en/7/7f/Lastcommand.jpg', 4, 3)

-- 4
--update DISCOS set UrlImagenTapa = 'https://upload.wikimedia.org/wikipedia/en/a/ac/Acdc_Highway_to_Hell.JPG' where Id = 4

-- 5
-- delete from ESTILOS where id = 5

-- 6
--select E.Descripcion from Estilos E, DISCOS D where D.IdEstilo = E.id

-- 7
--select D.Titulo, E.Descripcion Estilo, T.Descripcion Edicion from DISCOS D, TIPOSEDICION T, ESTILOS E
--where D.IdEstilo = E.Id and D.IdTipoEdicion = T.Id 

-- 8
select Titulo from DISCOS
where Titulo LIKE '%ho%'