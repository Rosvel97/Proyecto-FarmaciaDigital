use FarmaciaDigital
go 

create table Rol(
IdRol int primary key identity, 
Nombre varchar(30) not null
)
go 

drop table Usuarios
go 

create table Usuarios(
Usuario varchar(20) primary key, 
Contraseña varchar(20) not null, 
IdRol int not null, 
NombreEmplado varchar(30) not null, 
ApellidoEmplado varchar(30) not null, 
)
go 

alter table Usuarios add constraint Fk_IdRol_Usuarios foreign key (IdRol) references Rol(IdRol)
go

insert into Rol values 
('ADMIN'), 
('ADMINISTRATIVO'), 
('SECREATARIO')
go

insert into Usuarios values
('ADMIN', '123', 1, 'HENRY ', 'CAVIL'),
('ADMINISTRATIVO', '123', 2, 'ANDREW', 'GARFIELD'),
('SECRETARIA', '123', 3, 'MARIA', 'DE LOS ANGELES')
go 

CREATE procedure SP_Inicio_Sesion 
@Usuario varchar(50), 
@Pass varchar(50)
as 
	select Usuario, 
		   NombreEmplado, 
		   ApellidoEmplado,
		   r.Nombre AS ROL
	from Usuarios u
	inner join Rol r on u.IdRol = r.IdRol
	where Usuario = @Usuario and Contraseña = @Pass
GO 

exec SP_Inicio_Sesion 'ADMIN','123'
select * from Usuarios

select * from Medicamentos
